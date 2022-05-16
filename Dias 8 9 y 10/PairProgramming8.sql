--CREATE DATABASE DevPlaceBD
USE DevPlaceBD

SELECT*
FROM Tecnologia WHERE nombreTecnologia!='POO'

SELECT*
FROM Tecnologia WHERE nombreTecnologia!='.NET'

SELECT*
FROM Tecnologia WHERE nombreTecnologia!='.NET' AND nombreTecnologia!='POO'

SELECT*
FROM Tecnologia WHERE nombreTecnologia!='.NET' OR nombreTecnologia='POO'

SELECT*
FROM Tecnologia WHERE nombreTecnologia='.NET' OR nombreTecnologia!='POO'
