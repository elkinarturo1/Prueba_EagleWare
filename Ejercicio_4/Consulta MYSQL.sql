/**********************************************************/
/*Type of the most expensive property*/
SELECT TYPE, MAX(value_in_euros) price  FROM Property;
/**********************************************************/


/**********************************************************/
/*Name of the countries of which our database contains no people.*/
SELECT C.name

FROM Country C LEFT JOIN Person P
ON C.id = P.country_id
WHERE P.country_id IS NULL
;
/**********************************************************/

/**********************************************************/
/*Average value of vehicles (properties of type = 'vehicle').*/
SELECT AVG(value_in_euros) averageValue FROM Property
WHERE TYPE = 'vehicle';
/**********************************************************/

/**********************************************************/
/*Name of the person with more vehicles (properties of type = 'vehicle').*/
SELECT Person.name
,count(Property.person_id)  cantProperties

FROM Person INNER JOIN Property 
ON Person.id = Property.person_id

WHERE Property.`type` = 'vehicle';
/**********************************************************/


/**********************************************************/
/*Name of the people who have properties outside of their countries.*/
SELECT Person.id AS idPersona
,Person.name AS idPersonName
,Person.Country_id AS idPaisPerson
,Property.country_id AS idPaisProperty

FROM Person 

INNER JOIN Property
ON Person.id = Property.person_id

WHERE Person.Country_id <> Property.Country_id
;
/**********************************************************/


/**********************************************************/
/*List of people with their names and the total value of their properties, but display only those with more than 500.000 of total property value.*/
SELECT Person.name
,Property.value_in_euros

FROM Person 

INNER JOIN Property
ON Person.id = Property.person_id

WHERE (Property.value_in_euros > 500000)
;
/**********************************************************/