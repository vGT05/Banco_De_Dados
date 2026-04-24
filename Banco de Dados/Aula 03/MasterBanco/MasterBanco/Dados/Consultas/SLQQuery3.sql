-- OP READ - LER --
--SELECT * FROM Contas;

/*SELECT Id,Titular,NumeroDaConta,Saldo FROM Contas
WHERE Saldo > 1000
GO*/

SELECT * FROM Contas
WHERE Titular LIKE '%Silva%'
GO