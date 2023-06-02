
//Déclaration des variables
var sidenav = document.getElementById("mySidenav");
var openBtn = document.getElementById("openBtn");
var closeBtn = document.getElementById("closeBtn");

//Ouverture et fermeture 
openBtn.onclick = openNav;
closeBtn.onclick = closeNav;

// ouverture de la navigation de gauche à droite
function openNav() {
  sidenav.classList.add("active");
}

// Fermeture de la navigation
function closeNav() {
  sidenav.classList.remove("active");
}

//Ouverture du formulaire d'aide
function openForm() {
  document.getElementById("popupform").style.display = "block";
}
// Fermeture du formulaire d'aide
function closeForm() {
  document.getElementById("popupform").style.display = "none";
}

