SELECT * FROM Varaus

HaeVaraustiedot '2018-05-04','2018-05-04'

CREATE PROCEDURE HaeVaraustiedot
(
	@FromDate date,
	@ToDate date
)
AS
	SELECT varaus_id, asiakas_id, toimipiste_id, varattu_pvm, varattu_alkupvm, varattu_loppupvm FROM varaus
	WHERE varattu_pvm between @FromDate and @ToDate