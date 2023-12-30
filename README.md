# Summary
This is a microservice project with three separate services. Together they run the functions needed for a pizza restaurant. 

## Menu service
Handles storing the menu in a database; the different pizzas and their ingredients.

## Order service
Handles receiving orders and putting them into a database. Can get info about the pizzas from the menu service.

## Marketing service
Stores info about customers. Handles sending out marketing emails about campaigns. 

# Run instructions
Cd to solution directory, build project and run `docker compose up`
