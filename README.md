# CV-front
Ce projet est une application **Blazor WebAssembly** développée dans le but de découvrir et d'apprendre les bases de Blazor. Il constitue également un portfolio personnel qui présente mes expériences, compétences et formations.

## Objectifs du projet

- **Découverte de Blazor** : il s'agit de ma première expérience avec Blazor.
- **Apprentissage pratique** des concepts clés (components, routing, layout, appels API, etc.).
- **Architecture modulaire** : le projet est conçu pour que chaque partie soit facilement interchangeable (front, back, base de données). Cela permet de tester différentes technologies en les remplaçant sans impacter le reste du projet.

##  Architecture du projet

### Arborescence

```
CV-front/
├── Connected Services/
├── Dépendances/
├── Properties/
│   └── launchSettings.json
├── wwwroot/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   ├── Pages/
│   │   ├── CompetencePage.razor
│   │   ├── Component.razor
│   │   ├── ContactePage.razor
│   │   ├── Error.razor
│   │   ├── ExperiencesPage.razor
│   │   ├── FormationPage.razor
│   │   └── Home.razor
│   ├── App.razor
│   └── Routes.razor
├── data/
│   ├── cvHttpClient.cs
│   └── model.cs
├── appsettings.json
├── appsettings.Development.json
├── .gitignore
├── Dockerfile
├── .dockerignore
├── Program.cs
└── README.md
```

### Détail des dossiers

- `Components/Layout` : Layout principal (`MainLayout.razor`) et menu de navigation (`NavMenu.razor`).
- `Components/Pages` : Regroupe toutes les pages de l'application.
- `data/` : Contient la logique d’accès à l’API :
  - `cvHttpClient.cs` pour les appels HTTP.
  - `model.cs` pour représenter les données récupérées.
- `App.razor` & `Routes.razor` : Gèrent le routage de l’application.
- `wwwroot/` : Dossier public (images, favicon, etc.).
- Fichiers de configuration : `appsettings.json`, `Dockerfile`, etc.

## Modularité

Chaque couche du projet (frontend, backend, base de données) est conçue pour être **remplaçable indépendamment** :
- Le **front** peut pointer vers une autre API.
- Le **backend** peut être remplacé par un autre langage ou framework.
- La **base de données** peut être changée sans modifier le reste.

Cela me permet de tester différentes technologies et de comparer les performances et les approches selon les besoins.


## Technologies utilisées

- **Blazor WebAssembly**
- **.NET 8**
- **C#**
- **Docker** (pour conteneuriser le front)
- **Visual Studio 2022+** pour le développement

---
## Contact

Si vous avez des suggestions, remarques, ou que vous souhaitez echanger autour du projet, n'hesitez pas a me contacter :

**samuel.israel@sfr.fr**
