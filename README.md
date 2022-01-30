**Build image and run container:**  

```
docker build -t demoapi-image .  
docker run --name demoapi-container -d -p 8001:80 demoapi-image  
```

**URL:**  

```
localhost:8001/swagger  
```

**Tag image and upload to Docker Hub:**  

```
docker tag demoapi-image bstraehle/rest-api:latest  
docker push bstraehle/rest-api:latest  
```
