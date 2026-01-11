Generic REST API using in-memory data.  Implements CRUD operations via GET, POST, PUT, and DELETE verbs.  

Build image and run container:  
```
docker build -t restapi-image .  
docker run --name restapi-container -d -p 8001:8080 restapi-image  
```
URL:  
```
localhost:8001/swagger  
```
Tag image and upload to Docker Hub:  
```
docker tag restapi-image bstraehle/rest-api:latest  
docker push bstraehle/rest-api:latest  
```
For Docker orchestration using this container, see https://github.com/bstraehle/docker  
For Kubernetes orchestration using this container, see https://github.com/bstraehle/kubernetes  

---
*This is a test change to verify Devin's access and PR workflow.*  
