# Marketing API
## Summary  
This API handles getting and storing customers in a database. It also handles sending out marketing emails to customers when asked to do so. 

* **HTTP GET /customers**  
This endpoint returns all customers in the database. Customers are returned in a list of JSON-objects. 
Customer objects contain their Name and Emailadress.
Successful requests are returned with 200OK. 

* **HTTP GET /customer/{id}**  
This endpoint returns a single customer, specified by id in the query, as a JSON-object. 
The customer object contains Name and Emailadress.
Returns 200OK or 404Notfound if customer cannot be found.
If there is a problem with the body of the request this is indicated by 400BadRequest. 

* **HTTP POST /customer**  
Posting to the customer endpoint stores a new customer in the database. 
The post request needs to contain a JSON-object in the body with Name and Emailadress of the customer. 
If the customer already exists it returns 409Conflict.
Successful requests are returned with 200OK and all other problems are indicated by 400BadRequest or 500InternalServerError.

* **HTTP POST /sendmarketing**  
Posting to this endpoint triggers the service to send out a marketing email with the current campaign template.
The email will be sent to all relevant customers in the database. 
Successful trigger will be returned a 200OK. 
Checking that the emails has actually been sent is most easily checked by looking a campaign email in the inbox of the admin.