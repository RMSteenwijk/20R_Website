const chk = document.getElementById('chk');

const getStoredTheme = () => localStorage.getItem('theme')
const setStoredTheme = theme => localStorage.setItem('theme', theme)
const getPreferredTheme = () => {
    const storedTheme = getStoredTheme()
    if (storedTheme) {
      return storedTheme
    }

    return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'
  }

chk.addEventListener('change', () => {
  const isDark = document.documentElement.getAttribute('data-bs-theme') === 'dark';
  setStoredTheme(isDark ? 'light' : 'dark');
  document.documentElement.setAttribute('data-bs-theme', isDark ? 'light' : 'dark')
});

document.addEventListener('DOMContentLoaded', function() {
  var theme = getPreferredTheme();
    document.documentElement.setAttribute('data-bs-theme', theme)
    chk.checked = theme === 'dark';
});