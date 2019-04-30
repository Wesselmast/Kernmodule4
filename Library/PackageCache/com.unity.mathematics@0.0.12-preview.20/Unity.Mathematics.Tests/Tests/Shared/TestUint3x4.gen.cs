// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint3x4
    {
        [TestCompiler]
        public static void uint3x4_zero()
        {
            TestUtils.AreEqual(uint3x4.zero.c0.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c0.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c0.z, 0u);
            TestUtils.AreEqual(uint3x4.zero.c1.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c1.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c1.z, 0u);
            TestUtils.AreEqual(uint3x4.zero.c2.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c2.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c2.z, 0u);
            TestUtils.AreEqual(uint3x4.zero.c3.x, 0u);
            TestUtils.AreEqual(uint3x4.zero.c3.y, 0u);
            TestUtils.AreEqual(uint3x4.zero.c3.z, 0u);
        }

        [TestCompiler]
        public static void uint3x4_operator_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(790229414, 970783976, 1428432738, 1578747135, 1733797753, 2001507228, 1446876437, 1777406370, 1426387268, 1809275021, 1843770816, 1172185222);
            uint3x4 b0 = uint3x4(612337669, 1214209108, 2120643427, 295461214, 1510890331, 1893316566, 921816149, 1834958575, 1482011863, 2062852792, 226398742, 770290735);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x4 a1 = uint3x4(1469608940, 869874758, 458603090, 581282460, 1948324909, 1129078206, 1638391029, 1135553683, 2079295200, 576232476, 608208235, 11172509);
            uint3x4 b1 = uint3x4(36812057, 543224481, 1565350150, 1909926604, 1619900436, 1849990483, 1261604411, 161864811, 843379453, 1780425458, 215681636, 2123130580);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x4 a2 = uint3x4(1025529486, 2095601864, 193500113, 1780908384, 1587636094, 1892083815, 1250768669, 1984341771, 929607871, 2092475304, 1940221590, 196567546);
            uint3x4 b2 = uint3x4(708665810, 1902328998, 1808456602, 563830672, 200493241, 1391620681, 1035522654, 168447603, 91580624, 1974459648, 2074899534, 164782857);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x4 a3 = uint3x4(346458180, 2131041239, 1797649913, 162082500, 25639548, 1665178642, 1617231933, 1716426491, 1986475699, 262354389, 1517004243, 1058579789);
            uint3x4 b3 = uint3x4(1647410210, 1000391363, 1539243411, 1253927304, 894227825, 1897420927, 826437109, 139868307, 565247534, 1437897788, 1891416649, 1043772546);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1211464300, 1921862607, 508076684, 1249127920, 1394594555, 746862310, 1733655277, 1884008277, 1682018538, 795585660, 936027116, 927605411);
            uint b0 = (746972502);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x4 a1 = uint3x4(672785749, 585324157, 404448210, 969511077, 442746747, 1772925698, 1884034177, 451512860, 425476075, 1370577708, 597010220, 1249636005);
            uint b1 = (1465584610);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x4 a2 = uint3x4(211986678, 255635293, 1150443719, 177122433, 511346787, 1442445694, 667984966, 1684122010, 1962874832, 172230876, 496695881, 955604291);
            uint b2 = (1305479811);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x4 a3 = uint3x4(872759249, 1604334190, 443527663, 1734064824, 1483978726, 1018945528, 476526026, 564821616, 1368099334, 2134154866, 2136028886, 20195989);
            uint b3 = (811880239);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_equal_scalar_wide()
        {
            uint a0 = (1150044438);
            uint3x4 b0 = uint3x4(233855098, 924242519, 1402948791, 601381975, 2120518068, 629187703, 1971977031, 47183124, 1061805787, 1009011238, 312511148, 1460673064);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (737210539);
            uint3x4 b1 = uint3x4(1737844479, 1892405453, 2133024000, 455818693, 2003197687, 1276241219, 534746610, 559824292, 1758388240, 1023494292, 719963017, 1883763832);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (597498209);
            uint3x4 b2 = uint3x4(367814403, 1839429063, 223575614, 79701214, 1699606118, 759455864, 2017599457, 1395605233, 1191785903, 1156248212, 338891967, 61410415);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (1576985758);
            uint3x4 b3 = uint3x4(1066598856, 1070606918, 1295956934, 1391539053, 1206456305, 466211205, 1362213007, 554347592, 361925309, 1122476040, 1118155036, 2074160001);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_not_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(1660932106, 982847023, 97046264, 1739517447, 1253499180, 1830584069, 1841470429, 1397841646, 1770890135, 1906548631, 169082967, 2099271786);
            uint3x4 b0 = uint3x4(107139049, 75478496, 2055495054, 358586687, 942338347, 111564990, 113811950, 948912488, 1080084121, 1400504872, 1032134499, 1061123400);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x4 a1 = uint3x4(1909317609, 46519139, 1433204003, 931492669, 670504132, 1551558665, 1204055048, 1623586740, 226381077, 1145987803, 644253929, 475189890);
            uint3x4 b1 = uint3x4(221862069, 858950046, 989094643, 2023070999, 1269317127, 531883744, 687761409, 278427731, 296354221, 536981557, 1134676193, 1749879634);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x4 a2 = uint3x4(922313145, 2006448607, 1574579050, 1839580033, 155350910, 313644534, 2008975915, 1072866331, 10845678, 1588544505, 709736932, 1892341087);
            uint3x4 b2 = uint3x4(1944210269, 92849031, 164029425, 628797607, 2069207270, 2022667842, 880567401, 264404537, 1954996717, 572153302, 865957902, 1083128726);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x4 a3 = uint3x4(1603981028, 1174123795, 2033630343, 416869471, 1894155826, 2084120548, 1130129683, 448491949, 1577220741, 376532834, 374116875, 416935463);
            uint3x4 b3 = uint3x4(1628120900, 2020212393, 1562290229, 774641416, 444123152, 1636477381, 838643638, 506474707, 922761058, 1282331425, 1748402545, 1493297323);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_not_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(747758183, 1033001286, 1439973882, 2138928797, 1197845089, 1432672459, 950170763, 238704450, 2105962247, 727205263, 1640688041, 276313906);
            uint b0 = (248693828);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x4 a1 = uint3x4(2126300423, 2035077187, 1171827730, 1412347883, 1622176923, 768370497, 1072798259, 1808712713, 1497830076, 1582645163, 1876273820, 90244766);
            uint b1 = (791998981);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x4 a2 = uint3x4(30493685, 384643370, 11554610, 2016093187, 1515760622, 1596313927, 363921847, 1555396158, 913218907, 1739138988, 1916670251, 1516209113);
            uint b2 = (904014575);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x4 a3 = uint3x4(765258490, 1509386069, 1670155205, 6112585, 1942607934, 964072392, 779222124, 409389668, 321500037, 1728722181, 1641292942, 780105497);
            uint b3 = (668154629);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_not_equal_scalar_wide()
        {
            uint a0 = (2076921066);
            uint3x4 b0 = uint3x4(2037494727, 1989050616, 48833929, 1897435904, 514354517, 1783749164, 364694471, 754315072, 124108032, 1512967900, 1178825850, 1854793298);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (50286949);
            uint3x4 b1 = uint3x4(2100802631, 1640811853, 82110247, 472172806, 266984506, 2003668365, 1826089250, 1041416160, 356140110, 2057237962, 799920703, 1916347720);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (510966350);
            uint3x4 b2 = uint3x4(572038024, 1936481966, 1366859342, 1775285431, 604757336, 1047551607, 1311703338, 676012224, 627370253, 1715733805, 699755913, 1875151666);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (358894860);
            uint3x4 b3 = uint3x4(1036873378, 214171973, 340364269, 1652250278, 592713982, 806342921, 1264065574, 188560943, 1068608955, 485382245, 57935167, 1002934795);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_less_wide_wide()
        {
            uint3x4 a0 = uint3x4(1182186063, 415538999, 1667335818, 1566618442, 1166180837, 639095188, 1080836365, 771119973, 928263233, 789225474, 665243110, 1003542034);
            uint3x4 b0 = uint3x4(524633529, 1032195686, 760723389, 1505751409, 431962172, 1287906509, 1560084663, 1450178202, 2066166337, 1107069023, 1640077524, 2103263105);
            bool3x4 r0 = bool3x4(false, true, false, false, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x4 a1 = uint3x4(1032480172, 1961336172, 923379558, 21210619, 1089772116, 1707633052, 778986024, 158153146, 336715101, 1839141169, 1706859710, 1928438162);
            uint3x4 b1 = uint3x4(684229139, 1234033624, 1278743281, 1953079347, 1228832942, 2082539723, 1088437561, 1058382082, 207459172, 750531081, 2015788562, 2126542133);
            bool3x4 r1 = bool3x4(false, false, true, true, true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x4 a2 = uint3x4(1638101724, 2044698552, 1543260981, 471462349, 1668575142, 2147199161, 946870864, 582371851, 410751553, 198134393, 1999935258, 671192178);
            uint3x4 b2 = uint3x4(271967348, 1601249324, 1373999400, 1689592186, 459759541, 983106679, 332584818, 2034921203, 833499488, 1999487070, 836063897, 1987309319);
            bool3x4 r2 = bool3x4(false, false, false, true, false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x4 a3 = uint3x4(1908013191, 770353922, 1948420002, 396403395, 903274624, 1743415547, 1381528376, 409818366, 757370593, 413964581, 1088722047, 111511218);
            uint3x4 b3 = uint3x4(1878327039, 457783938, 253010953, 1164175257, 1982277686, 651412210, 567444942, 1863256363, 18040866, 319226483, 1322530114, 4130283);
            bool3x4 r3 = bool3x4(false, false, false, true, true, false, false, true, false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_less_wide_scalar()
        {
            uint3x4 a0 = uint3x4(608447185, 818840405, 869219329, 2080125385, 1214500548, 1361741203, 1667165786, 1615392341, 840091491, 469591900, 1247103789, 315321650);
            uint b0 = (1491216667);
            bool3x4 r0 = bool3x4(true, true, true, false, true, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x4 a1 = uint3x4(930950514, 933855388, 908563901, 1127696709, 1286331950, 380753337, 971148054, 1827886929, 1056649851, 1579735991, 689044913, 1960894027);
            uint b1 = (1100560246);
            bool3x4 r1 = bool3x4(true, true, true, false, false, true, true, false, true, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x4 a2 = uint3x4(371987110, 1703747625, 1698536333, 41716206, 243673862, 1274625476, 611065092, 118750042, 1829327996, 452204442, 1645191336, 1829152606);
            uint b2 = (867559111);
            bool3x4 r2 = bool3x4(true, false, false, true, true, false, true, true, false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x4 a3 = uint3x4(1891059504, 233590785, 894500093, 92899312, 965973603, 1496873003, 973411415, 694702440, 215973795, 1555455579, 1443255493, 212954934);
            uint b3 = (1217893177);
            bool3x4 r3 = bool3x4(false, true, true, true, true, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_less_scalar_wide()
        {
            uint a0 = (548436837);
            uint3x4 b0 = uint3x4(282703327, 14370648, 1862117300, 1304793311, 826073259, 988910157, 445132446, 1139670255, 111349251, 1102440676, 112183144, 1594415311);
            bool3x4 r0 = bool3x4(false, false, true, true, true, true, false, true, false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1890019295);
            uint3x4 b1 = uint3x4(2098715503, 608933527, 183989010, 1596056507, 1027318999, 146281093, 358911716, 874278078, 1106057699, 1256807459, 2111973919, 1736480659);
            bool3x4 r1 = bool3x4(true, false, false, false, false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (810406400);
            uint3x4 b2 = uint3x4(1329939911, 1276652605, 593690439, 771851138, 590897155, 386688344, 1290583204, 1984930954, 743544838, 1473400608, 1300775973, 1351720916);
            bool3x4 r2 = bool3x4(true, true, false, false, false, false, true, true, false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (168788814);
            uint3x4 b3 = uint3x4(670661854, 168118205, 894264935, 1763013903, 1647476162, 699045651, 1813273687, 900504872, 1574770031, 1684716245, 1458270033, 685700324);
            bool3x4 r3 = bool3x4(true, false, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_greater_wide_wide()
        {
            uint3x4 a0 = uint3x4(592884447, 2133928932, 918957182, 1284069471, 194584707, 739120780, 241654068, 1340158550, 2099542537, 1182623667, 1399607274, 789301637);
            uint3x4 b0 = uint3x4(138737040, 192863971, 1700841444, 1044631301, 1391589821, 730837695, 253553987, 2078872742, 910845808, 976047676, 202633078, 1223618940);
            bool3x4 r0 = bool3x4(true, true, false, true, false, true, false, false, true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x4 a1 = uint3x4(180400925, 594688333, 1877031463, 1360073500, 1091782422, 546676424, 348221770, 716039145, 458742739, 1365508046, 1523167942, 1574478622);
            uint3x4 b1 = uint3x4(641600530, 1830470354, 1570701388, 1104256103, 1838646932, 740166101, 1549021845, 1457092873, 1790630950, 907793213, 555122804, 1418910265);
            bool3x4 r1 = bool3x4(false, false, true, true, false, false, false, false, false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x4 a2 = uint3x4(1295065160, 715285504, 1130323487, 677530432, 1496919050, 12463046, 1106153111, 1315083485, 31516321, 1786538920, 1854361210, 1730650972);
            uint3x4 b2 = uint3x4(335209251, 1094341422, 1465325455, 390251369, 910309992, 277356652, 1601082764, 771366966, 1782348324, 550490783, 599992449, 550520692);
            bool3x4 r2 = bool3x4(true, false, false, true, true, false, false, true, false, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x4 a3 = uint3x4(194806663, 517304937, 984608679, 1847934645, 1214605555, 535405194, 855415884, 2121416263, 1161116500, 1390730698, 1536558799, 350939762);
            uint3x4 b3 = uint3x4(1873014441, 1756459971, 2028992071, 1772761768, 1323261715, 1541822212, 265732078, 1773940614, 156425055, 1585395425, 438682493, 1005143622);
            bool3x4 r3 = bool3x4(false, false, false, true, false, false, true, true, true, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_greater_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1097138316, 211763648, 1883002501, 56406996, 43662641, 1923456111, 1437755186, 1219010035, 2125058448, 304028799, 893125636, 48044515);
            uint b0 = (438688675);
            bool3x4 r0 = bool3x4(true, false, true, false, false, true, true, true, true, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x4 a1 = uint3x4(711945018, 577943770, 572743717, 1016617211, 2063134811, 1577403353, 64009107, 1462961460, 1143565920, 3715845, 689362811, 263973424);
            uint b1 = (1035679270);
            bool3x4 r1 = bool3x4(false, false, false, false, true, true, false, true, true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x4 a2 = uint3x4(1045140419, 524569092, 1183316983, 1107974092, 212839726, 523727054, 112709358, 614746280, 1000986708, 1683117650, 1451781409, 61102732);
            uint b2 = (1058332184);
            bool3x4 r2 = bool3x4(false, false, true, true, false, false, false, false, false, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x4 a3 = uint3x4(1284938191, 2125085618, 467075658, 1019531089, 2028286621, 940955706, 1037153304, 1184928188, 1260010015, 1456174269, 174216269, 1930086291);
            uint b3 = (1452639553);
            bool3x4 r3 = bool3x4(false, true, false, false, true, false, false, false, false, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_greater_scalar_wide()
        {
            uint a0 = (2024896938);
            uint3x4 b0 = uint3x4(599356784, 185671342, 1932327391, 2025591013, 1257191721, 1312388500, 1443698859, 779217735, 691047512, 741776730, 732565983, 668302204);
            bool3x4 r0 = bool3x4(true, true, true, false, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1556466996);
            uint3x4 b1 = uint3x4(858599525, 1896917159, 701542098, 1052151621, 1023307544, 1435392907, 1858177345, 299897686, 632930355, 1387203601, 483722222, 863042711);
            bool3x4 r1 = bool3x4(true, false, true, true, true, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (1713088900);
            uint3x4 b2 = uint3x4(315569296, 292652611, 1002628348, 927789921, 108145064, 425005337, 2093233588, 2063431853, 2079035844, 849337819, 1769234051, 358948261);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, false, false, false, true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (267985383);
            uint3x4 b3 = uint3x4(126402553, 2055164423, 577620406, 1167389614, 474380256, 1163355187, 1782967398, 1648397169, 845981950, 630459977, 1033887217, 1480829811);
            bool3x4 r3 = bool3x4(true, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_less_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(1577248162, 2043073061, 1688380407, 176431985, 223299035, 1502802140, 1691709825, 386789394, 117182003, 1665770435, 1958490731, 420032601);
            uint3x4 b0 = uint3x4(903445031, 2108974565, 210822256, 1281704747, 453681718, 66138830, 1229799377, 1620922595, 1715833766, 1366430432, 13102000, 46919981);
            bool3x4 r0 = bool3x4(false, true, false, true, true, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x4 a1 = uint3x4(1251092689, 2011681765, 749743684, 183784440, 1150674774, 1633828822, 1719442172, 336047314, 743733218, 1393995865, 1854442658, 1498138884);
            uint3x4 b1 = uint3x4(486470891, 1709514236, 2145785285, 854254454, 1273278658, 810263315, 1862773824, 201799013, 974166844, 1320622967, 2058099616, 522102017);
            bool3x4 r1 = bool3x4(false, false, true, true, true, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x4 a2 = uint3x4(912169992, 1992682021, 1619593455, 1883313982, 483412430, 857881876, 346624138, 531961063, 269897278, 1062947703, 1743454202, 2048964070);
            uint3x4 b2 = uint3x4(620752145, 1213693681, 1281818305, 1564146162, 1996153080, 1201909516, 614401396, 224997397, 648547686, 418431167, 1724009726, 401891826);
            bool3x4 r2 = bool3x4(false, false, false, false, true, true, true, false, true, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x4 a3 = uint3x4(1379786452, 622697214, 766589782, 339960970, 1135815654, 797344244, 153103264, 1382144646, 1537448323, 326850885, 1004891948, 2002658522);
            uint3x4 b3 = uint3x4(1463971422, 984323887, 1246893281, 1340476720, 1489579748, 128991539, 1117574406, 2016340116, 69682660, 1870772739, 1281621445, 129331822);
            bool3x4 r3 = bool3x4(true, true, true, true, true, false, true, true, false, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_less_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1722165358, 1219858357, 860410743, 411099660, 348104022, 1963256951, 212084836, 58924407, 1459242706, 1745758438, 532949158, 262559763);
            uint b0 = (1688048545);
            bool3x4 r0 = bool3x4(false, true, true, true, true, false, true, true, true, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x4 a1 = uint3x4(690091301, 2091514001, 1857173043, 1617221948, 2017733017, 804204255, 981729559, 2032949254, 910922522, 2079225209, 26179915, 238796519);
            uint b1 = (1806172431);
            bool3x4 r1 = bool3x4(true, false, false, true, false, true, true, false, true, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x4 a2 = uint3x4(1917813750, 20607406, 1337879822, 959460446, 1599429457, 1279143037, 1551937606, 626254356, 1162369122, 1021674613, 127839058, 1974631244);
            uint b2 = (1258115260);
            bool3x4 r2 = bool3x4(false, true, false, true, false, false, false, true, true, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x4 a3 = uint3x4(426908235, 487782623, 1454736163, 465255784, 686095683, 2012624010, 1427922646, 1129062501, 1896996725, 1609784025, 1413823266, 1483727269);
            uint b3 = (1818566980);
            bool3x4 r3 = bool3x4(true, true, true, true, true, false, true, true, false, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_less_equal_scalar_wide()
        {
            uint a0 = (1777585);
            uint3x4 b0 = uint3x4(1181030049, 1787703989, 1729760948, 1816537388, 1359786460, 874999193, 1678863148, 1711365839, 762067160, 11953554, 1131583906, 1175393186);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1293698493);
            uint3x4 b1 = uint3x4(48893340, 66196247, 1958607116, 1576473309, 861890786, 478252419, 957887737, 117849810, 1348693584, 105489302, 259034238, 530713566);
            bool3x4 r1 = bool3x4(false, false, true, true, false, false, false, false, true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (601413850);
            uint3x4 b2 = uint3x4(830430286, 145552297, 1697295044, 1150680564, 2091065664, 1796096704, 1572008712, 1556906486, 205552788, 620963188, 1156705971, 1121867260);
            bool3x4 r2 = bool3x4(true, false, true, true, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (733876180);
            uint3x4 b3 = uint3x4(1570208446, 541165966, 644414754, 734807383, 938714737, 591783460, 56988751, 790541516, 1811299247, 1308256680, 549490410, 1987696011);
            bool3x4 r3 = bool3x4(true, false, false, true, true, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_greater_equal_wide_wide()
        {
            uint3x4 a0 = uint3x4(263000030, 744235661, 1893760267, 237248, 1062370984, 1676977687, 816766880, 1089431546, 1394493730, 1176473380, 1193988637, 1703862455);
            uint3x4 b0 = uint3x4(1395535146, 1178373944, 1237373760, 1364855321, 600811864, 362060472, 290870624, 1839067862, 396958580, 1336888643, 1019684398, 1697684196);
            bool3x4 r0 = bool3x4(false, false, true, false, true, true, true, false, true, false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x4 a1 = uint3x4(1806186947, 1253571980, 589397635, 1951842887, 798931197, 808426484, 744869638, 1959531616, 207430702, 1533946595, 1148381840, 2011549474);
            uint3x4 b1 = uint3x4(1227300220, 2044269675, 1898323839, 874509380, 1873505472, 1268843918, 1606949562, 1263896445, 1805518202, 1412091359, 1240330374, 1955056253);
            bool3x4 r1 = bool3x4(true, false, false, true, false, false, false, true, false, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x4 a2 = uint3x4(605043041, 1707339660, 2038122892, 345761584, 1839156338, 1519670644, 2131285427, 775457686, 796452624, 1710612922, 1629927787, 1094198224);
            uint3x4 b2 = uint3x4(2025187918, 750755999, 869709740, 1390799279, 1194035112, 666460047, 103451220, 1311530792, 802468307, 1090745055, 1968071275, 1935027815);
            bool3x4 r2 = bool3x4(false, true, true, false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x4 a3 = uint3x4(584910611, 1129457941, 1633221450, 549302356, 1363234393, 1439226634, 190984179, 983870135, 1527743888, 1577171227, 87278918, 1280094665);
            uint3x4 b3 = uint3x4(2060060582, 1535954082, 291771096, 565856573, 1445999374, 711693364, 1201086888, 2076705104, 1565110852, 1698318173, 1293071569, 103979482);
            bool3x4 r3 = bool3x4(false, false, true, false, false, true, false, false, false, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_greater_equal_wide_scalar()
        {
            uint3x4 a0 = uint3x4(2112791350, 1043657935, 101764761, 1529909067, 556026890, 281734132, 1186600258, 815093894, 609211196, 1604309397, 829548642, 244604867);
            uint b0 = (1470533736);
            bool3x4 r0 = bool3x4(true, false, false, true, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x4 a1 = uint3x4(1419295004, 1819986195, 1460027917, 1646290021, 196833647, 1596738181, 1905036391, 1771391775, 1584946560, 370941146, 440219668, 1607345862);
            uint b1 = (471843809);
            bool3x4 r1 = bool3x4(true, true, true, true, false, true, true, true, true, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x4 a2 = uint3x4(1449142607, 379014762, 1719435169, 258833609, 1389585003, 612593660, 42612027, 1138747386, 1491562090, 917503963, 353608194, 1526792895);
            uint b2 = (1223010129);
            bool3x4 r2 = bool3x4(true, false, true, false, true, false, false, false, true, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x4 a3 = uint3x4(192092521, 367754234, 1738737389, 523396822, 594728703, 1332667659, 1627604854, 1542713928, 1997611484, 191413337, 1230701700, 702382564);
            uint b3 = (909358617);
            bool3x4 r3 = bool3x4(false, false, true, false, false, true, true, true, true, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1525542481);
            uint3x4 b0 = uint3x4(1503244746, 861711266, 817773856, 925984572, 571221723, 683686810, 118252990, 1653952090, 1240253990, 1947039008, 1869136019, 152012637);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, false, true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (1214546726);
            uint3x4 b1 = uint3x4(917376832, 303549425, 2111728811, 945321577, 173706579, 625318949, 519443238, 1583588379, 1026799433, 1713083717, 394922760, 1216218189);
            bool3x4 r1 = bool3x4(true, true, false, true, true, true, true, false, true, false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (1336522452);
            uint3x4 b2 = uint3x4(233894308, 479913036, 984991199, 172993285, 2121050903, 465645173, 788510727, 337378780, 273010835, 1898553615, 1111540136, 717385513);
            bool3x4 r2 = bool3x4(true, true, true, true, false, true, true, true, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (474197678);
            uint3x4 b3 = uint3x4(1417152771, 1476091619, 1312849725, 243299324, 1470872301, 1443256118, 1203165035, 2138148138, 1543595760, 186659728, 807288168, 1274079907);
            bool3x4 r3 = bool3x4(false, false, false, true, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_add_wide_wide()
        {
            uint3x4 a0 = uint3x4(2049228671, 1658660009, 491719392, 937013355, 81108663, 1063894558, 86954702, 843159721, 698977704, 192867135, 1683407172, 137301303);
            uint3x4 b0 = uint3x4(2088751567, 645762023, 306868786, 4360271, 506047997, 2094559874, 1634712736, 1601474440, 1586485231, 908746788, 1812370320, 1247342357);
            uint3x4 r0 = uint3x4(4137980238, 2304422032, 798588178, 941373626, 587156660, 3158454432, 1721667438, 2444634161, 2285462935, 1101613923, 3495777492, 1384643660);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x4 a1 = uint3x4(2103582820, 526139155, 447937230, 2127411006, 1670579390, 1914969141, 997691756, 857841794, 2129024875, 267535529, 978891383, 657092366);
            uint3x4 b1 = uint3x4(2043773873, 223363428, 175115707, 985928617, 507662836, 1231457019, 776127866, 607782424, 1160366210, 1384832242, 702057048, 703554905);
            uint3x4 r1 = uint3x4(4147356693, 749502583, 623052937, 3113339623, 2178242226, 3146426160, 1773819622, 1465624218, 3289391085, 1652367771, 1680948431, 1360647271);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x4 a2 = uint3x4(941872903, 906908654, 1940071697, 862186205, 1951450264, 689662850, 1928213278, 1703906688, 526120638, 423980484, 1867227242, 603782684);
            uint3x4 b2 = uint3x4(2106992817, 1994483489, 539473, 236858351, 411317652, 595429166, 713649927, 2053476603, 77965941, 1726775513, 1759186349, 2070333485);
            uint3x4 r2 = uint3x4(3048865720, 2901392143, 1940611170, 1099044556, 2362767916, 1285092016, 2641863205, 3757383291, 604086579, 2150755997, 3626413591, 2674116169);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x4 a3 = uint3x4(728643437, 927205560, 1544834791, 268450974, 1386681507, 1428974172, 1415690700, 1193340567, 1792960278, 1427490402, 86465016, 827052793);
            uint3x4 b3 = uint3x4(1732568358, 523040962, 899952708, 1401525772, 1970067897, 488428060, 132927517, 1670039917, 1678110790, 586374104, 262412628, 1415374948);
            uint3x4 r3 = uint3x4(2461211795, 1450246522, 2444787499, 1669976746, 3356749404, 1917402232, 1548618217, 2863380484, 3471071068, 2013864506, 348877644, 2242427741);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_add_wide_scalar()
        {
            uint3x4 a0 = uint3x4(2038218457, 134923711, 875689667, 1338884463, 997710928, 340490871, 1067888129, 70433301, 2003021861, 1635971971, 1160398286, 85446202);
            uint b0 = (2124409227);
            uint3x4 r0 = uint3x4(4162627684, 2259332938, 3000098894, 3463293690, 3122120155, 2464900098, 3192297356, 2194842528, 4127431088, 3760381198, 3284807513, 2209855429);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x4 a1 = uint3x4(1068152966, 1497676888, 1727477485, 1095438654, 756559204, 1818718931, 658923552, 1610518921, 1585755398, 692843300, 1068593469, 1704776233);
            uint b1 = (1239387100);
            uint3x4 r1 = uint3x4(2307540066, 2737063988, 2966864585, 2334825754, 1995946304, 3058106031, 1898310652, 2849906021, 2825142498, 1932230400, 2307980569, 2944163333);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x4 a2 = uint3x4(577782260, 711894571, 564257439, 2051736283, 1572837697, 1628006545, 1855700263, 656748782, 272774516, 1917133199, 828322973, 2116810190);
            uint b2 = (736972565);
            uint3x4 r2 = uint3x4(1314754825, 1448867136, 1301230004, 2788708848, 2309810262, 2364979110, 2592672828, 1393721347, 1009747081, 2654105764, 1565295538, 2853782755);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x4 a3 = uint3x4(2092767444, 1236931273, 504264449, 794292574, 1518058681, 1604636324, 354873417, 685247897, 227781140, 321182517, 1210575914, 1340503111);
            uint b3 = (973587865);
            uint3x4 r3 = uint3x4(3066355309, 2210519138, 1477852314, 1767880439, 2491646546, 2578224189, 1328461282, 1658835762, 1201369005, 1294770382, 2184163779, 2314090976);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_add_scalar_wide()
        {
            uint a0 = (391092078);
            uint3x4 b0 = uint3x4(519908870, 851424292, 328314822, 135622204, 740923360, 655394201, 1451896269, 1781697072, 996031825, 1557774949, 779774940, 1111541302);
            uint3x4 r0 = uint3x4(911000948, 1242516370, 719406900, 526714282, 1132015438, 1046486279, 1842988347, 2172789150, 1387123903, 1948867027, 1170867018, 1502633380);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (783046445);
            uint3x4 b1 = uint3x4(1130163944, 288279584, 1397683861, 1636583489, 673263339, 1469300874, 14855965, 1116636999, 1488863300, 1600990886, 190651301, 1307459768);
            uint3x4 r1 = uint3x4(1913210389, 1071326029, 2180730306, 2419629934, 1456309784, 2252347319, 797902410, 1899683444, 2271909745, 2384037331, 973697746, 2090506213);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (920085839);
            uint3x4 b2 = uint3x4(2082229835, 1992405574, 1213924458, 505841452, 981421162, 1488337699, 1113826640, 1806146508, 1841791222, 206610851, 526971953, 1236359886);
            uint3x4 r2 = uint3x4(3002315674, 2912491413, 2134010297, 1425927291, 1901507001, 2408423538, 2033912479, 2726232347, 2761877061, 1126696690, 1447057792, 2156445725);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (1459523189);
            uint3x4 b3 = uint3x4(965740631, 82842799, 1298403201, 1805809772, 1978864191, 415003386, 1906304148, 722870197, 744248796, 1677223559, 303376031, 1275565021);
            uint3x4 r3 = uint3x4(2425263820, 1542365988, 2757926390, 3265332961, 3438387380, 1874526575, 3365827337, 2182393386, 2203771985, 3136746748, 1762899220, 2735088210);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_sub_wide_wide()
        {
            uint3x4 a0 = uint3x4(1353441118, 797269833, 659988112, 56022121, 365847472, 2062899435, 1380988474, 799885138, 1306058185, 579775276, 1239163824, 344591081);
            uint3x4 b0 = uint3x4(1332656812, 1827794007, 972557431, 2078233689, 1508184327, 1372307701, 810327977, 936799885, 71562303, 1418723328, 1971342989, 1226053395);
            uint3x4 r0 = uint3x4(20784306, 3264443122, 3982397977, 2272755728, 3152630441, 690591734, 570660497, 4158052549, 1234495882, 3456019244, 3562788131, 3413504982);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x4 a1 = uint3x4(86359575, 1049709943, 721529513, 1767221271, 7652784, 545192611, 176298787, 1477774126, 1426963688, 2032787858, 2059525977, 445200454);
            uint3x4 b1 = uint3x4(136565478, 1979903295, 600719425, 837912956, 632054793, 711091688, 904695656, 1640069560, 750244414, 1385118097, 1102391291, 1221949855);
            uint3x4 r1 = uint3x4(4244761393, 3364773944, 120810088, 929308315, 3670565287, 4129068219, 3566570427, 4132671862, 676719274, 647669761, 957134686, 3518217895);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x4 a2 = uint3x4(425848588, 2026967474, 1128492011, 61421784, 988065731, 1741434432, 2070331135, 1356704176, 1888446703, 1364654917, 265135366, 760501098);
            uint3x4 b2 = uint3x4(609588723, 1054324682, 1678086165, 1529581776, 1718700085, 523422634, 223602473, 1912611694, 1224986479, 748933681, 88793450, 401362529);
            uint3x4 r2 = uint3x4(4111227161, 972642792, 3745373142, 2826807304, 3564332942, 1218011798, 1846728662, 3739059778, 663460224, 615721236, 176341916, 359138569);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x4 a3 = uint3x4(741271824, 2139243287, 2086038778, 1314011065, 1838848671, 1554054707, 721235598, 1856904592, 570633009, 1870509604, 1310744871, 1717222072);
            uint3x4 b3 = uint3x4(1087189363, 488919410, 1106956631, 1131451931, 1975243735, 111940790, 712896589, 477050266, 1163094482, 605082349, 954351492, 1203361215);
            uint3x4 r3 = uint3x4(3949049757, 1650323877, 979082147, 182559134, 4158572232, 1442113917, 8339009, 1379854326, 3702505823, 1265427255, 356393379, 513860857);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_sub_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1176369558, 1934521195, 309452150, 1417634074, 108910717, 1306356714, 1502312334, 1451794815, 281174200, 87530840, 1913724431, 2041593336);
            uint b0 = (462232403);
            uint3x4 r0 = uint3x4(714137155, 1472288792, 4142187043, 955401671, 3941645610, 844124311, 1040079931, 989562412, 4113909093, 3920265733, 1451492028, 1579360933);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x4 a1 = uint3x4(557239990, 1590376732, 819090189, 816382635, 815920639, 1829033117, 1792801932, 1113440549, 1418937976, 1277257189, 2092779398, 642236742);
            uint b1 = (1119051448);
            uint3x4 r1 = uint3x4(3733155838, 471325284, 3995006037, 3992298483, 3991836487, 709981669, 673750484, 4289356397, 299886528, 158205741, 973727950, 3818152590);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x4 a2 = uint3x4(1605250794, 1468003019, 128303186, 553494257, 1017126971, 1999744782, 2017272758, 1817991764, 1280985500, 676974855, 1638032613, 949761204);
            uint b2 = (819644478);
            uint3x4 r2 = uint3x4(785606316, 648358541, 3603626004, 4028817075, 197482493, 1180100304, 1197628280, 998347286, 461341022, 4152297673, 818388135, 130116726);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x4 a3 = uint3x4(1835969317, 976947310, 1304246606, 1456780208, 1554022712, 769804365, 2057831687, 758136579, 670433255, 603231411, 1673268965, 941598524);
            uint b3 = (919015590);
            uint3x4 r3 = uint3x4(916953727, 57931720, 385231016, 537764618, 635007122, 4145756071, 1138816097, 4134088285, 4046384961, 3979183117, 754253375, 22582934);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_sub_scalar_wide()
        {
            uint a0 = (1691534405);
            uint3x4 b0 = uint3x4(2022393810, 1612688515, 496689713, 887037586, 2097630964, 374934538, 939035482, 935242277, 1789300421, 264712893, 1231856067, 1818112748);
            uint3x4 r0 = uint3x4(3964107891, 78845890, 1194844692, 804496819, 3888870737, 1316599867, 752498923, 756292128, 4197201280, 1426821512, 459678338, 4168388953);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (1428436109);
            uint3x4 b1 = uint3x4(1258745460, 1077380396, 1330722719, 518111829, 967128529, 344666254, 1082267918, 907866696, 1816885123, 460340568, 962154498, 557113461);
            uint3x4 r1 = uint3x4(169690649, 351055713, 97713390, 910324280, 461307580, 1083769855, 346168191, 520569413, 3906518282, 968095541, 466281611, 871322648);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (1701216709);
            uint3x4 b2 = uint3x4(1980098777, 730060552, 1444397827, 853570556, 138836432, 1013190428, 718089530, 506757390, 1216448041, 936312747, 1997286455, 1969982026);
            uint3x4 r2 = uint3x4(4016085228, 971156157, 256818882, 847646153, 1562380277, 688026281, 983127179, 1194459319, 484768668, 764903962, 3998897550, 4026201979);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (902880656);
            uint3x4 b3 = uint3x4(1161220697, 1442464725, 622960765, 730968909, 614823841, 1889779020, 918322352, 133929920, 213123108, 1835450460, 521068072, 2066839749);
            uint3x4 r3 = uint3x4(4036627255, 3755383227, 279919891, 171911747, 288056815, 3308068932, 4279525600, 768950736, 689757548, 3362397492, 381812584, 3131008203);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_mul_wide_wide()
        {
            uint3x4 a0 = uint3x4(245827027, 208934650, 1019478917, 568231809, 877289039, 1585782440, 2111178729, 1186019069, 571481445, 1570087048, 629447153, 619383734);
            uint3x4 b0 = uint3x4(759663997, 350129201, 477450108, 1635735015, 388710278, 757722665, 1509388321, 1841703980, 1826369331, 1524322467, 1605207974, 428419155);
            uint3x4 r0 = uint3x4(3662155527, 1402281434, 332447596, 2361989735, 2624048730, 1455036648, 2128344329, 3700879228, 2640799263, 2093463192, 3087460678, 3161406466);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x4 a1 = uint3x4(2055121568, 700402816, 263414349, 187830569, 2048056680, 546694675, 853585367, 933370718, 990212476, 1915885905, 1984212358, 368146234);
            uint3x4 b1 = uint3x4(1460605791, 1968043860, 771161742, 2037340417, 322304267, 651448359, 1608326767, 1427155898, 1092185338, 665119139, 223634707, 694718952);
            uint3x4 r1 = uint3x4(990589280, 3356793344, 2953243830, 1156600361, 649177976, 678952165, 1063621177, 2683284556, 2152538904, 3721713555, 2642853618, 1626072720);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x4 a2 = uint3x4(899438811, 1765718681, 409003054, 2069758852, 140280263, 442491280, 1924530939, 1372320666, 200879709, 857149632, 962693646, 988118613);
            uint3x4 b2 = uint3x4(675813713, 999254223, 1326064110, 788102700, 1927999142, 1706356773, 747671596, 106127297, 1695925670, 1788874462, 534570710, 1110638325);
            uint3x4 r2 = uint3x4(1891467339, 335415735, 1128927428, 2638713520, 2861115658, 479369680, 3928339236, 4044803354, 48406862, 2297104000, 4019846068, 2811510105);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x4 a3 = uint3x4(892998613, 534109991, 1836805716, 591690444, 1092459557, 1068605049, 1152926708, 1628337363, 400029062, 511168096, 1165835487, 1650108606);
            uint3x4 b3 = uint3x4(142931150, 1684745462, 2101748242, 1831486861, 5683864, 1735084283, 1336059993, 721992570, 1906075622, 1073069872, 1374497592, 242540880);
            uint3x4 r3 = uint3x4(293009766, 3677102970, 1179445736, 3813187164, 2708838392, 1397450915, 487571412, 3889286542, 326598756, 995119616, 638698952, 1153153376);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_mul_wide_scalar()
        {
            uint3x4 a0 = uint3x4(1762033447, 465343930, 1570757881, 1326409563, 1824319147, 1356578909, 72749215, 154616909, 975743632, 573770299, 1958912969, 971327747);
            uint b0 = (1476837906);
            uint3x4 r0 = uint3x4(2981789374, 1326807828, 2156411778, 4018813542, 4229418502, 2976383114, 2455742766, 2574460778, 1736252960, 2595843622, 2760103458, 2441439286);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x4 a1 = uint3x4(1818877398, 660611671, 1279757657, 391009467, 1186856590, 890343818, 800117742, 606927173, 1338014500, 1688964615, 1439447294, 387721300);
            uint b1 = (1324050764);
            uint3x4 r1 = uint3x4(1927061896, 645718228, 3706353516, 3450526340, 3727282216, 2610351864, 3202713768, 133057916, 2712818352, 3265005844, 4046133608, 100822256);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x4 a2 = uint3x4(1192501703, 76318055, 124378112, 970518733, 1370700538, 1978842602, 1451974062, 987919119, 1659987051, 1325430351, 948943118, 1743760648);
            uint b2 = (1613845584);
            uint3x4 r2 = uint3x4(3900103216, 2959506480, 692371456, 973833232, 1630959136, 2616598816, 4103626336, 1516495024, 2027781488, 471196848, 2169531488, 1043640960);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x4 a3 = uint3x4(227492421, 370371313, 309869840, 1389753586, 1895557060, 1449787207, 1817244670, 2117623142, 1951266912, 206918942, 382686790, 396984449);
            uint b3 = (217698851);
            uint3x4 r3 = uint3x4(269461871, 1120555251, 1293383984, 1838219542, 3023271884, 1677010101, 1900394426, 512258290, 4056397088, 3786096410, 1697920914, 1359963043);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_mul_scalar_wide()
        {
            uint a0 = (99541948);
            uint3x4 b0 = uint3x4(1764461774, 657072478, 1459784358, 1610646683, 1632058826, 868441654, 1408757883, 335917146, 2105124483, 1178393968, 1963904348, 1409533767);
            uint3x4 r0 = uint3x4(3344568648, 4192918280, 1260585960, 1158730452, 4293361240, 3828814248, 2108402516, 1966690328, 1623617844, 2603413056, 3464455056, 3011267876);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (243286231);
            uint3x4 b1 = uint3x4(1336308795, 517963367, 1733623488, 459880225, 994616533, 1420531535, 1821413700, 677771573, 2132626845, 1158827713, 640102997, 944551639);
            uint3x4 r1 = uint3x4(3646578061, 2731337857, 3893490496, 2980416695, 62369507, 4218409817, 2881159196, 3966864259, 2038656731, 2224055319, 2818606435, 2745388689);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (1323243330);
            uint3x4 b2 = uint3x4(1186460236, 657101857, 1275563580, 1031291523, 1008470115, 1155301041, 1046199281, 2138825098, 1273008873, 1788343477, 1994364082, 597340263);
            uint3x4 r2 = uint3x4(4200942488, 50866050, 1979584376, 2165828294, 2084048518, 3664351394, 1987582754, 2187955092, 3020934930, 1909741994, 2131645412, 527678350);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (2022856151);
            uint3x4 b3 = uint3x4(1375763101, 1007501105, 1162446628, 96412054, 1676576573, 1763698296, 729299033, 1534484, 1053621089, 1978013043, 796620370, 890235481);
            uint3x4 r3 = uint3x4(2359761627, 3607975719, 2368172860, 3241673466, 3640972603, 2445305544, 1198448575, 3108682444, 2733658999, 2364617365, 3384645854, 938433983);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_div_wide_wide()
        {
            uint3x4 a0 = uint3x4(1590198532, 507812502, 126627032, 1058247011, 427387861, 290676154, 1829594484, 1127868739, 499016351, 1341209632, 134906097, 785470242);
            uint3x4 b0 = uint3x4(1434703236, 911965201, 390415521, 128746927, 525835375, 816946613, 878264647, 146789678, 2089524057, 254213018, 1916850021, 1737806518);
            uint3x4 r0 = uint3x4(1, 0, 0, 8, 0, 0, 2, 7, 0, 5, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x4 a1 = uint3x4(788249865, 1099825433, 1552968283, 1822367139, 1021812060, 1937073018, 645757349, 1097576782, 1246027674, 1152153253, 1900577195, 172149343);
            uint3x4 b1 = uint3x4(1906634983, 437754923, 825037958, 902508708, 896853614, 49452028, 1921327824, 787000669, 1032149621, 858558868, 1422112429, 837098844);
            uint3x4 r1 = uint3x4(0, 2, 1, 2, 1, 39, 0, 1, 1, 1, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x4 a2 = uint3x4(1735128704, 816492592, 2012272185, 632330092, 649232994, 123715336, 1438073735, 723262291, 850951883, 1942618200, 1088675276, 1648515976);
            uint3x4 b2 = uint3x4(616122946, 2035322800, 1324534444, 1820832158, 917489631, 367475696, 620492088, 1749833550, 1535651093, 932740870, 1078416711, 725172174);
            uint3x4 r2 = uint3x4(2, 0, 1, 0, 0, 0, 2, 0, 0, 2, 1, 2);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x4 a3 = uint3x4(991947275, 1155668991, 764696768, 1984712970, 1734485640, 850109866, 8545366, 1037720170, 264523522, 1547702681, 1797612488, 1496410581);
            uint3x4 b3 = uint3x4(554208963, 1250240123, 2074395021, 1513621083, 262726589, 936845337, 1934527986, 1844761263, 116240860, 1875751365, 730101086, 625535586);
            uint3x4 r3 = uint3x4(1, 0, 0, 1, 6, 0, 0, 0, 2, 0, 2, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_div_wide_scalar()
        {
            uint3x4 a0 = uint3x4(560951562, 1218680769, 375341724, 1613542090, 1919409166, 1397425408, 1349573078, 524526253, 341995568, 495895326, 1515313790, 1676971657);
            uint b0 = (947861580);
            uint3x4 r0 = uint3x4(0, 1, 0, 1, 2, 1, 1, 0, 0, 0, 1, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x4 a1 = uint3x4(2131487088, 1017891310, 542666029, 1646044372, 1447236569, 107215658, 19616726, 896899915, 707389627, 1249475421, 1486968988, 1738891885);
            uint b1 = (2105094094);
            uint3x4 r1 = uint3x4(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x4 a2 = uint3x4(1919705924, 1200843642, 206442634, 1508567412, 1825701056, 1117255783, 929925156, 1725332114, 1949103348, 1383839785, 2136282541, 159847918);
            uint b2 = (1244966864);
            uint3x4 r2 = uint3x4(1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x4 a3 = uint3x4(1515555001, 1033495687, 1947230231, 1969254260, 1948672400, 757256792, 2099218773, 455629883, 324433498, 1679339858, 2024651647, 1222061694);
            uint b3 = (614923813);
            uint3x4 r3 = uint3x4(2, 1, 3, 3, 3, 1, 3, 0, 0, 2, 3, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_div_scalar_wide()
        {
            uint a0 = (1161272038);
            uint3x4 b0 = uint3x4(187325733, 1594107378, 2016183849, 1589343709, 388768753, 1417077283, 1773486938, 1154044032, 81831373, 1476877645, 653688843, 45756703);
            uint3x4 r0 = uint3x4(6, 0, 0, 0, 2, 0, 0, 1, 14, 0, 1, 25);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (631027637);
            uint3x4 b1 = uint3x4(396671391, 784365696, 1250594097, 1818363859, 1653451772, 270557729, 48974453, 1796936382, 1427856423, 981056957, 1955700573, 705450043);
            uint3x4 r1 = uint3x4(1, 0, 0, 0, 0, 2, 12, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1054404890);
            uint3x4 b2 = uint3x4(351914083, 131970646, 1320586926, 366944102, 1575786200, 257204865, 1582754309, 2114509003, 1266146708, 45105265, 2092444751, 407744534);
            uint3x4 r2 = uint3x4(2, 7, 0, 2, 0, 4, 0, 0, 0, 23, 0, 2);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (126616016);
            uint3x4 b3 = uint3x4(1900058250, 523718813, 414718546, 1828540203, 860638950, 1827704212, 182494419, 669579562, 717750865, 560379939, 681272719, 638134699);
            uint3x4 r3 = uint3x4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_mod_wide_wide()
        {
            uint3x4 a0 = uint3x4(146150818, 1846543305, 1071447756, 308965362, 659881575, 1002365460, 861198439, 1510617532, 778525078, 1458458044, 101987897, 1249565173);
            uint3x4 b0 = uint3x4(983050390, 771341152, 942375212, 367361754, 749500619, 750718852, 2095151755, 88438806, 769227442, 647214624, 1026513788, 1544950956);
            uint3x4 r0 = uint3x4(146150818, 303861001, 129072544, 308965362, 659881575, 251646608, 861198439, 7157830, 9297636, 164028796, 101987897, 1249565173);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x4 a1 = uint3x4(938026607, 1692541775, 1518877124, 1806965510, 1325139851, 994457255, 1372400564, 1770508529, 100255877, 452674793, 1545968777, 629019189);
            uint3x4 b1 = uint3x4(160166322, 1099108075, 1158422232, 1798905209, 164686701, 327889784, 1082162785, 1213537518, 608481038, 329133821, 1824387961, 1223426748);
            uint3x4 r1 = uint3x4(137194997, 593433700, 360454892, 8060301, 7646243, 10787903, 290237779, 556971011, 100255877, 123540972, 1545968777, 629019189);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x4 a2 = uint3x4(1402964707, 2138294579, 1641714420, 1782022072, 1880968864, 1980798192, 1397317084, 995968277, 1090018756, 1573062648, 1100694500, 863521889);
            uint3x4 b2 = uint3x4(798137669, 79717779, 1233582258, 1267120677, 301592349, 911281434, 1357340934, 1648942990, 1350943898, 696511738, 1182727748, 1843845940);
            uint3x4 r2 = uint3x4(604827038, 65632325, 408132162, 514901395, 71414770, 158235324, 39976150, 995968277, 1090018756, 180039172, 1100694500, 863521889);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x4 a3 = uint3x4(1146202560, 546958747, 573838995, 2146465826, 1678630780, 1843627015, 1167611300, 157190789, 530148276, 594404567, 1248848240, 1963704081);
            uint3x4 b3 = uint3x4(244920526, 1640990506, 920431352, 1261122293, 469115027, 720739455, 1727247731, 91557593, 1874820225, 1070808215, 859227095, 890398590);
            uint3x4 r3 = uint3x4(166520456, 546958747, 573838995, 885343533, 271285699, 402148105, 1167611300, 65633196, 530148276, 594404567, 389621145, 182906901);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_mod_wide_scalar()
        {
            uint3x4 a0 = uint3x4(164800505, 1062177828, 1898749675, 1701653318, 820393245, 19002208, 128329633, 1464010899, 896587769, 405208598, 1982762194, 959236935);
            uint b0 = (883951171);
            uint3x4 r0 = uint3x4(164800505, 178226657, 130847333, 817702147, 820393245, 19002208, 128329633, 580059728, 12636598, 405208598, 214859852, 75285764);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x4 a1 = uint3x4(712321026, 1540068445, 1085897743, 1607489717, 165478511, 647846716, 915707999, 1602830401, 928191283, 1084934806, 488509689, 2087820912);
            uint b1 = (172564850);
            uint3x4 r1 = uint3x4(22061626, 159549645, 50508643, 54406067, 165478511, 130152166, 52883749, 49746751, 65367033, 49545706, 143379989, 17042712);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x4 a2 = uint3x4(377501313, 1216011754, 812183417, 1153802502, 1642671870, 1924710742, 665297470, 1568090825, 2050982942, 435886407, 453990946, 1731665372);
            uint b2 = (1778384846);
            uint3x4 r2 = uint3x4(377501313, 1216011754, 812183417, 1153802502, 1642671870, 146325896, 665297470, 1568090825, 272598096, 435886407, 453990946, 1731665372);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x4 a3 = uint3x4(586777590, 1585649515, 1414579860, 1891664981, 1262495021, 1400758118, 1529532008, 430295164, 1386414018, 2130346558, 666621411, 1524342239);
            uint b3 = (1475597526);
            uint3x4 r3 = uint3x4(586777590, 110051989, 1414579860, 416067455, 1262495021, 1400758118, 53934482, 430295164, 1386414018, 654749032, 666621411, 48744713);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_mod_scalar_wide()
        {
            uint a0 = (242383789);
            uint3x4 b0 = uint3x4(740000543, 1556450291, 1104736385, 437976569, 1911837205, 1507212038, 1906405167, 247693265, 293460573, 1495295166, 873323603, 530681233);
            uint3x4 r0 = uint3x4(242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1298102643);
            uint3x4 b1 = uint3x4(2057984657, 1000742091, 1461372131, 1859742342, 797184687, 821888842, 1083192997, 840114986, 1894865954, 615159964, 1485575122, 2028738);
            uint3x4 r1 = uint3x4(1298102643, 297360552, 1298102643, 1298102643, 500917956, 476213801, 214909646, 457987657, 1298102643, 67782715, 1298102643, 1739061);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (2122220318);
            uint3x4 b2 = uint3x4(164578061, 730088119, 1444946139, 1305792037, 1110829011, 872723581, 166847388, 1477846418, 511428733, 1642227542, 1962310765, 207128894);
            uint3x4 r2 = uint3x4(147283586, 662044080, 677274179, 816428281, 1011391307, 376773156, 120051662, 644373900, 76505386, 479992776, 159909553, 50931378);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (1342085447);
            uint3x4 b3 = uint3x4(448361286, 334667519, 705465751, 753088773, 1146344010, 275140144, 1074480141, 2092749846, 1631900558, 2088387496, 1098441751, 1648646354);
            uint3x4 r3 = uint3x4(445362875, 3415371, 636619696, 588996674, 195741437, 241524871, 267605306, 1342085447, 1342085447, 1342085447, 243643696, 1342085447);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_plus()
        {
            uint3x4 a0 = uint3x4(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479, 401565897, 1287765427, 849339193, 174532915);
            uint3x4 r0 = uint3x4(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479, 401565897, 1287765427, 849339193, 174532915);
            TestUtils.AreEqual(+a0, r0);

            uint3x4 a1 = uint3x4(1864850812, 1145639744, 1615499926, 2049663954, 1723005749, 409076474, 591286416, 1706631096, 1079164488, 1808261782, 1201290141, 82958939);
            uint3x4 r1 = uint3x4(1864850812, 1145639744, 1615499926, 2049663954, 1723005749, 409076474, 591286416, 1706631096, 1079164488, 1808261782, 1201290141, 82958939);
            TestUtils.AreEqual(+a1, r1);

            uint3x4 a2 = uint3x4(308695413, 2067379018, 1673126612, 500666137, 640289062, 836003812, 336058393, 829347661, 33442669, 381670450, 277507230, 361395485);
            uint3x4 r2 = uint3x4(308695413, 2067379018, 1673126612, 500666137, 640289062, 836003812, 336058393, 829347661, 33442669, 381670450, 277507230, 361395485);
            TestUtils.AreEqual(+a2, r2);

            uint3x4 a3 = uint3x4(1012749225, 2092803800, 1459040742, 531853559, 2093894901, 1589622197, 1559976318, 619729461, 731886792, 1441425968, 1921783986, 1257555634);
            uint3x4 r3 = uint3x4(1012749225, 2092803800, 1459040742, 531853559, 2093894901, 1589622197, 1559976318, 619729461, 731886792, 1441425968, 1921783986, 1257555634);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_neg()
        {
            uint3x4 a0 = uint3x4(1955022112, 662160019, 370300775, 2141283773, 1004505619, 28153593, 33894270, 505708349, 1115028238, 1636274969, 694995093, 1542206286);
            uint3x4 r0 = uint3x4(2339945184, 3632807277, 3924666521, 2153683523, 3290461677, 4266813703, 4261073026, 3789258947, 3179939058, 2658692327, 3599972203, 2752761010);
            TestUtils.AreEqual(-a0, r0);

            uint3x4 a1 = uint3x4(213087293, 341522275, 841085242, 574159094, 1687250035, 2057919693, 1175014732, 1259809073, 1212465326, 1190569920, 2047955772, 2120729864);
            uint3x4 r1 = uint3x4(4081880003, 3953445021, 3453882054, 3720808202, 2607717261, 2237047603, 3119952564, 3035158223, 3082501970, 3104397376, 2247011524, 2174237432);
            TestUtils.AreEqual(-a1, r1);

            uint3x4 a2 = uint3x4(1440774928, 431666091, 1387601718, 1745651998, 319115626, 1119959806, 739132284, 1954173314, 1709857098, 1836511050, 1662806453, 506144868);
            uint3x4 r2 = uint3x4(2854192368, 3863301205, 2907365578, 2549315298, 3975851670, 3175007490, 3555835012, 2340793982, 2585110198, 2458456246, 2632160843, 3788822428);
            TestUtils.AreEqual(-a2, r2);

            uint3x4 a3 = uint3x4(650922971, 1273997249, 1474445187, 1853826947, 1695573773, 729452512, 345069360, 575867536, 594119038, 1201840609, 1342872551, 1768435578);
            uint3x4 r3 = uint3x4(3644044325, 3020970047, 2820522109, 2441140349, 2599393523, 3565514784, 3949897936, 3719099760, 3700848258, 3093126687, 2952094745, 2526531718);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_prefix_inc()
        {
            uint3x4 a0 = uint3x4(864455342, 2035793213, 1275443862, 971919915, 411610189, 446210725, 395072276, 115573442, 913293639, 432884105, 1208161871, 1385544935);
            uint3x4 r0 = uint3x4(864455343, 2035793214, 1275443863, 971919916, 411610190, 446210726, 395072277, 115573443, 913293640, 432884106, 1208161872, 1385544936);
            TestUtils.AreEqual(++a0, r0);

            uint3x4 a1 = uint3x4(1835605516, 388229350, 696475402, 1786514683, 993189311, 752093909, 1622410417, 1398865015, 241906003, 1705625817, 609525897, 172599489);
            uint3x4 r1 = uint3x4(1835605517, 388229351, 696475403, 1786514684, 993189312, 752093910, 1622410418, 1398865016, 241906004, 1705625818, 609525898, 172599490);
            TestUtils.AreEqual(++a1, r1);

            uint3x4 a2 = uint3x4(504806865, 281942776, 1541894135, 924683935, 259568871, 1349062584, 1120518661, 65514038, 1495168208, 1321109497, 1366348660, 1777734111);
            uint3x4 r2 = uint3x4(504806866, 281942777, 1541894136, 924683936, 259568872, 1349062585, 1120518662, 65514039, 1495168209, 1321109498, 1366348661, 1777734112);
            TestUtils.AreEqual(++a2, r2);

            uint3x4 a3 = uint3x4(1414867743, 539531120, 886558347, 1733014170, 1586973907, 1145067277, 884064327, 82551838, 1001250037, 924273925, 242241802, 413165245);
            uint3x4 r3 = uint3x4(1414867744, 539531121, 886558348, 1733014171, 1586973908, 1145067278, 884064328, 82551839, 1001250038, 924273926, 242241803, 413165246);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_postfix_inc()
        {
            uint3x4 a0 = uint3x4(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527, 1396179607, 708474528, 177416855, 1524860667);
            uint3x4 r0 = uint3x4(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527, 1396179607, 708474528, 177416855, 1524860667);
            TestUtils.AreEqual(a0++, r0);

            uint3x4 a1 = uint3x4(1408994706, 1580130369, 1676086778, 717006530, 506142468, 732199129, 2026873940, 130175844, 1513142653, 420613464, 1219979307, 586574160);
            uint3x4 r1 = uint3x4(1408994706, 1580130369, 1676086778, 717006530, 506142468, 732199129, 2026873940, 130175844, 1513142653, 420613464, 1219979307, 586574160);
            TestUtils.AreEqual(a1++, r1);

            uint3x4 a2 = uint3x4(357567451, 1949784665, 1127356901, 101238629, 2131648021, 423320704, 827539403, 1919960927, 840371710, 2010345998, 1047836590, 586887730);
            uint3x4 r2 = uint3x4(357567451, 1949784665, 1127356901, 101238629, 2131648021, 423320704, 827539403, 1919960927, 840371710, 2010345998, 1047836590, 586887730);
            TestUtils.AreEqual(a2++, r2);

            uint3x4 a3 = uint3x4(1209169651, 1479717664, 1874959449, 104723114, 817246348, 1972950889, 1784631804, 1550936382, 718649502, 872906800, 717529320, 1995020676);
            uint3x4 r3 = uint3x4(1209169651, 1479717664, 1874959449, 104723114, 817246348, 1972950889, 1784631804, 1550936382, 718649502, 872906800, 717529320, 1995020676);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_prefix_dec()
        {
            uint3x4 a0 = uint3x4(200904609, 871077500, 968578728, 638967721, 1995396216, 435367037, 1782514098, 1589827826, 1434377580, 596759698, 1699290403, 1758478358);
            uint3x4 r0 = uint3x4(200904608, 871077499, 968578727, 638967720, 1995396215, 435367036, 1782514097, 1589827825, 1434377579, 596759697, 1699290402, 1758478357);
            TestUtils.AreEqual(--a0, r0);

            uint3x4 a1 = uint3x4(1914114460, 389120307, 1022184392, 1310293956, 356565557, 18299409, 906734601, 799006218, 1383897383, 1040798388, 1469596990, 1719228297);
            uint3x4 r1 = uint3x4(1914114459, 389120306, 1022184391, 1310293955, 356565556, 18299408, 906734600, 799006217, 1383897382, 1040798387, 1469596989, 1719228296);
            TestUtils.AreEqual(--a1, r1);

            uint3x4 a2 = uint3x4(220897829, 678025545, 14227726, 293093918, 1065286595, 1249415499, 1009503100, 157482354, 965385343, 1797304434, 1083672612, 929765380);
            uint3x4 r2 = uint3x4(220897828, 678025544, 14227725, 293093917, 1065286594, 1249415498, 1009503099, 157482353, 965385342, 1797304433, 1083672611, 929765379);
            TestUtils.AreEqual(--a2, r2);

            uint3x4 a3 = uint3x4(2083512379, 323646560, 1395297406, 583796119, 999841714, 1788073019, 1618852114, 1777032041, 1252764958, 1070818447, 219340317, 767990877);
            uint3x4 r3 = uint3x4(2083512378, 323646559, 1395297405, 583796118, 999841713, 1788073018, 1618852113, 1777032040, 1252764957, 1070818446, 219340316, 767990876);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_postfix_dec()
        {
            uint3x4 a0 = uint3x4(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737, 691209285, 2017728859, 802721301, 377162390);
            uint3x4 r0 = uint3x4(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737, 691209285, 2017728859, 802721301, 377162390);
            TestUtils.AreEqual(a0--, r0);

            uint3x4 a1 = uint3x4(526366486, 590919177, 60677868, 1867810045, 2095777993, 670715645, 324944916, 242636153, 1659736954, 1316734088, 1030072405, 1751972064);
            uint3x4 r1 = uint3x4(526366486, 590919177, 60677868, 1867810045, 2095777993, 670715645, 324944916, 242636153, 1659736954, 1316734088, 1030072405, 1751972064);
            TestUtils.AreEqual(a1--, r1);

            uint3x4 a2 = uint3x4(1868889881, 1931943579, 175622377, 181847458, 665549439, 530897466, 635466911, 416440036, 1447690298, 1444496274, 296146626, 1209855130);
            uint3x4 r2 = uint3x4(1868889881, 1931943579, 175622377, 181847458, 665549439, 530897466, 635466911, 416440036, 1447690298, 1444496274, 296146626, 1209855130);
            TestUtils.AreEqual(a2--, r2);

            uint3x4 a3 = uint3x4(2016700604, 647102652, 1948542169, 659874422, 2009120584, 1577004911, 1809041177, 518526567, 1464738365, 1815629310, 1216839298, 569144612);
            uint3x4 r3 = uint3x4(2016700604, 647102652, 1948542169, 659874422, 2009120584, 1577004911, 1809041177, 518526567, 1464738365, 1815629310, 1216839298, 569144612);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_and_wide_wide()
        {
            uint3x4 a0 = uint3x4(779935043, 1097962163, 1939593304, 800599247, 952140918, 782792558, 1608557706, 396446406, 2039894114, 1286974642, 442394124, 1759739564);
            uint3x4 b0 = uint3x4(307705143, 1710882162, 866836769, 532490608, 679371720, 1794035877, 1439832202, 519529812, 23633139, 1209152681, 646737179, 1255867027);
            uint3x4 r0 = uint3x4(39064835, 1097961522, 864731136, 263727168, 675283008, 715673636, 1438646410, 379666500, 16781410, 1209017504, 34366472, 1220739712);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x4 a1 = uint3x4(233435438, 665207770, 1942050241, 1022352952, 60340400, 329119345, 406517382, 1126764634, 343425836, 1957552749, 1624478957, 341972372);
            uint3x4 b1 = uint3x4(1900854122, 413173763, 1409138251, 2087190272, 563439483, 354579077, 642224854, 1650432515, 755290290, 902865191, 661389406, 2134212586);
            uint3x4 r1 = uint3x4(21541162, 10485762, 1405162561, 1013440000, 26222640, 285241857, 168582, 1107890178, 67125280, 880844837, 541065292, 337646976);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x4 a2 = uint3x4(181537307, 130347414, 1240828622, 526120460, 695449226, 1477446724, 201628999, 737924014, 1804502415, 1733695477, 1110712857, 113012430);
            uint3x4 b2 = uint3x4(1855189321, 185194029, 810374380, 133197864, 1989578783, 38739182, 387425484, 1690486314, 843085933, 1045118223, 41867329, 1397669260);
            uint3x4 r2 = uint3x4(177340425, 50384900, 4522188, 122712072, 538087434, 3140, 67404868, 549634602, 570425357, 641864965, 36962305, 34352268);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x4 a3 = uint3x4(1044352152, 865726845, 836668077, 1778871717, 1558881750, 231636456, 1278790837, 846361650, 37319023, 1806613498, 1312261777, 1448803516);
            uint3x4 b3 = uint3x4(1784025774, 1834587481, 856874373, 1719529679, 678478831, 86860920, 837158923, 1397449667, 195921481, 564422246, 1088025452, 2103483999);
            uint3x4 r3 = uint3x4(706085000, 555323737, 823298181, 1644519557, 140542406, 84698216, 2099201, 306339842, 36241481, 564404834, 1074889216, 1413520412);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_and_wide_scalar()
        {
            uint3x4 a0 = uint3x4(443615469, 490057985, 2042441263, 1524760558, 1405175110, 510212004, 1941875181, 1236735839, 1365509729, 428270198, 607982857, 650270920);
            uint b0 = (93423598);
            uint3x4 r0 = uint3x4(1114348, 85033216, 26281518, 8488942, 25232710, 67176356, 26247660, 26281806, 16778848, 25199206, 68224264, 75497672);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x4 a1 = uint3x4(1249238550, 1862276471, 143502472, 861733033, 1408932942, 957693145, 1567715668, 1102952410, 322053683, 1599352836, 208656708, 1272226025);
            uint b1 = (814629680);
            uint3x4 r1 = uint3x4(279056, 536871216, 9175040, 806092832, 277479424, 805568528, 268452112, 9175824, 268567088, 268697600, 934144, 8650784);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x4 a2 = uint3x4(462670926, 1466722981, 1817277774, 818900583, 772681077, 1630437952, 546018772, 872875431, 1143080525, 708719245, 1764446048, 1527981061);
            uint b2 = (1817145060);
            uint3x4 r2 = uint3x4(134433860, 1145858724, 1816224836, 542076516, 739126372, 1611530816, 537593028, 604439716, 1140983364, 672014980, 1745571424, 1208165380);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x4 a3 = uint3x4(398141788, 554819377, 1683835293, 972562207, 393685571, 2118911919, 1503487659, 283854137, 1911282206, 312686024, 384581172, 1826788967);
            uint b3 = (156911041);
            uint3x4 r3 = uint3x4(18481472, 17843457, 5783937, 156763393, 22151233, 138937729, 152585345, 4867329, 21643264, 132544, 4719616, 138544193);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1144543590);
            uint3x4 b0 = uint3x4(420346723, 562416448, 1393127318, 1560699552, 851218057, 703880958, 1159378889, 2031211279, 1089518981, 270607307, 1349288930, 520199596);
            uint3x4 r0 = uint3x4(547170, 18752, 1074284806, 1140867104, 3672064, 3168358, 1142427968, 1074811142, 1076893956, 2097474, 1076363618, 67115300);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1763483957);
            uint3x4 b1 = uint3x4(1248975349, 236938635, 185023291, 1085233038, 1845693112, 946052961, 1436238522, 2042776519, 56356886, 1770159840, 1872339579, 1439201366);
            uint3x4 r1 = uint3x4(1209041205, 136061185, 151265585, 1074528516, 1744830512, 671121697, 1092091952, 1761607941, 18391060, 1761615904, 1763221553, 1091051540);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (1233066417);
            uint3x4 b2 = uint3x4(1214109404, 2255485, 1814885263, 1711986588, 1286898282, 915476451, 1870138851, 372814411, 1623486506, 211665304, 1668985777, 348112007);
            uint3x4 r2 = uint3x4(1214058640, 2230321, 1210847617, 1074401680, 1211367456, 1116577, 1232603553, 3674113, 1078202400, 136118672, 1098518961, 4128897);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (1808619374);
            uint3x4 b3 = uint3x4(1516730209, 1647041932, 350465899, 1641369007, 1555310928, 857924828, 1980404095, 34923708, 1073528483, 742357726, 1244015681, 1980296380);
            uint3x4 r3 = uint3x4(1246058336, 1644778764, 12650346, 1640318254, 1216610624, 587220044, 1644695918, 33834028, 734795298, 671961678, 1241777216, 1644708908);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_or_wide_wide()
        {
            uint3x4 a0 = uint3x4(1731159103, 659068416, 382702471, 1821032196, 1565773438, 1004000514, 948501377, 600951835, 669346222, 396691477, 2108560248, 2117522137);
            uint3x4 b0 = uint3x4(1583847161, 692672727, 1161585489, 1756207130, 1321374429, 1287357212, 2075767170, 1273513430, 1610830169, 1316929125, 511625048, 573925879);
            uint3x4 r0 = uint3x4(2138044159, 793370327, 1476391895, 1823457054, 1607720703, 2147473182, 2075786115, 1811533279, 1743223295, 1610595957, 2147407736, 2117598207);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x4 a1 = uint3x4(330307355, 818676817, 1774459567, 1117506257, 1254511182, 1017865993, 1883021644, 1140203470, 759288967, 2122744307, 335621148, 715028074);
            uint3x4 b1 = uint3x4(1502255628, 1841676448, 1682928938, 1115131952, 1541423910, 1416096228, 188606371, 1041599540, 219545389, 560097663, 1087543661, 936383841);
            uint3x4 r1 = uint3x4(1538957087, 2110637297, 1842315183, 1124063985, 1541821294, 2096099309, 2067654639, 2146934782, 760610735, 2145839615, 1423162749, 1071544171);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x4 a2 = uint3x4(543305337, 662107399, 1934997335, 436754869, 1613808671, 362365372, 342908672, 2129231210, 203868172, 32846030, 1057901177, 1537975433);
            uint3x4 b2 = uint3x4(108816721, 1694053551, 452638547, 1219534055, 85142537, 1027930490, 2126839395, 2030328147, 2036352209, 1554561114, 1332339254, 480739851);
            uint3x4 r2 = uint3x4(645820281, 1744827823, 2080356183, 1522064887, 1697901599, 1037957630, 2129985379, 2146270587, 2103889117, 1576909022, 2138040959, 1605346955);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x4 a3 = uint3x4(470626699, 557640158, 536364388, 238304731, 787227554, 1298371111, 1020821539, 1327618264, 1104669041, 1949771204, 1973724646, 698690868);
            uint3x4 b3 = uint3x4(1502575584, 1889014859, 1557424474, 1390247341, 2029776623, 1665642846, 1570936353, 801872635, 1945815585, 1797879107, 112272980, 779933219);
            uint3x4 r3 = uint3x4(1569684459, 1908211167, 1610378622, 1593671167, 2130702319, 1869067135, 2113574435, 1877727995, 1946151793, 2134865351, 2008393718, 805175095);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_or_wide_scalar()
        {
            uint3x4 a0 = uint3x4(961259683, 471103264, 1733389229, 1591585258, 386953869, 1148351449, 1048929715, 1814263250, 860336789, 1637162093, 1227888278, 774029856);
            uint b0 = (1666102508);
            uint3x4 r0 = uint3x4(2068823279, 2136930284, 1734344685, 2145369582, 2002712301, 1736374269, 2144335359, 1869608446, 1934604029, 1675607277, 1803466494, 1869543148);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x4 a1 = uint3x4(879300408, 797240690, 1977614655, 46921989, 1980838747, 284225881, 64304104, 313591807, 1393862490, 1890090886, 521303722, 2021379070);
            uint b1 = (1179087439);
            uint3x4 r1 = uint3x4(1987018623, 1875378047, 2011657087, 1188035407, 1985442655, 1459090271, 1205302255, 1459058687, 1465382751, 1995407311, 1599567599, 2122316799);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x4 a2 = uint3x4(2055963359, 1775629833, 1142751163, 1767274359, 1421981808, 1501294791, 485944015, 539526284, 310877895, 1815369493, 529427586, 358352200);
            uint b2 = (1511253082);
            uint3x4 r2 = uint3x4(2057037535, 2077750875, 1579155451, 2069362559, 1590951034, 1534850271, 1593306847, 2050745566, 1519910623, 2117597023, 1604316378, 1600120154);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x4 a3 = uint3x4(1353013374, 1624839772, 1369983151, 666444298, 207757238, 257316089, 409252967, 1919967661, 1452040383, 2012115244, 1149949643, 142082352);
            uint b3 = (1349149982);
            uint3x4 r3 = uint3x4(1357872510, 1895528286, 1374318015, 2012964638, 1550483390, 1602123263, 1483666815, 1920624063, 1458464191, 2012116286, 1424685023, 1484416318);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1213433101);
            uint3x4 b0 = uint3x4(1212928242, 1614462616, 936937728, 764766995, 306352095, 574719481, 1283571271, 2109131012, 979469710, 1348323481, 1407542578, 697517649);
            uint3x4 r0 = uint3x4(1213978111, 1752940445, 2145094925, 1842867999, 1515425759, 1783858685, 1288945487, 2113391885, 2054391183, 1482673565, 1542972735, 1775486813);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1059093741);
            uint3x4 b1 = uint3x4(627815046, 418822515, 83214352, 424663473, 447949225, 527022375, 1947148461, 305251437, 1254601325, 1752329425, 1592402684, 1587055329);
            uint3x4 r1 = uint3x4(1064042223, 1073151487, 1073085693, 1064304125, 1068727789, 1063910895, 2133818605, 1060240621, 2145910509, 2138209533, 2146074365, 2142830317);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1088734150);
            uint3x4 b2 = uint3x4(298563808, 2052547661, 582843231, 656983670, 1944993640, 1081208038, 829763560, 990961386, 547309556, 1307122961, 263229121, 1518227598);
            uint3x4 r2 = uint3x4(1374682086, 2063067087, 1660812255, 1743570934, 1945042926, 1089859558, 1911943150, 2079645678, 1627375606, 1307434967, 1341444039, 1526649806);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (1098359242);
            uint3x4 b3 = uint3x4(997941952, 1075751132, 996271847, 623986648, 1091787263, 1548400620, 2022447724, 433714471, 963197960, 1639565037, 1287986616, 1326199854);
            uint3x4 r3 = uint3x4(2071978954, 1098885598, 2071455727, 1702356954, 1098381823, 1568651246, 2046802926, 1509946863, 2038414794, 1644161007, 1308081658, 1333769710);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_xor_wide_wide()
        {
            uint3x4 a0 = uint3x4(1556324760, 207002929, 1843444873, 1632079131, 1460334334, 1607815585, 220623650, 38668553, 47193340, 643663548, 1371932564, 94957188);
            uint3x4 b0 = uint3x4(1054997548, 1523759632, 251164872, 110472397, 384031112, 1109163205, 535118981, 179106262, 1523031711, 1713313372, 1294118730, 520360641);
            uint3x4 r0 = uint3x4(1646419380, 1451501345, 1662567489, 1741824470, 1105803126, 499723620, 314783655, 149092575, 1477935715, 1078104288, 484747486, 447544389);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x4 a1 = uint3x4(700973621, 370621508, 2087573076, 351476570, 1340815927, 681577472, 314138777, 446857644, 1368661599, 1672499683, 1259759761, 2049102405);
            uint3x4 b1 = uint3x4(1040688781, 1020757245, 1143954843, 1281933464, 175288469, 326874157, 1192052687, 1087083643, 1900865484, 1521193463, 569695524, 1622101483);
            uint3x4 r1 = uint3x4(399484088, 717273273, 943885263, 1486609346, 1167690402, 1004255277, 1437869910, 1516836311, 551090579, 958119956, 1793242549, 445489070);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x4 a2 = uint3x4(1972524935, 91962333, 1960780785, 1303778459, 960040360, 822786011, 2028027011, 170382968, 32554542, 1915830925, 2001025156, 2012451132);
            uint3x4 b2 = uint3x4(1340735463, 546583617, 1034420616, 262206030, 1834125935, 802756092, 611321886, 316379491, 325882121, 45335181, 1859278043, 1002624300);
            uint3x4 r2 = uint3x4(981182560, 636424092, 1232544377, 1108797141, 1416333255, 517186087, 1553020061, 419186459, 312225575, 1887600640, 429354079, 1278297104);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x4 a3 = uint3x4(1076174067, 344651773, 1769102694, 1408084527, 1139070023, 1195715957, 1051992510, 1468636326, 1018993657, 1514317444, 369266676, 1206540279);
            uint3x4 b3 = uint3x4(1704063552, 1618550727, 721247372, 131278097, 896003672, 746837613, 1952376600, 306395311, 419371442, 627496489, 1791585199, 757339713);
            uint3x4 r3 = uint3x4(632614579, 1962141754, 1133445610, 1413386046, 1988311583, 1808202520, 1256900262, 1170908169, 608404043, 2133094573, 2093737051, 1791902134);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_xor_wide_scalar()
        {
            uint3x4 a0 = uint3x4(2124666952, 177397845, 574879617, 1937385541, 1136545648, 213863690, 535061373, 289301586, 1305234431, 353786540, 1308626970, 1267729267);
            uint b0 = (493665894);
            uint3x4 r0 = uint3x4(1674536494, 402546227, 1060063719, 1846973987, 1590882582, 299103084, 42523931, 206756404, 1352725913, 142271690, 1399631484, 1459404053);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x4 a1 = uint3x4(125659640, 1730088797, 116862046, 375757978, 491079274, 191750702, 187129429, 967051293, 549951551, 653124416, 788984, 1479174924);
            uint b1 = (1315625690);
            uint3x4 r1 = uint3x4(1226289954, 695588231, 1218311812, 1477396032, 1395629232, 1158101236, 1162708111, 2010043079, 1856848613, 1753692570, 1315361570, 373338582);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x4 a2 = uint3x4(1680011736, 890841598, 293394300, 527727631, 529042816, 1382138962, 1206186973, 1059509471, 744733291, 64097148, 1814786305, 716239);
            uint b2 = (447453839);
            uint3x4 r2 = uint3x4(2122935127, 800240497, 198659571, 98559616, 86185743, 1221222109, 1565485394, 630017616, 919085284, 427397619, 1988160398, 446789440);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x4 a3 = uint3x4(476052372, 2058208914, 41260658, 1316660543, 2113008061, 256229982, 111578612, 1207271814, 2099944258, 1913013312, 870798185, 1771744425);
            uint b3 = (92561487);
            uint3x4 r3 = uint3x4(433822683, 2133436125, 133297725, 1274987888, 2020970994, 180462097, 52620731, 1114759625, 2024733453, 2005017615, 912470822, 1813957862);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1288453276);
            uint3x4 b0 = uint3x4(1077599928, 884741329, 212164516, 1585020328, 152985454, 1775851275, 1416249064, 1309317737, 1773918217, 1509843030, 1206045972, 1154916424);
            uint3x4 r0 = uint3x4(217506340, 2020616269, 1080648504, 313868596, 1171416050, 622160791, 413532788, 46573301, 628614293, 355622090, 187625864, 135961812);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1947871003);
            uint3x4 b1 = uint3x4(1774252400, 1946113778, 1079717492, 290620937, 1382343363, 939045099, 1309568053, 221134131, 885841718, 612068188, 194068085, 1396957881);
            uint3x4 r1 = uint3x4(500881003, 132477417, 876677487, 1699258642, 645842392, 1138923504, 974408494, 2033457704, 1087830061, 1348553799, 2139822446, 660194722);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (573581481);
            uint3x4 b2 = uint3x4(1813817520, 86594349, 2006985393, 1431761813, 905646837, 1522414781, 192882943, 714832744, 374210759, 215701593, 1573378082, 779254615);
            uint3x4 r2 = uint3x4(1311539225, 655981444, 1435501080, 2003229500, 399194716, 2022579220, 693043286, 145445825, 880683118, 787181808, 2146955403, 205673470);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (711527976);
            uint3x4 b3 = uint3x4(710611783, 223429246, 593102399, 1444947259, 302938485, 684673240, 1417651941, 1426772271, 948720266, 177752267, 2005602645, 896851285);
            uint3x4 r3 = uint3x4(3284335, 658000982, 154339351, 2085169939, 946304861, 44451568, 2115414221, 2137251591, 317021346, 552683235, 1575100285, 522048381);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_left_shift()
        {
            uint3x4 a0 = uint3x4(197771193, 622182602, 1283988958, 1327917304, 473415985, 432425717, 870301196, 2058433484, 1200694230, 1531607705, 1360008038, 1008296534);
            int b0 = (1321149625);
            uint3x4 r0 = uint3x4(1912602624, 2483027968, 3154116608, 4026531840, 1644167168, 3925868544, 402653184, 2550136832, 2885681152, 838860800, 3422552064, 2885681152);
            TestUtils.AreEqual(a0 << b0, r0);

            uint3x4 a1 = uint3x4(1447702302, 35667343, 1664454606, 2045594989, 2077023268, 592678686, 297755411, 1722762487, 1161625759, 37265945, 997793693, 1521705181);
            int b1 = (1079614371);
            uint3x4 r1 = uint3x4(2991683824, 285338744, 430734960, 3479858024, 3731284256, 446462192, 2382043288, 897198008, 703071480, 298127560, 3687382248, 3583706856);
            TestUtils.AreEqual(a1 << b1, r1);

            uint3x4 a2 = uint3x4(263886278, 2084190583, 230910816, 71403448, 481375728, 1176038816, 1382694875, 1824729613, 1535276688, 1581610518, 407677878, 1208958192);
            int b2 = (221147365);
            uint3x4 r2 = uint3x4(4149393600, 2269589216, 3094178816, 2284910336, 2519121408, 3273503744, 1296563040, 2556772768, 1884213760, 3366896320, 160790208, 31956480);
            TestUtils.AreEqual(a2 << b2, r2);

            uint3x4 a3 = uint3x4(740058147, 880835937, 2063772405, 430594634, 281771991, 1130057990, 1127968177, 1628217625, 979935914, 17663275, 956738326, 1996060114);
            int b3 = (946058001);
            uint3x4 r3 = uint3x4(3360030720, 4207017984, 1441398784, 3029598208, 4289593344, 2718695424, 3680632832, 1110573056, 1163132928, 173408256, 1445724160, 3953393664);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_right_shift()
        {
            uint3x4 a0 = uint3x4(548167301, 1161338299, 1617625829, 1860731847, 713958715, 196552656, 770466193, 1265099998, 572763124, 506619530, 426807581, 2031319045);
            int b0 = (1266801540);
            uint3x4 r0 = uint3x4(34260456, 72583643, 101101614, 116295740, 44622419, 12284541, 48154137, 79068749, 35797695, 31663720, 26675473, 126957440);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint3x4 a1 = uint3x4(701927980, 569504877, 185593382, 1102123711, 334005460, 1624751550, 280138733, 1598620011, 1840564178, 736389149, 1279158873, 408822762);
            int b1 = (917785020);
            uint3x4 r1 = uint3x4(2, 2, 0, 4, 1, 6, 1, 5, 6, 2, 4, 1);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint3x4 a2 = uint3x4(763607760, 1568185874, 774126687, 1587054000, 600069797, 29576474, 1880981389, 352174824, 1164508476, 425441430, 186542511, 1099859381);
            int b2 = (348013684);
            uint3x4 r2 = uint3x4(728, 1495, 738, 1513, 572, 28, 1793, 335, 1110, 405, 177, 1048);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint3x4 a3 = uint3x4(1234295294, 761662151, 1254855819, 903402043, 1180315725, 182990778, 958706431, 1075621082, 1409488892, 1576738052, 700893981, 1435331003);
            int b3 = (1028666766);
            uint3x4 r3 = uint3x4(75335, 46488, 76590, 55139, 72040, 11168, 58514, 65650, 86028, 96236, 42779, 87605);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void uint3x4_operator_bitwise_not()
        {
            uint3x4 a0 = uint3x4(1403358969, 831360921, 2088190243, 976721016, 878283189, 308994339, 1935567517, 1420884856, 472965491, 771711426, 627580960, 2061524024);
            uint3x4 r0 = uint3x4(2891608326, 3463606374, 2206777052, 3318246279, 3416684106, 3985972956, 2359399778, 2874082439, 3822001804, 3523255869, 3667386335, 2233443271);
            TestUtils.AreEqual(~a0, r0);

            uint3x4 a1 = uint3x4(753208488, 1303022493, 664744603, 1289372466, 1635981125, 1951018596, 1545651937, 717936457, 1284504687, 1342785385, 869629475, 2045854321);
            uint3x4 r1 = uint3x4(3541758807, 2991944802, 3630222692, 3005594829, 2658986170, 2343948699, 2749315358, 3577030838, 3010462608, 2952181910, 3425337820, 2249112974);
            TestUtils.AreEqual(~a1, r1);

            uint3x4 a2 = uint3x4(1282546942, 1824824810, 1736570715, 508906058, 2060752880, 1867418756, 388530274, 695179852, 1766938039, 897923626, 1816190464, 1362906829);
            uint3x4 r2 = uint3x4(3012420353, 2470142485, 2558396580, 3786061237, 2234214415, 2427548539, 3906437021, 3599787443, 2528029256, 3397043669, 2478776831, 2932060466);
            TestUtils.AreEqual(~a2, r2);

            uint3x4 a3 = uint3x4(1227946838, 189609278, 956441808, 2123488810, 1593014251, 19223061, 1722107954, 1636875694, 1914097392, 1382545027, 1285277010, 722020848);
            uint3x4 r3 = uint3x4(3067020457, 4105358017, 3338525487, 2171478485, 2701953044, 4275744234, 2572859341, 2658091601, 2380869903, 2912422268, 3009690285, 3572946447);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
