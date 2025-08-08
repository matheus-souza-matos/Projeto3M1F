-- DROP DATABASE Notas_Fiscais;
CREATE DATABASE Notas_Fiscais;

USE Notas_Fiscais;

DROP TABLE IF EXISTS login;
CREATE TABLE login(
	id_usuario INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	user VARCHAR(20) NOT NULL,
    senha VARCHAR(20) NOT NULL
);

DROP TABLE IF EXISTS CadastroEmpresa;
CREATE TABLE CadastroEmpresa(
	id_empresa INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nome_empresa VARCHAR(20) NOT NULL,
    cnpjcpf_empresa VARCHAR(20) NOT NULL
);

DROP TABLE IF EXISTS CadastroVeiculo;
CREATE TABLE CadastroVeiculo(
	id_veiculo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nome_veiculo VARCHAR(30) NOT NULL,
	marca_veiculo VARCHAR(15) NOT NULL,
	cor_veiculo VARCHAR(20) NOT NULL,
	ano_veiculo VARCHAR(10) NOT NULL,
	placa_veiculo VARCHAR(8) NOT NULL
);

DROP TABLE IF EXISTS EmissaoNota;
CREATE TABLE EmissaoNota(
	id_nota INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	id_veiculo INT NOT NULL,
    prestador VARCHAR(50) NOT NULL,
    cnpjcpf_prestador VARCHAR(20) NOT NULL,
    id_empresa INT NOT NULL,
    
    FOREIGN KEY (id_veiculo)
		 REFERENCES CadastroVeiculo(id_veiculo),
	
    FOREIGN KEY (id_empresa)
		 REFERENCES CadastroEmpresa(id_empresa)
);

