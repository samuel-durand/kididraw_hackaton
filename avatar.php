<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="src/css/header.css">
    <link rel="stylesheet" href="src/css/avatar.css">
    <script src="src/javascript/script.js" defer></script>
    <title>Kididraw-avatar</title>
</head>
<body>
    <?php
        require_once 'header.php';
    ?>

    <main>
        <section class="avatar-section">

            <article>
                <h1>Créer ton avatar</h1>

                <div class="container-icons">

                    <div>
                        <img src="src/asset/avatar 1 (1).png" alt="Une première icône d'avatar">
                    </div>

                    <div>
                        <img src="src/asset/avatar 2.png" alt="Une deuxième icône d'avatar">
                    </div>

                    <div>
                        <img src="src/asset/avatar 3.png" alt="Une troisième icône d'avatar">
                    </div>

                    <div>
                        <img src="src/asset/avatar 4.png" alt="Une quatrième icône d'avatar">
                    </div>
                </div>
                
                <form action="action.php">
                    <label for="username">Choisis ton pseudo</label>
                    <input type="text" class="pseudo" name="username" id="username" placeholder="Votre pseudo" required>

                    <input type="button" class="start" value="C'est parti !">
                </form>

                

                
            </article>

            
        </section>
    </main> 
</body>
</html>