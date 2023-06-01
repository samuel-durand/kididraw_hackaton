<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./css/style.css">
    <script src="./javascript/script.js" defer></script>
    <title>Kididraw-header</title>
</head>
<body>
    <header>

        <div class="header-container">

            <div id="mySidenav" class="sidenav">
                <a id="closeBtn" href="#" class="close">x</a>
                <ul>
                    <li><a href="accueil.php">Accueil</a></li>
                    <li><a href="entrainement.php">Entraînement</a></li>
                    <li><a href="dessins.php">Dessins pas à pas</a></li>
                    <li><a href="enquete.php">Enquête</a></li>
                    <li><a href="compte.php">Compte</a></li>
                    <li><a href="Quitter.php">Quitter le jeu</a></li>
                </ul>
            </div>

            <!-- Une icône de maison cliquable -->
            <div class="menu-container">
                <a href="#" id="openBtn">
                    <img src="./asset/icons8-accueil-50.png" alt="Un logo de maison">
                </a>
            </div>

            <div class ="logo-container">
                <!-- Le logo Kididraw -->
                <img src="./asset/Kididraw-1.png" class="logo" alt="Le logo Kididraw">
            </div>

            <div class="help-container">
                <!-- Le logo d'aide -->
                <a href="#" id="open-form"  onclick="openForm()">
                    <img src="./asset/icons8-poser-une-question-50.png" alt="Un logo de point d'interrogation">
                </a>
            </div>

            <!-- Le formulaire d'aide -->

            <div class="open_help_form">

                <div class="form-popup" id="popupform">

                    <form action="help-form.php" class="help_form">
                        <img src="./asset/icons8-poser-une-question-50.png"  alt="Un logo de point d'interrogation">

                        <p>
                            Besoin d'aide ?<br>
                            Notre assistant est là<br>
                            pour vous    
                        </p>
                        <label for="no_avatar">Votre avatar n'apparaît pas ?</label>
                        <input type="text" placeholder="Quel est le problème ?" name="no_avatar" required />

                        <label for="bug">Vous rencontrez des problèmes techniques ?</label>
                        <input type="text" placeholder="Signalez un bug" name="bug" required />

                        <label for="other_thing">Il y a t-il autre chose ?</label>
                        <input type="text" placeholder="Que se passe t-il ?" name="other_thing" required />

                        <label for="msg">Contactez-nous</label>
                        <input type="text" placeholder="Saissisez votre messsage" name="msg" required />


                        <button type="submit" class="btn_send">Envoyer</button>
                        <button type="submit" class="btn_cancel" onclick="closeForm()">Annuler</button>
                    </form>
                </div>
            </div>






        </div>
    </header>

    
</body>
</html>