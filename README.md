# YALB (Yet Another Load Balancer)
Load Balancer is one type of Reverse Proxy in a simpler sense. If we consider popular reverse proxies like Nginx, YARP (Yet Another Reverve Proxy) or Ocelot API Gateway; we can create custom Load Balancer using any of them. As YARP is relatively new amonng them and has a fantastic support with .Net in terms of configuration, so I use YARP's built in Load Balancing mechanisms to create a custom Load Balancer named YALB, where the name itself gives homage to the YARP.

Library Used
Yarp.ReverseProxy, Version=2.2.0

**What is Happeing?**

![image](https://github.com/user-attachments/assets/492c4ff9-9166-4e4f-8c0f-e4f553f13b05)


From the above diagram we can see that there is a YARP container acting as a Load Balancer between two instances of the API container. If you call the endpoints, in this case which are:

https://localhost:3001/employee

https://localhost:3001/employee/1

https://localhost:3001/department

https://localhost:3001/department/1

you will see the different urls are coming in the response body along with the data, which are actually the destination urls where the load balancer is redirecting the requests.
**How to run?**
run the docker-compose up in the root folder and then call the above urls from postman or browser or curl and you will get the desired result.
