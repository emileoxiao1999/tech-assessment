# Hey developers, engineers, hackers. 
**This is important!** We want to respect your valuable time so **_PLEASE_** timebox this exercise.

Your current mission, should you choose to accept it, is to take a few (no more than two) hours to build an Orders REST API endpoint. We have created some starter templates for a few languages but you don't need to use them if you would prefer to roll your own.

## What we would like to see from this exercise:
* Create order endpoint
* List all orders by customer endpoint
* Update order endpoint
* Cancel order endpoint
* Tests to prove your code works as expected

**Currently supported languages templates:** C#, Go, Node.JS, Python

_We are open to other languages if you feel more comfortable in them. We have expertises in **Java**, **Kotlin**, and a few others._

If you don't see your language of preference on the list of languages above, **_please reach out_**. We are happy to discuss other langages as well.

## How to interact with this activity:
1. Fork this repo
2. Complete exercise with a language listed above (assuming you haven't chosen another, hipper language and discussed it with us)
3. Provide a link to the completed exercise to Jenny Hove [jenny.hove@sogeti.com]
4. Receive personalized code review/feedback session from our technical team


_______________________________________________________________________________________________________________________________________________________________________________

#Emileo Xiao's Changes/Changelog
Files Created:
1. Order.cs
2. Customer.cs
3. OrdersController.cs
4. CSharpDbContext.cs

It took me the longest time to figure out where to start. As there was no customer or order specified, I realized that I had to create it from scratch.
Following a similar format to what was in the JSON files in the Python folder, I created the customer model. The Order model was just a guess with
attributes that I thought would make sense. They are then linked in a one-to-many relationship.

#First Attempt
I was following what I have done in previous projects so creating interfaces of repositories and services. This allows for easier scalability whenever you need to add
new models and are good coding practices. In addition, allowing repositories to handle data and services to handle calculations made the project more complicated. After a while, I realized that this was not a good way to do this exercise, because I was making it more complicated than needed to be. As I had almost all of the endpoints working, I wasted a lot of time thinking my Postman tests didn't work. I thought I had SSL certification turned off, but it was actually turned on so I couldn't test my endpoints. This led me to scrape almost everything and start over.

#Second Attempt
I decided to go with the simple and clean approach this time. I used Entity Framework Core's api model creation on Visual Studio which autocompletes many basic endpoint creation. I kept my previous in-memory database creation and added the custom endpoint of returning all orders based on the customer. Then, I tested and this whole attempt took me 20 minutes.

Lessons learned: don't over think what you need to do. Sometimes you need to try different things to find the one that works the best.

#Tests
Using Postman and in-order:

1. Get Request
  Header: https://localhost:44394/api/orders
  This returns all of the default orders already created.
  
2. Get Request
  Header: https://localhost:44394/api/Orders/customerid/102
  Returns all orders that were created by customer with id of 102
  
3. Post Request
  Header: https://localhost:44394/api/orders
  Choose Body, Raw, JSON
 
  Body:
  {
    "id": 208,
    "title": "created new order",
    "description": "created new order",
    "customerId": 102,
    "customer": null
  }
  
  This creates a new order with an id of 208
  
4. Get Request
  Header: https://localhost:44394/api/Orders/208
  This returns the newly created order, tests if it was successfully saved
  
5. Put Request
  Header: https://localhost:44394/api/orders/208
  Header: https://localhost:44394/api/orders
  Choose Body, Raw, JSON
 
  Body:
  {
    "id": 208,
    "title": "updated new order",
    "description": "updated new order",
    "customerId": 102,
    "customer": null
  }
  
  This updates the newly created order with new attributes
  
6. Get Request
   Header: https://localhost:44394/api/Orders/208
  This returns the newly updated order, tests if it was successfully saved
  
7. Get Request
  Header: https://localhost:44394/api/Orders/customerid/102
  To test if the newly created and updated order is returned by the customer id as well
  
8. Delete Request
  Header: https://localhost:44394/api/Orders/208
  This deletes our newly created order

9. Get Request
  Header: https://localhost:44394/api/Orders/208
  This shoudl return a 404 not found error because we just deleted the order
  
Testing Done!
  


