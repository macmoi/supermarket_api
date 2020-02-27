# DTO

A DTO (Data Transfer Object) class is a class that contains only basic information that will be exchanged between client applications and API endpoints, generally in form of JSON data, to represent some particular information. 

All responses from API endpoints must return a DTO.

It is a bad practice to return the real model representation as the response since it can contain information that the client application does not need or that it doesn’t have permission to have (for example, a user model could return information of the user password, which would be a big security issue).

We need a DTO to represent only our categories, without the products.

Without the resource class, response will look like this:

```json
[
  {
    "id": 100,
    "name": "Frutas y vegetales",
    "products": []
  },
  {
    "id": 101,
    "name": "Carnes",
    "products": []
  }
]
```
The propouse with this class is to have a response similar to the following. Without `products` property. 

```json
[
  {
    "id": 100,
    "name": "Frutas y vegetales"
  },
  {
    "id": 101,
    "name": "Carnes"
  }
]
```