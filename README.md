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

Schéma globalité sur aspdotnetcore
https://raw.githubusercontent.com/evan-boissonnot/AspNetCore-Developer-Roadmap/master/aspnetcore-developer-roadmap.png

https://connectionstrings.com/

options de relations EF
https://docs.microsoft.com/en-us/ef/core/querying/related-data/lazy
https://docs.microsoft.com/en-us/ef/core/querying/related-data/explicit

Conseils de migration/seeds
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/operations#using-migrationbuildersql
https://code-maze.com/migrations-and-seed-data-efcore/
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=dotnet-core-cli

Binding :
https://docs.microsoft.com/fr-fr/aspnet/core/mvc/models/model-binding?view=aspnetcore-5.0

Fetch (remplace jquery)
https://developer.mozilla.org/fr/docs/Web/API/Fetch_API/Using_Fetch
https://developer.mozilla.org/fr/docs/Web/JavaScript/Reference/Global_Objects/Promise

Sécurité
Rootme: exercices sur le hacking
https://www.root-me.org/
https://docs.microsoft.com/fr-fr/aspnet/core/security/anti-request-forgery?view=aspnetcore-5.0

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
- tests : création de repository dédié au test et création du controleur avec ces repository


Exercice du Mercredi
Tester l'affichage des selfies
Ecrire le ou les TU de non régression (min 2)

En TDD :
Rajouter un repo dédié
Tester avec ce repo
Dans le code de l'application, créer et connecter un repo qui va lire les données depuis un fichier csv ou json (newtonsoft)


Jeudi :
COMMENT FAIRE UNE MIGRATION
>dotnet tool install--global dotnet-ef
>dotnet ef migrations add First
  ne marche pas, installer sur le main project : EntityFrameworkCore.Design
>dotnet ef migrations add First --project=..\SelfieAWookie.Core.Infrastructure

a créé des fichiers dans le dossier Migrations, pour configurer la BDD

COMMENT INTEGRER UNE Migration
>dotnet ef database update

COMMENT CREER UNE NOUVELLE MIGRATION (ajout nouveau champs)
>dotnet ef migrations add AvatarUrl --project=..\SelfieAWookie.Core.Infrastructure

COMMENT PRENDRE EN COMPTE UNE Migration en base
>dotnet ef database update

EXPORTER MIGRATION en fichier sql
dotnet ef migrations script > monfichier.sql

Test ShouldReturnListOfWookiesDataBase : utilisation du Core.InMemory

Boss 3 :
faire la création d'un wookie
gérer l'enregistrement

etape 1 : sans les armes
etape 2 : avec l'arme prinsipale - proposer liste de choix - asp-items
etape 3 : avec les armes secondaires


Vendredi

Validation
1-possibilité de le faire en view (required)
2-ou bien taguer les dto avec [Required]
3-ou bien utiliser model.IsValid dans le controller avec des règles côté cEF configuration

Avis formation
très satisfait, on a des bases solides
donne envie de créer son petit site
presque frustré de ne pas aller plus loin et de découvrir des fonctionnalités plus avancées