-- MySQL dump 10.13  Distrib 5.6.16, for Win32 (x86)
--
-- Host: localhost    Database: BORDERLANDS2
-- ------------------------------------------------------
-- Server version	5.6.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipo` (
  `nombre` varchar(20) DEFAULT NULL,
  `localizacion` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES ('Bekah','Se obtiene de los enemigos Tubby teniendo el pack ultimate vault hunter 2'),('Sawbar','Se obtiene del tanquearaña final del digistruck y de los enanos legendarios'),('Bearcat','Se obtiene del tanquearaña final del digistruck y de los enanos legendarios'),('Seeker','Se obtiene del vendedor serafin de Flamerock Refuge en el dlc del asalto a la mazmorra del dragon'),('Serafin','Se obtiene del vendedor serafin de Oasis del dlc de la capitana scarlet y el botin pirata'),('Lead Storm','Se obtiene del vendedor serafin de Hunters groto del dlc de la caceria de Hammerlock o de Voracido el invencible'),('Kerblaster','Se obtiene del Simienano de Southern Shelf y de las maquinas de venta torgue en el dlc de la escabechina del señor Torgue'),('Shredifier','Se obtiene Hyperius el invencible en Washburne Refinery del dlc de la capitana scarlet y el botin pirata y de sitios aleatoriios'),('Madhous!','Se obtiene de Perro Loco en Lynchwood y de sitios aleatorios'),('Ogre','Se obtiene del Caudillo Orco en la ronda de cabronazos de la mision Masacre Magica en el dlc del asalto a la mazmorra del dragon'),('Hammer Buster','se obtiene de Mick Zaford tras haber elegido matar al clan de los Zaford en la mision Guerra entre Clanes en The Dust y en sitios aleatorios'),('Veruc','Se obtiene de Mobley en The Dust y en sitios aleatorios'),('Stomper','Se obtiene de la mision Mas Hambre que un Skag en Arid-Nexus Badlands'),('Evil Smasher','Se obtiene de la mision El Elegido en Sanctuary'),('Hail','Se obtiene completando la ronda final de la mision de Masacre de Bandidos en Finks Slaughterhouse al comienzo de The Fridge'),('Scorpio','Se obtiene completando la mision Portador de Malas Nuevas en Sanctuary'),('Rapier','Se obtiene completando la mision Mensaje en una Botella en Hayters Folly en el dlc de la capitana scarlet y su botin pirata'),('Stinkpot','Se obtiene matando a Sin Barba en Oasis en el dlc de la capitana scarlet y su botin pirata'),('Boom Puppy','Se obtiene de la mision Paseando al Perrito en el dlc de la escabechina del señor Torgue'),('Kitten','Se obtiene de la mision Todo el Mundo Quiere ser Buscado del dlc de la escabechina del señor Torgue'),('Damned Cowboy','Se obtiene matando a Cola Sangrienta en el dlc de caza del señor Hammerlock'),('Chopper','Se obtiene matando a Insidioso el invencible en Hunters Grotto del dlc de caza del señor Hammerlock'),('Wanderlust','Se obtiene de los enemigos Tubby teniendo el pack ultimate vault hunter 2'),('Stalker','Se obtiene del tanquearaña final del digistruck y enanos legendarios'),('Unforgiven','Se obtiene del tanquearaña final del digistruck y enanos legendarios'),('Stinger','Se obtiene de los Dragones Antiguos de la Destruccion del dlc del asalto a la mazmorra del dragon'),('Infection','Se obtiene del vendedor serafin de Hunters Grotto en el dlc de caza del señor Hammerlock y de Voracido el invencible'),('Devastator','Se obtiene del vendedor serafin de Oasis y de Master Gee el invencible en el dlc de la capitana scarlet y el botin pirata, solo en modo normal y experto, en definitivo lo puede soltar Hyperius el invencible'),('Infinity','Se obtiene matando al Doctor Piedad en Three Horns Valley, matando al golem dorado en minas de la avaricia en el dlc de asalto a la mazmorra del dragon y de Tubby Bones del mismo dlc'),('Thunderball Fists','Se obtiene matando al Capitan Flynt en Southern Shelf, de Sparky Flynt en Wam bam Island y de sitios aleatorios'),('Hornet','Se obtiene matando a Rastranudillos, a Hyperius el invencible y de sitios aleatorios'),('Gub','Se obtiene matando a Laney nieves y de sitios aleatorios'),('Unkempt Harold','Se obtiene de las maquinas de venta de torgue en el dlc de la escabechina del señor Torgue como objeto del dia y de lee el salvaje'),('Maggie','se obtiene de Mick Zaford tras haber elegido matar al clan de los Zaford en la mision Guerra entre Clanes en The Dust y en sitios aleatorios'),('Logans Gun','Se obtiene de Wilhelm en End of the Line y de sitios aleatorios'),('Gunerang','Se obtiene de Rakkman en The Fridge y sitios aleatorios'),('Dahlminator','Se obtiene de la mision El Tesoro Perdido en Sawtooth Cauldron'),('Gwens Head','Se obtiene en cinco ubicaciones diferentes de The Dust siendo el taller de Ellie el mas facil de localizar'),('Teapot','Se obtiene haciendo la mision de Tiny Tina Una Invitacion Cordial: la merendola en Tundra Express'),('Fibber','Se obtiene tras haber hecho la ultima mision de la cadena de misiones Un Niño de Verdad en Eridium Blight'),('Lady Fist','Se obtiene tras entregar los planos de la mision Tio Teddy a Una Baha en Arid-Nexus Badlands'),('Rubi','Se obtiene tras entregar la mision Rakkalcoholicos Anonimos de Sanctuary a Moxxi en vez de a Mordecai'),('Tinderbox','Se obtiene del capitan Flynt, en Tundra Express golpeando la cabeza del muñeco de nieve al principio del mapa con la mision activa de Todos al Tren y como objeto de mision Guerra entre Clanes: Desguaza Caravanas en The Dust'),('Veritas','Se obtiene tras hacer la mision Guerra entre Clanes: Velatorio Desvelado'),('Judge','Se obtiene del asesino Oney en Southpaw Steam & Power y del mismo asesino que aparece en el digistruck'),('Law','Se obtiene el oficial Friedman en Sanctuary tras completar la mision No me la Jugaras Otra Vez'),('Grog Nozzle','Se obtiene como objeto de mision en La Barba Hace al Mago en el dlc del asalto a la mazmorra del dragon, tambien se conseguia con un evento del juego'),('Greed','Se obtiene tras derrotar a Roscoe en la mision principal La x Señala el lugar del dlc de la capitana scarlet y el botin pirata, scarlet la dejara caer al terminar el combate'),('Little Evie','Se obtiene en Magnys Lighthouse tras matar a un enemigo de aparicion aleatoria llamado señor burbujas sin dañar a Hermanita que es el personaje que te dara el arma en el dlc de la capitana scarlet y el botin pirata'),('Pocket Rocket','Se obtiene de las maquinas de venta Torgue en el dlc de la escabechina del señor Torgue'),('Rex','Se obtiene de Bulstoss en el dlc de caza del señor Hammerlock'),('Tunguska','Se obtiene del tanquearaña final del digistruck, de enanos legendarios y sitios aleatorios'),('Ahab','Se obtiene del vendedor serafin de Oasis en el dlc de la capitana scarlet y el botin pirata en modo experto y de Master gee el invencible en el modo definitivo'),('Badaboom','Se obtiene de Donkey Mong en Eridium Blight y de sitios aleatorios'),('Norfleet','Se obtiene de Vermivoro el invencible y de Hyperius el invencible'),('Pyrophobia','Se obtiene del incinerador Clayton en Frostburn Canyon, de Clark en Hallowed Hollow y en sitios aleatorios'),('Bunny','Se obtiene de enemigos sebosos y sitios aleatorios'),('Nukem','Se obtiene de la Reina Negra en The Dust, en las maquinas de venta Torgue como objeto del dia en el dlc de la escabechina del señor torgue y de la Hija del Brujo en el dlc de asalto a la mazmorra del dragon'),('Mongol','Se obtiene de la Mama de Dukino en Lynchwood y de sitios aleatorios'),('Roaster','Se obtiene haciendo la mision Nota para Yo en The Fridge'),('Hive','Se obtiene de Saturno en Arid Nexus-Badlands'),('12 Pounder','Se obtiene de Modorra en Hayters Folly'),('Creamer','Se obtiene tras completar la ronda 5 de masacre de criaturas en el mapa que hay en la Wildlife Exploitation Preserve'),('Carnage','Se consigue de los enemigos Tubby teniendo el ultimate vault hunter pack 2'),('Butcher','Se obtiene del tanquearaña final del digistruck, de enanos legendarios y sitios aleatorios'),('Omen','Se obtiene de los Dragones Antiguos de la Destruccion en el dlc de asalto a la mazmorra del dragon'),('Retcher','Se obtiene del vendedor serafin de Oasis en el dlc de la capitana scarlet y el botin pirata en modo normal y experto y de Hyperius el invencible en definitivo'),('Interfacer','Se obtiene de Voracido el invencible en modo definitivo y del vendedor serafin en Hunters Grotto del dlc de caza del señor Hammerlock en modo normal y experto'),('Striker','Se obtiene del viejo Slappy en The Highlands-Outwash'),('Sledges Shotgun','Se obtiene de Trituracabezas en The Fridge, de Hyperius el invencible, del Golem dorado en Minas de Avaricia y de sitios aleatorios'),('Flakker','Se obtiene del Guerrero, en las maquinas de venta de Torgue en el dlc de la escabechina del señor Torgue y de Jack el Brujo en el dlc asalto a la mazmorra del dragon'),('Conference Call','Se obtiene del Guerrero, de Jack el Brujo y de sitios aleatorios'),('Deliverance','Se obtiene de Tumbaa en Wildlife Exploitation Preserve y de sitios aleatorios'),('Swordsplosion','Se obtiene de la mision La Espada en el Apedreador en el dlc asalto a la mazmorra del dragon'),('Slow Hand','Se obtiene del Çabronazosaurio y de Piston en el dlc escabechina del señor Torgue'),('Triquetra','Se obtiene de la mision Guerra entre Clanes: el Fin del Arcoiris'),('Octo','Se obtiene de la mision A por Slappy'),('Blockhead','Se obtiene de los Creeper cabronazos en Caustic Caverns'),('Heart Breaker','Se obtiene de la mision A Prueba de Robos entregando la mision a moxxi'),('Shotgun 1340','Se obtiene entregando la mision Experiencia Ultracorporea a Marcus'),('Tidal Wave','Se obtiene entregando la mison Tio Teddy a Hyperion en Arid Nexus-Badlands'),('Dog','Se consigue del asesino Rouf en Southpaw Steam & Power y del mismo en el Digistruck'),('Roksalt','Se consigue de la mision Grupo de Astilla'),('Jolly Roger','Se obtiene de la mision los Desertores del Desertico Desierto en Wurmwater en el dlc de la capitana scarlet y el botin pirata'),('Orphan Maker','Se obtiene de la mision Mensaje en una botella en Oasis en el dlc de la capitana scarlet y el botin pirata'),('Hydra',' se obtiene de Rojo en Candlerakks Crag en el dlc de caza del señor Hammerlock'),('Twister','se obtiene de Omnd-Omnd-Ohk'),('Teeth of Terramorpho','Se obtiene de Terramorfo el invencible'),('Landscaper','se obtiene de la mision final de Guerra entre Clanes siendo aliado de los Hodunk'),('Avenger','Se obtiene del tanquearaña final del digistruck, de enanos legendarios y sitos aleatorios'),('Tattler','Se obtiene del vendedor serafin de Oasis en modo normal y experto y de Hyperius el invencible en modo definitivo en el dlc de la capitana scarlet y el botin pirata'),('Actualizer','Se obtiene del vendedor serafin de Oasis y de Hyperius el invencible en el dlc de la capitana scarlet y el botin pirata'),('Florentine','Se obtiene del vendedor serafin en Flamerock Refuge en el dlc de asalto a la mazmorra del dragon'),('Slagga','Se obtiene de Tector y Jimbo Hodunk tras aliarse con los Zaford en la mision final de guerra entre clanes, del dragon alucinante en Hatreds Shadow del dlc asalto a la mazmorra del dragon y de sitios aleatorios'),('Emperor','Se obtiene de los asesinos Wot, Oney, Reeth y Rouf en Southpaw Steam & Power y el digistruck'),('Bitch','Se obtiene de BNK-3R y sitios aleatorios'),('Hellfire','Se obtiene de Brasa en Frostburn Canyon y digistruck y de Sully el herrero'),('Baby Maker','Se obtiene de Madame Von Bartlesby en Tundra Express'),('Yellow Jacket','Se obtiene de Jackenstein en H.S.S Terminus'),('orc','Se obtiene en la ronda 5 de la mision Masacre Mágica en el dlc de asalto a la mazmorra del dragon'),('bone Shredder','Se obtiene de Cabeza Hueso 2.0 en Arid Nexus-Badlands y digistruck y de Arguk el carnicero en el dlc asalto a la mazmorra del dragon'),('Crit','Se obtiene de la mision Pifia en Flamerock Refuge en el dlc asalto a la mazmorra del dragon'),('Good Touch','Se obtiene de moxxi dando propinas en su bar de Sanctuary'),('Bad Touch','Se obtiene de moxxi dando propinas en su bar de Sanctuary'),('Sand Hawk','Se obtiene de la mision ¡uy! en el dlc de la capitana scarlet y el botin pirata'),('Lascaux','Se obtiene en Frostbourne Canyon, se encuentra en una charca con hormigarañas'),('Bane','Se obtiene de la mision el azote'),('Commerce','Se obtiene del asesino Wot en Southpaw Steam & Power y el digistruck'),('Chulainn','Se obtiene de la ultima mision de Guerra entre Clanes, siendo aliado de los zaford'),('Godfinger','Se obtiene de enemigos Tubby teniendo el ultimate vault hunter pack 2'),('Storm','Se obtiene del tanquearaña final del digistruck, de enanos legendarios y sitios aleatorios'),('Hawk Eye','Se obtiene de Voracido el invencible, de Omnd Omnd Ohk y del vendedor serafín en modo normal y experto'),('Patriot','Se obtiene del vendedor serafin de Oasis en modo normal y experto y de Master Gee el invencible en el modo definitivo'),('Lyuda','Se obtiene de Gettle en the Dust y sitios aleatorios'),('Skullmasher','Se obtiene del hijo de Polillarakk en Wildlife Exploitation Preserve, de Rakkanoth en el dlc de caza del señor Hammerlock y de sitios aleatorios'),('Pitchfork','Se obtiene de Terramorfo el invencible y sitios aleatorios'),('Invader','Se obtiene de Saturno en Arid Nexus-Badlands y sitios aleatorios'),('Volcano','Se obtiene del Guerrero, de jack el Brujo en el dlc de asalto a la mazmorra del dragon y de sitios aleatorios'),('Longbow','Se obtiene del Creeper Cabronazo en Caustic Caverns'),('Sloth','Se obtiene de la mision Rakkalcoholicos Anonimos entregando la mision a mordecai'),('Trespasser','Se obtiene de la mision Los Derechos de los Animales'),('Elephant Gun','Se obtiene de Arizona en el dlc de caza del señor Hammerlock'),('Cobra','Se obtiene de Pete el piromano'),('Fremingtons Edge','Se obtiene del asesino Reeth en Southpaw Steam & Power y digistruck'),('Chere-amie','Se obtiene de la mision Masacre de Hyperion en Ore chasm'),('Pimpernel','Se obtiene de la mision No Copies ese Disquete del dlc de la capitana scarlet y el botin pirata'),('Morningstar','Se obtiene de la mision Contrato de Hyperion 873 en The Higlands'),('Buffalo','Se obtiene de la mision Cazador de Demonios en Lynchwood'),('Baster','este grupo de fusiles de asalto se encuentran en sitios aleatorios'),('BlaSSter','Se obtiene de sitios aleatorios'),('Dart','Se obtiene de la mision Misterio Medico X y de sitios aleatorios'),('Spiker','Se obtiene de la mision Misterio Medico X com-unicado'),('Plasma Caster','esta serie de subfusiles se consiguen en sitios aleatorios'),('Splasher Blashter','Se consigue en sitios aleatorios'),('Splatgun','Se obtiene de sitios aleatorios'),('Railer','Se obtiene de sitios aleatorios'),('Hybridfication','Se consigue de sitios aleatorios'),('Moloko','Se obtiene de sitios aleatorios'),('PRAZMA CANON','Se obtiene de sitios aleatorios'),('PBFG','Se obtiene de sitios aleatorios'),('Launcher','Se obtiene de sitios aleatorios'),('Topneaa','Se obtiene de sitios aleatorios'),('Mashine Gun','Se obtiene de sitios aleatorios'),('Carbine','Se obtiene de sitios aleatorios'),('Rifle','Se obtiene de sitios aleatorios'),('Torpedo','se obtiene de sitios aleatorios'),('Spinigun','Se obtiene de sitios aleatorios'),('Pistal','Se obtiene de sitios aleatorios'),('Repeater','Se obtiene de sitios aleatorios'),('Vision','Se obtiene de sitios aleatorios'),('Iron','Se obtiene de sitios aleatorios'),('Aegis','Se obtiene de sitios aleatorios'),('Handgun','Se obtiene de sitios aleatorios'),('Slapper','Se obtiene de sitios aleatorios'),('Anarchist','Se obtiene de sitios aleatorios'),('Smig','Se obtiene de sitios aleatorios'),('Fox','Se obtiene de sitios aleatorios'),('Transmurdera','Se obtiene de sitios aleatorios'),('Venom','Se obtiene de sitios aleatorios'),('Subcompact MG','Se obtiene de sitios aleatorios'),('Room Cleaner','Se obtiene de sitios aleatorios'),('Thinking','Se obtiene de sitios aleatorios'),('Coach Gun','Se obtiene de sitios aleatorios'),('Home Security','Se obtiene de sitios aleatorios'),('Ravager','Se obtiene de sitios aleatorios'),('Sniper','Se obtiene de sitios aleatorios'),('Transaction','Se obtiene de sitos aleatorios'),('Muckamuck','Se obtiene de sitios aleatorios'),('Snider','Se obtiene de sitios aleatorios'),('Droog','Se obtiene de sitios aleatorios'),('Launcher','Se obtiene de sitios aleatorios'),('Panorama','Se obtiene de sitios aleatorios'),('Tediore Launcher','Se obtiene de sitios aleatorios'),('Duuurp!','Se obtiene de sitios aleatorios'),('Vanquisher','Se obtiene de sitios aleatorios'),('Meteor Shower','Se obtiene del vendedor serafin en Badass Crater of Badassitude en el dlc de la escabechina del señor Torgue'),('Crossfire','Se obtiene del vendedor serafin en Badass Crater of Badassitude en el dlc de la escabechina del señor torgue'),('0-Negative','Se obtiene del vendedor serafin en Badass Crater or Badassitude en el dlc de la escabechina del señor Torgue en modo normal y experto y de Pete el invencible en modo definitivo'),('Fire Bee','Se obtiene de sitios aleatorios'),('Storm Front','se obtiene de Lee, Mike, Dan o Ralph en Bloodshot Stronghold'),('Pandemic','Se obtiene de Mortero en Sawtooth Cauldron y sitios aleatorios'),('Leech','Se obtiene del Guerrero, de Jack el Brujo en el dlc de asalto a la mazmorra del dragon y de sitios aleatorios'),('Fastball','Se obtiene de Boll en Three Horns Divide y sitios aleatorios'),('Nasty Surprise','Se obtiene de Vermivoro el invencible y de sitios aleatorios'),('Quasar','Se obtiene del Varkid Cabronazo Definitivo y de sitios aleatorios'),('Bouncing Bonny','Se obtiene de sitios aleatorios'),('Rolling Thunder','Se obtiene de Wilhelm en End of the Line, de las maquinas de venta Torgue como objeto del dia en el dlc escabechina del señor Torgue y de sitios aleatorios'),('Bonus Package','Se obtiene de los hermanos bum bum en Southern sHelf, en maquinas de venta Torgue como objeto del dia en el dlc escabechina del señor torgue y de sitios aleatorios'),('Breath of Terramorph','Se obtiene de Terramorfo el invencible'),('Fire Storm','Se obtiene de los magos cabronazos en el dlc asalto a la mazmorra del dragon'),('Relampago en Cadena','Se obtiene de los brujos cabronazos en el dlc asalto a la mazmorra del dragon'),('Proyectil Magico','Se obtiene de los magos en el dlc asalto a la mazmorra del dragon'),('Fireball','Se obtiene de magos de fuego y magos de fuego cabronazos en el dlc asalto a la mazmorra del dragon'),('Lightning Bolt','Se obtiene de brujos y nigromantes y del dragon alucinante en el dlc asalto a la mazmorra del dragon'),('Estrella de Medianoc','Se obtiene de la mision Mensaje en una botella en Faro de Magnys en el dlc de la capitana scarlet y el botin pirata'),('Fuster Cluck','Se obtiene de la mision Asalto al Tren de la Pasta en Tundra Express'),('Kiss of Death','Se obtiene de la mision la Furia de una Mujer Despechada en Sanctuary'),('Contraband Sky Rocke','Se obtiene con la edicion deluxe, coleccionista, edicion juego del año y ultimate loot chest del juego'),('Antagonist','Se obtiene del vendedor serafin de Flamerock Refuge en el dlc asalto a la mazmorra del dragon'),('Blockade','Se obtiene de los Dragones Antiguos de la Destruccion en el dlc asalto a la mazmorra del dragon'),('Evolution','Se obtiene del vendedor serafin de Oasis en el dlc de la capitana scarlet y el botin pirata en los modos normal y experto y de Hyperius el invencible en el modo definitivo'),('Hoplite','Se obtiene del vendedor serafin del dlc de la escabechina del señor Torgue en modos normal y experto y de Pete el invencible en modo definitivo'),('Pun-chee','Se obtiene del vendedor serafin del dlc de la escabechina del señor Torgue'),('Big Boom Blaster','Se obtiene del vendedor serafin del dlc de la escabechina del señor Torgue en modos normal y experto y de Pete el invencible en modo definitivo'),('Sponge','Se obtiene del vendedor serafin del dlc escabechina del señor Torgue'),('Impaler','Se obtiene del guerrero, de Jack el brujo en el dlc asalto a la mazmorra del dragon y de sitios aleatorios'),('Hide of Terramorphou','Se obtiene de Terramorfo el invencible'),('Neogenator','Se obtiene de la Psicaraña tras hacer la mision Macedonia de Monstruos parte 3 en Frostburn Canyon, de Sully el herrero en el dlc de la cosecha sangrienta y de sitios aleatorios'),('The Transformer','Se obtiene de Pimon en Wildlife Exploitation Preserve y de sitios aleatorios'),('The Sham','Se obtiene de BNK-3R bunker en the Bunker y de sitios aleatorios'),('Flame of the Firehaw','Se obtiene completando la mision los Sectarios: la Incineracion'),('Whisky Tango Foxtrot','Se obtiene de enemigos sebosos y de sitios aleatorios'),('Fabled Tortoise','Se obtiene de Azul en Caustic Caverns y de sitios aleatorios'),('Black Hole','Se obtiene del ingeniero Jasper en Opportunity y de sitios aleatorios'),('The Bee','Se obtiene de Hunter Hellquist en Arid Nexus-Boneyard, de los arboles Treants en The Forest en el dlc asalto a la mazmorra del dragon y de sitios aleatorios'),('The Cradle','Se obtiene de Henry en The Highlands y de sitios aleatorios'),('Cracked Sash','Se obtiene de Varkids super cabronazos, Varkids sebosos, Rakks Sebosos, Hormigarañas sebosas y Skags sebosos'),('Deadly Bloom','Se obtiene de la mision Overlock: esto es solo una prueba y sitios aleatorios'),('Love Thumper','Se obtiene de la mision el Mejor dia de la Madre de la historia'),('Captain Blades Manly','Se obtiene de la mision Mensaje en una botella en Wurmwater en el dlc de la capitana scarlet y el botin pirata'),('Captain Blades Manly','Se obtiene de la mision Mensaje en una botella en Wurmwater en el dlc de la capitana scarlet y el botin pirata'),('The Rough Rider','Se obtiene de The Bulwark en hunters Grotto en el dlc de caza del señor hammerlock'),('1340 Shield','Se obtiene de la mision Experiencia Ultracorporea, entregando la IA a Zed en vez de a Marcus'),('Pot O,Gold','Se obtiene de Peter Zaford en The Holy Spirits'),('Aequitas','Se obtiene de la mision Guerra entre Clanes: Velatorio desvelado'),('Order','Se obtiene de la mision Muy Mejores Amigos en Sancturary'),('Sangre de Terramorfo','Se obtiene de Terramorfo el invencible'),('Sombra de los serafi','Se obtiene del vendedor serafin de Flamerock Refuge en el dlc asalto a la mazmorra del dragon'),('Aliento de los seraf','Se obtiene del vendedor serafin de Hunters Grotto en el dlc de caza del señor Torgue'),('Sangre de los serafi','Se obtiene del vendedor serafin de Oasis en el dlc de la capitana scarlet y el botin pirata'),('Poder de los serafin','Se obtiene del vendedor serafin de Badass Crater of Badassitude en el dlc escabechina del señor Torgue'),('Sangre de los antigu','Se obtiene de los enanos legendarios en modo definitivo'),('Hueso de los antiguo','Se obtiene de los enanos legendarios en modo definitivo'),('Piel de los antiguos','Se obtiene de los enanos legendarios en modo definitivo'),('Corazon de los antig','Se obtiene de los enanos legendarios en modo definitivo'),('Aggression Relic','Se obtiene de sitios aleatorios'),('Proficiency Relic','Se obtiene de sitios aleatorios'),('Protection Relic','Se obtiene de sitios aleatorios'),('Stockpile Relic','Se obtiene de sitios aleatorios'),('Placa de Sheriff','Se obtiene de la Sheriff de Lynchwood'),('Strength Relic','Se obtiene de sitios aleatorios'),('Allegiance Relic','Se obtiene de sitios aleatorios'),('Vitality Relic','Se obtiene de sitios aleatorios'),('Resistance Relic','Se obtiene de sitios aleatorios'),('Elemental Relic','Se obtiene de sitios aleatorios'),('Tenacity Relic','Se obtiene de sitios aleatorios'),('Moxxis Endowment','Se obtiene de la mision el bueno, el malo y mordecai'),('Lucrative Opportunit','Se obtiene entregando la mision A Prueba de Robos a Marcus en vez de a moxxi'),('Vault Hunters Relic','Se obtiene con la version pre-order o comprando el pack mecanomancer'),('El Inyector','Se obtiene de la mision Una Imagen Positiva en The Dust'),('Amuleto Misterioso','Se obtiene comprandolo a Miz en Lair of infinite Agony en el dlc asalto a la mazmorra del dragon'),('Captain Blades Otto ','Se obtiene de la mision Mensaje en una botella en The Rustyards en el dlc de la capitana scarlet y el botin pirata'),('Placa de Ayudante','Se obtiene de la mision Duelo al Mediodia'),('turtle shield','Se obtiene de sitios aleatorios'),('Shield','Se obtiene de sitios aleatorios'),('Adaptive Shield','Se obtiene de sitios aleatorios'),('Absorb shield','Se obtiene de sitios aleatorios'),('Amplify Shield','Se obtiene de sitios aleatorios'),('Booster Shield','Se obtiene de sitios aleatorios'),('Maylay Shield','Se obtiene de sitios aleatorios'),('Nova Shield','Se obtiene de sitios aleatorios'),('Spike Shield','Se obtiene de sitios aleatorios'),('Granadas de transfus','Se obtiene de sitios aleatorios'),('Granadas Standard','Se obtiene de sitios aleatorios'),('Granadas Mirv','Se obtiene de sitios aleatorios'),('Granadas Bouncing Be','Se obtiene de sitios aleatorios'),('Granadas Tesla','Se obtiene de sitios aleatorios'),('Granadas de Singular','Se obtiene de sitios aleatorios');
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modificadores`
--

