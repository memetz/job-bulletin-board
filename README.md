# Job Bulletin Board Demo

## Summary

The Job Bulletin Board demo is meant to show a list of candidates and jobs. Both candidates and jobs have skills assigned to them. The main feature is to show all jobs and the best candidate for that. User can add candidates and jobs as well.
The matching algorithm has the following assumptions:
- If no candidate matches any of the skill for the job, no candidate will be shown
- If 2 or more candidates have the same amount of skills matched, first candidate matched will have priority  
## Technologies

The app has been created with VS 2017 .net Core Web Application with Angular(5) template for FE. The app comes with a basic nav menu which I re-used for navigation purposes.

## Requirements
You need the following SW installed in your machine
- .NET Core SDK
- Node.js with npm
## Running the app

If using VS it should be as easy as running the app within the IDE which will run both BE and FE. The very first time angular app will install the node_modules and serve the app so might take a while.
If you don't have VS20xx you can run run the BE app entering the following command in the command shell:

```bash
dotnet run
```

For the Angular app located in 'ClientApp' folder you need to install locally first(only once):

```bash
npm install
```

Then serve the app:

```bash
ng serve
```

