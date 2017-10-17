# Standard obvious submission:

SELECT name, population, area FROM World WHERE area > 3000000 OR population > 25000000

# Faster submission using UNION:
SELECT name, population, area FROM World WHERE area > 3000000
UNION
SELECT name, population, area FROM World WHERE population > 25000000