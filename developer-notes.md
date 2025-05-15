# in progress
- Overall structure of the site 
- Planing the UI, perhaps with charts from chart.js
- create Login and Auth now or perhaps later (JWT ?)
- What CRM Data should I use ?(usual suspects would be name, age, adress, notes, priority Nr,)
- create a Dashboard 
- one subsystem should be  'Notes' (with free text)
- create subsystem 'tasks' 
- create Logout 

# done
-  overall project structure is established
- Routes established. Because of the standalone option for the project, there are minor differences in the porject structure. The component  app.module.ts doesn't exist and I have to use app.routes.ts instead. 
- Routerlink caused some trouble but is working fine right now.
- repo was set to global. I accidantally created a repo inside another repo with  ng new.
- Wrote the backend part and used orm from aps.net to create the db.

# pushed back
- Design and other layout features will be added at the end.


# hurdles und/oder lessons learned
- angular standalone has a slightly different structur than the classic version.
- chatgpt is beyond stupid in regards to the standalone nature of the project. I mentioned about 30 times, that no standalone module like module.ts exists.
