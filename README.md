# API CRUD USING NET 6 and DOCKER

## How to Run Using Docker

```
docker build -t web_api .
```

```
docker image
```

```
docker-compose up
```

```
http://localhost:5000/swagger/index.html
```

## To override using env use this command
```
docker run --rm \
-p 8080:80 \
--name api-6 \
-e ASPNETCORE_ENVIRONMENT="Staging" \
-e ConnectionStrings__ProductDB="Server=host.docker.internal;Database=ProductDB;User Id=sa;Password=<pass>;MultipleActiveResultSets=true" \
api:latest
```




refer : https://www.twilio.com/blog/containerize-your-aspdotnet-core-application-and-sql-server-with-docker
