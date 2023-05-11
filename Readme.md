# hc-graphl-dotnet

Minimal asp.net core application that showcases utilizing a graphl to fetch data.

## Getting Started:

Run `dotnet run` in the root directory of this project to start the application.

Navigate to https://localhost:7152/graphql to see the application in action.

If you're using VS Code, you can simply press F5 to start debugging.

## Test GraphQL:

Click *'Create document'*, then *'Apply'*, and paste the following query into the *'Operations'* window (upper left panel):

``` graphql
query {
  book(where: {
    title: { contains: "The Fellowship of the Ring"}
  }) {
    author {
      name
    }
  }
}
```

Finally, click *Run ▷* and the following response should show up in the *Response* window:

``` json
{
  "data": {
    "book": [
      {
        "author": {
          "name": "J.R.R. Tolkien"
        }
      }
    ]
  }
}
```
