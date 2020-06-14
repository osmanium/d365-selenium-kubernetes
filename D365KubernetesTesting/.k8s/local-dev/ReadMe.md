#This cluster is for Selenium hub and chrome debug 3.1

#Initiate cluster nodes
kubectl -apply -f .


#VNC port forwarding
kubectl port-forward [pod name] 9000:5900