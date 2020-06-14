#This cluster is for Selenium hub and chrome 3.1

#Initiate cluster nodes
kubectl -apply -f .

#Change namespace
kubectl config set-context --current --namespace=d365-scaled-selenium-testing

#Open http://localhost:32000/grid/console to confirm nodes are connected to hub

#Url for RemoteWebDriver to connect to Selenium Hub from host
http://localhost:32000/wd/hub

#Easiest way to restart nodes
kubectl scale deployment chat --replicas=0 --namespace=d365-scaled-selenium-testing
kubectl scale deployment chat --replicas=5 --namespace=d365-scaled-selenium-testing

#Check nodes logs
kubectl get pods -l app=selenium-node-chrome

#Get one of the pods name
kubectl logs [pod name]