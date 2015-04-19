UPDATE OccupationalTrends
SET Occupation = 'Religion'
WHERE Occupation = 'Religious Settings';


UPDATE OccupationalTrends
SET Occupation = 'Science'
WHERE Occupation = 'Scientific/Technical';

INSERT INTO OccupationalTrends (Occupation, PersonalityType)
VALUES ('Technical', 'INTJ');

INSERT INTO OccupationalTrends (Occupation, PersonalityType)
VALUES ('Technical', 'INTP');