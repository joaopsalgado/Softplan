# Softplan

# Build Docker 
## No diretório do Dockerfile buildar a imagem docker: docker build -t softplanapp:1.0 .
## Iniciar o container com o código:  docker run -d -it --name softplan -p 5000:80  softplanapp:1.0

## Acessar a Url da API por exemplo:
   http://127.0.0.1:5000/api/calculadorTaxa/calculajuros?valorinicial=100&meses=5
