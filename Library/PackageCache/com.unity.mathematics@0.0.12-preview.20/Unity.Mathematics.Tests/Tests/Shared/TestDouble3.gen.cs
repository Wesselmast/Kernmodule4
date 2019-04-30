// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble3
    {
        [TestCompiler]
        public static void double3_zero()
        {
            TestUtils.AreEqual(double3.zero.x, 0.0);
            TestUtils.AreEqual(double3.zero.y, 0.0);
            TestUtils.AreEqual(double3.zero.z, 0.0);
        }

        [TestCompiler]
        public static void double3_constructor()
        {
            double3 a = new double3(1, 2, 3);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
        }

        [TestCompiler]
        public static void double3_scalar_constructor()
        {
            double3 a = new double3(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
            TestUtils.AreEqual(a.z, 17.0);
        }

        [TestCompiler]
        public static void double3_static_constructor()
        {
            double3 a = double3(1, 2, 3);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
        }

        [TestCompiler]
        public static void double3_static_scalar_constructor()
        {
            double3 a = double3(17.0);
            TestUtils.AreEqual(a.x, 17.0);
            TestUtils.AreEqual(a.y, 17.0);
            TestUtils.AreEqual(a.z, 17.0);
        }

        [TestCompiler]
        public static void double3_operator_equal_wide_wide()
        {
            double3 a0 = double3(-135.18925172425304, -49.094127439471947, 169.12980778940482);
            double3 b0 = double3(-220.01464591734793, 66.980020792679852, 499.20158576369363);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double3 a1 = double3(240.80529772527757, 314.73919382446411, 442.39301916695808);
            double3 b1 = double3(-371.113114291389, 208.44865212610398, 390.80369133074009);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double3 a2 = double3(177.92444881141398, 335.53340283759564, 168.1544516869609);
            double3 b2 = double3(-72.443806920407269, 362.97643273089841, 194.6783255053117);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double3 a3 = double3(350.72955982327903, 367.17843668869625, 46.941470406456574);
            double3 b3 = double3(471.6448635867074, -404.04466719368691, -144.69675476136467);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_equal_wide_scalar()
        {
            double3 a0 = double3(65.671194345537174, 404.41550440546848, -269.7301577393572);
            double b0 = (-155.8157547245807);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double3 a1 = double3(83.630607882342588, -155.86829836474186, 314.67125597348024);
            double b1 = (152.99450476141385);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double3 a2 = double3(386.36515325417986, -132.63519460178691, -65.667489797653388);
            double b2 = (290.04894007837811);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double3 a3 = double3(-69.683271678948415, 186.84520086406042, -232.89569221851218);
            double b3 = (-191.19075521789063);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_equal_scalar_wide()
        {
            double a0 = (36.383921878591195);
            double3 b0 = double3(-400.48919958644046, -71.286823544319191, 156.97811491646712);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (-225.23872791288363);
            double3 b1 = double3(499.14180993435059, -211.97992358542047, 428.31192394174263);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-489.50133322621758);
            double3 b2 = double3(-5.6915457275190988, -30.865948453017495, -362.98307221149241);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (184.50319322594589);
            double3 b3 = double3(-160.47062142215231, 316.66882315122928, 390.36923879681581);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_not_equal_wide_wide()
        {
            double3 a0 = double3(279.99414576217259, -43.342018386042696, -465.72473523846116);
            double3 b0 = double3(-460.912120318465, -476.00904844515446, 468.13642070635058);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double3 a1 = double3(317.46655645848557, 85.714987079480238, 360.89050572034466);
            double3 b1 = double3(-341.01254312182431, -62.658060341448561, -458.80166718866752);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double3 a2 = double3(366.08152668833804, 154.5428384070018, 332.426219856565);
            double3 b2 = double3(-457.73023316717251, -59.523265627922171, 3.024243117787023);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double3 a3 = double3(397.11323160543725, -431.3749584776233, 489.01079319837072);
            double3 b3 = double3(155.81276352508587, -19.839918384253963, -6.0169332055453992);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_not_equal_wide_scalar()
        {
            double3 a0 = double3(-155.44111282911206, -19.426602134214079, 174.63305409934048);
            double b0 = (-393.41354173860213);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double3 a1 = double3(507.9207296352464, 171.15146430356026, -58.923273352404692);
            double b1 = (59.177048472304364);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double3 a2 = double3(-398.17684835855704, -165.24150879925185, 270.34102333259818);
            double b2 = (492.20105361016522);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double3 a3 = double3(-380.24326222960059, -134.34545642433011, 458.40042302496749);
            double b3 = (501.8990516615562);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_not_equal_scalar_wide()
        {
            double a0 = (478.35313938481409);
            double3 b0 = double3(459.55319592894671, 436.45324369727314, -488.71416806090349);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (392.76794475725296);
            double3 b1 = double3(-266.73665369056937, 338.55788270503183, -338.10012475498957);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (-152.3145445102428);
            double3 b2 = double3(-452.82067868338, 209.43931422449612, 50.107968592135194);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (372.4343656843688);
            double3 b3 = double3(-488.0213141329686, 489.74075697816011, 270.40006149485714);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_less_wide_wide()
        {
            double3 a0 = double3(51.710243010758518, -313.85556450200062, 283.04767359562572);
            double3 b0 = double3(-261.83523881707117, -19.810742149041403, -149.25882084167506);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            double3 a1 = double3(235.02188621974642, 44.0783565249659, -207.25566659088042);
            double3 b1 = double3(205.99822316225539, -306.02438535635565, 102.12168006884008);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double3 a2 = double3(3.3829410091894943, -144.30134326978651, -69.369597705718888);
            double3 b2 = double3(231.90633760760829, 179.49885305180158, 473.22488496882136);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double3 a3 = double3(-135.66796762108243, -194.78736576567746, -33.473868147225062);
            double3 b3 = double3(15.891647107848712, 270.04990614114786, 490.91400240869916);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_less_wide_scalar()
        {
            double3 a0 = double3(-221.86977325280651, -121.54646807608498, -97.52392511140738);
            double b0 = (199.06751808853244);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double3 a1 = double3(479.88107775146193, 137.32880574899207, 282.96659601990439);
            double b1 = (67.118990214131259);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double3 a2 = double3(258.27909362422258, -288.08113278452356, 82.665427008022334);
            double b2 = (-111.41316061439608);
            bool3 r2 = bool3(false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double3 a3 = double3(-361.64292042406413, 12.788020378345664, -66.703050406045747);
            double b3 = (-68.088202269788951);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_less_scalar_wide()
        {
            double a0 = (-250.4849370692321);
            double3 b0 = double3(-377.19654887597846, -505.14754104295167, 375.92672198634909);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double a1 = (110.17393474940855);
            double3 b1 = double3(-118.09757452742082, -40.45089079833167, -299.74430932651478);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double a2 = (31.437125935888389);
            double3 b2 = double3(-458.904539560389, 13.684679276163024, -458.50690839183841);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double a3 = (248.27646624682302);
            double3 b3 = double3(389.23142999654237, 488.74553679337055, -221.63786731550368);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_greater_wide_wide()
        {
            double3 a0 = double3(-229.29066501804192, 505.536608216137, -73.80706862071861);
            double3 b0 = double3(-445.84502407808088, -420.03529210576568, 299.02440108872224);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double3 a1 = double3(100.29203777215071, -419.21478124112582, -159.55974753180504);
            double3 b1 = double3(-13.880978829171966, 151.56173593903043, -163.5094302461992);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double3 a2 = double3(-396.7703608929973, 127.03739482119556, 489.13989733585151);
            double3 b2 = double3(-391.09603733154762, 479.2837710228207, -77.674873149802409);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            double3 a3 = double3(51.91890885863404, 155.38475544535777, -135.63165027258526);
            double3 b3 = double3(-46.5841996886694, -415.37701888353422, 71.466978344818131);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_greater_wide_scalar()
        {
            double3 a0 = double3(11.156317000815761, -411.02322382993214, 385.88556188432756);
            double b0 = (-302.81693877969724);
            bool3 r0 = bool3(true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double3 a1 = double3(-485.10304831206008, 405.17534632476759, 173.57509740329124);
            double b1 = (-491.18003033622171);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double3 a2 = double3(69.269281181166548, -367.027771405423, -86.124509613087639);
            double b2 = (501.30683183172107);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double3 a3 = double3(-489.09058998948456, -18.149639853346002, -236.41493498367021);
            double b3 = (-172.51816066192379);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_greater_scalar_wide()
        {
            double a0 = (453.54610201974685);
            double3 b0 = double3(-226.20441423459187, -423.46500487973213, 409.40550227156166);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double a1 = (453.87706277048073);
            double3 b1 = double3(87.475727837288673, 113.79560308987072, 176.40926154721956);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double a2 = (-140.44002944810319);
            double3 b2 = double3(-182.48286804113673, -158.29329188088576, -162.68531830733889);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            double a3 = (-193.328676075362);
            double3 b3 = double3(230.18129955519987, -102.58784227379965, 392.5205878655056);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_less_equal_wide_wide()
        {
            double3 a0 = double3(240.09053169940159, 462.2131528622532, 293.08251561461134);
            double3 b0 = double3(-81.203838624620744, 493.63743876555816, -411.47211451617636);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            double3 a1 = double3(-427.87067361728782, -405.5227226715175, 204.59190211286386);
            double3 b1 = double3(99.164449499530974, -295.66769875943089, -480.46254824123463);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double3 a2 = double3(294.670105832941, -327.56444445604666, -456.12326667091031);
            double3 b2 = double3(74.414040361723892, 260.916124226952, 306.17329730939741);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double3 a3 = double3(282.3012408140587, 421.8811549720732, -311.71284809322697);
            double3 b3 = double3(139.56480438055689, -505.75247955031341, -489.62680958659706);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_less_equal_wide_scalar()
        {
            double3 a0 = double3(309.1924356469849, 69.673792633076118, -101.72418622939114);
            double b0 = (292.92427148154206);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double3 a1 = double3(-315.97240629604664, 424.15386577330241, -410.87006945669191);
            double b1 = (-346.01106731314724);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double3 a2 = double3(-483.90265320423185, 320.44249287268258, -257.87003791419329);
            double b2 = (183.82114538169515);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double3 a3 = double3(-386.801748694294, 349.25012962392077, 485.31159304329731);
            double b3 = (-182.9388249772316);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_less_equal_scalar_wide()
        {
            double a0 = (-511.15238141974078);
            double3 b0 = double3(51.159012579898786, 340.44369022010062, 312.81429519914752);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double a1 = (354.19252626699983);
            double3 b1 = double3(136.39671165142056, -94.767871185563422, 288.544332877055);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double a2 = (304.04282369466625);
            double3 b2 = double3(-148.61806089646092, -506.30010127755816, 27.581254256694251);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            double a3 = (48.471146844546865);
            double3 b3 = double3(104.88351326104419, -488.6858386884843, -480.43516968210935);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_greater_equal_wide_wide()
        {
            double3 a0 = double3(-386.59181302906563, -157.12078221008215, 391.01526445477054);
            double3 b0 = double3(153.44301350109424, 49.892483019219981, 78.025787628267835);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double3 a1 = double3(-511.88687133783793, -5.4220387960886569, 287.64527501149348);
            double3 b1 = double3(138.81373292711271, -225.51057802211056, -339.35611335344436);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double3 a2 = double3(-122.53520184500849, 7.4814426933794493, 152.94642765491574);
            double3 b2 = double3(-373.302078182484, 364.9358934671319, -322.71539870030961);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double3 a3 = double3(48.986223482054811, 57.338148859021317, 300.46493138953338);
            double3 b3 = double3(125.47818165900105, -25.776589167200314, 297.51890792395864);
            bool3 r3 = bool3(false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_greater_equal_wide_scalar()
        {
            double3 a0 = double3(495.457423679278, -14.345115906719627, -463.47478053694346);
            double b0 = (189.20512804258851);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            double3 a1 = double3(217.51749215718246, -377.65869706573835, 53.815095211293169);
            double b1 = (-246.86571776441565);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double3 a2 = double3(-123.33294373533357, 252.99433410027734, -116.44038277326172);
            double b2 = (-221.50546441856096);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double3 a3 = double3(-395.36331028275345, -287.00733889593153, 355.83704559683667);
            double b3 = (164.77259667439978);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_greater_equal_scalar_wide()
        {
            double a0 = (215.43534169692327);
            double3 b0 = double3(204.80295310020585, -101.10404853760451, -122.05503827056617);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double a1 = (-70.456147941973143);
            double3 b1 = double3(-239.62025677395064, -185.99272426683115, -455.61258027312);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double a2 = (276.66581476697036);
            double3 b2 = double3(79.39918831707871, 416.42054791768112, 379.27350801009379);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double a3 = (-439.51472612820322);
            double3 b3 = double3(67.141009600433108, -74.560638224035813, -367.25635474140586);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_add_wide_wide()
        {
            double3 a0 = double3(465.14837644302679, 278.91072548502621, -277.52992237616792);
            double3 b0 = double3(483.99436186440028, -204.07667193379098, -365.67356007437854);
            double3 r0 = double3(949.14273830742707, 74.834053551235229, -643.20348245054652);
            TestUtils.AreEqual(a0 + b0, r0);

            double3 a1 = double3(-65.197214395365336, -473.32437561141529, -4.6955420992782138);
            double3 b1 = double3(-509.92086076639634, -270.69751108377125, 486.76397846954126);
            double3 r1 = double3(-575.11807516176168, -744.02188669518659, 482.06843637026304);
            TestUtils.AreEqual(a1 + b1, r1);

            double3 a2 = double3(-470.53676698661258, -109.95011453980118, -178.70145782209067);
            double3 b2 = double3(267.49177587567442, 251.6425212601398, 244.4951094335388);
            double3 r2 = double3(-203.04499111093816, 141.69240672033862, 65.793651611448126);
            TestUtils.AreEqual(a2 + b2, r2);

            double3 a3 = double3(-420.03378339299644, 290.71109236903078, -446.5296368294068);
            double3 b3 = double3(-78.675763882079991, 352.20551340291536, 82.779185095233515);
            double3 r3 = double3(-498.70954727507643, 642.91660577194614, -363.75045173417328);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_add_wide_scalar()
        {
            double3 a0 = double3(459.89829728561369, -447.66336104258119, -94.438627525436971);
            double b0 = (500.99725913489112);
            double3 r0 = double3(960.89555642050482, 53.333898092309937, 406.55863160945415);
            TestUtils.AreEqual(a0 + b0, r0);

            double3 a1 = double3(126.42986279652916, -349.64130060264904, -2.7912590516690443);
            double b1 = (-36.254356162741033);
            double3 r1 = double3(90.175506633788132, -385.89565676539007, -39.045615214410077);
            TestUtils.AreEqual(a1 + b1, r1);

            double3 a2 = double3(-478.41478489265535, 268.092225914864, 41.32102133767728);
            double b2 = (443.11525246273504);
            double3 r2 = double3(-35.299532429920305, 711.207478377599, 484.43627380041232);
            TestUtils.AreEqual(a2 + b2, r2);

            double3 a3 = double3(-471.25607584009697, 78.985822952811532, 202.14799151297098);
            double b3 = (-2.6649749291431704);
            double3 r3 = double3(-473.92105076924014, 76.320848023668361, 199.4830165838278);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_add_scalar_wide()
        {
            double a0 = (-325.51276484388518);
            double3 b0 = double3(-264.08813178915909, -106.00925998855814, -355.44729320865463);
            double3 r0 = double3(-589.60089663304427, -431.52202483244332, -680.96005805253981);
            TestUtils.AreEqual(a0 + b0, r0);

            double a1 = (-447.33029362528134);
            double3 b1 = double3(-158.70021040677102, -199.48369154682553, 180.31809123806568);
            double3 r1 = double3(-606.03050403205236, -646.81398517210687, -267.01220238721567);
            TestUtils.AreEqual(a1 + b1, r1);

            double a2 = (337.57936898692481);
            double3 b2 = double3(-37.05501486596421, 230.80498014707348, -140.17433339924287);
            double3 r2 = double3(300.5243541209606, 568.38434913399828, 197.40503558768194);
            TestUtils.AreEqual(a2 + b2, r2);

            double a3 = (18.02419591789328);
            double3 b3 = double3(-138.61435825126915, 26.904163611542458, -374.53758233345);
            double3 r3 = double3(-120.59016233337587, 44.928359529435738, -356.51338641555674);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_sub_wide_wide()
        {
            double3 a0 = double3(133.37101680290471, -131.8321183341705, -197.29314407952739);
            double3 b0 = double3(123.46028739002543, 359.56010048443454, -48.24847819667707);
            double3 r0 = double3(9.9107294128792773, -491.39221881860504, -149.04466588285032);
            TestUtils.AreEqual(a0 - b0, r0);

            double3 a1 = double3(-485.286571013409, -337.55033103448818, 471.66710470228782);
            double3 b1 = double3(478.97904680621764, 207.15832886805686, 142.36730462981723);
            double3 r1 = double3(-964.26561781962664, -544.708659902545, 329.29980007247059);
            TestUtils.AreEqual(a1 - b1, r1);

            double3 a2 = double3(146.5066197600712, -130.58504372955537, 110.77707367333448);
            double3 b2 = double3(-125.60551005490379, -65.299004823574307, -477.876434787119);
            double3 r2 = double3(272.112129814975, -65.286038905981059, 588.65350846045351);
            TestUtils.AreEqual(a2 - b2, r2);

            double3 a3 = double3(-235.54160486699158, 78.879356659427, -347.68616811730254);
            double3 b3 = double3(164.50000031501986, 428.00958915614035, 72.6278169493321);
            double3 r3 = double3(-400.04160518201144, -349.13023249671335, -420.31398506663464);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_sub_wide_scalar()
        {
            double3 a0 = double3(48.936717294592768, 410.45158953706346, -364.44171612544062);
            double b0 = (-291.59041442144212);
            double3 r0 = double3(340.52713171603489, 702.04200395850557, -72.8513017039985);
            TestUtils.AreEqual(a0 - b0, r0);

            double3 a1 = double3(163.98060353285666, 110.91942339340198, 204.35834441164434);
            double b1 = (-460.06732318367222);
            double3 r1 = double3(624.04792671652888, 570.9867465770742, 664.42566759531655);
            TestUtils.AreEqual(a1 - b1, r1);

            double3 a2 = double3(180.26971420099483, -470.26204297983185, 400.53491968686455);
            double b2 = (-377.92569344952972);
            double3 r2 = double3(558.19540765052454, -92.33634953030213, 778.46061313639427);
            TestUtils.AreEqual(a2 - b2, r2);

            double3 a3 = double3(461.50756499800252, 21.605312595891405, 246.35072171238755);
            double b3 = (-246.28726660753006);
            double3 r3 = double3(707.79483160553264, 267.89257920342146, 492.63798831991761);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_sub_scalar_wide()
        {
            double a0 = (294.58645905861);
            double3 b0 = double3(452.35251757705237, 256.98980891750648, -275.159888634067);
            double3 r0 = double3(-157.76605851844238, 37.59665014110351, 569.746347692677);
            TestUtils.AreEqual(a0 - b0, r0);

            double a1 = (-89.027518075437968);
            double3 b1 = double3(488.22838829840919, -333.21728030462623, -64.232989102710519);
            double3 r1 = double3(-577.25590637384721, 244.18976222918826, -24.794528972727448);
            TestUtils.AreEqual(a1 - b1, r1);

            double a2 = (-66.041730196234653);
            double3 b2 = double3(341.20492831859963, -385.775056303374, 75.394746577085357);
            double3 r2 = double3(-407.24665851483428, 319.73332610713936, -141.43647677332);
            TestUtils.AreEqual(a2 - b2, r2);

            double a3 = (354.94371645289641);
            double3 b3 = double3(169.13141520746581, 88.216608326982964, 1.7350065716240124);
            double3 r3 = double3(185.8123012454306, 266.72710812591345, 353.2087098812724);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_mul_wide_wide()
        {
            double3 a0 = double3(-394.78053898121254, -412.37219519744264, -25.874570143350638);
            double3 b0 = double3(-149.76397831261346, -345.04538671348496, -284.33404721148963);
            double3 r0 = double3(59123.904078224172, 142287.1235617903, 7357.0212487164608);
            TestUtils.AreEqual(a0 * b0, r0);

            double3 a1 = double3(-241.04595886964626, -93.675987525692221, 244.15999257013198);
            double3 b1 = double3(267.97923648915219, -326.64849558782225, -150.68967754705329);
            double3 r1 = double3(-64595.312016683383, 30599.120397970968, -36792.390550284115);
            TestUtils.AreEqual(a1 * b1, r1);

            double3 a2 = double3(494.68846606402121, 53.537962700025105, -239.49641167349017);
            double3 b2 = double3(207.73243794577775, 366.19289248352538, 358.88076202891807);
            double3 r2 = double3(102762.84107913627, 19605.221418797286, -85950.654724573629);
            TestUtils.AreEqual(a2 * b2, r2);

            double3 a3 = double3(236.67584644848284, -211.85620818466703, -216.65482030466887);
            double3 b3 = double3(214.85359368792433, 253.42280900358355, -307.71382751488773);
            double3 r3 = double3(50850.6561485879, -53689.195383006307, 66667.684005499876);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_mul_wide_scalar()
        {
            double3 a0 = double3(328.20302191758674, -290.10672272839895, 236.99572454998065);
            double b0 = (192.21119055161773);
            double3 r0 = double3(63084.293585418032, -55761.758562653624, 45553.230371395039);
            TestUtils.AreEqual(a0 * b0, r0);

            double3 a1 = double3(120.48136692889102, 134.86723214707672, -477.31047104173825);
            double b1 = (357.90315811610924);
            double3 r1 = double3(43120.661717995856, 48269.408311817213, -170830.92498772583);
            TestUtils.AreEqual(a1 * b1, r1);

            double3 a2 = double3(-438.272912467957, -238.40500103608008, 422.08249374017237);
            double b2 = (-46.729179165665585);
            double3 r2 = double3(20480.133450173231, 11140.470007405675, -19723.568472675437);
            TestUtils.AreEqual(a2 * b2, r2);

            double3 a3 = double3(-48.83483722099794, 119.35660391643489, -196.995807977857);
            double b3 = (355.30832998608628);
            double3 r3 = double3(-17351.424458135145, 42408.39561035925, -69994.2515468721);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_mul_scalar_wide()
        {
            double a0 = (-464.534700371574);
            double3 b0 = double3(329.36093846399376, -198.68342671109525, 184.07942518223047);
            double3 r0 = double3(-152999.58486347177, 92295.346096036214, -85511.280621599);
            TestUtils.AreEqual(a0 * b0, r0);

            double a1 = (256.01618754864489);
            double3 b1 = double3(266.22629297255833, -97.894749448585685, 159.74810583877752);
            double3 r1 = double3(68158.240552042975, -25062.640534856713, 40898.101024961237);
            TestUtils.AreEqual(a1 * b1, r1);

            double a2 = (-351.82222263506719);
            double3 b2 = double3(491.80157660497423, 49.902031206480274, 424.46256871915546);
            double3 r2 = double3(-173026.72377659229, -17556.643533068374, -149335.36435216322);
            TestUtils.AreEqual(a2 * b2, r2);

            double a3 = (160.11807616060514);
            double3 b3 = double3(-395.99208492599058, 125.20168858636248, -265.01581991138676);
            double3 r3 = double3(-63405.490813176577, 20047.053508507553, -42433.823236336641);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_div_wide_wide()
        {
            double3 a0 = double3(246.26574933075619, -269.85612953354428, -451.61952588130697);
            double3 b0 = double3(172.11981423763552, -77.141104972521362, -325.8353723612779);
            double3 r0 = double3(1.4307809383918566, 3.4982144685336105, 1.3860359070548143);
            TestUtils.AreEqual(a0 / b0, r0);

            double3 a1 = double3(-7.38850236283082, -308.20558681534862, -373.394808704683);
            double3 b1 = double3(-450.60868117334724, -261.26215398556656, -122.44949847201326);
            double3 r1 = double3(0.016396715535066435, 1.1796794220427942, 3.0493780159501847);
            TestUtils.AreEqual(a1 / b1, r1);

            double3 a2 = double3(360.41863482092447, 25.80972458133931, -274.050461181463);
            double3 b2 = double3(-93.210781379235357, -442.00522705633438, 484.36271380091216);
            double3 r2 = double3(-3.8667054335113131, -0.05839235149599218, -0.56579594872388561);
            TestUtils.AreEqual(a2 / b2, r2);

            double3 a3 = double3(127.53858977534742, -447.6717600522897, -137.4586017771897);
            double3 b3 = double3(-390.78178686219348, 402.02531714086672, 316.65072193585831);
            double3 r3 = double3(-0.32636779415802974, -1.1135412148569459, -0.43410165287743668);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_div_wide_scalar()
        {
            double3 a0 = double3(-244.51745116175965, 69.112274917360537, -333.02311888943575);
            double b0 = (-60.024377612408443);
            double3 r0 = double3(4.0736357608014941, -1.1514034408425655, 5.5481311449798705);
            TestUtils.AreEqual(a0 / b0, r0);

            double3 a1 = double3(257.39682519500923, 154.34436066185322, 131.52659160062979);
            double b1 = (403.24561257066466);
            double3 r1 = double3(0.63831277308665835, 0.38275521382097105, 0.32616992597180733);
            TestUtils.AreEqual(a1 / b1, r1);

            double3 a2 = double3(-261.88639200007844, -275.53868187383688, 210.55792174607416);
            double b2 = (-348.92380516087815);
            double3 r2 = double3(0.75055467161184541, 0.78968152300985706, -0.60344957446796244);
            TestUtils.AreEqual(a2 / b2, r2);

            double3 a3 = double3(287.64239968342815, 491.78708600056689, -26.63160015392657);
            double b3 = (504.37224626185946);
            double3 r3 = double3(0.57029783421923308, 0.97504787316398334, -0.052801478176695719);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_div_scalar_wide()
        {
            double a0 = (41.737658758525527);
            double3 b0 = double3(-422.676129776368, 248.12963235011773, 449.39137741988122);
            double3 r0 = double3(-0.098746193168297289, 0.1682090863683405, 0.092875967042706856);
            TestUtils.AreEqual(a0 / b0, r0);

            double a1 = (245.85813796047967);
            double3 b1 = double3(-326.62061253498337, 163.71510489457989, 333.664472020075);
            double3 r1 = double3(-0.75273307478151441, 1.5017437646867933, 0.73684242278478951);
            TestUtils.AreEqual(a1 / b1, r1);

            double a2 = (38.291076916405473);
            double3 b2 = double3(-472.97976062864984, 192.23013958345643, -200.29686960964318);
            double3 r2 = double3(-0.080957115089896864, 0.19919392973119834, -0.19117161936195318);
            TestUtils.AreEqual(a2 / b2, r2);

            double a3 = (-490.18150376257557);
            double3 b3 = double3(-211.10257468517057, -322.85234108700058, -137.98529035317961);
            double3 r3 = double3(2.3220062781972768, 1.5182838758802248, 3.5524185404685804);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_mod_wide_wide()
        {
            double3 a0 = double3(-442.30985924336585, 368.50046246522129, -1.0938966279355213);
            double3 b0 = double3(-43.245045443645211, -144.19587690392319, -62.640481739603217);
            double3 r0 = double3(-9.8594048069137443, 80.1087086573749, -1.0938966279355213);
            TestUtils.AreEqual(a0 % b0, r0);

            double3 a1 = double3(-364.67383473211612, -197.34394487987458, -34.034902350062);
            double3 b1 = double3(-336.82826510855381, -154.6102545981343, -154.02935583611452);
            double3 r1 = double3(-27.845569623562312, -42.73369028174028, -34.034902350062);
            TestUtils.AreEqual(a1 % b1, r1);

            double3 a2 = double3(-101.34858350704826, 208.31857142612273, -140.77031404374645);
            double3 b2 = double3(487.0462093237071, -469.82909105244516, -145.20377237405802);
            double3 r2 = double3(-101.34858350704826, 208.31857142612273, -140.77031404374645);
            TestUtils.AreEqual(a2 % b2, r2);

            double3 a3 = double3(183.446989383291, -463.36838100076113, 83.839106360375467);
            double3 b3 = double3(-203.38401780062543, -22.520082245823062, 224.6900237652892);
            double3 r3 = double3(183.446989383291, -12.966736084299896, 83.839106360375467);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_mod_wide_scalar()
        {
            double3 a0 = double3(-433.41699548876704, -5.5141427542614565, 393.39439958771425);
            double b0 = (-90.499235433758827);
            double3 r0 = double3(-71.420053753731736, -5.5141427542614565, 31.39745785267894);
            TestUtils.AreEqual(a0 % b0, r0);

            double3 a1 = double3(299.41153277988155, -502.939041133476, -450.80766245853511);
            double b1 = (-120.80601626299602);
            double3 r1 = double3(57.799500253889505, -19.714976081491898, -88.389613669547032);
            TestUtils.AreEqual(a1 % b1, r1);

            double3 a2 = double3(186.09479698263794, -318.78148356023314, 433.45469041981482);
            double b2 = (-84.473635951277629);
            double3 r2 = double3(17.147525080082687, -65.360575706400255, 11.086510663426679);
            TestUtils.AreEqual(a2 % b2, r2);

            double3 a3 = double3(-54.6001856581309, -429.71466728193434, 222.36186109406958);
            double b3 = (-172.33886607565864);
            double3 r3 = double3(-54.6001856581309, -85.036935130617053, 50.022995018410938);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_mod_scalar_wide()
        {
            double a0 = (-396.4224028049141);
            double3 b0 = double3(-159.14024384279747, 230.17333399046834, 14.779358632294134);
            double3 r0 = double3(-78.141915119319151, -166.24906881444576, -12.159078365266623);
            TestUtils.AreEqual(a0 % b0, r0);

            double a1 = (-303.15649738123477);
            double3 b1 = double3(399.63502020371845, 206.69470534412881, 397.04482263934096);
            double3 r1 = double3(-303.15649738123477, -96.461792037105965, -303.15649738123477);
            TestUtils.AreEqual(a1 % b1, r1);

            double a2 = (-393.89064735634747);
            double3 b2 = double3(-372.06709426085797, 201.01229796233224, -95.5668547598491);
            double3 r2 = double3(-21.8235530954895, -192.87834939401523, -11.6232283169511);
            TestUtils.AreEqual(a2 % b2, r2);

            double a3 = (-258.95146882671463);
            double3 b3 = double3(106.98357563232241, 469.3235559264773, -34.808985011097491);
            double3 r3 = double3(-44.984317562069805, -258.95146882671463, -15.288573749032196);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double3_operator_plus()
        {
            double3 a0 = double3(271.6708086802023, -79.080240524876956, -330.98506203805334);
            double3 r0 = double3(271.6708086802023, -79.080240524876956, -330.98506203805334);
            TestUtils.AreEqual(+a0, r0);

            double3 a1 = double3(31.824682965793045, 319.22218742930431, 190.32466015141677);
            double3 r1 = double3(31.824682965793045, 319.22218742930431, 190.32466015141677);
            TestUtils.AreEqual(+a1, r1);

            double3 a2 = double3(-350.30858270745193, 102.0544069288552, -107.00351267075331);
            double3 r2 = double3(-350.30858270745193, 102.0544069288552, -107.00351267075331);
            TestUtils.AreEqual(+a2, r2);

            double3 a3 = double3(-428.77622075973835, 234.77393042052813, 34.283600107898792);
            double3 r3 = double3(-428.77622075973835, 234.77393042052813, 34.283600107898792);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void double3_operator_neg()
        {
            double3 a0 = double3(420.22718854445372, -196.25749811728366, -335.42683068636188);
            double3 r0 = double3(-420.22718854445372, 196.25749811728366, 335.42683068636188);
            TestUtils.AreEqual(-a0, r0);

            double3 a1 = double3(509.04366969924592, -498.57532071442125, -495.8379526063045);
            double3 r1 = double3(-509.04366969924592, 498.57532071442125, 495.8379526063045);
            TestUtils.AreEqual(-a1, r1);

            double3 a2 = double3(-270.85946787095605, 268.23670662019254, -180.60051473444349);
            double3 r2 = double3(270.85946787095605, -268.23670662019254, 180.60051473444349);
            TestUtils.AreEqual(-a2, r2);

            double3 a3 = double3(223.38126312167446, -395.68154186554324, -349.14948885010062);
            double3 r3 = double3(-223.38126312167446, 395.68154186554324, 349.14948885010062);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void double3_operator_prefix_inc()
        {
            double3 a0 = double3(-99.79557113526181, 458.74185082816609, 96.179026886904126);
            double3 r0 = double3(-98.79557113526181, 459.74185082816609, 97.179026886904126);
            TestUtils.AreEqual(++a0, r0);

            double3 a1 = double3(-48.552469514567633, -299.23014583216525, -323.61485853959567);
            double3 r1 = double3(-47.552469514567633, -298.23014583216525, -322.61485853959567);
            TestUtils.AreEqual(++a1, r1);

            double3 a2 = double3(-456.89028832730384, -305.58477344437722, 64.0964734852763);
            double3 r2 = double3(-455.89028832730384, -304.58477344437722, 65.0964734852763);
            TestUtils.AreEqual(++a2, r2);

            double3 a3 = double3(148.67930967578627, -115.5592263283018, -326.87781992874937);
            double3 r3 = double3(149.67930967578627, -114.5592263283018, -325.87781992874937);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void double3_operator_postfix_inc()
        {
            double3 a0 = double3(322.94356623429042, 472.05246542024076, 203.48761925636211);
            double3 r0 = double3(322.94356623429042, 472.05246542024076, 203.48761925636211);
            TestUtils.AreEqual(a0++, r0);

            double3 a1 = double3(-49.854570650427888, 455.33662459595905, 271.45466840986842);
            double3 r1 = double3(-49.854570650427888, 455.33662459595905, 271.45466840986842);
            TestUtils.AreEqual(a1++, r1);

            double3 a2 = double3(55.736877228942149, -174.17301925186672, -427.40105100506969);
            double3 r2 = double3(55.736877228942149, -174.17301925186672, -427.40105100506969);
            TestUtils.AreEqual(a2++, r2);

            double3 a3 = double3(215.11022744658874, -333.05045262586816, 241.46487509527469);
            double3 r3 = double3(215.11022744658874, -333.05045262586816, 241.46487509527469);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void double3_operator_prefix_dec()
        {
            double3 a0 = double3(-416.20121712992022, -96.637880131899351, -50.145671629414721);
            double3 r0 = double3(-417.20121712992022, -97.637880131899351, -51.145671629414721);
            TestUtils.AreEqual(--a0, r0);

            double3 a1 = double3(-207.31644759295341, -304.40081920493435, 337.96895734312432);
            double3 r1 = double3(-208.31644759295341, -305.40081920493435, 336.96895734312432);
            TestUtils.AreEqual(--a1, r1);

            double3 a2 = double3(246.08898293510492, -227.44280134301761, 298.28480710568135);
            double3 r2 = double3(245.08898293510492, -228.44280134301761, 297.28480710568135);
            TestUtils.AreEqual(--a2, r2);

            double3 a3 = double3(326.50782338087811, -478.03137253133178, -326.45297852459038);
            double3 r3 = double3(325.50782338087811, -479.03137253133178, -327.45297852459038);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void double3_operator_postfix_dec()
        {
            double3 a0 = double3(-376.59242719066907, 16.969734438215255, -0.25066399585949739);
            double3 r0 = double3(-376.59242719066907, 16.969734438215255, -0.25066399585949739);
            TestUtils.AreEqual(a0--, r0);

            double3 a1 = double3(-202.32328734282555, 47.856652520530247, -281.11170376516492);
            double3 r1 = double3(-202.32328734282555, 47.856652520530247, -281.11170376516492);
            TestUtils.AreEqual(a1--, r1);

            double3 a2 = double3(-262.062590959511, 450.12809559801974, -129.23265582380475);
            double3 r2 = double3(-262.062590959511, 450.12809559801974, -129.23265582380475);
            TestUtils.AreEqual(a2--, r2);

            double3 a3 = double3(-332.15495768755443, 205.46112570793423, -230.22777878038016);
            double3 r3 = double3(-332.15495768755443, 205.46112570793423, -230.22777878038016);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void double3_shuffle_result_1()
        {
            double3 a = double3(0, 1, 2);
            double3 b = double3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ), (5));
        }

        [TestCompiler]
        public static void double3_shuffle_result_2()
        {
            double3 a = double3(0, 1, 2);
            double3 b = double3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), double2(4, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), double2(4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), double2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftZ), double2(5, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY), double2(5, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), double2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftZ), double2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX), double2(5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ), double2(5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), double2(4, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightZ), double2(4, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX), double2(5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), double2(4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY), double2(5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), double2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), double2(1, 2));
        }

        [TestCompiler]
        public static void double3_shuffle_result_3()
        {
            double3 a = double3(0, 1, 2);
            double3 b = double3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightZ, ShuffleComponent.RightX), double3(1, 5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftZ), double3(4, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX), double3(2, 5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftY), double3(4, 0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY, ShuffleComponent.LeftZ), double3(5, 4, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.LeftY), double3(2, 0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightX), double3(2, 4, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftY, ShuffleComponent.RightZ), double3(2, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightZ), double3(4, 4, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY), double3(4, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), double3(5, 5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightX), double3(5, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightZ), double3(4, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.RightY), double3(2, 3, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), double3(4, 0, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightZ), double3(4, 0, 5));
        }

        [TestCompiler]
        public static void double3_shuffle_result_4()
        {
            double3 a = double3(0, 1, 2);
            double3 b = double3(3, 4, 5);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.LeftY), double4(1, 2, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightY), double4(4, 2, 5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightZ, ShuffleComponent.LeftY), double4(4, 4, 5, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), double4(3, 3, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftX), double4(4, 1, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightZ), double4(3, 4, 3, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightZ), double4(1, 5, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), double4(4, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightZ, ShuffleComponent.LeftZ, ShuffleComponent.LeftX), double4(3, 5, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), double4(4, 3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), double4(0, 2, 5, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightZ, ShuffleComponent.RightZ), double4(1, 4, 5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), double4(2, 3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftZ), double4(3, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(5, 3, 0, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightY), double4(2, 5, 0, 4));
        }


    }
}