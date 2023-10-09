import pymongo

client = pymongo.MongoClient("mongodb://localhost", 27017)
db = client["MovieTunes"]
collection = db["Genero"]

print(f"Essa é uma coleção usada {collection}")''