DROP TABLE IF EXISTS `modificadores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modificadores` (
  `nombre` varchar(250) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `personaje` varchar(20) DEFAULT NULL,
  `obtencion` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modificadores`
--

LOCK TABLES `modificadores` WRITE;
/*!40000 ALTER TABLE `modificadores` DISABLE KEYS */;
INSERT INTO `modificadores` VALUES ('Legendary Sniper','naranja','zero','Se obtiene de enemigos tubby teniendo el pack ultimate vault hunter mode'),('Sniper','morado','zero','Se obtiene de sitios aleatorios'),('Rogue','morado','zero','Se obtiene en cofres del dlc asalto a la mazmorra del dragon'),('Spy','morado','zero','Se obtiene de sitios aleatorios'),('Legendary Soldier','naranja','Axton','Se obtiene de Vermivoro el invencible, de Pete el invencible y de Voracido el invencible'),('Rifleman','morado','Axton','Se obtiene de sitios aleatorios'),('Gunner','morado','Axton','Se obtiene de sitios aleatorios'),('Legendary Gunzerker','naranja','Salvador','Se obtiene de enemigos Tubby teniendo el pack ultimate vault hunter mode'),('Hoarder','morado','Salvador','Se obtiene de sitos aleatorios'),('Monk','morado','Salvador','Se obtiene de los cofres y enemigos del dlc asalto a la mazmorra del dragon'),('Legendary Siren','naranja','Maya','Se obtiene de Vermivoro el invencible, de Pete el invencible, Voracido el invencible y de los antiguos dragones de la destruccion'),('Nurse','morado','Maya','Se obtiene de sitios aleatorios'),('Banshee','morado','Maya','Se obtiene de sitios aleatorios'),('Legendary Mechromancer','naranja','Gaige','Se obtiene de Vermivoro el invencible, Pete el invencible y Voracido el invencible'),('Zapper','morado','Gaige','Se obtiene de sitios aleatorios'),('Technophile','morado','Gaige','Se obtiene de sitios aleatorios'),('Legendary Psycho','naranja','Krieg','Se obtiene de enemigos invencibles y sitios aleatorios'),('Crunch','morado','Krieg','Se obtiene de sitios aleatorios'),('Toast','morado','Krieg','Se obtiene de sitios aleatorios'),('legendary Hunter','naranja','zero','Se obtiene de Vermivoro el invencible, Pete el invencible, Voracido el invencible y antiguos Dragones de la Destruccion'),('Legendary Sniper','naranja','zero','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Ninja','naranja','zero','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Killer','naranja','zero','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('zero Slayer of Terramorphous','naranja','zero','Se obtiene de Terramorfo el invencible'),('Legendary Engineer','naranja','Axton','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Pointman','naranja','Axton','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Ranger','naranja','Axton','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Axton Slayer of Terramorphous','naranja','Axton','Se obtiene de Terramorfo el invencible'),('Legendary Berserker','naranja','Salvador','Se obtiene de Vermivoro y de Voracido el invencible'),('Legendary Titan','naranja','Salvador','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Hoarder','naranja','Salvador','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('salvador Slayer of Terramorphous','naranja','Salvador','Se obtiene de Terramorfo el invencible'),('Legendary Nurse','naranja','Maya','se obtiene de enemigos sebosos con el pack ultimate vault hunter'),('Legendary Cat','naranja','Maya','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Binder','naranja','Maya','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Roboteer','naranja','Gaige','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Catalyst','naranja','Gaige','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Anarchist','naranja','Gaige','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('gaige Slayer of Terramorphous','naranja','Gaige','Se obtiene de Terramorfo el invencible'),('Legendary Torch','naranja','Krieg','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Sickle','naranja','Krieg','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('Legendary Reaper','naranja','Krieg','Se obtiene de enemigos Tubby con el pack ultimate vault hunter'),('krieg Slayer of Terramorphous','naranja','Krieg','Se obtiene de Terramorfo el invencible'),('Survivor','morado','zero','Se obtiene de sitios aleatorios'),('Killer','morado','zero','Se obtiene de sitios aleatorios'),('Stalker','morado','zero','Se obtiene de sitios aleatorios'),('Shot','morado','zero','Se obtiene de sitios aleatorios'),('Professional','morado','zero','Se obtiene de sitios aleatorios'),('Ninja','morado','zero','Se obtiene de sitios aleatorios'),('Infiltrator','morado','zero','Se obtiene de sitios aleatorios'),('Specialist','morado','Axton','Se obtiene de sitios aleatorios'),('Shock Trooper','morado','Axton','Se obtiene de sitios aleatorios'),('Granadero','morado','Axton','Se obtiene de sitios aleatorios'),('Pointman','morado','Axton','Se obtiene de sitios aleatorios'),('Tactician','morado','Axton','Se obtiene de sitos aleatorios'),('Veteran','morado','Axton','Se obtiene de sitios aleatorios'),('Engineer','morado','Axton','Se obtiene de sitios aleatorios'),('Ranger','morado','Axton','Se obtiene de sitios aleatorios'),('Titan','morado','Salvador','Se obtiene de sitios aleatorios'),('Tank','morado','Salvador','Se obtiene de sitios aleatorios'),('Renegade','morado','Salvador','Se obtiene de sitios aleatorios'),('Raider','morado','Salvador','Se obtiene de sitios aleatorios'),('Devastator','morado','Salvador','Se obtiene de sitios aleatorios'),('War Dog','morado','Salvador','Se obtiene de sitios aleatorios'),('Berserker','morado','Salvador','Se obtiene de sitios aleatorios'),('Beast','morado','Salvador','Se obtiene de sitios aleatorios'),('Warder','morado','Maya','Se obtiene de sitios aleatorios'),('Binder','morado','Maya','Se obtiene de sitios aleatorios'),('Fox','morado','Maya','Se obtiene de sitios aleatorios'),('Trickster','morado','Maya','Se obtiene de sitios aleatorios'),('Witch','morado','Maya','Se obtiene de sitios aleatorios'),('Cat','morado','Maya','Se obtiene de sitios aleatorios'),('Matriarch','morado','Maya','Se obtiene de sitios aleatorios'),('Cleric','morado','Maya','Se obtiene de sitios aleatorios del dlc asalto a la mazmorra del dragon'),('Jill of all Trades','morado','Gaige','Se obtiene de sitios aleatorios'),('Prodigy','morado','Gaige','Se obtiene de sitios aleatorios'),('Punk','morado','Gaige','Se obtiene de sitios aleatorios'),('Roboteer','morado','Gaige','Se obtiene de sitios aleatorios'),('Catalyst','morado','Gaige','Se obtiene de sitios aleatorios'),('Anarchist','morado','Gaige','Se obtiene de sitios aleatorios'),('Sweetheart','morado','Gaige','Se obtiene de sitios aleatorios'),('Necromancer','morado','Gaige','Se obtiene de sitios aleatorios del dlc asalto a la mazmorra del dragon'),('Blister','morado','Krieg','Se obtiene de sitios aleatorios'),('Wound','morado','Krieg','Se obtiene de sitios aleatorios y sobre todo en Bloodshot Stronghold'),('Slab','morado','Krieg','Se obtiene de sitios aleatorios'),('Sickle','morado','Krieg','Se obtiene de sitios aleatorios'),('Reaper','morado','Krieg','Se obtiene de sitios aleatorios'),('Meat','morado','Krieg','Se obtiene de sitios aleatorios'),('Torch','morado','Krieg','Se obtiene de sitios aleatorios'),('Barbarian','morado','Krieg','Se obtiene de sitios aleatorios del dlc asalto a la mazmorra del dragon');
/*!40000 ALTER TABLE `modificadores` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-02 11:20:45