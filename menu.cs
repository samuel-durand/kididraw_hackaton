using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    //Navigation sur le menu de connexion
      public void Connexion()
    {
        Debug.Log("connexion à Kididraw!");
        SceneManager.LoadScene("mainMenu");
    }
     public void ResetPassword()
    {
        Debug.Log("clic sur mot de passe oublié");
    }

    public void Menu()
    {
        Debug.Log("clic sur le menu");
    }
    //Navigation sur le menu principal
     public void Dressing()
    {
        Debug.Log("clic sur le vestiaire de l'avatar");
    }
     public void Success()
    {
        Debug.Log("clic sur le panneau des succès");
        SceneManager.LoadScene("successMenu");
    }
     public void Adventure()
    {
        Debug.Log("clic sur le mode aventure");
         SceneManager.LoadScene("adventureMenu");
    }
     public void Training()
    {
        Debug.Log("clic sur le mode entrainement");
         SceneManager.LoadScene("trainingMenu");
    }
     public void Paperboard()
    {
        Debug.Log("clic sur le menu création libre");
         SceneManager.LoadScene("paperBoardMenu");

    }
    //Navigation sur le menu d'entrainement
    public void Lesson()
    {
        Debug.Log("clic sur le menu leçons pas à pas");
         SceneManager.LoadScene("lessonMenu");

    }
    public void Video()
    {
        Debug.Log("clic sur le menu cours vidéo");
         SceneManager.LoadScene("videoMenu");

    }
    public void Game()
    {
        Debug.Log("clic sur le menu mini jeux");
         SceneManager.LoadScene("gameMenu");

    }
    //Navigation retour
     public void Back()
    {
        Debug.Log("clic sur retour");
    }
    //Navigation sur les thèmes de lecons
    
   
     public void technicLesson()
    {
        Debug.Log("interessons nous aux techniques de dessins");
         SceneManager.LoadScene("technicLessonMenu");
    }
     public void animalLesson()
    {
        Debug.Log("interessons nous aux animaux");
         SceneManager.LoadScene("animalLessonMenu");
    }
     public void objectLesson()
    {
        Debug.Log("interessons nous aux objets");
        SceneManager.LoadScene("objectLessonMenu");
    }
     public void landscapeLesson()
    {
        Debug.Log("interessons nous aux paysages");
        SceneManager.LoadScene("landscapeLessonMenu");
    }
     public void characterLesson()
    {
        Debug.Log("interessons nous aux personnages");
        SceneManager.LoadScene("characterLessonMenu");
    }

    //Navigation sur les sujet de lecons
     public void faceLesson()
    {
        Debug.Log("apprenons à dessiner un visage");
    }
    public void perspectiveLesson()
    {
        Debug.Log("apprenons à dessiner une perspective");
    }
    public void moveLesson()
    {
        Debug.Log("apprenons à dessiner un mouvement");
    }
    public void catLesson()
    {
        Debug.Log("apprenons à dessiner un chat");
    }
    public void wolfLesson()
    {
        Debug.Log("apprenons à dessiner un loup");
    }
    public void tigerLesson()
    {
        Debug.Log("apprenons à dessiner un tigre");
    }
    public void computerLesson()
    {
        Debug.Log("apprenons à dessiner un ordinateur");
    }
    public void houseLesson()
    {
        Debug.Log("apprenons à dessiner une maison");
    }
    public void carLesson()
    {
        Debug.Log("apprenons à dessiner une voiture");
    }
    public void beachLesson()
    {
        Debug.Log("apprenons à dessiner une plage");
    }
    public void mountainLesson()
    {
        Debug.Log("apprenons à dessiner une montagne");
    }
    public void townLesson()
    {
        Debug.Log("apprenons à dessiner une ville");
    }
    public void princessLesson()
    {
        Debug.Log("apprenons à dessiner une princesse");
    }
    public void superheroLesson()
    {
        Debug.Log("apprenons à dessiner un super héros");
    }
    public void pirateLesson()
    {
        Debug.Log("apprenons à dessiner un pirate");
        
    }
    //Lecture des vidéos
     public void watchVideo()
    {
        Debug.Log("la video se lance");
        SceneManager.LoadScene("videoMenu");
    }
    //Navigation du mode aventure
    public void knightAdventure()
    {
        Debug.Log("allons sauver la princesse!");
        
    }
    public void treasureAdventure()
    {
        Debug.Log("allons trouver le trésor!");
    }
    public void invasionAdventure()
    {
        Debug.Log("allons sauver le monde!");
    }

     //Navigation sur les modes de jeu
      public void quizGame()
    {
        Debug.Log("jouons au quiz");
    }
     public void completeGame()
    {
        Debug.Log("jouons à compléter un dessin");
    }
     public void linkGame()
    {
        Debug.Log("jouons à relier des points");
    }
     public void chronoGame()
    {
        Debug.Log("jouons à dessiner rapidement");
        
    }
    //Retour vers les menus précédent
     public void backMainMenu()
    {
        Debug.Log("mainMenu");
        SceneManager.LoadScene("mainMenu");
        
    }
     public void backTrainingMenu()
    {
        Debug.Log("trainingMenu");
        SceneManager.LoadScene("trainingMenu");
        
    }
     public void backGameMenu()
    {
        Debug.Log("gameMenu");
        SceneManager.LoadScene("gameMenu");
        
    }
     public void logOut()
    {
        Debug.Log("SampleScene");
        SceneManager.LoadScene("SampleScene");
        
    }
    public void backLessonMenu()
    {
        Debug.Log("retour au menu leçons");
        SceneManager.LoadScene("lessonMenu");
        
    }
    public void paperBoardMenu()
    {
        Debug.Log("recommencer à dessiner");
        SceneManager.LoadScene("paperBoardMenu");
        
    }

    //Quitter l'application
     public void Quit()
    {
        Debug.Log("clic sur quitter");
    }
}
