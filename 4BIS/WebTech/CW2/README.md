<h1 align="center">This web application was created by 00011883 to fulfill Web Technology module's requirements and does not represent an actual company or service</h1>

## Description

This application is a list of courses with minimalistic functionality that represent details of the each course. 
There are 3 sections on the application: Home, Create a Course, Favourites and ability to Edit already created Course.

## Functionality

<details>
  <summary>Creating a course:</summary>
By clicking "Create Course", the user can add any course. To do this, the user must fill in all the fields, such as the name of the course, author, cost, and duration.
All fields are validated. The user cannot create a course without filling in all fields (required fields).
As you can see, there is an optional field for entering the cover image. To do this, the user needs to copy the URL of any image on Google and paste it into this field.
If user does not set covering image, the application will automatically set default cover image. 
In addition, there is a toggle button that allows you to consider the course as your favorite. If yes, the course will appear in the Favorites section.
</details>

<details>
  <summary>Home section:</summary>

In this section, all created courses with all the information provided are available. To the right of each course there are 3 icons:
adding to the favorites list, editing and deleting.
</details>
  
<details>
  <summary>Favourite section:</summary>

Only courses marked as "favorites" will be displayed in this section. Again, the same features are available, such as editing and deleting from this list. Also,
clicking the red icon will remove the course from the list.
</details>

## Project Structure

- /CW2
  - /backend
    - /src
      - /controllers - controls for routers
      - /middlewares - checkpoints
      - /models - db collection creation 
      - /routes - paths
      - index.ts - app config
      - server.ts - app launcher
    - project back setup files
  - /client
    - /public
    - /src
      - /assets - images
      - /component - reusable components
      - /layouts - only changable items included in default
      - /router - paths
      - /styles - separate style can be imported
      - /views - visible main components
      - App.vue - main app view
      - main.ts - config of app
      - shims-vue.d.ts
    - project front setup files 

## Installation process

<details>
  <summary>Instructions:</summary>
Firstly you need to create '.env' file in the backend folder near '.env.example' and add fields from that with your own data

Secondly, install yarn if you don't have it in your maschine <br />
Run the following <code>npm install --global yarn</code> in the terminal or in cmd to install Yarn

After that, open in VSCode or any Code Editor project folder and open two terminals and set directory to backend and client.<br />
For backend run ```yarn start``` and client ```yarn serve``` respectively.

Then, as compilation finishes, open the link from the client terminal
</details>

## Application Dependencies

<details>
  <summary>Back-End:</summary>
  
  ```
  "dependencies": {
    "axios": "^0.26.1",
    "cors": "^2.8.5",
    "dotenv": "^16.0.0",
    "express": "^4.17.3",
    "mongoose": "^6.2.7",
    "morgan": "^1.10.0",
    "nodemon": "^2.0.15",
    "prettier": "^2.6.1",
    "typescript": "^4.6.2"  
  },
  "devDependencies": {
    "@types/cors": "^2.8.12",
    "@types/express": "^4.17.13",
    "@types/morgan": "^1.9.3",
    "@types/node": "^17.0.21",
    "@types/prettier": "^2.4.4",
    "ts-node": "^10.7.0"
  }
  ```
  
</details>
<details>
  <summary>Front-End:</summary>

  ```
  "dependencies": {
    "sass": "^1.49.10",
    "vue": "^3.0.0",
    "vue-router": "^4.0.0-0"
  },
  "devDependencies": {
    "@vue/cli-plugin-router": "~4.5.13",
    "@vue/cli-plugin-typescript": "~4.5.13",
    "@vue/cli-service": "~4.5.13",
    "@vue/compiler-sfc": "^3.0.0",
    "axios": "^0.26.1",
    "sass-loader": "^8.0.2",
    "typescript": "~4.1.5",
    "vue-axios": "^3.4.1"
  },
  ```
  
</details>

## Hosted on

* Github - Repo [CW2](https://github.com/khusanov-m/WIUT-Uni-Assessments/tree/main/4BIS/WebTech/CW2)
* Backend - Heroku  [00011883](https://wiut00011883.herokuapp.com/api/v1/courses)
* Frontend - Vercel [00011883](https://00011883.vercel.app/)

## Technologies

Front-End
* VueJS 3

Backend-End
* NodeJS/Express
* TypeScript
