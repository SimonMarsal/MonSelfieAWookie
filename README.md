# MonSelfieAWookie

Liens : 
Introducing .netCore 5
https://devblogs.microsoft.com/dotnet/introducing-net-5/

github dotnetcore 5.0
https://github.com/dotnet/runtime

Design patterns :
http://refactoring.guru/design-patterns/

GitHub du projet wookie d'Evan :
https://github.com/devtobecurious/asp-net-core-mvc-projects


Livres : 
DDD: Patterns Principles and practices of Domain-Driven Design
C# 3.0 design patterns



Plugins utiles visual studio :
Commitizen



----------------
Mardi
serveur web dotnetcore
Tout s'autogère, plus de serveur obligatoire en dotnetcore.

SOLID
S = Single Responsability Principe (SRP) - bien faire les choses - cohésion
O open/close
L Liskov (substitution) (appeler le parent plutot que l'enfant)
I Séparation par petites interfaces
D Dependency injection (IoC)



cshtml = Razor


Responsive design : 
ViewPort
Media query
flex, grid
principe des 12 cases


- Notion de dialogue modèle-vue
- Viewbag


Exercice boss du mardi 2 mars :
Construire une page qui liste les wookies
wookie : id, prénom, nbpoils, nombre de selfies, arme de préférence, nb d'armes auxiliaires

je veux une liste qui affiche les wookies>tableau avec comme colonne :
-prénom - arme de préférence - nb d'armes auxiliaires - nombre de selfies

Filtres
on peut filtrer la liste par :
arme de préférence, nom du selfie


--
Mercredi

Testing : 
http://agileinaflash.blogspot.com/2009/02/first.html

Injection de dépendance :
- interface : faiblement couplé avec les classes
- on peut paramétrer l'injection automatique
-tests : création de repository dédié au test et création du controleur avec ces repository


Exercice du Mercredi
Tester l'affichage des selfies
Ecrire le ou les TU de non régression (min 2)

En TDD :
Rajouter un repo dédié
Tester avec ce repo
Dans le code de l'application, créer et connecter un repo qui va lire les données depuis un fichier csv ou json (newtonsoft)

