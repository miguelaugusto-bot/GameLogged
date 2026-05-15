// =============================================
// GameLogged — Login (com integração à API)
// =============================================

const API_URL = 'http://localhost:5182/api/auth/login';

document.addEventListener('DOMContentLoaded', () => {

  // ── Eye toggle
  const eyeToggle = document.getElementById('eyeToggle');
  const passwordField = document.getElementById('password');

  if (eyeToggle && passwordField) {
    eyeToggle.addEventListener('click', () => {
      const isText = passwordField.type === 'text';
      passwordField.type = isText ? 'password' : 'text';
      eyeToggle.setAttribute('aria-label', isText ? 'Ver senha' : 'Ocultar senha');
    });
  }

  // ── Form submit
  const form = document.getElementById('loginForm');
  const btnSubmit = form ? form.querySelector('button[type="submit"]') : null;

  if (form) {
    form.addEventListener('submit', async (e) => {
      e.preventDefault();
      clearErrors();

      const email    = document.getElementById('email').value.trim();
      const password = document.getElementById('password').value;
      let valid = true;

      if (!email || !isValidEmail(email)) {
        showError('email', 'Informe um e-mail válido.');
        valid = false;
      }
      if (!password || password.length < 6) {
        showError('password', 'Senha deve ter no mínimo 6 caracteres.');
        valid = false;
      }

      if (!valid) return;

      // Desabilita o botão enquanto aguarda a resposta
      setLoading(true);

      try {
        const response = await fetch(API_URL, {
          method: 'POST',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify({ email, password })
        });

        if (response.ok) {
          const data = await response.json();
          // Salva dados básicos do usuário na sessão (sem senha)
          sessionStorage.setItem('usuario', JSON.stringify({
            id:       data.id,
            nickname: data.nickname,
            nome:     data.nome,
            email:    data.email
          }));
          window.location.href = 'perfil.html';
        } else if (response.status === 401) {
          showGlobalError('E-mail ou senha incorretos.');
        } else {
          showGlobalError('Erro ao tentar fazer login. Tente novamente.');
        }
      } catch (err) {
        console.error(err);
        showGlobalError('Não foi possível conectar à API. Verifique se o servidor está rodando.');
      } finally {
        setLoading(false);
      }
    });
  }

  // ── Helpers
  function isValidEmail(v) {
    return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(v);
  }

  function setLoading(isLoading) {
    if (!btnSubmit) return;
    btnSubmit.disabled = isLoading;
    btnSubmit.textContent = isLoading ? 'Entrando...' : 'Entrar';
  }

  function showError(fieldId, msg) {
    const field = document.getElementById(fieldId);
    if (!field) return;
    field.closest('.input-group').classList.add('has-error');
    const err = document.createElement('span');
    err.className = 'field-error';
    err.textContent = msg;
    field.closest('.input-group').appendChild(err);
    field.style.borderColor = 'var(--accent-red)';
  }

  function showGlobalError(msg) {
    clearGlobalError();
    const err = document.createElement('p');
    err.id = 'global-error';
    err.className = 'field-error global-error';
    err.textContent = msg;
    form.prepend(err);
  }

  function clearErrors() {
    clearGlobalError();
    document.querySelectorAll('.field-error').forEach(el => el.remove());
    document.querySelectorAll('.input-field').forEach(el => {
      el.style.borderColor = '';
    });
    document.querySelectorAll('.input-group').forEach(el => {
      el.classList.remove('has-error');
    });
  }

  function clearGlobalError() {
    const existing = document.getElementById('global-error');
    if (existing) existing.remove();
  }

});
