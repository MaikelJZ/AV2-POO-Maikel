-- Cria o banco de dados
CREATE DATABASE IF NOT EXISTS Financeiro
DEFAULT CHARACTER SET utf8mb4
DEFAULT COLLATE utf8mb4_general_ci;

-- Seleciona o banco
USE Financeiro;

-- Cria a tabela Gastos
CREATE TABLE IF NOT EXISTS Gastos (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Valor DECIMAL(10,2) NOT NULL,
    Data DATE NOT NULL,
    FormaPagamento VARCHAR(50) NOT NULL,
    Descricao VARCHAR(255)
);

Select * from Gastos

INSERT INTO Gastos (Valor, Data, FormaPagamento, Descricao)
VALUES (150.75, '2025-01-20', 'Cartão de Crédito', 'Compra de material de escritório');

