using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Aoc2017.Tests
{

    public class TestDataClass
    {
        private static readonly Dictionary<int, string> Inputs = new Dictionary<int, string>();
        static TestDataClass()
        {
            Inputs.Add(1, "878938232157342756754254716586975125394865297349321236586574662994429894259828536842781199252169182743449435231194436368218599463391544461745472922916562414854275449983442828344463893618282425242643322822916857935242141636187859919626885791572268272442711988367762865741341467274718149255173686839265874184176985561996454253165784192929453678326937728571781212155346592432874244741816166328693958529938367575669663228335566435273484331452883175981955679335327231995452231118936393192583338222595982522833468533262224874637449624644318418748617949417939228988293391941457722641936417456243894182668197174255786445994567477582715692336249243254711653529871336129825735249667425238573952339922948214218872417858525199642194588448543565474847272984232637466664695217176358283788781843171636841215675851778984619377575696447366844854289534215286959727688419731976631323833892247438149829975856161755122857643731945913335556288817112993911694972667656914238999291831997163412548977649491227219477796124134958527843213824792685117696631512141241496451845758655276186597724748432996276498527911292531185292149948139724345841584782352214921634858734671118495424143437282979243347831258285851259579133433182387444656386679831584933397915132785411686688447731696776459621924821667112751789884987883991845818513249994767543526169463766975791464756526911587399764736557959464923353896921342944821833991457125256329564489631352268722457628514564128231487382111682976886838192412996932924373337524262135399256658638418515239876732866596731888779532573243713128238419234963195589987539467221517535272384899524386267268959484881379944796392255419838743164714275463459351741296586465213689853743856518583451849661592844879264196761867481258778393623584884535246239794178981387632311238115362178576899121425428114696158652976277392224226268242332589546757477683398264294929442592131949398261884548427951472128841328376819241955153423452531538413492577262348369581399925647624623868299468436859667152463974949436359589931136236247929554899679139746162554183855278713574244211854227829969443151478986413333429144796664423754818256172862812877688675514142265239992529776262844329188218189254491238956497568");
            Inputs.Add(2, @"3458	3471	163	1299	170	4200	2425	167	3636	4001	4162	115	2859	130	4075	4269
2777	2712	120	2569	2530	3035	1818	32	491	872	113	92	2526	477	138	1360
2316	35	168	174	1404	1437	2631	1863	1127	640	1745	171	2391	2587	214	193
197	2013	551	1661	121	206	203	174	2289	843	732	2117	360	1193	999	2088
3925	3389	218	1134	220	171	1972	348	3919	3706	494	3577	3320	239	120	2508
239	947	1029	2024	733	242	217	1781	2904	2156	1500	3100	497	2498	3312	211
188	3806	3901	261	235	3733	3747	3721	267	3794	3814	3995	3004	915	4062	3400
918	63	2854	2799	178	176	1037	487	206	157	2212	2539	2816	2501	927	3147
186	194	307	672	208	351	243	180	619	749	590	745	671	707	334	224
1854	3180	1345	3421	478	214	198	194	4942	5564	2469	242	5248	5786	5260	4127
3780	2880	236	330	3227	1252	3540	218	213	458	201	408	3240	249	1968	2066
1188	696	241	57	151	609	199	765	1078	976	1194	177	238	658	860	1228
903	612	188	766	196	900	62	869	892	123	226	57	940	168	165	103
710	3784	83	2087	2582	3941	97	1412	2859	117	3880	411	102	3691	4366	4104
3178	219	253	1297	3661	1552	8248	678	245	7042	260	581	7350	431	8281	8117
837	80	95	281	652	822	1028	1295	101	1140	88	452	85	444	649	1247");

            Inputs.Add(3, "ToBeFilled");
            Inputs.Add(4, "ToBeFilled");
            Inputs.Add(5, "ToBeFilled");
            Inputs.Add(6, "ToBeFilled");
            Inputs.Add(7, "ToBeFilled");
            Inputs.Add(8, "ToBeFilled");
            Inputs.Add(9, "ToBeFilled");
            Inputs.Add(10, "ToBeFilled");
            Inputs.Add(11, "ToBeFilled");
            Inputs.Add(12, "ToBeFilled");
            Inputs.Add(13, "ToBeFilled");
            Inputs.Add(14, "ToBeFilled");
            Inputs.Add(15, "ToBeFilled");
            Inputs.Add(16, "ToBeFilled");
            Inputs.Add(17, "ToBeFilled");
            Inputs.Add(18, "ToBeFilled");
            Inputs.Add(19, "ToBeFilled");
            Inputs.Add(20, "ToBeFilled");
            Inputs.Add(21, "ToBeFilled");
            Inputs.Add(22, "ToBeFilled");
            Inputs.Add(23, "ToBeFilled");
            Inputs.Add(24, "ToBeFilled");
            Inputs.Add(25, "ToBeFilled");
            Inputs.Add(26, "ToBeFilled");
            Inputs.Add(27, "ToBeFilled");
            Inputs.Add(28, "ToBeFilled");
            Inputs.Add(29, "ToBeFilled");
            Inputs.Add(30, "ToBeFilled");
            Inputs.Add(31, "ToBeFilled");

        }



        public static IEnumerable TcD01P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData("1234").Returns(0);
                yield return new TestCaseData("1111").Returns(4);
                yield return new TestCaseData("1122").Returns(3);
                yield return new TestCaseData("91212129").Returns(9);
                yield return new TestCaseData(Inputs[1]).Returns(1175);
            }
        }
        public static IEnumerable TcD01P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData("1212").Returns(6);
                yield return new TestCaseData("1221").Returns(0);
                yield return new TestCaseData("123425").Returns(4);
                yield return new TestCaseData("123123").Returns(12);
                yield return new TestCaseData("12131415").Returns(4);
                yield return new TestCaseData(Inputs[1]).Returns(1166);
            }
        }
        public static IEnumerable TcD02P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(@"5 1 9 5
7 5 3
2 4 6 8").Returns(18);
                yield return new TestCaseData(Inputs[2]).Returns(51139);
            }
        }
        public static IEnumerable TcD02P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(@"5 9 2 8
9 4 7 3
3 8 6 5").Returns(9);
                yield return new TestCaseData(Inputs[2]).Returns(272);
            }
        }

        public static IEnumerable TcD03P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[3]).Returns(-1);
            }
        }
        public static IEnumerable TcD03P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[3]).Returns(-1);
            }
        }
        public static IEnumerable TcD04P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[4]).Returns(-1);
            }
        }
        public static IEnumerable TcD04P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[4]).Returns(-1);
            }
        }
        public static IEnumerable TcD05P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[5]).Returns(-1);
            }
        }
        public static IEnumerable TcD05P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[5]).Returns(-1);
            }
        }
        public static IEnumerable TcD06P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[6]).Returns(-1);
            }
        }
        public static IEnumerable TcD06P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[6]).Returns(-1);
            }
        }
        public static IEnumerable TcD07P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[7]).Returns(-1);
            }
        }
        public static IEnumerable TcD07P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[7]).Returns(-1);
            }
        }
        public static IEnumerable TcD08P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[8]).Returns(-1);
            }
        }
        public static IEnumerable TcD08P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[8]).Returns(-1);
            }
        }
        public static IEnumerable TcD09P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[9]).Returns(-1);
            }
        }
        public static IEnumerable TcD09P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[9]).Returns(-1);
            }
        }
        public static IEnumerable TcD10P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[10]).Returns(-1);
            }
        }
        public static IEnumerable TcD10P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[10]).Returns(-1);
            }
        }
        public static IEnumerable TcD11P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[11]).Returns(-1);
            }
        }
        public static IEnumerable TcD11P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[11]).Returns(-1);
            }
        }
        public static IEnumerable TcD12P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[12]).Returns(-1);
            }
        }
        public static IEnumerable TcD12P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[12]).Returns(-1);
            }
        }
        public static IEnumerable TcD13P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[13]).Returns(-1);
            }
        }
        public static IEnumerable TcD13P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[13]).Returns(-1);
            }
        }
        public static IEnumerable TcD14P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[14]).Returns(-1);
            }
        }
        public static IEnumerable TcD14P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[14]).Returns(-1);
            }
        }
        public static IEnumerable TcD15P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[15]).Returns(-1);
            }
        }
        public static IEnumerable TcD15P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[15]).Returns(-1);
            }
        }
        public static IEnumerable TcD16P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[16]).Returns(-1);
            }
        }
        public static IEnumerable TcD16P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[16]).Returns(-1);
            }
        }
        public static IEnumerable TcD17P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[17]).Returns(-1);
            }
        }
        public static IEnumerable TcD17P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[17]).Returns(-1);
            }
        }
        public static IEnumerable TcD18P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[18]).Returns(-1);
            }
        }
        public static IEnumerable TcD18P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[18]).Returns(-1);
            }
        }
        public static IEnumerable TcD19P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[19]).Returns(-1);
            }
        }
        public static IEnumerable TcD19P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[19]).Returns(-1);
            }
        }
        public static IEnumerable TcD20P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[20]).Returns(-1);
            }
        }
        public static IEnumerable TcD20P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[20]).Returns(-1);
            }
        }
        public static IEnumerable TcD21P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[21]).Returns(-1);
            }
        }
        public static IEnumerable TcD21P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[21]).Returns(-1);
            }
        }
        public static IEnumerable TcD22P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[22]).Returns(-1);
            }
        }
        public static IEnumerable TcD22P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[22]).Returns(-1);
            }
        }
        public static IEnumerable TcD23P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[23]).Returns(-1);
            }
        }
        public static IEnumerable TcD23P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[23]).Returns(-1);
            }
        }
        public static IEnumerable TcD24P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[24]).Returns(-1);
            }
        }
        public static IEnumerable TcD24P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[24]).Returns(-1);
            }
        }
        public static IEnumerable TcD25P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[25]).Returns(-1);
            }
        }
        public static IEnumerable TcD25P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[25]).Returns(-1);
            }
        }
        public static IEnumerable TcD26P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[26]).Returns(-1);
            }
        }
        public static IEnumerable TcD26P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[26]).Returns(-1);
            }
        }
        public static IEnumerable TcD27P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[27]).Returns(-1);
            }
        }
        public static IEnumerable TcD27P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[27]).Returns(-1);
            }
        }
        public static IEnumerable TcD28P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[28]).Returns(-1);
            }
        }
        public static IEnumerable TcD28P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[28]).Returns(-1);
            }
        }
        public static IEnumerable TcD29P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[29]).Returns(-1);
            }
        }
        public static IEnumerable TcD29P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[29]).Returns(-1);
            }
        }
        public static IEnumerable TcD30P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[30]).Returns(-1);
            }
        }
        public static IEnumerable TcD30P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[30]).Returns(-1);
            }
        }
        public static IEnumerable TcD31P1
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[31]).Returns(-1);
            }
        }
        public static IEnumerable TcD31P2
        {
            get
            {
                yield return new TestCaseData("").Returns(0);
                yield return new TestCaseData(Inputs[31]).Returns(-1);
            }
        }


    }
}
