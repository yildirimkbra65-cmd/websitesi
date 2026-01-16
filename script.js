const themeToggle = document.querySelector(".switch .input");

const setTheme = (theme) => {
  document.documentElement.setAttribute("data-theme", theme);
  if (themeToggle) {
    themeToggle.checked = theme === "dark";
  }
  localStorage.setItem("theme", theme);
};

const savedTheme = localStorage.getItem("theme");
const prefersDark =
  window.matchMedia && window.matchMedia("(prefers-color-scheme: dark)").matches;

setTheme(savedTheme || (prefersDark ? "dark" : "light"));

if (themeToggle) {
  themeToggle.addEventListener("change", () => {
    setTheme(themeToggle.checked ? "dark" : "light");
  });
}
