<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="src/css/video_paysage.css">
    <link rel="stylesheet" href="src/css/header.css">
    <script src="src/javascript/script.js" defer></script>
    <title>Personnages</title>
</head>

<body>
    <?php
    require_once "header.php";
    ?>
    <main>
        <div id="titre">
            <div id="image">
                <a href="th-personnages.php"><img src="src/asset/icons8-arrière-50.png" alt=""></a>
            </div>
            <div>
                <h1>Dessin pas à pas</h1>
                <h2>Dessinner des personnages</h2>
            </div>
        </div>
        <div id="iframe">
            <div style="position: relative; overflow: hidden; padding-top: 65.25%"><iframe style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; border: 0;" src="https://airapi.kumullus.com/api/v1/kumullus/624ca3b59dfbf9001de6c952/deploy" allowfullscreen=""></iframe></div>
        </div>
        <h1>PARTAGE TON DESSIN</h1>
        <div id="dessin">
            <img src="src/asset/icons8-appareil-photo-50.png" alt="">
            <a href="" id="download">Ajouter une photo</a>
        </div>
    </main>

</body>

</html>