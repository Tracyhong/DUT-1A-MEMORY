Imports System.IO

Module ModuleMemory
    'VARIABLES *************************************************************************************************************************
    'Toutes les cartes instanciées une seule fois pour pouvoir les comparer par la suite
    'Public BackCard As Image = My.Resources.BackCard
    'Private Card0 As Image = My.Resources.Card0
    'Private Card1 As Image = My.Resources.Card1
    'Private Card2 As Image = My.Resources.Card2
    'Private Card3 As Image = My.Resources.Card3
    'Private Card4 As Image = My.Resources.Card4

    'Private CardF0 As Image = My.Resources.CardSaiki
    'Private CardF1 As Image = My.Resources.CardNendo
    'Private CardF2 As Image = My.Resources.CardKaido
    'Private CardF3 As Image = My.Resources.CardAren
    'Private CardF4 As Image = My.Resources.CardTeruhachi

    'Private CardD0 As Image = My.Resources.CardTile0
    'Private CardD1 As Image = My.Resources.CardTile1
    'Private CardD2 As Image = My.Resources.CardTile2
    'Private CardD3 As Image = My.Resources.CardTile3
    'Private CardD4 As Image = My.Resources.CardTile4
    Public BackCard As Image = Image.FromFile("./img/BackCard.png")
    Private Card0 As Image = Image.FromFile("./img/Card0.png")
    Private Card1 As Image = Image.FromFile("./img/Card1.png")
    Private Card2 As Image = Image.FromFile("./img/Card2.png")
    Private Card3 As Image = Image.FromFile("./img/Card3.png")
    Private Card4 As Image = Image.FromFile("./img/Card4.png")

    Private CardF0 As Image = Image.FromFile("./img/CardSaiki.png")
    Private CardF1 As Image = Image.FromFile("./img/CardNendo.png")
    Private CardF2 As Image = Image.FromFile("./img/CardKaido.png")
    Private CardF3 As Image = Image.FromFile("./img/CardAren.png")
    Private CardF4 As Image = Image.FromFile("./img/CardTeruhachi.png")

    Private CardD0 As Image = Image.FromFile("./img/CardTile0.png")
    Private CardD1 As Image = Image.FromFile("./img/CardTile1.png")
    Private CardD2 As Image = Image.FromFile("./img/CardTile2.png")
    Private CardD3 As Image = Image.FromFile("./img/CardTile3.png")
    Private CardD4 As Image = Image.FromFile("./img/CardTile4.png")

    'Tableau d'images qui servira pour charger les images du jeu lors du clic pour retourner la carte.
    'La carte possede un numéro (Carte+num : ex Carte1) qui correspond à l'index du tableau
    'Le tableau contient toutes les images du jeu, c'est a dire 5cartes differentes, avec chacune 4 exemplaires
    'ce tableau est initialisé à chaque partie et est mélangé au hasard
    Public Cartes(19) As Image

    'des qu'on clic on augmente le compteur
    Public cptClic As Integer = 0
    'des qu'on clic on stocke le label cliqué pour comparer les images
    Public tabClic(3) As Label

    Public chrono As Integer = 60
    'variable pour commencer le timer
    'false pour la premiere fois et devient true au premier clic pour commencer la partie. Ne change plus apres
    Public startTimer As Boolean = False
    Public Structure joueur
        Public nom As String
        Public nbMaxCarre As Integer
        Public tempsMin As Integer
        Public nbParties As Integer
        Public cumulTempsJeu As Integer 'ou date
    End Structure
    'list pour stoker les joueurs ? > à save dans un fichier
    Public Joueurs As List(Of joueur)

    'VARIABLE OPTIONs
    'OPTION PAUSE
    Public IconPause As Image = My.Resources.iconPause
    Public IconPlay As Image = My.Resources.iconPlay
    Public btnPause As Boolean = False
    Public niveau As String = "normal"
    Public theme As String
    Public path As String = "./save/"
    'cartes pour les niveaux à initialiser dans init
    'sinon faire des if et remplacer les card 

    'mettre en paramettre dans init, puis faire des if pour la boucle a chager les cartes de dos,
    'rajouter aussi dans le form jeu lors des click pour tourner les bonnes images et comparer les bonnes images aussi

    'image pour background
    Public background As Image

    'MAIN *********************************************************************************************************************************
    Sub main()
        Joueurs = New List(Of joueur)

        'recup les fichiers
        'si on a fait option alors si on a enregistré les fichiers quelques part d'autre alors il faut recharger les fichiers a partir de la bas,
        'il faut creer un fichier qui va enregistrer le chemin dans le debug puis a chaque ouverture, si ce fichier existe, alors charger les fichiers
        'a partir de ce chemin sinon a partir du debug


        Try
            'recuperer tous les fichiers
            Dim fichiers = My.Computer.FileSystem.GetFiles(path, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            'boucle pour tous les fichiers
            For Each nom In fichiers
                'Console.WriteLine("path is : " & nom)
                charger(nom)
            Next
        Catch ex As Exception
            MsgBox("pas de fichier à charger")

        End Try
        Application.Run(FormMenu)

    End Sub


    'SUBS ET FUNCTIONS ***********************************************************************************************************************

    'Procédure qui initialise le tableau Cartes() et qui appelle la procédure mélange qui va mélanger les cartes du tableau
    Public Sub init()
        If niveau = "facile" Then
            For i As Integer = 0 To 3
                Cartes(i) = CardF0
            Next
            For i As Integer = 4 To 7
                Cartes(i) = CardF1
            Next
            For i As Integer = 8 To 11
                Cartes(i) = CardF2
            Next
            For i As Integer = 12 To 15
                Cartes(i) = CardF3
            Next
            For i As Integer = 16 To 19
                Cartes(i) = CardF4
            Next

        ElseIf niveau = "dur" Then
            For i As Integer = 0 To 3
                Cartes(i) = CardD0
            Next
            For i As Integer = 4 To 7
                Cartes(i) = CardD1
            Next
            For i As Integer = 8 To 11
                Cartes(i) = CardD2
            Next
            For i As Integer = 12 To 15
                Cartes(i) = CardD3
            Next
            For i As Integer = 16 To 19
                Cartes(i) = CardD4
            Next

        ElseIf niveau = "normal" Then

            For i As Integer = 0 To 3
                Cartes(i) = Card0
            Next
            For i As Integer = 4 To 7
                Cartes(i) = Card1
            Next
            For i As Integer = 8 To 11
                Cartes(i) = Card2
            Next
            For i As Integer = 12 To 15
                Cartes(i) = Card3
            Next
            For i As Integer = 16 To 19
                Cartes(i) = Card4
            Next

        End If

        'appeller autant de fois melanger carte qu'on veut
        melangerCartes()
        'Charger toutes les cartes mettant BackCard
        For Each carte As Label In FormJeu.PanelCartes.Controls
            carte.Image = BackCard
            carte.Enabled = True
        Next
        startTimer = False
    End Sub

    'Procédure utilisée par init() qui appelle la méthode Random pour mélanger les cartes au hasard
    'Le mélange se fait par permutation de 2 cartes. On repete l'opération 20fois pour parcourir tout le tableau
    Private Sub melangerCartes()
        Dim r As Random = New Random()
        For carte As Integer = 0 To Cartes.Length - 1
            Dim carteR As Integer = r.Next(0, Cartes.Length)
            permuter(carte, carteR)
        Next
    End Sub
    'Procédure utilisée par melangerCartes() qui permute 2 cartes
    'carte : l'index de la 1ere carte
    'carteR : l'index de la 2e carte
    Private Sub permuter(carte As Integer, carteR As Integer)
        Dim tmp As Image = Cartes(carte)
        Cartes(carte) = Cartes(carteR)
        Cartes(carteR) = tmp
    End Sub
    'Public Sub echangerCarte(carte As Label)
    '    Dim tmp As Image = carte.Image
    '    carte.Image = carte.BackgroundImage
    '    carte.BackgroundImage = tmp
    'End Sub

    '**************************************************************
    'Fonction du jeu pour la comparaison des cartes et la verification de partie gagnée

    'Fonction qui compare deux images
    'return un boolean : true si les images sont identiques, sinon false
    Public Function comparerImage(i As Integer) As Boolean
        If tabClic(0).Image Is tabClic(i).Image Then
            Return True
        Else Return False
        End If
    End Function

    'Fonction qui verifie si la partie est gagnée en vérifiant si tous les Labels Carte du formulaire sont désactivés
    'return boolean : true si la partie est gagnée, sinon false
    Public Function verifGagner() As Boolean
        For Each carte As Label In FormJeu.PanelCartes.Controls
            If carte.Enabled Then
                Return False
            End If

        Next
        Return True
    End Function
    '***************************************************
    'Enregistrer les joueurs
    Private Function verifJoueurExistant(nom As String) As Boolean
        'si la liste est vide
        If Joueurs IsNot Nothing AndAlso Joueurs.Count = 0 Then
            Return False
        End If

        'si il existe des joueurs, on parcourt la liste pour chercher si le joueur (nom) existe
        For Each j As joueur In Joueurs
            If j.nom = nom Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub enregistrerJoueur(nom As String, nbMaxCarre As Integer, tempsMin As Integer, tempsFin As Integer)
        'verifier qu'il exsite pas deja

        If Not verifJoueurExistant(nom) Then
            Dim j As joueur
            j.nom = nom
            j.nbMaxCarre = nbMaxCarre
            j.tempsMin = tempsMin
            j.nbParties = 1
            j.cumulTempsJeu = tempsFin

            Joueurs.Add(j)

        Else
            Dim Jtmp As joueur
            For i As Integer = 0 To Joueurs.Count - 1
                If Joueurs.Item(i).nom = nom Then
                    'retenir le plus grand
                    Jtmp.nom = nom
                    Jtmp.nbMaxCarre = Joueurs.Item(i).nbMaxCarre
                    Jtmp.tempsMin = Joueurs.Item(i).tempsMin
                    If Joueurs.Item(i).nbMaxCarre < nbMaxCarre Then
                        Jtmp.nbMaxCarre = nbMaxCarre
                        Jtmp.tempsMin = tempsMin
                    ElseIf Joueurs.Item(i).nbMaxCarre = nbMaxCarre And Joueurs.Item(i).tempsMin > tempsMin Then
                        Jtmp.tempsMin = tempsMin
                        Jtmp.nbMaxCarre = Joueurs.Item(i).nbMaxCarre
                    End If
                    Jtmp.nbParties = Joueurs.Item(i).nbParties + 1
                    Jtmp.cumulTempsJeu = Joueurs.Item(i).cumulTempsJeu + tempsFin
                    Joueurs.RemoveAt(Joueurs.IndexOf(Joueurs.Item(i)))
                    Joueurs.Add(Jtmp)
                    Exit For
                End If
            Next
        End If
    End Sub

    '******************************************************
    'FLUX DE FICHIER 
    'Charger un fichier de sauvegarde s'il existe
    'Paramettres:
    '  path : chemin 
    Public Sub charger(path As String)
        'ouvrir fichier
        If File.Exists(path) Then
            'Dim f = My.Computer.FileSystem.OpenTextFileReader(path)
            Dim f As New StreamReader(path)
            Dim j As New joueur
            Do While f.Peek >= 0
                j.nom = f.ReadLine
                'Console.WriteLine(j.nom)
                j.nbMaxCarre = f.ReadLine
                'Console.WriteLine(j.nbMaxCarre)
                j.tempsMin = f.ReadLine
                'Console.WriteLine(j.tempsMin)
                j.nbParties = f.ReadLine
                'Console.WriteLine(j.nbParties)
                j.cumulTempsJeu = f.ReadLine
                'Console.WriteLine(j.cumulTempsJeu)
            Loop

            f.Close()
            Joueurs.Add(j)

        Else MsgBox("pas de fichier")

        End If

    End Sub

    ' Procedure qui sauvegarde un joueur dans un fichier
    ' Paramettres :
    '  path : chemin 
    '  nom : nom du joueur ou nom du fichier
    Public Sub save(path As String, joueur As joueur)
        'stocker dans fichier
        'si le dossier n'existe pas
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
        'si le fichier n'existe pas dans le dossier
        Dim fichier As String = joueur.nom & ".txt"
        If Not Directory.Exists(path & fichier) Then
            Dim fs As FileStream = File.Create(path & fichier)
            fs.Close()
        End If
        ' ECRIRE dans le fichier
        Dim f As New StreamWriter(path & fichier)
        f.WriteLine(joueur.nom)
        f.WriteLine(joueur.nbMaxCarre)
        f.WriteLine(joueur.tempsMin)
        f.WriteLine(joueur.nbParties)
        f.WriteLine(joueur.cumulTempsJeu)
        f.Close()
    End Sub
End Module
