DROP DATABASE IF EXISTS `Probando`;
CREATE DATABASE `Probando`;
USE `PROBANDO`;
CREATE TABLE `Usuario` (
	`NombreUsuario` VARCHAR(10) NOT NULL,
    `Contrasenia` VARCHAR(20) NOT NULL,
    `Nombre` VARCHAR(20),
    `FechaNacimiento` DATE,
    PRIMARY KEY(`NombreUsuario`)
);