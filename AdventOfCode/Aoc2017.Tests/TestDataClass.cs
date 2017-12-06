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
            #region 01
            Inputs.Add(1, "878938232157342756754254716586975125394865297349321236586574662994429894259828536842781199252169182743449435231194436368218599463391544461745472922916562414854275449983442828344463893618282425242643322822916857935242141636187859919626885791572268272442711988367762865741341467274718149255173686839265874184176985561996454253165784192929453678326937728571781212155346592432874244741816166328693958529938367575669663228335566435273484331452883175981955679335327231995452231118936393192583338222595982522833468533262224874637449624644318418748617949417939228988293391941457722641936417456243894182668197174255786445994567477582715692336249243254711653529871336129825735249667425238573952339922948214218872417858525199642194588448543565474847272984232637466664695217176358283788781843171636841215675851778984619377575696447366844854289534215286959727688419731976631323833892247438149829975856161755122857643731945913335556288817112993911694972667656914238999291831997163412548977649491227219477796124134958527843213824792685117696631512141241496451845758655276186597724748432996276498527911292531185292149948139724345841584782352214921634858734671118495424143437282979243347831258285851259579133433182387444656386679831584933397915132785411686688447731696776459621924821667112751789884987883991845818513249994767543526169463766975791464756526911587399764736557959464923353896921342944821833991457125256329564489631352268722457628514564128231487382111682976886838192412996932924373337524262135399256658638418515239876732866596731888779532573243713128238419234963195589987539467221517535272384899524386267268959484881379944796392255419838743164714275463459351741296586465213689853743856518583451849661592844879264196761867481258778393623584884535246239794178981387632311238115362178576899121425428114696158652976277392224226268242332589546757477683398264294929442592131949398261884548427951472128841328376819241955153423452531538413492577262348369581399925647624623868299468436859667152463974949436359589931136236247929554899679139746162554183855278713574244211854227829969443151478986413333429144796664423754818256172862812877688675514142265239992529776262844329188218189254491238956497568");
            #endregion
            #region 02
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
            #endregion
            #region 03
            Inputs.Add(3, "368078");
            #endregion
            #region 04
            Inputs.Add(4, @"sayndz zfxlkl attjtww cti sokkmty brx fhh suelqbp
xmuf znkhaes pggrlp zia znkhaes znkhaes
nti rxr bogebb zdwrin
sryookh unrudn zrkz jxhrdo gctlyz
bssqn wbmdc rigc zketu ketichh enkixg bmdwc stnsdf jnz mqovwg ixgken
flawt cpott xth ucwgg xce jcubx wvl qsysa nlg
qovcqn zxcz vojsno nqoqvc hnf gqewlkd uevax vuna fxjkbll vfge
qrzf phwuf ligf xgen vkig elptd njdm gvqiu epfzsvk urbltg dqg
sfpku viwihi fje umdkwvi ejzhzj qrbl sfpku sad nawnow ksnku
nzhj mfudick ueaa jnhz kpy pzk
euiin xvl elaoelu wbdd xlv jtm nohtq gfdbgdg gdfggdb edtym
xfmkn wyww woe hwysuh gjw dtk utryasc dela eluk vmmun
nmag qfwe cwslmgd nlhf hpf
ifs sszo iod isf jna
pjptwg wreera leyb hmlbpf qcrbma ylgue
rwlpo jhla rprxvgs quguh pyybwgl qqvcb
rxtcpdy wmpci mpcwi vwvdzdn nfpnj rcsxinl itatg ycy hrctg ron wveju
zmkfn wip pyiz pyiz tnyg dvftf elks ezhotbj wip
sgmtfdd xdl sch sch yaxzh wphgksh knzrixp yaxzh etm czqbaa jldta
gnbr rnpd upe eeb sbq sbq oxc rwvugoj
cshk thcc emfxx emfxx pbtcf jpim vltkqar czy iudkac jhpcc nqs
uzbvx fkiuyk izxdiu yutntvn dixuzi hkyfnud oyz ynutntv
ewl mfns idy fphu yqccb pte unukirt unukirt fdx
lzn tin fgena qbql qycbdw gbtn lctlysx adhjfq blu aiv
ites ites pbxzunl vljzh lqgerta pbxzunl
vmk wjfzvhn pqkidze qfwh
tqprmc exypl caf kwikh mdyyljc pbo hhxxo skna
sqxgejb ejc fvup hpesvs luz fcxqwhr ypxof fxlcp pxyk xiczjri
vjg qcw fsyqaoj mxf jha feclqqr vzdqnk verw mvmvm pvdqtcd xsfu
fwwn ktvdh aecfv acfve yjozxwo cnujw bcgde lphnk knlph bqwlqju
uwwapm dlln uwwapm uwwapm
huupab ewetcte huupab ewetcte
wjs zipivpd klwafr ipcczg wbv uujstsw hykn
mgojdyh hlm xruta lbmaxit pabqrnp vkyigd ptpzr glin gfau pbo
tbwx baqxq vtz jwex tvz tzv
efopwx wfknzb ogaxln tqzrh jne zugd zpxikma
rdjsa arjds hqdldw fjrtl midt qjv jfrlt
dggqohj bidaaty iah lgmug wwmlbc lggmu laonaoq erkqrb tqolnns iygv qnonlst
msc glwn xjfnij itt pka irrafjd euazydj silo
zsyut znsht ldky zsyut dzcdft znsht
iit cyteu pib fgvrs iux ffctql pib zuzp zsbb ieoi
xxtwlu kqfxjhq isj xqjhfkq dohrs haovzc cgfwfrt munqon vuyexz nouqnm
eptpqgi uiflvd acj livzq ejtt bniud cjdh jkrcken lspfy tpxri zibj
zxme dpo fumup gly bkdcwxn lsly eglhe
uoshw ijoyiql rcskaa vjbqv roiinzi fppqdu
xuw vdbxie oypcx khxq xebjt oypcx uitqep vdbxie hoz
lrjv tdksk uebo wktebvx nlapmp udhhxh uliqbm cklyyf jlzw xrmdlvx
fosspck fosspck fosspck qyidyur hxnxmb dkpj
rmrvlms susvos idw hzy idw tjgxbc lhgqxr tjgxbc uuq
etjmbdr hwqe lnfwzni lnfwzni good eisci etjmbdr
yqde bmlcc yuel vpyplss vyvhho kslgiu lllhc jtkijdj uclz hfbqsf
tlohlvv tlohlvv bdqahw tlohlvv qavcqrn penia saafy
lvtzyt qffe eaikhv eaikhv wbnl mdkg mdkg utfrm
luowwk magp luowwk oyao oyao hsb yms
gnxply vsdqum nprf jik axdp ariqjpc hjqcc
izbo nkqkb xpqg pgxq qpxg gpm jxbkvu resj
hsgyxar hvsl ner zzmcn lcpdvqn ern
rfjlhu xkyh hafs cvvk drg vjsk mymc iab ycmlubx kpwemiw
wlci qhhpr vhpr oyrili cnynh sivdso ldjya wilc ioiyrl
cdfwd mbtk sienxui jsmxzo yxbeyl bybtc covxaq yuxn ktbvztl ktbvztl rcekjhk
ptenhqv tzdt phetqvn mfkdz
hmezeak pqvqld amsih jxqacc uferfyh nfqjsz rtuqdzz pohcx qia cpxho hgpqs
iygny dluc uxqz nlujm xkdtlm xbdgepg jwn ohl wpfll
lnqf pcxy cpit enp zpj lqfn oowgw yoxdff ohvcfcf fuvz qkpmb
oydu jlscilm pzxen nmtdngu tslcupx ntdgmun uztpx nlhh jqn llsv
euyx epn gyvg cwtoe ruyap yaurp uryap obbl ovo
pgo irm ksrxe qotuygd afwh qfhzfsr wafh dqjbwce dzfo hew skrxe
dpvel dpvel ipljjxs vrrsob iakey uheuu swxu qmnmn mpjkb jqrwfmv jozj
sempz plzxqe qvyg sempz fejux
cqgqvg zhqir rqzih vyu fmb mfb
uejl kjh ayz dzimg yzafvg dem vlogg
htfkd htfkd hwykmm htfkd
oxvgq wtai rkyyxya ldkecdv
lvlrsu rsullv pptnrwi slvulr vxrk dpzti
gde ixwoz nnsx nhc nzi
dsadkj qtgya wco psyondq jayad crc lswwm purrad pof
nocibgs hxqdejv nlqxdpu dvzd
jfaws aiwnjm tqjpgs fuiobz gwnemv hjevs xkbbgiq sakgv zmwpkuq grjllw
xrr jwhtchs boaqkg wjhdr xrr
vyapct tgw juzgwkz odddvof juzgwkz
unuu kubdd dxr drwg
qpefzz iemo fwa vhdcxx
hseqy copss gytzub lxi mrxtwc hxqqdfx ijt kcy tafjs jit
uevse rrq zmwyjfe xljx lhgnyzt rngvwqd
gfvpyhq xpdhind eocgpiz ebs pcmsgjy swni iwns thspnh yvbzxz fgb
hxr ehw ekfd ncxcs gxjmd oqszdjp fgu gwuoafw zumenf qltbw whzuxov
wfc pawqo pim jxgt dtiwzil hdptivc slkazm htafjih hzheez rkk amy
mgoatiy pkec ddvwyni zuya aqrcjes ubkaeus nuhhad upe qfem bpcc
rmyeg qfq bia lzk fusqfb ltvgry vggr xaxi avwdkbg zhlzt
zkjoeee dyi sxdwfqa irqljmw gek dgdb mrakr ddaznn zlh ajzzacf juv
kmqcy pohbej hujdgao rsxfkn vlu
scnpa hvl cybql lvh lbcyq msw deqqb yjpsndq
ndhjooo dpf ziey jtjlc eesag ldhgoif
tysbae wkpst kjz stpkw sil yetsba
ghvlfq flhvgq tgkjie gqlvfh
oimn vlmsljl ocala vokhrs odyv msn dzly wcky
cfjwmh rpsdor bttnkg jxenm mwdk mer jgsusdz cslf
ialvxk bvc qjfikr caw puhmmfl xpmsx
tyoey egcf dijg vywd enued uxkshz nav bdrn hjugffi iobqwiy
eykhxck shpfjhk vlqg alkenz kuj okxs oeth mqbr nfvqvkv xfvyi mboo
zbw curcajm mel jxqcw mpdscxq rhadty zrddeh wmedc wkcwt yvwm
iee hzeofmh pqlkkb azlam fpj hzeofmh ripi
sawaqek oyoiwtb npq pisadk nnd bzgo wiqme lxnvn
obqx ffiegn obxq for xobq
zwway wwazy aqxg gaxq
ebssilw nuscati mofyc sogyacc yujmdwu ehxsx qcaf udvoo nlcfaz eov
vnbe wtzzjn bczyxt crmvas zujy kukq zujy kukq
gvltk kgltv kglvt zflikic
hby pium gut fjqn sksoqyq kcliapa
tbonrr prf vga jqgw ulze ukfig
zafixw hia omgwoi noeiox fqbket iviidgp bebune kwcuotp slvy wcx
fjq cyecn fhxvj byv kojvj iaqd aaxva rkogp
vqbbt sjmr mxu mxu rlfj yqhtzv cuar yde yrs sjmr
iyxiyp auepgw dtpbyvu thuoai fpsfkpn bemgbsk lni ozy jogp xldyvvx fpsfkpn
jtha ibn ahbkh xzxkei tql mycvmyh ioyw
mpsc pvdiuu wqixxlo cqwmlrw cttoz lad
srl xxlnofu dqf snxd zjlp htxzd
fkv berlbyh kyna wkme qjzgh thpw frup
irhreaj udkpbza qmgp ormlipa lbyuc
empizc apcb ossmtj awk ttsgi bfoymzd ftx jkicph qqjv tywp fwzfe
zaqkd ysn zaluvs rljdk ast fjp amjqr uabrya ufswzjg vcldkxt hzsmrbl
qvy tqgnwj akibr tfjevhv vav
mhe sxg hacoa emh kasf hid jklfy ijk dih
qvwbenk akdctm jztmsx aqvpodu vmknns nck letcrk poba
lhve kkvff iiixid vtsun uvgte mmlxk pgd
gktphd aaoqwz lrvsuw ofcyvmi suvwrl dpqiol wjgj uqigjx
tbp xoc lmz dyzlvp bjleh pxj xjp xbil
gpzgvj tctszm tctszm pnp upqtmm rribg tctszm sllsbr
hpm qvjnd lyqg bybpwn etz pwfigbg uqgrvpg cvniubo
tpowus bdncyxg gmm ebfg zwoue izgkwtx gmtfeg xvudp xgmjp atrvn aqgl
wlrxvo wvonohi owxlvr owhnvoi
knyo aiixyi sjtqb kukhgv qkj qiuefb syhfc aoana okmot tdsmnoj eyzqjn
szhto szhto szhto fxpsavu dtcz hnwqdvk iza
poykme rboczge tuyiw sxr
lpgbp bpmf aiqy exzqt gxdoow yjp fxwdmt eoklc jnps zbnbiwr ppvl
huecy jjhyz pwcea ffofmj tts
ahbmkw brz xdenmw mwexnd ncdxgf gcxnfd
yhfnra vqljz bkyxzt vhtsyde ysaxt qbw
gqhiej rofhmp soeebdp rcuiblb rcuiblb rrnh nses
pxrwe suil iihzf lhcgmfm mqasxh ttpp kqitdyf cuabaa
cxl cwsp qyseogj dimvv igsoxu ncrexla ubrvpp oum usluv
rkmo jqqcdjb mobqcta pbcmoi afjlh mork
nmohoeq fezpxh fezpxh yec
yxlncrt ivi dajo tjpim tjpim
hzhy rcjs uhyvwz tdpxlqw itoiyf
ded apfmhe stfk ugyujv drwks zagqnw mbbzmvc aoupemq
iezre wivdwif xzytxe xwytd vpnol pljx aot phln ztncw
ozblu asda tkxh xqe pvijnl qwwh uvp bdhtgjt uynwtav cdz uqmvp
eukgtsy kdfb bdfk tnv dfkb ewdemb
rsf cxnk cid qsa zwk oetnggn
fpq oim zetbmlk fpq oim xgv cbaj cjrqm
phgldt fhmkc efkztj qidri vsv bvjf lfwfgm wfuoln toamg wfuoln idrs
iuc rrdnk rrdnk asqhnz qxkigmo eeoim mmdtgif akk
rfvsyy kopfhmd tnv ibo demeqm gxrxw hwk ukorln bep
ialo eogif sxlj xfegx nanch egoif eymwt
kttrpjq gbnyiat kptg oarewx vkmt gbnyiat szyokf
tjll xviodi tjll efc rliugl wfbbpq wsqvdli jur tjll bguqyu
uecm yzjhn vqf labnc xyaksj
hjtef zzq ellr wtrodcg drwqo ernt uzx sqiokam
izmh ddutl bdzft jvfthh
ecr xqrp qlxstu kgprd gqvtwni mkughf bulabe bvoxkx
jwsna vjwq swkycg cpp dvmyal xotxviy qkiva ffa eakwp fww yirri
ufnl lpuxw rjki nggh ajdkpvo oeuaemy bjisma vsjzc
ctxu aavlw rap fzxtcp msufn fzxtcp sdlaom vgvdvpc
rftw cyf twyxi orifavd
ogiht ertz wcw jnqdup phvp lbw
tplpyq jeh aobamqe bvaim qptac gssi mkjbaj
nmklyg iitx iczojzr vjspqb uooky uooky hjk
ggnekbb bnebggk sepzjd fvqfgr
wnfwrn yaiogv mbusuy cpbcgs thjea
atndjc dbjgdz guedeay rasa kfhame pusuu dbjgdz
xivzyml xivzyml eqsykxo bshvz xivzyml
nfe ayx gscy ylyp oqyl isatnpx poaelm zsrw dpd eyrdjpq yllk
feqktz mlm jhi yxigeu xzqa qwv yquxw emken jgqsp rojfcu
ruvfcud poubal xswer hfhpyp guf pzgzoq pzgzoq jwgxafi guf kqzzlu apg
rxwcsdc rxwcsdc ywu rxwcsdc
dmgsey xrtx wldwyxz avi
yxnqv ewlx fvif ozfcbxb zqapa yudqksk wlxe mjpvgz
ozoa ozoa hwkbp ozoa
qcv drtqn uqv kcsavgn ybzs tkw
njmloq wapa srm srm ifurca
ezm ccj rub yuaww xhee liikjee kcabgic sbgqx vrpyo pzmesdp ksvv
hycyne raaksm nylsc lcpgn akasrm vxwoaum
zhugs pqquitv bae lyozb fhij pcdcc bae rygsgm pqquitv pizz
oxx bzk grpis qiqljwh svkn
qcq qqc fzgn sqg
lclad motw ukz zghp
glr okzfs zgv ygsvv sauuog glr amxr vvmwmu khy eyh
ukpxpy rgnqyaw ncm coeblf
qdbr ortzo spvnrnq uomtj vffbeva
miwar bidfxp eibo qyee
yldec ghwj mxlemvi imac klkvmg fekxhp kevlzfr fcgnoq fncgqo
hlm vlol qdic rltij nlzxfys rzpoh
krpwspb yrosr hioqla dbpgzgu dvkvvc vvdckv lcjzb qbsbr acbi rtnk
iqtvk jcldzuv smly whmnte mdwlse mkxw mfnkv mkxw kes owkfh
iwcjmkt rnb bjcdjl furhzuu exs
kjwu iuaj ixkujoa jzeau whpn
tvj zrdy fwsbagh zrdy czuzum lxotprx wbohaai
crsyzod jouf osxntw iwzzie bodu scze gjxn vgxvqo gjxn mmthykb
dabjfb vjqz cvr gsymwoe qzpusj twvwhw gyvlqd kdrdkzm bdljp cvr
vmswdz lgjsvxz yjkgqkg tzmjkfp uzbmwxe kuqa dzomt hep jjlibs oxvpvq cix
iqgd btwdjd ncdrovj ltxqc orwhdlo orwhdlo
nxro uxj ovgha elvzl xmlzssr wonimvb urecfx dbfn kope
tbes cgyh fypswue fgxjqtd dxdrfm pzhnaeu kugspa
eouzw qrpokyb fyhpb bcvfvze brdwey gpaa fpqutw pbqkroy axtc egamku gxk
xdrovpt peeww wkcin suir gvrbix
hgsjks juvod jtii iijt
yaw hzifa wpagkd tgvmc iru yyeuy mgcvt fhiza
lsk lks kls edypaxo
tjz qjs mgoyd gomyd ztjbex nprwk vvw rtjsq quvf vuziqtb oygdm
kftodz xua lyxt zfadf fgdwt zfadf xua ehwykd wniahd mqoarg
qgiapb xptk iscyf zfspn qvrpva egufqte zfspn hksw xwxrs dkdruku vegfs
wqifs wfsevg iwnjjpi oajju tkvhpl lemuw
rzbmhso pbvb lfgpq fzjwxxh pqlgf rbhsomz
ufi aiyd gxozgx hygjp dtma uughdc ojumcf yuadt
caami tqzkvor tqzkvor tqzkvor
vhtnvyx myxdywi mwpwq hjxadd qkcj vvytxnh dmbea
jvjtcjg mbiwyad cup xkrfk puz uxpmutf rjxyxyn mfchc
ocrak zprfbgu pjjzl zoehfkm xqn qki uxq tcv emknqjp wvmkas
nxg myr myr vnfzpoy
gwu ezt kbmeouj sxue cxax gcquz ieegnal xecusia vxf
xermi xermi qporwc mzemns ticltnz ddpsstr ddpsstr slgbn
xnujwtw bvzv xjwntuw unxwtjw
tipo akp fkmcls wglmjq fnrtsv
fan dfbya qrp lcvxqqu ldpm gucmeky mrzy fixaph rygneb ocm pjh
ovtrqs ujmbnal geihpe mijhy eewuic toaxbp ipy tvb evlmrtd lbujmna
lsmbwwd hvurk ihbuek hvoyq erzomhn gue lpq dihon dgzvst
fuoshq hfrzeu zfrhue ufqohs
icgwnbi gmhogxu gmguohx toixb hfwj haxlav hbe jdpxeyi xtgfi
vfakk ioil hddqu sdztx hduqd bmiuyr vmas
mcvjjhf sfgt sfgt lambvp dnqc pfecquk
xgr omy bmoadg afbna mar nicpazd iveku zdioyo
rpipon dwg wgd pironp
fkyx wjefuy mfesst ztlf gnnceb rsbvuk ckilt kliqnm iuifcvu
lmgzx oknwr wmttry luipa vcttj nuqdmy
iota efrxkk daqzm certtoi nnvqrwz qrqgza tllwp efrxkk
alde wqmdjy erh txrtqm zuljg hspbnrd pvsnebh bkue pvsnebh txrtqm txtthn
hgggm rswwfpj uctzrv bylqeen dpbnw ostsjwn jtjiyuh ofxu mmmqlg ayhza opbgdrv
qmhkh orbeokv agosach lhujcju jzpp wmxtcy jcxglu iuwmzrv xwkgz sxlzld
dzcdm lwal xpujjm xpujjm lpfojz lqqcon qmqrg
gmwugq ceslt rxcogaq jwkraq
joxr brdy yixlou brdy lnr lnr
wbut pxlsclt igigapq zeacg jxiezn hvws wwz ujpbl fdjtfjw opod kea
tsodswf pufo zqrt zvcpu
nyy mrqmg zkt tslzsf zkt
hxywv lbmogd hhv npyzgjy whfvv mlfqjr ggjz owijo zmesslo gtvizw
xzz dvpzxbd wxwlp cye rcqpgrr gynzo nhy gzpk fpfmb
nhaakbv iazpdc yadqbe kmqm dffq lidnh cegjosw kgd hwivd wijj
cwmdyf huoy awihev qav cwmdyf rdwck hahj pesfyk uoju zrirjdu
qabl vwcwbb phnd xnp huuzwxl rukbp kod sfu ngcvgrt buncnfw
regyd gjzfwf hpuv zmm vphu gwffjz
rdf emo crsoeo bksetj aqfzm pphny
opbmboi iakvj ymjwm vxoq qvox yafk zkch adlusz
qhm jul zasv xhu qnhjwzx
mjmyvd mezfuls upbdpzw awc qxta bzrx tjpjmj dxfyewc zorm
bko kfokm htcpoqc liuvj xhmpcu ccqphot dthvo pfj dtxpmu xoocm cmxoo
kxv eenns qhpfsvo gqoyv jzjho aoscl fetug agxmfea aygpt
javmegf jlmt epdwy egfs hwv uszcqvn foixpz iukh dbuhqgs zgb
zrex zrex xtx ydan maomp hqdhh mfvan broh wvwhqbu
phatsot joipm pmniq arqzmbe vurl bgy iwbwk oyhngcv vnzbzgm bgy
xprufgn vhca nrs abuh zwsxmhk mqrj tyslsij ojkdzom wepxg koodzv ypvyy
vop nnpz mcod mlli ntyhz laqztb kauqkla gmrfte pcuhaci
vrenj lypors prknc djbdkzv amofdx
lgig lojnrw obusoc fkwe ggnv pydcraq bvdivl vev mrojjs rxa
qeg tap jocwlsm vqxa lmjscow
gptlrgq vdasm erdc oparmw
rgbsa nacqhvm pczf anupcp upudwgp
jbnobi ifhzrd ihrkkf osw wos lrnwv
aiuntpl fcxpmz fplacs fplacs tipm gfotkx
fsbnd qoc ozmbi rqv fmbxh tuso kfoxvjn ocja zzs jwplx
muaklvq ghozoxh nwxbh mgoou ufptl ouhh reyuf jougckd dgprag
gwbnqwv dtrd mkzxinl erxl zmfa skuu crxmp wwao wwvdpk nxbn lglzy
qeejk wvnypc yfzyfcr eeqkj
nmcp fmkgfyi grfthau azw
kkallxz rjke ukbt ixkhfb bktu jkre
pxj mnwe djrjde gpsc enqz pdbydx cktfs jjeddr
mgplj yyunujc vis odee ccesa yyg yjcnuyu doo utse
flyy juvxomm vcdcyva lfyy ozxnuzw bmgns
kmsypi zpbyiv rrycnb qos sslwyeo jgbyv njltzt fuwk nwfb ozcf xqnf
sdcvgmy sdcvgmy hzv uyq sdcvgmy
fyox vmgxahj ywaxbmm ugy ruwc mys yrjwr ozsxb vaq
gjpyc sgdn kgm fbvq cziui nzy bwu ezjkkus jrag
kxcr tgjxss xkcr bembjv rbbiw bwbri
dcz rrhvdc zbonfzy ubjt
rvq yjnzswt vatkopb xlj dwxig dqlt qts iva
lylclc jptz rbidu lbt byxk
lwre vwriwh afixsi vwriwh
kmvbflr nfptw fbglxh pyas dxmn hemf segaz zrs
dvbey zmj xfoi bma udtxhb
yryng geiwgz bbrvjp ala
olzicp olzicp qhhslry olzicp
exf xdmwh xdwhm nhjsssn rmlkdb excguia fex
xkwgeso htys sjdk jizciy gjjl phgqdjh wzdb izew zcrumu llxfp
frkohf oifsm aisebkt ijsfkot ukk
koqf xvoior tpe erfpnp npnx
sneysk nsxki wpmhd mdor akrpvgz moicncj sbsj owfhj exw
oqqbvk xztx gtxlms icmo
lfy ltq dlzqlvi ovbrsa gzm nhcjq umbtgm nhcjq
iuopdzq cqaeuu xuzngq kxlx laml slvvr frtml tvioiez vyoomw xickbqh
ckahov mepeku gtaf gtaf
tlto cnnz kzsbkjo kzsbkjo
kqf comkf dvrkyl jdsqi rnwvb vxvd pok
hncq xcx yuykfs egrruvw yqh smcou
tywyq xeq cix yywqt jhzptci hybcoe
zsw zsgot wnu sumd azmuos qawjaz rpf zkxgwdu iom igh
vmxmelt gll ysbbt yboqoyz ykdglk cnypf otn owsz ipn epfeka bkmy
wxjpce etzyavi whb sxzft bfu dgwnbgc nfw sxcteis qqpk
kofv dgoyme vlza oxhbo lrqt uic tvfqiyy iaqm afnk
nsmpg wkibdcz dxbw tlxzm zgwe nqwjji eacbhn blk
shlgws eencr rtufah kjyvqw transt ecsq otbf
obs xsjceex ffqj sob djpq jcda zlskve
rfqtle klarp mtzrx rasr eisqovk rpt vymibt zwrif ilsnd
ldu ffd ldu tizfexr fwpmyan
flxso tzec pzn flxso kzdouon tkvkj
tvd arh qywql uev btvnpm
wtwx kzafvk ybyzmhv mdbrphy vamlvr gbxhod tyulba krcqj ikotmla qfhpa
bnfin ebngj agfdfzu rhjtj aaqzh fsyp nilar uwurjnu hhmso hhmso
uanmesj vshh syosjdt xkormf syosjdt ifvytwl qnw vshh jkg
epyzcn pgdxgye lecnx nebg jzdhvge hfy imiyft
zonbcnv vuvg sxtuty zdhmiow lmud cuegzg
bxgft mxhzrh unqd pqpsnce khykn qlb oujdxpq pxrd jzxjuxr tij
qss mqirowz ijjswjm jjer utwn kuedqxx bxshuok qkfag dmfwcr
jgln zdohd xitfbge xbokj xxeuv wqhvhjo erg cua fhc mhwy
euo ousht ipxt tpzq vnbmlo wvbjpb yjg bwpjbv nzvsea aerhsqv
axhmi bcf zdx vplso xhmai qsk psolv
ydnpmyo pfba zmo nat ykwxvm ydnpmyo rtd uuvqqr hcfccbd rtd
ytp guw ydmyf rww oucmpf gemhpj labc
edpbefn awgg qzpe aat cupig
mmi ghdaoh ibx fbyj gge vmmssen nplt mmqcra omcvm uwa fxypxfc
kjaw mtijne cfmsigd zwcjjd ajxjlqr tbp bnilc
fse ele vcsyiv bfe udny vznrao mgrjfgw
hadl nikvvpf gmdg bkmgt ugj
xkis qmr cgz nresp gms zrii coxkke vfsqiil
wmicbf bkk wcwklfg vpcbeg kfmjab vabc dax tnao tnao fvvzeyq fqm
bct tvj tra soo stqao kqua ikupoy wulcu nauxkkb pvqxy bfu
wpz txdduxq gaehfki kxo lvjzpxu iqon swr eyihl nbbec
fuphnbj bdtz huwu zdtb ilgzpa uyaut vpy viff tuuya
cvusbh bgy apsao qsupha
jtzlbd ljfvh wkjrw xsah sef jygb pqym zbcwok zdmug qpym
hbibuax iorqc dqjrs daeb iorqc qiw sagyt rkc sagyt khbr
shz mgn pqrdbm jvace gfhnq ann zosq wdwzmuf kswsg dzt brlavyo
qiw cdvwds dckpruy pybjra lfvgfn cwj bajtud pojehb rzrzvwe
txfyk zkgeeu zkgeeu zkgeeu wskcv nccoz
eettnxq gbgr uiqonyz wqtgs ozfjbn gbgr
svd thmmr rbbtxn sxkq isxlnhf tamdlbe bqrgvu nmpvlkc spko
qmn rspbjme ikjddkq kdb ugpegi egipgu
ufffijo revqpep zfw kwd pnya blqo rnntzx anpy
piaeyf vbeye uuqd vbeye
hamd hap ekk lgla twto
isniinr crz sjpmfxn uskwj
lzeofk tavbq ijcglqy lvy jliqcyg lwlip
uhyyyw itlrf tdc iabeocv jzwnjh vqxll nefze pyrxmx eispxnm hzlksce
ucuh mlam bhyej rgzkew ctbo iswqnvg
ytmb toppqgp ytmb gqgpr gqgpr vps ebv
eavn atkqltv bjvojs kaskr vqltakt uiktr xglc eyb rkkas fhnf eaorqm
jmfipc ujggeh hdxpfa xtab ydkibi ycxn ujggeh icheh vpznael oprbf
xazqxg khlemu awh uwz vhnixk vdcty hkk
gcl kayi hfozask grpseyn zviy tzoum qywnr wqkhq
ctrrcpw wqfbylp wqfbylp wqfbylp
gtk lqohf hqeaku mdj zrfkmxn bcqgf msing
luhpel kexokpx vojap ldaexs bbbtz
oimnqb esg zyjmbfh dfyhcf khpo zjtgm yelztbs ugj zjtgm mxro xyfxpk
dgtsu vvk wwfugbx aai zlxab beyxcg bpx chc bnxui
irrwbo orwibr lqt qtl tqknh
ihjsg ihjsg powwy pycyqo ihjsg
xdcu outh fnqrc eihkss bdylm sjunib eihkss
jpnw ycimse rffu ismyce uhxl feai
yyodnh dvwshkx vulh pvxj ydhyno hyodny
vuuweg pfguvyu orhei orhei wrm amkr xecja lmnveth
wriwe xgtnvj tdmxf gadtqh bezjvz lifu
euft tchbm xmtlwji tchbm
cfi zudn zludl pwiu axe psed
dbtfwf ajxcudj uaxdjcj dxuajjc zouyy
fmycmej bqhe jyfecmm kkrv kcdvjoy
grtb uzs rkxzt hivhic brtg hwyc lsl iivhch qbcp
ymn xfpka hqm sldz dblvsoe
qrcapma hntgmy difrkpk difrkpk xlsph
flvqh akcw boxrz ywhq boxrz esnxzv boxrz
zrvh jskaw mfs fkj
abveb qxfnlfq abveb kbwiyvd abveb
pgarl nbfrenx rnxgx bdlkix liltdm dzcokeg fubupcg iwp xfayp obfaz nevfw
nuhvaci blyv fcsp adlanka sjy syj ysxl
avwakn dkoya yzuszuk lqrr oqfyd dmgbhd lqrr
pxa mcvtoug nlweso yffqc dtuagcd ovvrkz ggfhw wnlseo bpqbn ohxzs rxzo
djkcl kbgyfir ogquot uoqotg jtmyd ohudvle xrnbt yvsln wykqt hntc xlrhqrb
ykt tkxfmd exas kty
zebstke msbbndq itmli ubexmht vekvd xbmb iajbj wac sta
ptdg oftwo goiulah tfmsrqs jffxvnv ozaluj qlhqjy wyffa
xeq ezmlpw xgno xorvfo yzq vwif wsi
hdove hqbzhu pjrxlj uafuh rizlb advmkca
jzk ddoisdh tfjh yuvikps ixpkf hnu
kixa djx uksr ogxty dxj clda ukrs
xgiy diwbvn vphdbg qnelyz tqptqig lenyzq ecsswj
alx awj fpasmmg zukuh qaanvb too nvskuk too gnria
suo suo brw nazq suo dqv
tan uxiz oqa xyezcd lsaicjr bosiak rmmh
bidpomf dimcj qekero wbrc lewt kmgmlao
bciacj eye lxfpef cbdshd dhdsbc qwnhil iuokc
zduefht lrgfjn nclksm wpjpjr hkeqd oprsjcw
chhdr bram swdfjr yikqra xkzsloc otptp agec hhdrc uofljf toppt wpbyrwo
bwlpb nishr knnrysj bvr ftnb iedskch weo
czo hsfp wblh cru kzalun intt
jvob rppz rkwv hgyhrqg
sgo hued jnygge izf ztan kjgpcn fagff jsi ijcxzoi tgqjjp tgqjjp
ltjq zidjy rfmy yevuaa nlhfyg xytdtle wsqvzzx wfflboo nawhv golhf xhsti
bmtzlml xcbsquq vnfsux voep lkss ioim
ntfffh gcncwu mmymn wkwlswa gcncwu iaeyumz
kcgdm rbaau cwsoya pznnnn xzz zbbdlhw zxuelq xzz pjeq
xrmnuct kwvykx khxr ioua xnmtrcu xrnctum ujq imnt ecee
xjsgx fby fby fby ggtpgdm jqvuj qshewki tkml ymsazcq
sdbyhwg kewtrte novhdcp wbuaoh dtytgtx zez whygbds hpg
tjvaqo yrycda yrycda ldbp yrycda
kloi tmsocmx dza sqtxc wgevs zlevs vtm
ftnx drvdm ryjfdgw nerynh cwfjpa mddvr
wsqjyn svg ncw aesn hvuq vybajti aesn bql atxhp ipu
eye romgxj gumuke jwi jrf dtt kcj wmg waw
ptltud oymklv fgnmbc ete apanovb vpt vyospi
clkguhu rbxs lxtnmy ferdx qbmrpg pvojnj zbcffbp
itngp dvtlq fzxp cxrf gbxxqp aafls pfe bpxgxq
nmikrui ddsq srfilr gnuvghu mwnacz nlbdm zcjm uylgev umzu mftz nmikrui
bow jmnxyen bow hvz
lksibxk lefzh lksibxk nkxsi nkxsi pldvhk
osjlzns pihvr zpeu zxjgjb xplykfk xplykfk
hajmfss cardd kaddjw uicfde taue
rgwdjra sgifh ggt mpzx usghkos oob fvzx ghnyxr sblcif
dtu gnihpry kjdpiny xvax itmluk fxvgaap bei xuq wzcy rhb hailtgo
wwob ueldq ueldq glxc umimwv onu dxhmhis ebottoa lnysfiu
zfbyi eyq etaj idpbkf
qshcfjb ozzqigv raztm ymcv sgivwoc kightf dcaglk udah fdm
jmxr jrcnck enffwfl jycc jmxr cylnigo enffwfl
bkslhv tykqw tykqw mbeqrbt tykqw
vogf nhqltpt nhqltpt vogf kpc
ryayz ddktu rfhkmx xok xninjcm ijcrw fxu
cmezfj zaamjrs whlcuoo mug lcaqhkb ymkdci qexa onhgk pgy
hcrcok qri fki wbiog ptj pmgtdt
xsl mpfxwbz bmzxpwf hrysu bmfxwzp xfja
gybzho ktokndy rzkbr jcnp ahicq weccg pgrodkt che vaglyn omhmpo
vdv bngjox srs faymg xrmf enseu aygfm gvsd
nuzi xodkbag eevovl bfjuv nuzi xmejqn
kcswegw bpa dgil insf insf
stg tklrut poi knurfpf
pcs dgirfie yep lvkfk ype hntt athvad clfybsq ofjhegj epy qwawns
wjtpgd wjtpgd vxnapp mwyfsm vxnapp rvcswcs jksa
ckzslrg wdzeimw cqhp nfgk zgukvd yyt tra erkx wdzeimw
hsww avl vkmzej hsww
mum oczj jfew rag zjoc wjfe yqynjqt cbkcsgo mri
vjhfqdi vjhfqdi npfa pzdmy utlyw bwvbfm nqdv iiap ygpky bwvbfm eocya
ewkqi ckb yviuro mqz vtrdam yzkqzv ppbj lhmj blkafo juxvwke lvewc
ljrewgx sutnb hfsavbu jofr ltml mjzkzz nmjii sutnb eonegt
cxzv nepyrb wmejdo vwqi aeqys
sbx fmne obzdz rdnfb gmb sbx ykcae hbzom ncwju rhpiao obzdz
lsgfun cbmfjwk fya ktzxbwt
ica bpsk bwjwkp obloxdx uwoqdo bnnhjuc tlsx qtaacp bdooxxl jamy ade
psus wmtkg ikvfx fkvesj upqlhfs ueje nyt abxvo
adlbl hzskbrp ooht nps
wtcgnvy nvqtvx tvgnycw ntvcygw kkxcp zyjmpbh
xfxww xsddqe ewvmgw qxqwy wpabtz ppe zuiw zubcc onaqii
kkaeec xhcakul wrrvi dtlqfy ahqdilw bnt gwimw espaivx nam yfv
lxz jtc nkwgz nbgsao olsck emtltf xidwcvm lcjxq
eav dzh hnbp hnbp yeg
egaq yvat kavsige csar zsi sptai
pofijc ibdnoe caoazp azlnjk dqp chik lowll iby gpvjv ohm
ors lexk zcneaj rmesx jman uqkb kvkq zfufmn
qgsyzxd hlm juerg ortfzw hxjzg
fxwy lcoc fyxw pzhynp yfn zdzrz
datmws ckwghgr gbtyf lqrpfgl mbgpd dyjilr fgybt hxpg
mxw facxdnu wxm urltwtf qfo wtpwrj
esa srypq jauwv dpm wdgqq hrke icvudq bdmubb ellhfjh ttpjjd gxmg
gvwvqwj cbzzuvj eckube adqinpa djutlue wcpw vrt ucqwu ekruwsn
fhj fst zmtb yhwk dxlbozs fcb vjvuxin dxlbozs rixdvu
egfoep cvq icd prwj icyg
aojaa ezmcuf udreyi bja cyrtpl wjl
gjeka bsbufp tbqqq vbmnqg sfqtgac odhq xzsxt
yse gujdr ugjdr sye
tax hntqw phf eixjwfh qkylnu nkyuql ugsuj
wyh egum zizhfc jrq htbyug lop dsu
exh vfdoosj ajrna jbiaz lqsgvks xklqgjv abtmdud
juqc ormfa sab tucsfln detqfo feg kifsion juqc ovhra
hvcrh oddhme omzmu vmy she xulvfa fecmgi
ayo gspge nkmy yblsj lrsre nkmy pwocjz gdexqqx ovovm
acy sqcz ijl htt yjsi rly vea bck
bniafe yore xnh rkcfd hxfuzw xlr nkzmmcs ekwggiu kgoboi wfuzxh hwfxuz
weq crkeq cccphe dtozviy kzkkdr yku cephcc ctq zbau dewpi
vfla rzpl bnmx uvggon foivrb fval
ziaove lawkpdn ddwl sxj krroj rqmffxv babb
bdw dsifr kuueet hugddwt piz dwb sjixveg kmsoknq
czl feyxf soyvbj tnmpjn kklwi akx nqepntc
nrmhc tkkn jrxgc jrxgc tkkn
ufzn mrhiapi qrme kjlf qrme xpp qrme loyzizz xqm coli
qvaoye mysv ydfxr iixrw
dql tqarux fxqfn haoinu lyati xml
kyve obatly dgfjt fjz sqrz xlbst lgwlt zovih aepy otrpl oifid
ymawam afgye lcnpkmv feilfws vonseh rxrdco
tqij kuawg dmova slds imdtb sjsafo ffkzzl pxxenva wuakg efbgx
yrwoaos vpw ijjpua jnbxl sev yvgdxzr mpqa vpe lboh sev
krwdtd uglxtcz mljcgdk lqj fgpfle nuui cqk exr nuu oyn
dwd nwt idhclm vgkh rpubq wybhapp
hskhgpy gzvz jztbr jwv vcx vdjmnjr jrsp
ikml ceuhcng biu zoo gra bnnforx abzan hwsmd lmki tsl yvogo
kqfc younaz azvgfz gesajr tmwxvyb vmcdu dclwh rfjwhic slfym
pbrhjml rsacryg jga qvgks neh fcq qmi mwb juezk mjteeg alkb
pcj ujstl fkrqm eeczrle hbkcvm upbo mrb qrspjt
jbq rrk xjl rgokbnx hor ogg szxqu hysy vqj piorq wtrtrdk
bnq ntvhcrf vrm puer kde xaxkja sfxgjf
pgcicus hqeqkkx xqekqhk qqkxhke
puquxi hmeaehh oxe tasipw qzyg hyvy wcmpwe
hvs fxq wvfy zjepsl dvrfxnc xnvg
xle crcuc qkhnv crcuc oedez bjw pmwq
xzzpiy cjwss jwscs apb bpa
ydjhhf yeltadb lwi cjdcb ovaox xrdm vkxub
zax xza admbc lvpzfeh auxn rwasj
kebx eild nrskdr meja jxczomh gcne");
            #endregion
            #region 05
            Inputs.Add(5, @"1
2
0
0
0
2
-2
-2
-3
-3
-7
0
-1
0
-10
-8
-12
-8
-3
-6
0
0
-18
-17
-11
-18
1
-7
-10
-4
-18
-8
-26
-15
-24
0
-8
-17
-15
-24
-7
-21
-15
-19
-30
-40
-44
-23
-3
-25
2
-31
-20
-45
-51
-50
-34
-4
-33
-41
0
-49
-43
0
-62
1
1
-32
-50
-22
-10
-60
-13
-46
-57
-40
-28
-33
-34
-13
-40
-5
-49
-17
-25
-71
-5
-16
-23
-58
-69
-22
-28
-84
-70
-71
-73
-87
-8
-11
-99
-65
-27
-32
-48
-87
-96
1
-58
-101
-94
2
-52
-34
-22
2
-25
-7
-36
-66
-84
-100
-45
-65
-69
-52
-5
-4
-93
-100
-7
-13
-50
-87
-87
-4
-119
-25
1
-41
-58
-24
-12
-15
-39
-140
-40
-136
-88
-141
-112
-43
-68
-67
-128
-23
-24
-90
-56
-71
-146
-46
-41
-76
-54
-38
-144
-53
-1
-97
0
0
-70
-60
-171
-12
-97
-147
-21
-174
-108
-101
-91
-56
-76
-13
-177
-1
-40
-2
-177
-136
-168
-126
-5
-175
-177
-144
-104
-174
-4
-172
-114
-69
-18
-24
-157
-47
-110
-6
-155
-79
-157
-93
-93
-114
-77
-148
-32
-100
-192
-144
-123
-192
-65
-220
-143
-1
-40
-149
-69
-230
-202
-69
-52
-112
-175
-72
-69
-168
-198
-181
-156
-37
-179
-168
-81
-51
-205
-2
-104
-25
-199
-83
-176
-115
-174
-204
-207
-127
-161
-219
-27
-107
-160
-141
-34
-39
-182
-46
-41
-90
-267
-234
-48
-72
-49
-110
-266
-167
-194
-124
-183
-184
-108
-49
-130
-166
-198
-87
-196
-183
-275
-130
-275
-39
-70
-143
-257
-22
-53
-12
-93
-30
-141
-32
-239
-284
-186
-211
-160
-145
-21
-167
-258
-67
-56
-262
-272
-19
-194
-244
-95
-261
-27
-109
-271
-7
-146
-328
-266
-207
-76
-204
-273
-177
-159
-68
-231
-215
-75
-264
-27
-342
-298
-338
-178
-268
-303
-78
-283
-149
-147
-209
-146
-147
-282
-131
-204
-129
-319
-166
-256
-114
-267
-211
-15
-194
-53
-114
-236
-127
-33
-316
-123
-180
-234
-131
-107
-21
-209
-174
-174
-24
-1
-281
-367
-251
-42
-17
-158
-33
-181
-26
-286
-235
-262
-1
-374
-121
-253
-215
-19
-114
-8
-372
-89
-185
-50
-71
-130
-248
-274
-9
-99
-66
-402
-256
-294
-313
-256
-36
-229
-64
-47
-32
-259
-178
-278
-416
-334
-286
-229
-377
-50
-424
-359
-182
-41
-270
-96
-372
-1
-100
-45
-88
-111
-373
-247
-185
-356
-66
-246
-157
-326
-196
-258
-325
-218
-43
-224
-429
-461
-159
-101
-21
-187
-416
-154
-416
-311
-54
-189
-379
-375
-300
0
-405
-170
-478
-119
-451
-121
-30
-304
-320
-218
-369
-294
-41
-328
-482
-42
-200
-254
-409
-260
-447
-196
-156
-394
-142
-180
-376
-316
-323
-455
-262
-360
-143
-318
-242
-226
-382
-211
-493
-443
-14
-231
-304
-168
-396
-100
-201
-187
-209
-49
-45
-150
-309
-275
-449
-523
-260
-366
-222
-483
-234
-209
-398
-247
-343
-266
-456
-396
-528
-232
-241
-482
-417
-362
-406
-503
-164
-146
-198
-285
-23
-133
-506
-159
-203
-70
-35
-410
-209
-482
-304
-45
-550
-27
-6
-117
-121
-143
-265
-196
-179
-334
-77
-253
-526
-276
-437
-212
-276
-253
-414
-192
-48
-53
-28
-24
-139
-554
-534
-82
-35
-237
-447
-274
-125
-377
-404
-101
-241
-166
-192
-120
-469
-461
-534
-222
-409
-363
-211
-477
-300
-491
-506
-512
-344
-554
-31
-617
-49
-268
-63
-143
-512
-115
-299
-344
-453
-573
-590
-330
-342
-347
-3
-46
-344
-423
-561
-411
-95
-9
-323
-354
-523
-523
-526
-573
-162
-281
-578
-326
-475
-506
-319
-190
-15
-193
-586
-430
-166
-72
-160
-530
-233
-626
-345
-253
-413
-152
-217
-672
-675
-498
-417
-104
-25
-114
-283
-187
-314
-51
-88
-217
-311
-408
-148
-420
-615
-221
-454
-461
-213
-131
-115
-326
-244
-561
-133
-50
-434
-544
-616
-418
-302
-366
-202
-624
-302
-241
-158
-494
-321
-555
-136
-601
-363
-246
-630
-705
-121
-427
-91
-453
-664
-271
-210
-155
-573
-232
-349
-152
-208
-233
-395
-185
-121
-291
-149
-11
-263
-55
-488
-78
-155
-447
-667
-556
-730
-406
-454
-382
-496
-568
-235
-374
-200
-475
-513
-275
-423
-95
-643
-434
-144
-527
-418
-577
-564
-211
-485
-122
-387
-484
-212
-129
-763
-268
-83
-428
-518
-394
-784
-223
-549
-232
-175
-566
-569
-329
-300
-3
-563
-571
-369
-753
-111
-609
-461
-514
-514
-174
-800
-702
-808
-780
-708
-774
-811
-518
-741
-404
-364
-48
-74
-228
-333
-380
-90
-813
-457
-275
-414
-281
-723
-101
-123
-438
-657
-406
-779
-161
-825
-715
-79
-358
-183
-554
-716
-596
-56
-39
-505
-268
-425
-609
-69
-92
-7
-44
-10
-681
-86
-30
-225
-551
-213
-335
-829
-817
-804
-74
-109
-732
-781
-401
-370
-40
-526
-694
-336
-859
-294
-682
-264
-325
-27
-679
-135
-82
-711
-570
-159
-179
-604
-41
-580
-403
-540
-262
-69
-329
-5
-879
-345
-632
-367
-183
-38
-80
-63
-448
-832
-656
-774
-292
-474
-596
-862
-842
-16
-107
-243
-647
-782
-336
-785
-816
-78
-416
-712
-810
-389
-264
-304
-847
-520
-619
-161
1
-584
-719
-486
-516
-360
-747
-363
-672
-134
-177
-894
-778
-582
-766
-769
-114
-843
-287
-493
-30
-620
-467
-141
-206
-437
-367
-426
-799
-943
-508
-594
-545
-61
-829
-844
-589
-775
-409
-28
-726
-452
-261
-613
-106
-441
-496
-643
-606
-742
-408
-321
-260
-333
-328
-751
-21
-768
-36
-265
-936
-697
-702
-924
-89
-215
-896
-216
-477");
            #endregion
            #region 06
            Inputs.Add(6, "5	1	10	0	1	7	13	14	3	12	8	10	7	12	0	6");
            #endregion
            #region 07
            Inputs.Add(7, "ToBeFilled");
            #endregion
            #region 08
            Inputs.Add(8, "ToBeFilled");
            #endregion
            #region 09
            Inputs.Add(9, "ToBeFilled");
            #endregion
            #region 10
            Inputs.Add(10, "ToBeFilled");
            #endregion
            #region 11
            Inputs.Add(11, "ToBeFilled");
            #endregion
            #region 12
            Inputs.Add(12, "ToBeFilled");
            #endregion
            #region 13
            Inputs.Add(13, "ToBeFilled");
            #endregion
            #region 14
            Inputs.Add(14, "ToBeFilled");
            #endregion
            #region 15
            Inputs.Add(15, "ToBeFilled");
            #endregion
            #region 16
            Inputs.Add(16, "ToBeFilled");
            #endregion
            #region 17
            Inputs.Add(17, "ToBeFilled");
            #endregion
            #region 18
            Inputs.Add(18, "ToBeFilled");
            #endregion
            #region 19
            Inputs.Add(19, "ToBeFilled");
            #endregion
            #region 20
            Inputs.Add(20, "ToBeFilled");
            #endregion
            #region 21
            Inputs.Add(21, "ToBeFilled");
            #endregion
            #region 22
            Inputs.Add(22, "ToBeFilled");
            #endregion
            #region 23
            Inputs.Add(23, "ToBeFilled");
            #endregion
            #region 24
            Inputs.Add(24, "ToBeFilled");
            #endregion
            #region 25
            Inputs.Add(25, "ToBeFilled");
            #endregion
            #region 26
            Inputs.Add(26, @"[46,14][25,23][37,11](-5,7)(-24,-15)(0,-7)(-30,-5)(32,18)(-30,13)(-8,-3)(5,-10)(26,11)(33,5)(-5,0)(1,-19)(-16,-2)(-10,-6)(-18,3)(24,11)(16,2)(21,-11)(-3,-17)(-1,15)(-5,27)(-28,14)(-10,-19)(-26,0)(2,-5)(-21,16)(14,-21)(26,-11)(34,-16)(21,1)(5,18)(-28,14)(-30,18)(-15,-2)(8,-3)(33,-13)(-8,4)(19,-11)(-44,6)(-5,-5)(-2,6)(5,4)(-18,-1)(-22,-2)(15,-10)(0,-13)(-8,14)(6,8)(27,-4)(-3,-18)(-3,-1)(-7,-4)(26,10)(22,0)(-12,13)(-17,-14)(-1,-6)(12,2)(20,12)(2,-10)(14,-12)(-18,-14)(-46,10)(-12,2)(-6,22)(44,12)(23,12)(35,-6)(1,-8)(-8,-11)(-44,-1)(-31,5)(-10,5)(38,-14)(16,-23)(16,13)(-36,20)(-18,5)(-34,-10)(31,5)(30,14)(20,-3)(-32,-10)(-10,-8)(15,-3)(7,-7)(-14,-3)(-28,5)(15,0)(-17,-6)(15,-5)(0,6)(21,21)(-14,5)(-7,-12)(11,5)(14,6)(24,2)(-21,-8)(12,-17)(-41,4)(1,-13)(-16,2)(27,-11)(25,21)(12,19)(12,24)(1,-4)(-36,-14)(-38,-21)(-4,-10)(31,-3)(0,25)(-32,-14)(-20,-2)(31,-27)(5,21)(15,-5)(-23,23)(-1,-6)(10,23)(-1,-12)(0,-12)(-27,-19)(9,-6)(29,5)(21,16)(18,1)(-14,11)(8,0)(-26,1)(1,-18)(-17,0)(0,10)(2,1)(-19,-20)(37,-10)(-9,23)(5,16)(-28,20)(-5,2)(3,4)(17,-13)(6,1)(-10,-4)(-2,13)(6,-16)(6,-2)(-24,-14)(-14,2)(25,6)(33,-10)(4,-14)(7,7)(-27,18)(22,10)(-19,-19)(1,-10)(2,-2)(11,0)(16,-7)(-3,15)(-1,14)(6,16)(12,1)(-26,-15)(-1,-18)(-33,-11)(22,-6)(-2,2)(15,-6)(-17,2)(-16,18)(-17,20)(-8,12)(-6,-19)(1,-19)(-3,0)(-13,11)(-12,7)(46,-1)(3,-14)(46,0)(-20,5)(37,11)(-11,9)(3,-4)(6,9)(-24,-7)(-9,3)(-1,3)(25,-9)(0,6)(-17,2)(-22,-3)(23,-18)(-5,1)(12,23)(-1,5)(-1,-14)(-10,-22)(4,17)(17,12)(16,18)(-28,-20)(-21,-17)(-14,-16)(26,0)(5,-4)(9,-4)(-26,3)(23,24)(11,0)(22,2)(-44,-21)(8,10)(-28,2)(14,11)(-29,-8)(21,-13)(-10,3)(13,13)(0,-2)(16,-14)(-6,-15)(12,14)(23,7)(21,10)(-23,-11)(-37,-11)(-7,1)(-19,11)(1,20)(-11,-12)(10,0)(-4,0)(-15,1)(10,-12)(28,-5)(28,2)(-11,21)(-29,-2)(6,-1)(-12,-7)(7,4)(-32,4)(46,-8)(11,-10)(24,7)(0,1)(17,8)(8,-11)(-17,7)(-10,-2)(-17,11)(12,-3)(13,12)(-12,8)(-15,-4)(-26,-6)(7,-8)(-9,0)(5,-2)(-22,-7)(13,3)(19,-18)(25,16)(-10,-1)(-38,5)(-15,-16)(13,-4)(43,16)(8,-4)(3,10)(-1,-9)(24,15)(9,4)(1,7)(1,1)(-11,-18)(-24,-21)(1,7)(11,2)(-21,20)(-6,-5)(-18,6)(1,-11)(-2,-5)(-10,2)(11,13)(-28,6)(20,2)(-5,-15)(36,-3)(-16,0)(7,-4)(-12,-5)(17,-3)(32,14)(-16,3)(-25,-2)(-30,-14)(2,-6)(13,1)(30,7)(-8,7)(-20,-10)(-13,-9)(4,-4)(22,24)(-6,22)(-11,-12)(-22,-19)(9,-10)(12,23)(37,-2)(7,-9)(26,-23)(-43,-3)(-18,16)(-22,0)(11,4)(-22,-7)(-10,21)(-7,13)(18,15)(26,-5)(26,-12)(3,-28)(-23,7)(1,8)(7,14)(17,-13)(5,12)(0,11)(-6,5)(-15,-21)(-26,-23)(-25,-16)(-5,18)(10,22)(3,4)(12,3)(30,-14)(11,14)(8,-4)(1,13)(0,6)(-9,6)(-13,1)(1,-6)(11,-2)(5,2)(23,5)(-37,-21)(-27,-23)(-10,-8)(40,8)(25,10)(3,5)(-16,6)(4,-4)(-9,1)(-17,7)(-13,-3)(2,-10)(-6,-4)(18,-1)(15,5)(12,6)(-31,23)(-25,9)(12,-17)(11,-11)(17,-24)(16,-3)(-8,-2)(5,-3)(-11,-6)(-14,13)(-13,14)(11,11)(30,-24)(11,-14)(-36,2)(-1,-2)(-14,26)(37,-1)(-15,-1)(-19,-21)(-2,8)(15,20)(38,2)(5,-14)(8,-17)(4,-4)(-9,4)(-31,2)(-43,22)(-18,9)(22,16)(34,1)(14,-11)(7,-4)(6,-3)(-23,8)(-28,0)(-30,-6)(29,-16)(33,8)(10,-18)(-28,10)(-33,-5)(2,25)(19,-5)(-9,-8)(4,-19)(-22,-6)(7,-1)(-24,0)(34,14)(21,6)(32,-5)(-29,13)(-16,10)(-21,27)(23,-4)(24,-11)(-5,-13)(-35,3)(-20,8)(21,-9)(44,-20)(2,-20)(-16,8)(-41,-5)(26,4)(2,1)(33,5)(-5,10)(14,-5)(4,-4)(-33,-17)(-23,0)(-10,23)(1,21)(35,-4)(-13,-6)(-6,-17)(-11,11)(1,8)(2,4)(-17,-1)(2,-12)(34,1)(-2,-16)(3,-10)(-12,15)(25,8)(-15,13)(11,1)(-12,9)(24,-18)(-4,-26)(9,-16)(-23,12)(13,18)(-1,26)(-3,-1)(-9,-14)(-22,-2)(31,-9)(3,23)(16,-12)(3,20)(-39,-20)(-17,7)(-22,-3)(1,-7)(-4,-14)(23,-4)(5,2)(-5,0)(-8,-16)(31,3)(39,20)(-18,9)(-27,9)(-14,-14)(13,4)(10,-1)(20,-3)(9,6)(14,-13)(-38,5)(-5,-9)(-9,14)(23,2)(8,10)(15,4)(-11,-12)(-31,-18)(-34,5)(22,6)(20,2)(23,-20)(-11,-6)(-22,11)(0,1)(0,16)(13,7)(-25,9)(-26,-1)(-16,-22)(-3,14)(15,6)(-4,8)(7,-13)(-10,-8)(3,-6)(-8,-11)(8,7)(4,11)(30,8)(-8,-8)(24,13)(11,-6)(-9,-11)(-28,-23)(-5,11)(12,-1)(-3,12)(-16,-7)(29,23)(9,4)(16,14)(-12,-27)(29,-5)(-16,-7)(12,7)(-34,2)(4,-4)(-40,15)(21,-2)(-7,5)(35,-2)(-17,7)(-9,3)(-27,1)(-7,-2)(6,0)(32,-12)(28,-16)(21,-15)(-13,7)(-10,6)(-23,18)(-15,4)(3,3)(32,-13)(14,-20)(-2,-4)(-24,-3)(-6,8)(25,10)(18,-4)(14,15)(-8,6)(-19,0)(-9,-19)(-8,-5)(-14,17)(-8,6)(-25,-5)(9,-20)(2,9)(21,-5)(14,8)(2,7)(-18,7)(-9,11)(-21,-12)(13,0)(11,-4)(9,13)(18,6)(1,-14)(6,-4)(-5,-7)(-1,19)(30,-20)(-25,4)(2,-6)(-3,1)(8,-10)(3,9)(-37,0)(-10,17)(-17,-3)(-2,0)(19,2)(7,7)(22,24)(-20,-28)(16,-13)(5,-21)(23,17)(-11,11)(-14,19)(0,-14)(-18,-9)(-2,-8)(16,18)(16,3)(17,-11)(-14,-10)(-11,-12)(-19,-1)(-16,-6)(-6,2)(20,-4)(-8,14)(25,-9)(-12,-1)(5,6)(3,21)(0,0)(24,-19)(-38,0)(16,16)(-1,9)(23,-7)(1,7)(-27,9)(-25,3)(-19,2)(26,-13)(39,-6)(-16,-5)(9,7)(4,6)(40,-3)(2,-4)(-8,-1)(3,-18)(-26,-6)(11,-15)(-11,5)(-10,2)(-20,7)(-6,11)(3,10)(10,0)(-13,-13)(-2,-13)(-36,0)(-4,25)(-10,0)(22,12)(-8,-3)(32,4)(-3,2)(17,-15)(-19,-4)(-6,-16)(-8,-3)(23,5)(17,7)(-8,-6)(2,-10)(-25,9)(25,9)(-28,-1)(16,4)(-30,18)(0,11)(0,-6)(32,-3)(29,2)(-12,-7)(-13,-23)(-20,2)(29,3)(-9,23)(-19,0)(-38,-1)(-10,-9)(29,-11)(9,12)(6,-4)(7,16)(-1,-17)(-1,-3)(-9,5)(33,1)(-5,-4)(5,-21)(-1,11)(40,5)(14,15)(-14,-19)(-4,15)(-17,-16)(-1,4)(1,-24)(-22,14)(-14,-4)(7,6)(35,10)(27,17)(-23,12)(-13,-27)(-6,7)(-20,-9)(-17,17)(-4,-11)(39,-6)(20,6)(4,7)(-8,20)(9,-6)(-25,-15)(7,-13)(-1,-14)(23,3)(-8,5)(-25,22)(0,2)(-8,-16)(-15,-3)(6,10)(9,10)(13,-13)(-23,-14)(-19,0)(2,18)(12,8)(10,9)(17,-24)(1,-14)(-23,8)(2,5)(3,4)(14,-8)(-29,3)(6,11)(6,9)(21,-5)(3,-14)(4,0)(10,0)(7,0)(-20,-21)(-28,12)(-17,10)(-4,9)(5,5)(12,12)(31,4)(18,-3)(-9,-6)(0,1)(2,6)(-30,-10)(-7,-2)(-15,-24)(37,11)(-14,-4)(-10,21)(-15,-3)(2,8)(-7,-18)(-7,-4)(30,-7)(-1,4)(25,-10)(-20,8)(25,0)(-15,13)(-8,-1)(18,14)(3,-13)(31,-3)(1,-22)(15,-3)(-1,-18)(-30,23)(-36,13)(2,11)(16,-8)(17,-9)(-14,7)(-23,-16)(14,14)(-3,-14)(33,4)(-24,-17)(-3,3)(-2,-1)(-14,-1)(17,-8)(-37,-3)(4,24)(-21,3)(6,1)(16,0)(8,10)(25,6)(11,-18)(2,-6)(-16,-2)(-21,9)(7,12)(19,15)(33,-12)(-8,4)(-12,-13)(-28,8)(-15,-19)(-10,14)(-1,-2)(28,13)(14,-19)(29,3)(-11,2)(-27,25)(-4,3)(-28,-4)(9,-4)(-17,4)(24,-9)(17,-11)(9,-20)(-12,6)(-12,11)(-18,23)(-3,11)(12,-18)(25,-12)(20,-2)(-1,14)(5,-9)(-2,-18)(-12,-19)(-21,2)(-14,3)(28,25)(9,-2)(26,8)(-25,-3)(-30,16)(-37,-5)(30,-11)(13,-5)(19,8)(-15,-5)(16,-4)(10,9)(-9,1)(-9,-2)(-14,-19)(-4,19)(-8,0)(-11,14)(-9,-26)(14,8)(-6,-18)(11,6)(13,-4)(24,0)(-13,12)(-6,-9)(16,21)(-2,5)(-4,17)(-42,-10)(7,-5)(-25,-7)(42,9)(8,-14)(4,-11)(-2,-16)(21,5)(17,0)(-20,-3)(-5,1)(0,6)(-12,4)(-12,-7)(-21,8)(-2,3)(3,-1)(17,-6)(17,1)(12,-3)(-10,18)(-2,3)(-20,8)(23,-22)(18,8)(13,-5)(-4,-3)(-10,-21)(12,-3)(-28,18)(-20,11)(-15,23)(16,-21)(-7,-5)(2,-19)(18,6)(35,4)(14,16)(6,15)(-18,-6)(-27,-4)(-18,-14)(6,-2)(27,7)(10,2)(0,-2)(-42,-20)(-36,16)(14,22)(30,-3)(21,-4)(-26,-7)(-31,9)(-7,-2)(0,3)(11,9)(31,-2)(19,-3)(-4,6)(-40,0)(-34,2)(-2,-13)(2,-6)(6,-9)(27,-8)(21,10)(16,-3)(6,13)(-4,-8)(-9,10)(-26,-16)(19,13)(13,3)(14,19)(-20,-16)(15,7)(0,-9)(5,0)(-14,-18)(-10,8)(-11,1)(-15,3)(-3,-12)(2,1)(22,-6)(24,7)(15,13)(9,19)(-13,2)(-16,-18)(-23,-11)(-4,-5)(-2,13)(-8,-5)(-13,18)(-13,-7)(15,-7)(32,-24)(43,-8)(-24,15)(-31,-4)(-5,23)(-1,3)(14,0)(2,-18)(21,-4)(-23,16)(-42,6)(-23,-1)(44,10)(-1,-13)(21,11)(-24,-2)(42,4)(-13,-11)(5,-21)(-2,13)(-8,3)(14,10)(-38,-14)(9,-2)(-40,-2)(2,6)(10,-6)(9,7)(5,6)(-11,7)(22,-10)(-3,-10)(-9,2)(7,19)(5,12)(41,3)(-18,-3)(30,-14)(1,2)(9,-19)(2,-6)(-31,-24)(-22,-3)(-20,12)(18,2)(14,10)(-16,7)(-14,20)(-10,-2)(4,-9)(-4,-13)(3,2)(12,-9)(6,11)(27,0)(-9,21)(-5,-17)(-40,15)(31,-12)(-6,22)(15,-27)(-27,4)(28,1)(-6,19)(-8,5)(-24,-8)(4,-11)(15,-12)(26,-10)(25,3)(-8,-6)(-14,2)(-1,-11)(14,26)(-18,0)(6,12)(-14,-7)(32,-1)(-15,4)(26,-3)(-1,-10)(8,-15)(-9,2)(5,16)(-10,12)(-11,-2)(-11,9)(-5,10)(9,-16)(6,-5)(8,-9)(-16,9)(-26,-18)(0,2)(-1,12)(-4,26)(-29,10)(13,-9)(29,-5)(23,-2)(8,-5)(-21,-22)(4,-4)(-8,12)(15,19)(0,-14)(1,-3)(-1,-16)(4,11)(-5,-7)(-11,21)(3,-11)(13,6)(21,-17)(-32,7)(9,-15)(-4,-3)(1,-5)(-26,15)(1,-3)(11,5)(2,-11)(11,2)(30,4)(-18,17)(-12,16)(-20,6)(-4,0)(-2,-5)(-8,3)(37,-19)(-18,-7)(6,-5)(-12,14)(-13,3)(-18,-10)(-6,-10)(5,-1)(17,6)(-9,7)(29,7)(23,8)(35,11)(11,8)(-12,2)(-6,-15)(-42,-7)(-33,-2)(-29,2)(37,-2)(40,-20)(26,15)(-1,0)(-22,5)(-32,-17)(-37,-12)(-17,12)(29,-1)(22,15)(28,-16)(7,17)(2,-14)(-24,1)(-13,-4)(-6,-1)(2,18)(4,5)(-13,19)(7,-13)(-29,-18)(0,5)(32,11)(6,-8)(19,-26)(-7,-21)(32,13)(-15,-1)(-35,10)(-2,12)(8,3)(-4,-4)(-4,-4)(-1,16)(22,8)(-12,-6)(4,-4)(-19,-5)(-16,-3)(-21,9)(12,4)(8,11)(1,-15)(-2,5)(6,-17)(37,0)(33,5)(26,4)(-9,5)(-25,-11)(-6,14)(-30,-9)(12,11)(-7,0)(33,19)(-25,-21)(5,-23)(3,-20)(13,24)(-30,7)(-1,4)(14,-23)(37,11)(-20,-6)(-30,2)(-2,-19)(5,18)(17,6)(-22,24)(23,-3)(-10,7)(-10,-3)(-28,-8)(2,-20)(34,-13)(-5,2)(10,7)(-5,16)(6,0)(-14,16)(-9,-24)(30,-1)(27,-11)(10,2)(-25,4)(-1,3)(-23,9)(-20,-10)(-15,-2)(3,1)(20,8)(-5,-10)(-1,11)(-15,7)(18,12)(-5,-24)(-3,-3)(-3,-12)(7,2)(20,-10)(-13,5)(-11,22)(-11,8)(28,8)(10,-2)(31,-13)(-17,-5)(24,-10)(-6,22)(9,7)(-27,9)(-9,-24)(-4,0)(-8,-13)(-3,22)(1,-18)(25,-8)(10,-22)(-1,0)(10,26)(2,2)(-3,20)(-33,-16)(-18,5)(-23,6)(2,-3)(-1,-1)(5,-1)(-10,9)(2,0)(29,-23)(2,-12)(-12,-2)(0,2)(1,12)(22,16)(4,17)(39,5)(16,1)(-19,6)(-19,4)(-32,1)(9,-5)(-24,1)(6,-6)(-4,-5)(2,-12)(26,-10)(-24,-7)(-5,0)(-26,-3)(9,17)(31,4)(-9,17)(-10,-12)(1,10)(31,7)(16,-7)(5,-21)(-11,-5)(13,4)(-11,16)(13,-21)(-26,-9)(7,-14)(-42,23)(34,17)(11,11)(42,-4)(-12,4)(-23,-1)(-11,-11)(-20,-2)(-20,6)(-32,5)(-3,4)(39,-12)(1,-14)(15,-7)(6,-6)(8,18)(-6,-15)(-32,9)(11,-3)(23,24)(20,12)(-20,13)(-9,-12)(8,-28)(15,-7)(-12,-13)(-8,6)(-7,-11)(-20,19)(-34,16)(-9,12)(30,-8)(25,0)(16,-10)(-13,-14)(-8,-10)(-16,14)(28,17)(14,-5)(26,-16)(-36,7)(-14,8)(-9,12)(-9,-11)(27,-13)(-6,-7)(29,-9)(-23,10)(6,-10)(-12,5)(-4,-3)(0,4)(16,15)(18,14)(4,-3)(-3,-23)(-31,2)(-16,9)(-5,16)(8,-2)(19,-1)(-3,9)(23,-8)(7,0)(13,-7)(3,-14)(-11,1)(-10,0)(-16,14)(-11,-2)(-4,4)(9,4)(-6,10)(18,-16)(-17,-19)(42,-5)(-12,-6)(28,24)(-29,1)(16,17)(0,-10)(-9,-13)(-18,-11)(-14,8)(33,8)(-10,17)(-13,2)(-25,10)(28,-20)(-15,-14)(29,-15)(-36,23)(39,12)(-34,8)(19,-24)(-6,-14)(12,-16)(-22,18)(-21,16)(-10,13)(-2,-2)(3,-7)(-2,-5)(42,-10)(29,-8)(34,0)(-2,18)(-23,-6)(-22,16)(-41,-22)(20,15)(5,-10)(17,5)(-23,8)(7,-7)(8,-7)(-1,-11)(-30,3)(-9,6)(24,-8)(34,5)(20,-5)(-13,20)(-24,10)(0,-2)(-2,-14)(18,-5)(-15,22)(-4,11)(-10,3)(-10,-20)(-20,-16)(-1,-10)(-4,8)(11,1)(19,8)(16,-12)(9,-4)(3,-7)(21,11)(7,11)(2,4)(-5,13)(-1,-13)(-41,-4)(-20,-24)(-8,11)(12,-9)(-3,2)(-19,-2)(1,17)(20,14)(23,2)(5,-4)(-16,7)(9,5)(-15,8)(-17,-5)(-20,-11)(29,-9)(19,3)(20,1)(-32,-18)(-10,-9)(-33,-9)(-3,17)(10,16)(40,3)(4,-11)(-8,-2)(-25,23)(10,20)(20,-18)(8,-13)(27,-17)(-22,5)(17,-2)(3,-9)(4,4)(-32,-2)(-25,13)(7,-14)(-6,17)(-7,5)(-20,3)(41,-2)(20,-10)(27,10)(-28,0)(-24,2)(-9,2)(7,-6)(13,8)(-18,10)(-22,0)(14,4)(26,-4)(24,1)(3,-5)(1,-13)(4,8)(-38,-1)(-11,3)(-28,-3)(18,11)(-2,-6)(9,-17)(-6,-15)(-10,-2)(14,10)(3,3)(20,19)(-20,-8)(29,-15)(-17,-23)(16,-7)(-31,28)(2,7)(-7,10)(22,-15)(30,18)(30,-2)(-14,2)(-23,-12)(-18,-9)(-19,11)(26,-6)(22,8)(43,-17)(-46,13)(-22,1)(-46,-4)(42,-3)(-6,12)(25,-1)(-32,-17)(-6,-3)(11,11)(12,-1)(7,6)(-35,-13)(-18,-1)(27,3)(36,25)(40,24)(-6,-28)(-5,-5)(-9,0)(-2,23)(-19,-10)(11,3)(-33,3)(24,11)(-25,-15)(4,-1)(-8,-17)(-9,15)(29,-14)(-28,21)(-10,-20)(-26,4)(44,-6)(13,1)(3,-7)(-30,-13)(-8,15)(31,2)(27,-3)(18,-17)(-37,-4)(0,4)(-7,-2)(-3,19)(-40,7)(13,24)(34,-1)(25,2)(-1,0)(-10,4)(3,10)(-27,-28)(13,-6)(-29,-6)(32,1)(-26,-19)(3,-13)(-12,0)(1,24)(8,-1)(-14,22)(10,-21)(6,7)(-4,-6)(15,7)(7,-4)(29,-3)(-28,-10)(-20,17)(6,-3)(28,23)(27,-18)(-2,-11)(-20,-18)(-19,-7)(-1,7)(-23,4)(6,1)(-29,-5)(0,-5)(-19,10)(2,17)(6,3)(26,-3)(20,1)(24,10)(4,9)(2,-18)(0,-2)(-17,4)(8,20)(-30,-16)(4,2)(1,-20)(46,26)(26,-26)(-4,17)(-43,-9)(0,6)(-35,-5)(-1,-5)(-41,8)(44,11)(9,-3)(11,-5)(-46,-1)(14,3)(-6,0)(11,-6)(-3,7)(24,-4)(26,0)(12,-8)(-10,-1)(-4,-7)(-18,6)(11,0)(-24,13)(-7,5)(-23,20)(21,1)(17,0)(8,-11)(-21,-3)(6,-4)(22,-12)(28,-11)(-1,-10)(-11,13)(9,-5)(-7,17)(-19,14)(-25,1)(3,-22)(7,-20)(5,16)(-1,15)(-3,19)(-13,-2)(-23,2)(-6,-10)(2,4)(39,-5)(-4,6)(-7,-20)(-30,10)(6,-9)(17,11)(32,-26)(-4,-2)(20,8)(1,23)(40,12)(-44,-7)(-17,-9)(1,-1)(12,3)(-5,5)(-20,-12)(27,1)(-19,-9)(18,-4)(-17,3)(31,13)(-29,4)(10,-6)(-11,-19)(0,0)(-23,-11)(-9,19)(-10,-2)(12,-2)(10,-15)(6,14)(-19,-5)(9,13)(25,-15)(26,2)(-2,-19)(4,2)(-22,3)(-3,16)(-6,-1)(18,13)(-27,1)(7,-3)(-12,7)(29,-9)(-20,2)(9,-4)(-9,10)(1,13)(-4,-7)(-10,3)(-6,-7)(2,14)(31,-9)(20,-4)(8,-4)(-36,-9)(-24,-9)(14,1)(11,9)(14,20)(-37,-5)(23,-6)(15,-9)(8,4)(-26,14)(-7,3)(3,1)(16,4)(-25,-2)(12,-12)(-3,-14)(19,0)(-24,1)(-25,15)(0,13)(18,1)(37,-11)(15,-10)(0,-2)(-36,2)(-29,-7)(0,14)(32,-15)(10,18)(10,-19)(7,11)(-1,-5)(-12,2)(-23,-5)(-3,-12)(-20,17)(-3,-3)(2,17)(18,-5)(26,8)(-2,-9)(21,2)(-35,1)(-18,6)(-25,-19)(34,-10)(38,-14)(9,20)(-35,21)(-30,7)(3,-23)(17,-15)(6,-13)(-23,3)(18,6)(19,20)(0,15)(-40,-18)(-24,-3)(4,2)(20,23)(-10,4)(28,5)(-10,0)(27,-17)(-15,-3)(8,1)(-8,16)(-17,-23)(-17,-13)(-7,-8)(22,9)(11,17)(5,-14)(-20,-6)(14,-22)(5,25)(14,-1)(17,19)(-23,-16)(-17,3)(-27,1)(4,-11)(13,9)(23,-18)(34,1)(29,-1)(3,12)(-8,2)(-25,10)(-24,-13)(-5,-1)(-7,-11)(-12,3)(-21,12)(2,7)(-8,8)(40,14)(11,8)(37,-8)(-20,-10)(0,-11)(1,16)(-12,-10)(-9,3)(-3,-15)(26,-3)(15,-15)(-4,-6)(-7,0)(1,20)(-26,16)(-15,7)(2,-9)(37,-19)(3,11)(-16,-10)(-8,5)(1,-18)(-9,20)(-19,21)(-13,12)(9,-13)(21,-3)(30,-16)(-4,-1)(-5,-16)(9,19)(30,-4)(-27,-2)(0,-20)(-20,9)(10,3)(-8,25)(-4,-5)(0,5)(-5,-13)(-6,-5)(0,-8)(-19,-5)(14,-3)(18,20)(-10,19)(-6,3)(-26,-14)(-1,-20)(-3,5)(6,15)(32,21)(-3,-5)(-8,-3)(-15,-6)(-13,3)(26,-11)(26,1)(-2,-7)(-20,1)(-8,3)(25,25)(31,5)(-18,-21)(-26,-21)(-8,-10)(26,15)(0,-7)(8,-6)(-45,-19)(13,8)(5,7)(45,12)(17,7)(-16,4)(-16,3)(-8,3)(6,10)(-28,-6)(5,-14)(6,-5)(38,-4)(-4,3)(-28,-5)(-15,-5)(17,0)(3,10)(3,8)(-10,3)(23,-6)(-6,-6)(9,-10)(-23,-16)(-10,18)(3,6)(17,17)(14,-7)(-21,4)(-13,-10)(-5,-3)(-2,18)(22,12)(16,2)(21,-13)(-26,-8)(-9,16)(3,-9)(-10,-9)(14,-12)(-6,-2)(9,9)(-22,4)(-22,15)(15,-1)(4,-3)(27,9)(10,4)(13,-3)(-15,-6)(-20,-6)(-25,-9)(-3,-3)(3,8)(12,14)(-1,-1)(-6,-10)(15,-3)(-22,-18)(23,-8)(4,8)(24,16)(2,1)(-20,-9)(-11,9)(-42,7)(-4,1)(-6,-14)(9,-2)(10,0)(4,17)(26,13)(-4,-5)(30,-20)(-6,7)(-20,16)(-24,10)(-23,1)(16,-6)(-3,3)(0,-5)(19,3)(-7,-3)(1,-5)(-32,-6)(12,3)(7,0)(12,-6)(24,-21)(0,-5)(24,12)(-35,9)(6,9)(-30,-3)(-7,-6)(17,-18)(14,-14)(20,18)(0,3)(-3,-3)(-7,2)(4,-5)(7,23)(28,-19)(-27,7)(-18,-27)(-17,19)(18,-7)(4,13)(10,0)(9,14)(7,-1)(-10,1)(-8,-2)(-1,14)(-18,-7)(-26,3)(-16,-9)(2,7)(33,2)(6,11)(1,-10)(-18,-15)(28,-8)(17,-2)(9,0)(-23,-20)(-6,14)(-6,13)(-6,27)(-13,-24)(6,-1)(12,-23)(-6,9)(13,6)(8,24)(26,-3)(-16,-14)(-4,-20)(-17,20)(-1,4)(2,17)(27,-26)(-23,13)(-10,-20)(-28,12)(10,-1)(8,9)(29,-8)(-1,-7)(7,0)(-32,21)(-6,10)(-28,13)(29,-24)(16,-14)(-1,-27)(3,18)(-21,-10)(39,6)(5,-7)(23,17)(-20,-5)(-41,-2)(0,2)(-21,16)(3,8)(12,-20)(-2,-6)(11,-11)(-20,7)(15,-2)(-5,12)(-12,8)(25,2)(1,-20)(30,9)(-20,-1)(-9,20)(-15,-25)(14,1)(27,-17)(12,26)(-27,9)(-15,2)(-15,-27)(25,-19)(2,-4)(17,3)(-15,27)(-7,21)(-5,2)(20,-10)(34,-11)(16,7)(6,-6)(-5,9)(0,-10)(-43,2)(3,0)(-23,4)(20,-6)(-25,-10)(22,14)(15,3)(1,-2)(-43,-12)(-27,11)(12,8)(39,8)(11,-21)(-17,0)(-21,8)(16,20)(0,-7)(14,-11)(-17,1)(-2,-2)(-12,-8)(20,-13)(29,16)(20,19)(1,15)(-8,-11)(-36,-9)(-38,-14)(9,-3)(32,9)(42,-10)(-25,3)(-38,-10)(-20,23)(-11,7)(28,10)(5,-23)(22,4)(6,-2)(-15,17)(10,4)(8,3)(-8,-2)(-11,-11)(-28,-1)(11,8)(-18,-13)(-10,-5)(21,-10)(20,5)(26,-10)(-10,-4)(-2,0)(-21,7)(5,-5)(-17,-8)(5,8)(-13,1)(11,12)(23,-10)(-21,8)(-11,11)(-18,-6)(2,-8)(-8,-6)(-16,4)(15,17)(26,-2)(40,14)(-7,4)(-17,-5)(-23,-18)(19,-1)(25,10)(12,6)(-12,-25)(-30,4)(8,3)(-18,11)(3,-8)(-12,8)(13,16)(21,-16)(3,-24)(18,-26)(13,21)(-18,24)(-25,22)(-14,-2)(12,-18)(9,-11)(4,-17)(-10,17)(-5,14)(12,17)(-13,-21)(4,-21)(0,-18)(44,-1)(32,-3)(-34,14)(-7,21)(-23,0)(30,3)(-22,0)(18,18)(-19,-6)(4,-15)(-11,-12)(-8,5)(-6,-6)(-30,1)(24,-9)(24,7)(39,0)(2,7)(-1,2)(6,10)(3,-1)(-16,-1)(-16,-13)(-5,-15)(23,6)(-26,21)(-17,13)(-19,5)(5,-24)(11,0)(2,5)(1,-1)(-8,-11)(-10,-23)(-9,8)(-23,20)(28,19)(24,18)(16,-17)(-4,-13)(1,-20)(10,9)(-7,14)(-17,6)(-26,5)(1,-23)(30,0)(11,0)(-15,8)(-14,-6)(10,9)(1,6)(12,19)(-7,-7)(-21,8)(6,-8)(-8,-11)(7,-12)(-34,-9)(8,-2)(12,17)(38,9)(8,18)(21,-11)(-20,-12)(21,-18)(-3,-7)(5,18)(-38,9)(-20,-1)(-1,-16)(34,-14)(19,5)(-12,12)(-24,21)(-31,-10)(20,3)(6,-7)(17,14)(-15,-7)(-16,-16)(-5,9)(21,-9)(-5,9)(-5,-5)(-29,0)(15,8)(29,5)(-14,10)(-9,5)(-42,-13)(44,9)(22,-12)(3,0)(-45,-5)(-6,7)(29,-10)(0,-13)(9,9)(-31,22)(44,11)(-3,-12)(30,-17)(-30,-14)(-13,-4)(-16,19)(21,2)(23,-7)(5,-3)(-14,4)(-40,21)(-20,1)(-21,13)(34,-4)(3,-13)(4,-7)(-25,-1)(9,0)(27,-1)(9,-3)(3,-7)(-4,-7)(22,-9)(0,11)(15,4)(-24,-3)(5,-1)(-32,4)(3,23)(-19,-1)(25,-2)(-18,-23)(45,-9)(-27,-3)(2,12)(-36,11)(18,-5)(43,4)(-4,1)(-5,13)(-34,7)(23,-17)(-4,-15)(28,-4)(11,24)(23,18)(-27,0)(-28,1)(-19,-15)(25,-20)(7,-3)(3,8)(5,24)(12,2)(19,-15)(-3,0)(14,-17)(-26,4)(-16,-15)(-7,2)(1,15)(-5,-11)(-1,13)(19,2)(25,10)(7,-10)(7,-11)(-24,7)(-33,-11)(-22,12)(-3,-18)(8,1)(-2,-16)(8,19)(-11,18)(19,14)(-17,-10)(16,-19)(0,-2)(14,16)(4,25)(-36,5)(6,-22)(-17,-22)(35,-11)(-4,18)(17,1)(-25,-11)(18,-11)(-15,13)(-6,19)(3,1)(15,-6)(12,-7)(0,-11)(17,-1)(6,2)(-44,19)(-3,2)(0,4)(27,-6)(-23,-4)(11,1)(-16,-5)(-7,0)(-24,-13)(3,3)(4,-2)(25,1)(12,9)(-6,-1)(-14,-3)(-18,-5)(30,-4)(-14,21)(27,2)(-15,0)(8,-2)(-32,-1)(9,8)(20,-4)(-2,-5)(-32,2)(-35,-10)(0,7)(16,-2)(41,-8)(4,-4)(27,17)(3,9)(9,-8)(-30,-12)(-15,9)(30,18)(-5,-10)(-29,-16)(-31,-24)(29,19)(10,16)(26,4)(-24,1)(-8,6)(-17,18)(-1,-8)(8,-6)(1,-18)(-10,3)(13,-11)(-10,14)(20,3)(18,1)(11,-19)(2,-17)(-13,-9)(5,1)(-7,3)(-21,-3)(-19,8)(-8,0)(2,9)(18,5)(4,-5)(-9,7)(14,-12)(-9,21)(7,11)(-14,2)(-1,-9)(18,-14)(4,8)(9,-13)(-14,11)(-13,6)(28,6)(-4,-7)(-17,-6)(-26,18)(27,-4)(34,15)(19,-7)(-35,10)(3,-2)(-15,-18)(13,1)(-20,-21)(5,7)(1,3)(8,12)(5,1)(10,-13)(-2,6)(-21,-1)(2,13)(-12,-13)(25,4)(-23,-6)(-11,5)(-31,1)(-1,-7)(21,-14)(31,-14)(32,0)(-14,3)(3,0)(11,-2)(35,0)(-25,22)(-42,-6)(-45,9)(-1,2)(40,17)(32,12)(-6,-11)(-10,-9)(-6,-14)(16,-6)(-21,-8)(-10,5)(-18,5)(2,21)(4,-15)(0,8)(24,-21)(3,21)(8,-6)(-32,17)(-16,5)(25,-13)(26,-21)(38,-25)(-20,27)(9,0)(-23,9)(6,-18)(-20,8)(-22,17)(21,4)(20,17)(36,-13)(-13,0)(-38,-13)(-5,-10)(-3,-11)(10,6)(12,16)(13,8)(-1,-1)(-9,-13)(-27,7)(25,3)(-19,-7)(12,7)(-12,5)(24,19)(-1,-17)(20,0)(-2,3)(7,8)(0,-11)(-36,-2)(-30,4)(-45,4)(1,2)(19,-3)(41,-9)(25,-15)(14,-15)(-27,7)(0,18)(8,14)(30,-4)(14,-22)(-29,-3)(-23,0)(-23,2)(-4,-7)(-18,-5)(-18,12)(36,14)(11,-8)(1,-13)(-8,-4)(-5,10)(17,21)(-19,9)(8,14)(6,-18)(26,-11)(25,-20)(-21,15)(-25,8)(0,14)(26,-19)(20,-13)(-2,-7)(-12,4)(3,7)(-29,15)(22,-5)(-11,11)(-4,-2)(-39,0)(10,-1)(4,-6)(27,15)(-34,-13)(-4,-19)(-11,-9)(17,-9)(35,11)(25,-6)(-1,12)(-24,16)(-27,4)(21,-4)(24,-3)(32,18)(-2,14)(-11,0)(-29,-6)(-8,-26)(-15,-1)(7,1)(-13,28)(15,-21)(-15,1)(-12,-8)(-23,18)(-8,2)(7,-3)(37,-12)(17,-13)(7,-16)(-14,8)(22,2)(-20,13)(-31,-1)(-7,7)(1,-6)(43,0)(-33,-16)(-1,14)(-25,10)(20,17)(4,-18)(24,-24)(-10,-11)(-1,-2)(-24,21)(20,1)(14,20)(19,2)(-11,-1)(-2,-14)(-23,-18)(-7,-2)(4,3)(10,14)(29,22)(21,-2)(-25,-1)(-10,-26)(-12,-7)(31,-17)(-27,2)(-5,8)(-16,21)(21,21)(-1,0)(13,-11)(6,1)(-12,-4)(-6,7)(15,-4)(-9,13)(-9,-1)(-24,-21)(26,8)(6,-16)(-21,16)(-4,0)(1,26)(7,-8)(-15,-2)(-2,-23)(16,4)(-2,-16)(11,9)(8,-12)(23,-8)(3,-13)(4,26)(11,26)(6,2)(-19,-14)(-34,-5)(-7,22)(-3,-8)(-5,-14)(-19,-3)(26,-4)(18,0)(20,1)(1,5)(-19,-4)(-30,-15)(-7,3)(18,22)(23,2)(-33,6)(18,-2)(-25,-9)(28,9)(-39,-7)(45,16)(4,-16)(35,-7)(-11,-5)(-16,12)(-7,3)(-21,13)(-13,7)(-2,-5)(-11,-5)(38,-26)(-9,8)(-2,4)(3,11)(28,-4)(45,-12)(-10,15)(-17,-11)(-45,8)(-1,-17)(-15,12)(6,8)(-13,4)(17,11)(16,-13)(9,2)(-5,-15)(-18,-12)(-2,12)(4,8)(34,14)(17,-11)(3,-6)(-15,6)(-19,8)(-6,14)(3,2)(-5,-8)(-23,0)(-10,-10)(16,8)(37,-3)(12,-12)(0,-14)(-40,-7)(12,9)(-33,17)(22,-1)(-29,8)(42,-25)(-14,-8)(3,-14)(-28,25)(26,6)(-9,0)(2,-17)(4,-6)(0,18)(21,2)(-11,5)(18,3)(-16,6)(-27,6)(11,-25)(-18,-11)(35,-17)(5,25)(9,1)(-34,3)(-7,0)(18,1)(9,15)(-17,-23)(-4,-8)(3,8)(13,14)(-21,15)(-4,-9)(-19,-1)(35,1)(-6,-6)(28,-4)(-34,-4)(10,-6)(5,2)(-7,-9)(-8,21)(-38,11)(41,20)(12,-18)(23,0)(-43,-14)(-16,3)(-26,-15)(3,0)(26,15)(40,9)(35,8)(7,-26)(-40,-11)(-2,1)(-3,15)(29,6)(2,-3)(-28,-11)(1,5)(-8,-7)(9,8)(-26,7)(11,1)(30,-1)(37,-16)(-39,-2)(-11,2)(-21,-5)(10,19)(-3,0)(25,-6)(23,-25)(-4,9)(-10,9)(-27,4)(-6,-21)(-14,-1)(15,7)(6,13)(2,6)(-7,1)(-4,11)(19,-7)(-16,-7)(21,-8)(-8,17)(1,-5)(5,-9)(10,-7)(21,17)(-34,6)(-27,0)(-8,-6)(13,-7)(-11,11)(12,-2)(-4,-1)(21,-19)(-25,14)(2,-3)(-24,12)(-2,-12)(-23,11)(-4,-7)(13,8)(0,-11)(3,7)(16,-11)(40,25)(32,-8)(-15,5)(-4,-5)(-15,1)(-7,9)(3,-5)(19,6)(26,-11)(-22,4)(2,8)(11,-10)(27,-18)(3,-24)(-36,10)(-12,17)(-44,9)(6,-7)(13,-18)(37,-13)(8,17)(-20,-2)(-5,20)(16,-19)(-18,26)(-14,-6)(-11,16)(30,-7)(27,14)(-10,-20)(-15,8)(-35,-20)(-1,26)(12,-5)(23,-3)(6,-12)(4,-6)(12,8)(6,-4)(-13,4)(-20,-8)(-21,11)(-11,7)(8,7)(-7,-9)(-14,-15)(-33,1)(40,-2)(30,15)(40,-3)(0,-3)(8,-14)(-35,-10)(-22,0)(-31,-6)(11,6)(7,-5)(18,16)(9,6)(15,25)(-8,-23)(8,2)(1,-26)(0,-1)(-5,7)(-33,20)(24,9)(12,1)(3,5)(-34,-8)(-39,3)(32,-15)(36,20)(26,-15)(-4,6)(-29,-9)(-22,-7)(4,-8)(29,-2)(38,7)(-12,12)(-3,3)(-24,7)(6,-5)(-11,-9)(1,-17)(2,-11)(-26,4)(14,0)(1,11)(10,6)(2,7)(-32,-17)(12,3)(-28,3)(1,4)(-16,2)(21,5)(10,18)(-1,-2)(14,-6)(-6,3)(7,-6)(3,10)(24,-22)(8,-11)(-40,-3)(7,18)(8,23)(8,3)(-39,-18)(-6,-9)(7,-3)(40,-3)(20,-14)(24,-16)(-10,17)(-7,25)(-38,3)(-3,-2)(-33,-11)(-2,16)(-13,3)(35,-13)(38,-19)(25,-17)(-1,17)(-17,0)(-30,16)(-7,-6)(11,1)(2,-17)(-30,1)(7,21)(-15,20)(14,4)(-10,-14)(2,-4)(-5,-8)(-26,3)(10,4)(3,18)(-7,7)(1,-8)(12,-18)(22,6)(24,-11)(19,18)(-6,-4)(-8,18)(-43,-27)(-8,-6)(16,-8)(-2,27)(25,6)(-44,6)(2,-10)(-32,-3)(29,-5)(-2,-3)(10,-14)(9,11)(2,12)(15,24)(-36,-9)(13,-3)(-8,-12)(38,11)(-7,-13)(-11,2)(-9,-10)(16,-4)(13,9)(-19,11)(-10,20)(-7,0)(30,-20)(-8,-20)(30,-12)(-3,19)(16,18)(-34,-3)(-14,2)(3,1)(29,7)(-16,-3)(18,-14)(-5,8)(2,0)(-16,-3)(-21,-25)(6,-11)(-13,4)(-1,14)(21,-13)(22,14)(15,10)(-34,13)(-34,-19)(-5,-4)(37,-12)(5,-7)(12,-21)(-2,-1)(28,25)(-18,20)(-38,9)(-32,-16)(-13,-11)(36,-1)(38,-1)(1,-9)(7,7)(1,0)(37,3)(0,4)(4,-6)(-41,0)(-2,8)(-17,26)(23,-2)(-15,-23)(0,-24)(6,3)(10,21)(9,20)(-11,17)(-19,-16)(-3,-6)(-7,-16)(4,-6)(-35,-5)(32,5)(7,-2)(27,15)(-41,10)(10,1)(7,-6)(32,-1)(-30,5)(10,0)(-11,-12)(29,17)(-38,1)(-20,10)(5,-2)(17,-5)(23,8)(0,-11)(-7,-14)(-20,-19)(-9,-1)(-6,3)(15,19)(-25,6)(-5,21)(-4,-12)(-1,0)(5,-12)(-7,3)(-6,4)(-10,-5)(32,-15)(3,-12)(38,4)(-20,-1)(8,-7)(-28,12)(-22,23)(14,2)(-10,-26)(11,-6)(17,10)(12,6)(32,-5)(-8,0)(29,13)(-36,1)(-29,3)(-32,-4)(2,3)(-7,5)(3,0)(36,4)(29,-19)(17,-13)(-29,-4)(-6,12)(-20,3)(-2,-9)(12,-7)(0,9)(9,5)(-32,8)(18,-9)(-8,7)(18,-6)(-12,16)(-2,0)(8,-3)(-8,-16)(9,-17)(13,4)(8,21)(0,10)(-25,-10)(19,-6)(-8,5)(20,23)(-31,-8)(-12,-1)(-18,-13)(34,1)(43,-9)(-11,1)(-27,-3)(-35,4)(31,-10)(4,1)(28,-1)(-7,-1)(9,0)(-25,1)(-13,8)(-13,3)(14,17)(-17,13)(23,5)(9,0)(42,-5)(-12,-6)(10,-10)(-12,1)(5,-8)(-35,-2)(9,5)(-25,-3)(6,-11)(-14,4)(10,23)(24,0)(16,-25)(3,-24)(-27,-2)(-38,24)(20,12)(1,18)(24,-11)(-9,4)(-15,-21)(-9,7)(6,1)(30,21)(-11,-7)(-27,-4)(-22,-11)(17,-8)(24,-9)(20,-4)(6,21)(-13,6)(-1,13)(-4,-6)(-12,14)(7,2)(8,-12)(23,-14)(-10,-3)(-6,11)(-24,-9)(-9,-9)(-24,0)(6,17)(-7,11)(7,-10)(28,-14)(0,6)(9,12)(-27,16)(20,-1)(9,-7)(4,5)(13,-5)(-24,-10)(29,-26)(-14,-9)(37,-4)(-39,12)(-26,11)(-45,9)(27,0)(31,-15)(41,2)(-26,4)(-10,-6)(-31,7)(10,-12)(-21,1)(11,-4)(8,23)(25,1)(-13,-3)(-13,-16)(-17,9)(17,-11)(3,2)(-8,-11)(0,25)(30,-4)(7,23)(4,-13)(-20,-5)(20,-24)(4,3)(20,21)(17,12)(-10,11)(-37,-16)(-38,-8)(-5,-26)(34,18)(-4,8)(14,26)(-11,-16)(25,9)(-32,-17)(-27,-2)(-27,-11)(13,-4)(20,-5)(9,15)(11,7)(-6,-2)(-4,-18)(-19,6)(7,6)(33,11)(30,6)(-6,2)(5,-13)(-18,-21)(9,11)(-35,11)(12,18)(-23,6)(16,-9)(-17,-4)(39,-17)(7,2)(22,9)(-22,17)(-12,16)(-32,-1)(5,-7)(-16,3)(14,-2)(20,-15)(38,-26)(23,-23)(-13,17)(-22,23)(-23,25)(-13,-18)(4,-8)(8,2)(28,9)(20,-9)(-17,-16)(-38,-2)(-36,4)(23,11)(25,-7)(34,0)(-26,-20)(6,7)(-31,1)(41,-1)(-28,-11)(1,8)(-24,5)(17,22)(-2,-2)(-10,19)(8,-3)(20,6)(7,-26)(-17,-12)(-6,-3)(10,5)(10,-3)(5,-17)(-23,15)(-7,9)(-26,-5)(6,7)(22,-3)(1,10)(17,-4)(-6,-5)(12,14)(-27,-9)(-13,18)(-10,1)(1,-4)(-25,-24)(10,-2)(34,6)(24,20)(22,-21)(-17,-9)(10,-10)(-17,23)(5,2)(4,9)(17,-12)(4,8)(-9,-2)(-9,4)(-14,-13)(-21,11)(-21,-12)(2,12)(21,-18)(35,21)(1,1)(-27,-10)(-19,-9)(25,-13)(-2,11)(22,-16)(-23,23)(20,-1)(-40,15)(9,-19)(-14,-5)(9,-6)(-13,13)(-4,-5)(3,-1)(16,-6)(17,6)(5,0)(-27,-1)(2,-4)(2,19)(15,-10)(10,9)(-1,-18)(-12,10)(-23,3)(-16,4)(16,7)(13,-14)(32,-12)(-22,2)(23,7)(-37,8)(18,-16)(-4,-6)(27,11)(-4,2)(-5,22)(0,-6)(6,-8)(-1,-8)(-17,0)(-21,23)(-31,4)(4,-6)(0,4)(19,-3)(6,-2)(45,-27)(-8,7)(14,-4)(-12,23)(16,-10)(-35,7)(-5,-12)(-1,-1)(27,2)(-18,13)(-20,6)(10,1)(-11,-24)(7,3)(0,14)(30,13)(-6,-9)(-1,-27)(8,-7)(9,-12)(-31,28)(-1,10)(18,25)(39,-26)(-15,-2)(-22,-11)(-40,8)(-13,-6)(30,-10)(38,18)(15,-4)(-27,13)(-24,-10)(7,17)(22,-17)(4,-11)(-26,-12)(-21,24)(15,-1)(6,1)(-8,-13)(-28,5)(25,2)(32,-2)(8,15)(7,-6)(-13,1)(-9,-18)(3,9)(-18,5)(9,-7)(-45,11)(23,7)(14,20)(14,-17)(-20,-12)(-18,-11)(10,18)(1,8)(31,-3)(9,-6)(27,1)(-46,18)(-31,-6)(-9,2)(25,-24)(4,-10)(-27,-14)(17,26)(27,-5)(13,9)(-32,-12)(12,26)(-6,-12)(3,-14)(-14,-3)(25,18)(1,6)(-12,-21)(-17,-18)(22,5)(-18,-2)(2,9)(-18,12)(32,12)(11,11)(19,1)(11,6)(-1,-22)(-28,3)(-25,0)(2,2)(37,-5)(20,-16)(-19,24)(-39,5)(-10,5)(13,-20)(23,-20)(-30,3)(-8,14)(2,15)(11,13)(-21,-14)(-12,4)(24,-15)(8,12)(-17,-11)(0,12)(18,-17)(40,-5)(6,-14)(15,13)(-4,17)(-14,-6)(3,4)(-5,-11)(-15,6)(-21,1)(-32,7)(30,8)(1,-7)(20,-20)(2,10)(16,-10)(-6,5)(-23,-21)(-3,19)(10,-2)(2,-2)(-13,-5)(-10,13)(-9,18)(-11,-6)(13,-20)(29,-10)(-12,15)(-20,4)(1,-9)(42,-26)(35,-3)(-39,23)(1,24)(-34,22)(34,-11)(-8,-9)(-7,-16)(-12,-7)(8,-11)(40,-6)(-16,-6)(-25,16)(0,21)(25,19)(24,-2)(-22,-7)(9,-6)(-7,-3)(2,5)(-26,9)(-37,-1)(-3,-1)(-13,4)(6,-5)(-17,-2)(19,-5)(31,13)(8,-11)(-13,-19)(-5,-9)(34,10)(32,7)(-14,11)(-3,-16)(-27,-1)(-12,-12)(-14,25)(-14,2)(-3,-3)(-25,-15)(3,8)(39,11)(4,-1)(35,8)(-41,-19)(10,5)(-37,-5)(20,-1)(13,12)(10,-11)(-1,26)(-28,-8)(-7,-7)(-14,-5)(-1,3)(1,20)(-2,-15)(36,-18)(23,-10)(27,6)(-6,10)(-2,-2)(-14,2)(-8,10)(15,-8)(12,6)(14,1)(-29,23)(6,-11)(-8,-19)(7,-25)(2,10)(6,15)(-3,17)(-25,-19)(-19,-4)(-18,9)(13,21)(-9,-3)(21,-15)(-19,5)(-3,0)(23,-8)(36,-12)(-1,4)(0,0)(-3,3)(17,0)(-9,-3)(-3,-17)(16,-16)(5,17)(1,27)(7,18)(-14,-9)(-35,-8)(-16,-3)(1,9)(24,-6)(-23,-15)(-9,-3)(-12,2)(35,11)(10,-1)(30,-16)(-17,15)(-26,-13)(-2,13)(22,-11)(42,16)(-34,-7)(-10,-5)(-31,2)(2,13)(-3,-3)(-7,-9)(-4,-14)(4,11)(16,16)(6,10)(-27,-11)(-3,2)(-4,9)(24,14)(-18,-28)(28,-1)(8,2)(8,16)(7,-17)(-5,-4)(2,10)(-31,20)(-23,6)(32,-21)(24,-21)(22,-25)(-32,17)(-27,2)(0,22)(3,-6)(23,15)(-15,-3)(13,-14)(5,-17)(22,-13)(-27,10)(-15,-5)(-32,-3)(15,-2)(-11,1)(19,24)(-11,1)(18,27)(-22,-19)(24,4)(0,-13)(23,6)(11,-4)(16,5)(-23,-4)(-26,-10)(-19,7)(0,10)(28,25)(-6,-13)(17,-18)(-15,-7)(4,14)(-18,13)(0,-18)(-23,-10)(41,2)(15,15)(31,1)(-30,-17)(-6,4)(-10,-4)(15,4)(-26,-5)(6,3)(8,5)(2,12)(15,-18)(-10,1)(16,-17)(-9,2)(-10,6)(2,7)(-4,15)(11,0)(14,-7)(-12,-9)(-13,-17)(-33,-8)(12,-4)(-14,24)(-1,0)(-6,20)(43,-3)(18,15)(-4,-2)(-41,-3)(-16,-12)(7,-11)(-4,7)(12,1)(-11,8)(14,-25)(2,10)(9,3)(6,17)(12,-3)(-17,-12)(-11,1)(-25,-2)(4,-9)(23,-16)(31,-11)(29,12)(-7,8)(-15,21)(-12,8)(3,11)(10,-21)(9,0)(-14,-14)(2,24)(-6,-20)(11,13)(-1,-5)(-16,5)(-22,-6)(-3,-9)(27,9)(42,14)(-16,-5)(-18,4)(-7,-16)(-11,9)(-18,-5)(2,15)(11,4)(17,10)(-4,-10)(-4,-12)(1,-24)(2,-15)(21,-2)(-16,28)(-24,21)(-3,17)(-3,-26)(8,-5)(-28,1)(1,20)(-16,4)(4,2)(-3,0)(-5,4)(26,-23)(5,-2)(3,-21)(-3,27)(33,-20)(7,20)(-5,-26)(-21,19)(19,-14)(-12,-2)(-4,-6)(5,4)(22,0)(6,-4)(-2,-15)(-7,12)(-20,3)(4,0)(-6,-7)(33,7)(-35,18)(20,22)(-19,-4)(25,2)(-7,-21)(-1,10)(2,-10)(6,14)(6,-14)(-5,0)(-16,-10)(7,-1)(4,0)(-23,2)(-3,-1)(7,12)(9,4)(-2,14)(-4,-11)(-1,9)(-20,-8)(3,13)(-11,-19)(21,4)(-29,-11)(29,14)(9,5)(-5,-5)(-19,-3)(-18,-11)(16,7)(20,4)(18,-6)(16,-7)(-17,-13)(-18,1)(-17,0)(-1,7)(10,4)(23,-4)(4,-5)(11,10)(-2,9)(22,-9)(-16,-3)(5,-13)(-23,2)(2,-13)(0,24)(13,4)(8,1)(-11,-17)(-3,-5)(-28,8)(-19,18)(-15,4)(14,11)(33,0)(7,10)(23,-23)(-8,2)(19,-9)(-26,15)(-23,-5)(-10,5)(13,-4)(-7,4)(-16,15)(-23,12)(2,0)(-9,-3)(1,-1)(9,-12)(6,-13)(40,-10)(-13,5)(20,-7)(-7,-8)(12,-3)(14,23)(-29,1)(8,-8)(-42,-8)(26,0)(-12,13)(35,-4)(-9,-6)(-12,-19)(-7,-9)(4,4)(29,4)(-6,18)(-23,16)(13,4)(0,-15)(6,1)(-19,0)(12,13)(28,3)(4,-2)(-33,-12)(-29,-24)(-25,20)(33,15)(24,11)(12,-12)(-17,-7)(-19,-9)(20,6)(13,2)(-12,12)(-14,-15)(-16,-2)(23,2)(19,18)(-1,3)(4,-18)(-23,-24)(-6,-2)(-1,24)(9,13)(-7,-15)(-22,-6)(-1,6)(13,0)(35,10)(-3,-6)(10,22)(-6,-17)(-11,-6)(-18,-14)(-31,1)(-4,4)(23,12)(34,-1)(30,3)(-5,-24)(2,11)(-25,8)(-2,28)(-40,-5)(12,-4)(20,-12)(33,7)(-4,-14)(-24,3)(-16,-1)(20,9)(4,-4)(18,2)(-6,-14)(15,-1)(-26,-7)(8,11)(-9,-6)(2,3)(-26,-4)(-24,-1)(5,-17)(1,18)(41,6)(27,9)(29,-12)(-6,8)(-35,-3)(-4,9)(2,-14)(30,11)(4,-15)(-12,8)(-29,-18)(-15,19)(-25,7)(8,23)(5,-19)(19,-11)(-1,-11)(-22,-7)(17,-4)(-18,-8)(3,14)(-38,-5)(18,-4)(23,-10)(20,12)(7,8)(6,11)(4,14)(2,-4)(-41,-10)(-25,-3)(-9,19)(11,23)(44,-17)(27,-18)(30,-20)(-17,16)(0,4)(-43,-4)(16,-10)(-23,2)(6,12)(-40,3)(-1,8)(33,-5)(9,-6)(14,5)(-25,1)(23,2)(-18,-6)(16,0)(-22,0)(-16,-7)(-19,-3)(-11,8)(31,-6)(7,16)(16,-12)(-13,1)(-1,-16)(5,-8)(-19,0)(-20,12)(-23,21)(28,-2)(14,-13)(17,6)(6,8)(31,7)(-15,-11)(-3,-5)(-22,5)(29,8)(-6,11)(10,3)(-24,-8)(-22,-16)(0,5)(21,-5)(4,4)(-11,-1)(-20,1)(34,3)(11,-15)(17,12)(-2,7)(-13,3)(-8,-17)(-21,-11)(-1,-7)(-7,0)(22,11)(24,6)(11,-6)(-15,-12)(-3,11)(-22,10)(-20,6)(-9,-20)(16,3)(28,12)(6,9)(8,5)(-17,-9)(-26,5)(16,0)(10,-6)(-2,-8)(-32,-4)(-4,8)(31,-8)(17,-3)(-11,6)(-22,-1)(13,3)(15,-24)(27,26)(-4,-6)(17,0)(-30,-10)(-32,12)(-6,2)(30,-13)(-1,2)(-15,10)(-1,0)(41,-3)(20,9)(-1,16)(-1,1)(-3,-15)(-2,-20)(-40,1)(-32,16)(-3,21)(0,-23)(-4,-19)(2,-9)(34,4)(35,10)(-6,3)(-30,5)(3,15)(-3,0)(23,8)(-21,-11)(5,-4)(-6,-4)(2,-4)(-13,1)(9,-8)(-23,-8)(-21,4)(-2,7)(1,3)(43,-1)(-20,8)(31,9)(-14,-4)(27,2)(-30,9)(12,-8)(-15,-20)(11,-13)(-4,-1)(14,2)(22,-13)(-26,18)(5,21)(-17,26)(-4,-9)(-38,-22)(-10,-26)(24,4)(31,8)(23,8)(4,-7)(9,-3)(0,16)(-18,16)(-23,19)(-13,3)(4,-21)(-18,-16)(-16,-16)(-21,7)(31,10)(36,-7)(37,1)(-4,-3)(-4,1)(-31,-10)(-1,-2)(-30,-3)(-8,8)(-26,-12)(20,12)(8,3)(18,5)(-14,-2)(26,13)(-14,17)(0,2)(-14,-19)(23,2)(22,-9)(-10,-6)(-24,-11)(-26,3)(9,1)(24,3)(39,9)(16,18)(1,1)(-4,-10)(-17,-16)(4,-3)(-37,9)(-17,9)(0,-11)(27,4)(26,0)(-13,-4)(6,-16)(4,-10)(0,18)(-16,17)(-10,18)(-13,-21)(-12,-8)(-3,3)(3,13)(2,12)(16,-12)(-11,-2)(22,-14)(8,16)(44,-5)(4,13)(4,-15)(-40,3)(9,-1)(-23,-1)(2,3)(0,-14)(-4,13)(33,-3)(-16,-6)(-6,-1)(-1,-6)(8,0)(25,-21)(-2,15)(-19,11)(-1,9)(-24,-3)(12,7)(3,-9)(26,8)(7,3)(5,12)(8,-13)(-27,-7)(-35,-10)(-19,17)(23,-2)(23,17)(7,-10)(7,-6)(5,-14)(-19,-17)(-6,18)(-20,5)(-13,13)(-33,-14)(-16,0)(20,-9)(-2,-11)(4,-11)(-5,15)(8,24)(22,16)(3,-17)(26,-7)(9,5)(24,19)(-11,-18)(-27,-1)(-38,-8)(-22,14)(31,4)(27,13)(32,11)(-8,0)(-12,-4)(-27,-17)(2,-8)(-1,-15)(5,1)(-18,-14)(-4,7)(32,-10)(22,17)(15,-5)(-25,15)(-32,-2)(10,16)(17,9)(13,-9)(-8,-5)(-5,1)(24,9)(-2,7)(-23,-1)(-28,2)(-10,-26)(4,2)(27,1)(-7,27)(14,-18)(-8,-6)(4,-4)(-7,16)(-17,8)(-14,0)(16,-13)(-18,-7)(15,0)(-27,-3)(3,-3)(19,-2)(23,9)(38,13)(-1,-3)(16,-4)(-24,-25)(-37,1)(-23,-8)(13,16)(40,-7)(-11,12)(-9,-5)(4,5)(32,1)(23,5)(-8,-2)(-36,4)(-8,6)(-18,-15)(-3,0)(-33,3)(-15,3)(38,-5)(29,0)(42,12)(-4,7)(8,-26)(-4,-10)(-29,-5)(-13,11)(-29,-1)(3,3)(-8,-12)(9,2)(-11,-13)(-6,0)(-11,6)(8,4)(-3,13)(7,10)(30,1)(-8,-9)(-2,-11)(4,-4)(12,10)(17,-7)(-11,11)(9,-3)(-17,10)(-20,-19)(-16,-6)(25,0)(16,21)(24,5)(-2,-14)(9,-22)(7,-9)(-24,22)(-28,13)(-37,12)(19,1)(28,13)(20,-5)(7,4)(-25,-26)(25,-2)(-24,-18)(-7,24)(-1,12)(-10,2)(17,-7)(-18,0)(7,-6)(3,1)(2,-8)(6,18)(-16,-5)(-23,1)(2,2)(29,8)(-2,-8)(11,-1)(5,-2)(10,9)(0,-22)(-22,-10)(19,10)(11,15)(13,17)(-21,0)(-33,-16)(6,-8)(20,-17)(34,17)(3,0)(12,14)(-2,-14)(-37,7)(-1,-17)(-33,-1)(31,-10)(-16,23)(31,4)(2,9)(-4,-7)(-27,10)(-28,-6)(2,0)(-13,-9)(-12,-10)(-25,-9)(2,0)(15,0)(13,6)(8,-6)(18,19)(-1,3)(8,4)(-11,-20)(14,4)(18,1)(3,5)(12,6)(-25,-6)(0,-1)(-36,-14)(-9,20)(-21,-3)(34,5)(20,-1)(28,-6)(-35,-11)(22,1)(12,19)(43,14)(-7,-16)(-13,6)(-29,2)(5,6)(2,-5)(19,-3)(-26,-5)(-14,-18)(-6,-5)(9,15)(13,21)(-18,11)(5,-21)(-23,-20)(0,-22)(-14,23)(29,1)(2,9)(12,-2)(-27,17)(21,-12)(9,-22)(24,-18)(-16,6)(-35,16)(-26,20)(24,20)(40,-14)(33,-24)(1,-26)(-10,19)(-34,-2)(-16,23)(-12,4)(25,14)(-1,-24)(-7,-9)(0,11)(17,22)(7,-10)(11,3)(3,-3)(-16,11)(-9,-17)(-45,1)(30,-16)(-12,-7)(33,-14)(-7,22)(18,23)(-9,-1)(-20,-17)(-20,-23)(6,16)(31,1)(-13,6)(-17,-17)(7,-2)(-3,0)(2,23)(-6,23)(17,-6)(1,-3)(-5,-8)(9,15)(20,-2)(5,8)(8,9)(3,5)(-17,-3)(1,-19)(-32,-22)(-4,-19)(2,-8)(2,2)(-17,4)(2,11)(1,16)(1,17)(-8,-8)(31,-4)(2,0)(-32,23)(-37,7)(36,-14)(30,-12)(40,-12)(-25,3)(5,-10)(-14,0)(9,3)(-10,11)(-16,-2)(-12,-16)(-6,6)(-4,-9)(24,10)(7,6)(35,23)(3,4)(2,-13)(1,-12)(-16,3)(-25,10)(-12,8)(19,4)(26,-15)(-32,-3)(-42,-5)(-17,8)(26,8)(42,2)(13,9)(10,-4)(-9,-12)(-22,0)(5,4)(-2,3)(24,-15)(-12,-16)(-30,-9)(3,3)(-4,12)(28,6)(-6,-12)(6,-1)(-17,-6)(14,16)(-23,-12)(24,1)(-41,-2)(35,-6)(0,13)(42,-8)(-27,17)(-22,-2)(-36,-6)(27,-10)(-10,-8)(-3,14)(-19,0)(-2,9)(27,-17)(-11,12)(20,-16)(-19,9)(-6,-12)(15,0)(25,-9)(28,-12)(5,6)(-14,22)(-24,3)(3,2)(11,1)(19,17)(-14,-3)(-23,-12)(-9,0)(-11,23)(0,-9)(-23,-19)(10,-14)(6,1)(33,17)(3,11)(12,13)(-22,6)(-30,-25)(-27,1)(1,-16)(30,28)(35,-6)(17,-8)(-4,-20)(-23,8)(0,17)(13,0)(17,6)(-13,-15)(-32,-3)(10,-13)(-5,6)(23,2)(-2,1)(13,16)(-21,11)(-6,2)(16,-23)(19,-8)(-2,-5)(-9,9)(-13,11)(-9,1)(-2,10)(-15,6)(-5,-4)(15,1)(10,-25)(23,15)(-17,-16)(19,1)(-29,-20)(-3,13)(-27,7)(18,6)(22,10)(25,7)(17,9)(-27,-13)(13,-2)(-6,8)(-8,-4)(-43,11)(-19,-22)(5,9)(7,-22)(8,5)(1,-2)(38,22)(16,18)(28,8)(-39,-1)(-7,0)(-33,-7)(8,-5)(-5,-18)(-7,-18)(-5,-7)(-12,-3)(22,6)(9,-9)(13,18)(-20,7)(5,11)(-26,-2)(30,11)(13,-11)(3,1)(-14,-13)(-36,16)(-11,-2)(-23,8)(0,1)(24,-1)(13,-10)(13,-16)(14,-19)(31,2)(-12,-5)(-20,18)(-31,16)(4,6)(6,-6)(7,-16)(33,11)(0,-3)(0,6)(-11,-2)(-8,7)(-13,2)(-23,11)(-5,-6)(-1,-4)(29,2)(22,18)(27,12)(-29,-13)(-11,-6)(10,0)(20,-1)(12,4)(-23,-5)(-8,4)(-13,-8)(18,-21)(22,10)(-14,-12)(3,19)(1,-26)(-1,7)(-20,-11)(-3,21)(-2,-7)(-17,-1)(-10,-16)(4,19)(20,-5)(18,17)(24,-11)(17,1)(-10,-21)(2,-11)(-7,-2)(3,17)(-22,22)(8,18)(7,-9)(15,-2)(-25,-16)(-13,-11)(-22,-23)(17,-2)(-11,10)(13,25)(-22,25)(-7,0)(-18,-12)(34,-15)(28,5)(3,2)(-21,8)(-13,8)(35,5)(21,-16)(17,-12)(7,-4)(-6,11)(-44,3)(-44,-2)(-39,-2)(42,-7)(8,12)(36,5)(-30,1)(33,-11)(-30,-2)(4,2)(-16,-4)(21,7)(19,-2)(-12,7)(3,-11)(-34,3)(27,-6)(0,12)(9,-3)(-30,-4)(-20,-17)(17,6)(1,-6)(14,13)(-8,11)(20,18)(9,-7)(2,-6)(-7,0)(-20,-9)(-9,-4)(-12,-2)(-3,13)(4,2)(-5,-2)(6,-16)(24,2)(20,-4)(12,9)(-8,-18)(-6,6)(17,5)(-31,1)(-18,2)(-46,3)(41,26)(-3,-18)(14,-12)(-27,-9)(22,21)(9,-4)(10,9)(19,5)(-2,15)(-20,-19)(-22,-13)(7,-11)(38,-6)(24,-12)(16,-4)(-14,15)(-5,12)(-20,20)(-9,-5)(-9,-1)(-1,-6)(-7,-1)(-16,-13)(-13,-10)(-2,6)(28,3)(-2,20)(-6,-14)(-20,13)(0,-17)(30,23)(9,-2)(22,12)(1,-18)(5,-11)(6,0)(8,0)(-33,15)(-20,-20)(0,-8)(13,2)(-5,16)(-28,-1)(24,-10)(11,-13)(16,20)(-30,9)(8,7)(-12,-18)(13,7)(-4,11)(-20,13)(-22,-12)(-25,-8)(31,4)(26,-9)(5,-7)(13,5)(-13,2)(26,14)(-43,1)(-10,-1)(-28,-5)(3,-25)(27,10)(-1,8)(28,28)(-6,-1)(10,0)(-10,-12)(-15,-13)(19,-14)(-9,10)(-4,11)(8,-4)(-4,-15)(18,8)(2,13)(23,-1)(-22,1)(-25,-1)(-14,4)(37,-9)(-8,-2)(-6,12)(5,6)(1,10)(14,-16)(-32,2)(36,-13)(9,-6)(31,-21)(-7,8)(-36,22)(-43,25)(-39,4)(12,-20)(30,1)(19,-1)(28,22)(-3,-10)(-12,-24)(-15,-18)(-16,-7)(32,3)(-24,-7)(17,6)(-15,18)(16,23)(-14,8)(5,-17)(17,-13)(-5,-15)(-2,11)(-6,-13)(-1,18)(19,5)(-17,5)(7,-25)(-31,-9)(19,-3)(22,17)(-6,12)(-23,17)(-30,0)(-2,-5)(24,9)(27,5)(21,2)(-7,-18)(-12,4)(-4,-5)(20,-9)(13,-7)(-2,7)(-35,25)(-12,-18)(22,4)(-7,-5)(-17,17)(-29,-18)(35,-17)(36,-5)(5,-8)(-12,2)(-33,13)(-20,0)(1,16)(20,-22)(30,11)(9,4)(-8,-6)(-26,12)(-7,-24)(18,0)(37,-17)(-8,0)(-37,10)(-8,11)(2,18)(17,17)(-12,-13)(-3,8)(7,-13)(8,8)(-18,-2)(-25,12)(-28,13)(17,1)(24,-25)(21,2)(-1,-15)(-11,21)(-14,-17)(8,0)(31,-15)(2,2)(-14,-8)(-30,20)(-6,-13)(24,13)(-15,0)(11,3)(-9,-11)(26,-27)(27,11)(-22,10)(18,26)(-37,-1)(7,2)(-2,-8)(3,1)(2,5)(-7,8)(5,3)(5,-23)(7,-3)(-4,-13)(18,10)(-17,-5)(-9,2)(-7,-3)(12,1)(33,5)(2,11)(-6,-1)(-2,7)(4,-11)(13,-6)(-11,-3)(5,6)(-14,7)(21,-4)(-2,8)(-18,-11)(-19,-5)(4,-14)(24,6)(22,-3)(-13,1)(-15,-8)(-42,5)(17,-6)(-11,9)(35,5)(-2,19)(13,-4)(-9,14)(-18,3)(23,-4)(-27,-7)(0,-4)(-24,-3)(13,-7)(12,8)(-14,7)(-2,-4)(-19,-13)(7,13)(16,-9)(-5,6)(15,-15)(-20,12)(29,-12)(13,0)(35,-3)(-35,-9)(-28,-3)(-39,4)(-2,15)(19,5)(5,4)(-6,-10)(-16,-11)(15,1)(3,17)(-8,7)(0,-15)(25,-3)(18,12)(4,16)(-24,6)(3,-11)(-28,-18)(23,-17)(2,0)(43,7)(6,4)(-19,18)(-21,6)(-18,0)(6,-25)(6,9)(3,-3)(-17,13)(-10,5)(-9,14)(22,14)(28,-8)(18,-22)(14,-15)(-45,-7)(-23,19)(-15,1)(23,-1)(20,-5)(0,1)(0,3)(17,9)(-14,10)(13,-9)(-25,-1)(6,-8)(-29,13)(22,-19)(26,5)(35,7)(-30,8)(-9,0)(-28,0)(17,-6)(-9,-19)(20,-26)(19,10)(20,13)(9,16)(2,-13)(-13,12)(-44,0)(-6,25)(-17,-19)(29,-6)(-11,-23)(16,10)(15,-2)(3,1)(1,6)(-2,0)(9,15)(11,-1)(-42,17)(-1,6)(-31,-5)(44,-2)(-28,-16)(13,-2)(-5,-3)(30,-11)(-13,5)(5,8)(-25,2)(12,-4)(-7,-12)(25,7)(-11,-1)(-23,11)(2,17)(32,9)(30,-1)(-7,-17)(-1,-16)(-30,-23)(-35,5)(-27,11)(-4,4)(5,-3)(2,4)(16,18)(24,-7)(-18,0)(10,0)(-25,11)(20,-1)(-25,-21)(29,8)(18,-6)(30,6)(-21,-15)(-27,10)(-32,-10)(-10,2)(32,-20)(16,11)(34,-1)(-5,1)(13,-2)(-10,16)(-16,5)(-5,12)(-20,2)(-11,-14)(1,-7)(2,-24)(19,19)(-18,-6)(32,5)(-11,-11)(-15,15)(-34,-7)(1,14)(38,-6)(7,15)(10,-20)(-17,3)(-14,9)(4,8)(19,5)(6,-8)(-30,-10)(-11,-11)(14,-3)(10,27)(0,-14)(-13,-12)(4,-4)(-24,6)(31,21)(2,-15)(5,-5)(-38,-6)(-10,-1)(29,2)(40,-7)(31,3)(1,7)(-33,12)(-2,-3)(-12,-8)(33,-10)(-33,18)(-21,13)(-31,-8)(12,-22)(-1,-4)(-2,4)(1,5)(22,1)(37,0)(22,-3)(-15,-1)(-3,19)(-22,-1)(28,6)(1,0)(27,-4)(-7,-1)(-37,-5)(-16,25)(-2,-14)(39,-7)(15,-10)(12,13)(-24,-3)(-19,0)(-44,-7)(17,8)(-24,6)(38,14)(-28,-20)(-2,-13)(-11,-5)(-8,10)(45,10)(-8,1)(19,-1)(-24,-9)(1,-9)(5,19)(-16,17)(-4,14)(-15,-5)(39,-5)(23,3)(15,-14)(-32,4)(-4,-7)(-5,1)(1,-14)(-15,-19)(-15,5)(27,17)(6,1)(21,9)(-31,-28)(19,7)(-20,-13)(22,1)(-5,0)(-5,-8)(7,14)(-1,16)(5,13)(-38,-9)(-38,-8)(33,0)(27,4)(1,5)(-7,-8)(13,12)(28,-3)(13,-5)(6,-19)(15,-15)(-39,18)(-39,-3)(-2,-2)(-6,-13)(10,4)(-15,24)(27,8)(6,15)(-4,-4)(2,12)(-15,-15)(8,6)(-14,-16)(-8,4)(0,-13)(-1,4)(6,-5)(-13,8)(-8,9)(29,1)(19,-15)(9,-23)(-3,0)(-17,-4)(13,25)(3,6)(-5,21)(9,-16)(4,3)(20,2)(-4,-9)(-5,-11)(-3,-24)(-12,26)(-29,9)(-8,21)(-20,-21)(18,6)(16,-7)(8,16)(12,11)(1,-15)(36,-18)(-25,-15)(-22,0)(-37,4)(14,12)(6,16)(4,-6)(-7,-18)(-12,10)(4,9)(6,12)(18,-5)(27,2)(21,-5)(11,-8)(-37,-10)(-30,3)(-11,8)(23,10)(4,-5)(-1,-13)(8,-4)(16,-7)(6,18)(-4,15)(-21,22)(-7,-13)(-23,-24)(-10,-4)(15,12)(32,3)(39,-15)(-26,-10)(-42,9)(-4,-1)(-1,3)(7,13)(-18,20)(-2,-1)(36,-18)(-3,-7)(2,-14)(-1,-7)(26,-19)(24,-3)(-10,11)(-12,19)(-34,4)(-12,-7)(-27,-18)(9,10)(19,3)(4,15)(4,-4)(3,19)(38,6)(-12,15)(1,-21)(-24,-1)(-1,-2)(-15,-3)(7,-19)(20,-21)(10,15)(-21,6)(-17,19)(-26,-11)(14,18)(3,1)(14,17)(0,-22)(10,-2)(-26,1)(-22,7)(-23,-21)(44,-5)(16,6)(37,12)(-31,-11)(28,-12)(-27,0)(17,15)(-13,18)(19,12)(13,-7)(-23,4)(-29,4)(-8,10)(12,-7)(35,-14)(6,-13)(13,-16)(-28,-4)(-40,12)(-15,21)(2,9)(39,-20)(-9,-6)(2,-6)(-16,19)(16,5)(12,12)(-22,-24)(10,-22)(9,-8)(33,14)(10,19)(-24,-7)(-8,-9)(-33,-1)(8,-3)(-6,7)(13,-14)(-7,2)(-16,13)(-7,10)(10,-9)(8,-15)(1,-4)(-10,0)(13,-8)(-15,14)(2,18)(11,-1)(27,-22)(13,5)(-38,7)(-27,23)(18,-2)(38,3)(38,-15)(-2,5)(-15,-11)(-40,10)(-18,-6)(-16,13)(5,-9)(-17,-6)(-2,-14)(6,-14)(14,1)(35,12)(-5,16)(6,10)(-3,-6)(-1,-8)(17,-20)(3,9)(-5,10)(-26,0)(-39,-15)(3,-8)(27,19)(43,11)(20,14)(-29,-11)(-27,5)(-5,-22)(24,6)(24,-6)(8,12)(-25,2)(-29,-10)(-18,-14)(6,-6)(-10,4)(5,7)(17,-3)(16,2)(-7,0)(-12,15)(-14,13)(-6,3)(-1,-2)(-3,-1)(27,15)(-25,-23)(41,-17)(13,-24)(42,-1)(-7,11)(-30,2)(-19,-1)(-34,15)(24,1)(9,25)(36,-1)(-1,0)(8,-1)(-25,-3)(-4,23)(-11,-3)(11,-22)(-11,-5)(14,4)(-13,10)(4,-7)(-18,-10)(6,2)(-14,-6)(3,9)(30,6)(36,10)(18,-5)(-13,-12)(-23,5)(-14,-6)(-27,6)(1,-18)(-19,11)(38,-4)(17,11)(18,-9)(-6,13)(-32,-2)(-15,-5)(-3,-15)(29,-13)(27,7)(9,12)(-4,13)(2,-14)(-6,-19)(-17,-13)(-9,14)(-27,12)(-5,-2)(6,-13)(1,8)(20,6)(-40,7)(32,-11)(12,12)(37,10)(-21,1)(-1,-13)(-26,-1)(-8,5)(-6,15)(-10,-15)(17,-6)(-5,-11)(29,4)(12,9)(-15,9)(-28,2)(-32,-7)(18,-16)(30,15)(20,6)(-29,4)(-31,2)(-18,-17)(-3,3)(7,-28)(24,15)(34,7)(20,2)(-19,-7)(-13,-7)(15,0)(-3,17)(-21,3)(-23,22)(-3,-4)(42,-1)(10,-9)(-5,-10)(-37,0)(-24,-4)(37,15)(36,-7)(33,-10)(-42,-17)(-27,15)(-41,1)(1,-1)(1,-8)(46,8)(30,7)(16,1)(-40,0)(10,2)(-33,-5)(0,17)(-40,-15)(-1,17)(26,-23)(41,25)(44,1)(-5,11)(-27,-11)(-44,-3)(-7,3)(-17,-11)(5,-8)(15,-8)(38,-5)(34,-14)(4,-10)(-26,15)(-29,2)(7,15)(19,2)(-2,22)(-46,-8)(-2,-10)(33,-5)(37,14)(-8,8)(5,-14)(-15,-10)(-18,3)(-7,-1)(-8,-8)(20,-2)(-15,12)(10,13)(3,7)(-14,-11)(-24,2)(18,-18)(24,9)(6,-4)(-24,5)(-14,8)(7,-4)(18,5)(22,-12)(31,-3)(0,-14)(-4,-9)(-18,21)(-5,25)(-6,8)(2,-1)(6,-12)(-28,4)(10,-21)(-26,6)(24,-13)(-20,5)(26,-7)(14,13)(18,8)(-18,13)(-18,10)(-15,-6)(22,-18)(20,-15)(23,-5)(-8,2)(-10,6)(-36,1)(-18,13)(6,-13)(29,0)(1,2)(-30,25)(3,-3)(-5,-3)(10,-7)(-8,18)(5,5)(19,-9)(6,-5)(11,-2)(-14,16)(2,-10)(-2,-24)(-8,-22)(-11,16)(-17,5)(24,11)(16,-15)(-8,18)(-17,-5)(-14,1)(27,-1)(-12,-5)(-15,10)(9,-10)(-3,-5)(-12,-13)(-39,-3)(-9,10)(-4,2)(31,9)(42,-8)(41,14)(-27,-9)(-32,26)(-19,2)(21,-1)(-10,-13)(19,2)(-12,6)(40,-14)(-36,-10)(18,-8)(-38,13)(30,7)(2,2)(44,2)(-29,-10)(-9,-2)(-38,3)(18,-11)(-4,21)(12,9)(-4,24)(-17,-2)(9,-10)(4,-25)(22,-13)(-3,-8)(-12,6)(-20,9)(20,-6)(4,15)(9,-19)(-18,14)(6,-24)(20,-1)(11,4)(11,24)(1,12)(-3,-9)(12,-7)(-6,6)(-7,7)(-16,3)(-25,-19)(-6,-10)(16,7)(38,15)(-10,-6)(-3,-25)(-10,5)(-9,23)(-10,-1)(7,-18)(42,-12)(-26,0)(-16,11)(0,7)(37,8)(23,-9)(-4,-5)(-43,9)(-23,-1)(-8,5)(12,-15)(-6,22)(2,-3)(27,16)(-15,-10)(-34,-3)(-37,-3)(2,-10)(41,8)(12,-10)(18,13)(-32,-13)(6,0)(-1,-9)(23,9)(-9,0)(-14,-8)(-19,-14)(24,20)(10,14)(11,1)(-19,-19)(26,1)(17,10)(27,10)(1,-12)(-3,5)(-41,-2)(-21,13)(-29,-10)(35,3)(3,-10)(0,5)(-18,-9)(19,7)(0,4)(26,10)(-18,6)(-6,-1)(-9,1)(-27,-12)(40,-2)(-1,3)(22,-3)(-11,3)(-33,-8)(-13,14)(-26,-10)(11,13)(35,-12)(8,9)(10,-20)(-1,19)(29,-6)(-14,14)(-1,-19)(-32,12)(2,-6)(-22,15)(32,-26)(-6,-1)(2,-3)(-23,20)(17,5)(-13,-12)(-5,-10)(18,-15)(34,6)(21,1)(-3,23)(2,9)(8,-11)(1,-24)(-34,-12)(-46,20)(-12,1)(22,12)(8,2)(15,23)(-4,-15)(14,-6)(-23,-27)(8,13)(6,-2)(25,19)(-23,4)(14,6)(0,-15)(-13,3)(-7,-10)(-9,-1)(16,-18)(-18,0)(-17,6)(20,-1)(20,-6)(19,6)(5,5)(-36,5)(-22,-14)(-31,3)(5,15)(31,17)(10,9)(30,-6)(-29,-2)(-14,-21)(-17,4)(-11,10)(-2,6)(15,5)(19,-5)(-2,17)(11,-26)(-2,-5)(42,-28)(-1,19)(-16,-3)(-6,5)(-19,-10)(25,-10)(-21,10)(-9,-4)(-31,22)(13,9)(2,22)(2,-22)(-1,-23)(12,-27)(28,-3)(-30,4)(-1,24)(16,25)(21,7)(6,-23)(-26,-6)(17,-2)(7,3)(-19,7)(-16,-10)(-22,20)(16,0)(-20,26)(-13,-23)(8,-19)(2,-10)(-6,16)(-25,4)(15,-5)(42,-9)(40,14)(-14,13)(-27,3)(-39,-23)(-5,-10)(14,2)(19,7)(9,-8)(3,-3)(5,7)(-8,3)(-32,-2)(-24,-8)(26,15)(45,-1)(26,14)(18,1)(-36,20)(-6,-16)(-23,-7)(4,-1)(25,19)(-19,-17)(-10,-15)(-35,-6)(30,4)(14,-11)(19,2)(-10,18)(3,23)(9,-2)(14,-16)(5,-16)(2,-5)(-4,5)(-12,17)(-8,-5)(-31,-11)(25,-22)(7,8)(43,22)(-16,14)(6,-12)(-22,-14)(-21,2)(-22,13)(17,-8)(13,0)(-1,-1)(-12,21)(3,-11)(0,3)(0,-15)(10,-1)(5,-14)(-28,13)(-23,0)(-13,15)(15,8)(40,19)(0,-19)(9,-11)(-12,-3)(25,1)(-24,-7)(-1,-3)(-21,6)(13,18)(-25,2)(14,6)(-7,-26)(35,-14)(-13,2)(19,15)(-3,14)(11,-17)(14,1)(-28,-12)(13,16)(-14,-18)(0,-10)(-27,-3)(-2,10)(12,10)(6,-4)(-19,18)(-23,1)(15,4)(19,-20)(37,3)(-15,5)(15,4)(-22,-12)(5,1)(-27,1)(-10,5)(-9,-15)(35,-9)(20,-5)(-3,16)(-29,19)(15,8)(-6,-13)(-8,-14)(-30,1)(30,13)(29,-1)(25,11)(-32,5)(-3,12)(-28,-22)(8,-24)(-23,4)(5,24)(-4,22)(16,-5)(-6,-3)(6,-5)(-9,-14)(11,-20)(19,-17)(6,20)(-6,5)(-34,5)(-19,-8)(-6,-2)(40,13)(24,10)(10,-3)(-42,-11)(15,-26)(16,27)(30,5)(-25,4)(-6,-18)(-7,5)(17,8)(-6,-1)(14,-5)(-25,-8)(25,13)(-8,12)(3,17)(-23,-19)(-7,-12)(-11,-20)(14,4)(5,12)(35,6)(4,1)(11,-18)(-18,10)(-32,-4)(-13,9)(-2,-17)(32,2)(-14,2)(25,6)(-10,-6)(10,-11)(-20,1)(-13,8)(-7,5)(22,1)(-15,16)(15,-8)(-6,1)(33,-10)(15,8)(-8,-3)(-14,-10)(-22,-13)(13,3)(25,6)(22,10)(-37,9)(-28,-9)(-7,17)(6,-16)(-8,24)(-37,-8)(-3,11)(10,1)(25,-13)(23,4)(13,-11)(-18,18)(-23,10)(-3,-7)(-5,1)(31,-27)(-21,6)(20,-7)(-36,16)(7,3)(-17,-11)(21,-8)(25,-12)(8,-3)(-6,14)(-20,6)(7,8)(-4,-2)(-11,8)(12,-3)(0,-14)(8,-12)(-16,-2)(-7,-7)(18,15)(3,-7)(35,23)(-11,-12)(-1,9)(-26,-3)(-21,-1)(22,-6)(5,1)(30,11)(2,0)(-6,4)(13,-1)(-18,14)(-15,-8)(-6,6)(19,5)(30,10)(-13,2)(-31,-17)(-14,-27)(-25,-3)(0,-4)(5,9)(4,-10)(17,5)(-16,12)(25,-11)(-29,13)(31,-8)(0,25)(41,-8)(-24,15)(-16,0)(-27,17)(24,-18)(23,-9)(9,-3)(-17,18)(1,-3)(12,-23)(9,-23)(-35,9)(5,20)(0,-4)(17,-23)(-20,3)(2,21)(-21,0)(1,2)(2,-13)(1,5)(2,-3)(-12,18)(25,21)(-19,-22)(12,-15)(-8,-24)(-1,20)(-8,10)(-6,23)(25,-4)(14,-19)(29,-12)(7,1)(-29,23)(-31,13)(-22,-13)(31,-15)(33,-17)(29,5)(-7,-10)(-12,7)(-16,-5)(-17,14)(-26,-17)(12,10)(25,-8)(30,22)(-14,4)(-10,12)(-6,-10)(-20,1)(5,-16)(-3,-12)(-4,-11)(7,20)(-18,23)(2,-10)(0,5)(-4,2)(31,7)(-4,0)(38,2)(8,21)(-10,-25)(-13,-20)(-15,-12)(-18,-1)(-10,-1)(-17,-16)(23,25)(-6,18)(-5,27)(-37,-9)(30,-8)(32,-20)(28,-3)(-7,11)(-7,-7)(-8,6)(-1,-27)(15,24)(-5,-8)(-18,21)(-3,-20)(3,-3)(23,4)(-40,7)(-13,-6)(0,-5)(31,-10)(33,-2)(-26,6)(5,25)(-7,17)(17,-8)(-7,-7)(-12,6)(-9,-5)(-13,-16)(11,-2)(-5,11)(-3,-1)(-13,-13)(23,-11)(15,25)(8,7)(-37,-13)(6,1)(-16,-8)(6,8)(-27,-19)(-3,-3)(8,0)(26,15)(27,7)(26,5)(11,-2)(-25,10)(-6,-4)(-35,-11)(34,-12)(-16,-7)(31,-9)(2,-7)(9,23)(-16,18)(-13,13)(-20,-22)(-22,4)(-21,4)(29,0)(37,-12)(17,-14)(-26,15)(-14,4)(4,-3)(8,-6)(5,0)(-7,13)(22,-3)(12,-7)(22,-16)(-25,3)(-21,3)(-16,27)(-11,-2)(-4,2)(2,-18)(25,-1)(13,-4)(7,-6)(-16,8)(0,-1)(-15,-1)(23,-3)(-15,15)(-11,14)(0,10)(-4,-11)(29,-13)(-24,-13)(6,-12)(-17,17)(7,14)(-15,17)(19,-11)(-3,-19)(32,0)(-13,15)(-1,21)(0,-7)(-19,3)(-5,-25)(-21,7)(-6,-12)(-5,16)(4,-4)(-1,-15)(8,0)(23,7)(16,21)(13,-14)(-21,-21)(-19,3)(-28,14)(6,4)(19,-5)(20,1)(-6,16)(-21,5)(-20,-6)(-9,-14)(35,-13)(15,-10)(19,15)(-18,-6)(19,1)(-21,-6)(-11,12)(-6,4)(3,1)(1,6)(9,1)(17,1)(16,-10)(-6,-3)(3,-6)(0,-10)(-27,1)(-3,-11)(21,7)(39,3)(14,11)(-19,13)(-1,-6)(-44,-8)(-19,2)(-9,3)(37,23)(10,-1)(12,17)(-25,-2)(-5,-22)(-26,-1)(17,-9)(29,21)(14,-12)(-18,10)(4,-5)(-18,4)(17,-17)(-13,-18)(13,5)(9,10)(-12,20)(-17,-7)(-5,-8)(-14,-18)(13,-4)(-28,14)(34,7)(11,2)(39,-10)(-2,-8)(1,-10)(-6,-12)(-18,9)(2,-2)(-25,-2)(2,3)(-33,6)(16,21)(-3,-13)(37,11)(-12,-10)(26,21)(-3,6)(25,12)(-2,-17)(-38,-2)(-9,-2)(-6,4)(43,-21)(-16,-2)(-18,0)(-3,12)(22,8)(19,1)(-10,0)(-19,-18)(-19,0)(-14,-2)(-1,1)(28,-3)(-3,5)(22,-6)(-7,16)(-7,-8)(-18,21)(-28,-9)(0,21)(-22,-9)(26,1)(-4,-19)(38,11)(-8,-2)(26,-5)(1,-7)(0,-11)(12,0)(-18,0)(13,23)(-3,14)(-5,-2)(-20,-11)(-38,-4)(0,-10)(-6,-13)(36,-9)(4,14)(2,20)(-4,22)(25,-13)(-15,-21)(-22,-7)(-15,12)(16,3)(25,4)(-28,5)(-11,25)(-28,4)(6,2)(33,-20)(-8,-3)(26,-7)(-19,17)(26,-11)(-3,-21)(7,-3)(9,10)(-21,25)(-14,-11)(-30,-6)(32,-16)(-15,4)(39,1)(-7,3)(9,-6)(-27,5)(4,2)(-6,0)(22,3)(-3,-4)(41,0)(7,-23)(-27,2)(-38,-5)(-30,-1)(9,-4)(8,0)(-9,24)(-3,2)(-2,20)(9,-15)(-8,-8)(-8,-7)(-15,16)(16,26)(41,-9)(23,-12)(-3,-28)(-29,2)(-8,-6)(-4,10)(10,14)(0,6)(14,-3)(1,4)(11,-1)(-29,7)(-19,-25)(-16,-3)(4,2)(9,24)(31,-1)(29,11)(25,-15)(-34,6)(1,-4)(-19,15)(3,-3)(-17,-12)(0,-22)(16,-7)(-10,-10)(2,4)(11,6)(-7,1)(15,0)(-16,11)(45,25)(-4,12)(0,-14)(-43,-17)(6,-20)(17,-5)(32,5)(-8,-1)(-11,17)(8,-3)(-23,6)(2,-4)(-16,13)(29,2)(10,-10)(13,-17)(2,3)(-36,10)(-12,16)(-35,16)(15,-9)(-1,-10)(30,-2)(15,-4)(-1,-6)(-8,-3)(-4,15)(-9,12)(1,-11)(-17,5)(-2,-6)(1,2)(-8,-16)(2,2)(1,9)(22,17)(-11,-15)(-3,-8)(-17,-26)(37,9)(-29,-12)(29,16)(-21,-4)(1,17)(-38,3)(-21,13)(26,0)(34,-13)(5,8)(18,-10)(-3,21)(-6,-2)(-40,8)(-29,-2)(6,-16)(30,2)(4,-11)(28,12)(-19,4)(21,-12)(-31,-10)(-14,3)(-26,24)(-1,15)(18,2)(41,-10)(27,-8)(21,-21)(-31,3)(-25,-14)(0,11)(17,-18)(32,21)(-17,-5)(-22,20)(-35,-9)(18,10)(33,4)(43,0)(-13,-23)(-34,3)(-30,-10)(-1,14)(22,-14)(14,8)(3,-9)(-12,6)(-12,5)(-21,13)(-15,2)(-2,-14)(-9,2)(0,-20)(21,6)(12,-5)(15,5)(8,-10)(30,-13)(-15,18)(1,18)(-30,23)(43,0)(-31,-10)(17,-23)(0,-22)(18,5)(1,24)(-6,2)(-9,10)(-1,-16)(2,8)(13,-24)(-5,14)(-8,3)(4,22)(16,-6)(5,-8)(6,-7)(-30,-2)(-31,14)(-20,-5)(8,-9)(13,-15)(-6,-3)(0,20)(-3,11)(-16,18)(12,-5)(11,2)(26,-13)(-28,-6)(8,-1)(-25,13)(9,-4)(-17,-8)(41,-7)(5,10)(6,-9)(-36,0)(-11,-8)(-12,24)(30,1)(24,13)(-3,-4)(-39,-6)(13,0)(10,-20)(5,-6)(-31,-3)(-15,0)(14,16)(10,-10)(24,12)(13,-13)(-6,14)(-20,10)(-3,10)(23,-5)(2,-1)(-25,-12)(-3,-11)(23,-3)(37,14)(-10,15)(-7,7)(-15,5)(-13,-20)(-8,-1)(-8,-24)(10,4)(9,-10)(-3,-1)(12,17)(10,-9)(2,20)(-33,-11)(-18,-6)(-1,-7)(22,5)(-13,9)(-2,4)(-20,6)(37,2)(18,-9)(14,0)(-25,16)(-14,18)(-8,-26)(11,-10)(-7,-15)(22,25)(17,-12)(3,-12)(9,-10)(-11,6)(13,16)(-18,-8)(-9,7)(10,-16)(15,-1)(8,-13)(-8,5)(-18,-7)(-25,19)(-8,-5)(-14,7)(18,-21)(24,18)(-5,5)(-16,18)(-5,-17)(32,-11)(9,-20)(-4,2)(9,7)(6,22)(-10,1)(-39,-9)(16,-24)(14,2)(25,22)(-14,22)(-12,15)(12,0)(3,-19)(-28,-3)(-11,2)(-5,23)(27,9)(-23,2)(-10,-17)(-15,-27)(40,-14)(3,-1)(7,20)(-10,9)(14,-4)(14,-21)(9,7)(12,18)(-17,4)(-33,-26)(-24,-14)(-12,10)(11,0)(24,14)(8,-8)(-17,10)(-15,-18)(14,13)(1,-6)(0,18)(-26,-5)(10,14)(1,-14)(2,9)(28,-19)(14,-7)(43,-22)(-22,17)(-18,0)(-29,24)(-14,-15)(-10,2)(28,-12)(8,19)(24,6)(0,-2)(-17,-6)(-25,-8)(-30,-6)(1,2)(-15,17)(-13,13)(22,-6)(19,3)(39,-9)(4,16)(-16,-1)(-21,8)(8,-24)(14,-10)(20,8)(-24,2)(23,-5)(-34,1)(20,-4)(-13,13)(5,-20)(-16,-1)(1,-16)(-9,22)(29,0)(-25,8)(18,-4)(1,19)(-4,8)(26,-2)(-22,-11)(23,-9)(-22,-13)(7,-4)(6,-1)(1,7)(-7,-3)(10,18)(10,7)(-17,13)(-29,-9)(-33,-17)(12,-4)(12,-13)(32,3)(-13,4)(8,0)(12,-9)(2,10)(-2,3)(-43,27)(22,3)(9,-4)(2,-8)(17,-27)(-11,12)(12,-5)(-32,3)(-6,-11)(15,7)(14,8)(8,8)(-3,-9)(14,5)(3,-8)(-27,3)(4,9)(-25,18)(2,-7)(-36,-4)(-3,3)(2,5)(30,-1)(30,-20)(18,-11)(-39,-12)(-5,22)(-19,18)(2,7)(6,-2)(23,-13)(35,-1)(3,-13)(-16,-2)(-3,-3)(3,5)(29,13)(4,-5)(3,3)(3,4)(-9,-2)(-19,-1)(-11,5)(11,13)(-14,-8)(-11,-22)(-19,-3)(6,-5)(-5,3)(-4,-12)(8,0)(16,14)(28,12)(22,9)(14,-7)(-13,11)(-38,-12)(-40,-15)(-21,-3)(7,21)(25,12)(31,-16)(-2,-13)(-16,11)(-4,17)(20,-1)(12,-10)(-18,-6)(-12,8)(-6,5)(3,-2)(2,-1)(-21,-9)(12,7)(21,-5)(34,5)(-28,-1)(-19,9)(6,4)(19,-12)(15,-15)(-17,-3)(-7,12)(-28,-6)(-12,-5)(-11,1)(30,8)(19,-9)(33,-4)(-5,-1)(-30,3)(-42,-8)(-19,12)(4,21)(15,8)(-15,-18)(24,-22)(15,-16)(27,2)(2,0)(-29,25)(11,-3)(-22,21)(44,-13)(-11,8)(13,-8)(-19,-15)(-14,1)(21,-9)(9,25)(-3,10)(-27,21)(5,0)(27,6)(25,-3)(-23,-17)(-40,-21)(-2,-14)(14,13)(25,-1)(2,-10)(-21,6)(11,15)(-14,26)(20,-19)(10,-1)(-13,-18)(-1,-7)(-38,4)(30,5)(-26,-1)(-5,-18)(-9,0)(34,5)(28,-1)(-22,-2)(-15,-3)(-31,-2)(-11,-7)(12,16)(34,8)(45,16)(-10,-2)(-24,10)(-45,-4)(-22,-8)(7,1)(44,-5)(31,12)(29,-6)(-19,-11)(-12,6)(-38,5)(1,11)(16,-18)(29,-10)(10,-4)(1,7)(-14,-1)(-31,5)(-23,-11)(-12,-7)(16,9)(-12,23)(27,17)(6,-12)(4,-3)(-29,3)(3,5)(21,-2)(2,-8)(-27,1)(-23,-18)(15,7)(16,-5)(0,20)(-9,5)(20,5)(11,-20)(20,-10)(2,6)(13,10)(-8,0)(-13,-8)(-16,-13)(-3,2)(-17,-1)(24,8)(-19,1)(33,-1)(-19,10)(26,9)(-44,-9)(-9,-10)(-23,-22)(27,0)(20,17)(27,19)(3,9)(0,-15)(-6,-8)(-20,4)(-6,2)(5,-14)(1,-4)(13,15)(-32,21)(-10,8)(-7,-28)(42,-18)(39,-15)(1,10)(-12,19)(-12,9)(-17,16)(-21,3)(-16,12)(-12,-11)(21,-10)(-2,-16)(37,-8)(-7,-8)(0,17)(-34,10)(-22,6)(-5,-22)(16,-7)(12,3)(37,9)(26,18)(-13,-9)(-36,7)(-24,-20)(13,20)(25,-9)(18,-6)(0,-3)(4,-4)(-36,15)(20,-10)(-18,1)(33,-8)(0,-6)(19,0)(-32,-5)(-20,14)(5,4)(24,-4)(26,0)(-5,6)(-21,9)(-5,2)(-8,9)(17,-5)(-37,-24)(15,-27)(-15,0)(10,19)(0,20)(28,3)(-4,-6)(-33,-10)(-17,21)(-4,-14)(4,15)(-17,-23)(29,22)(-6,-15)(39,-5)(11,-21)(25,-1)(-20,24)(-38,6)(-33,2)(-16,-11)(28,14)(44,1)(18,5)(-6,-14)(-38,-2)(-22,-14)(12,0)(17,3)(-2,4)(-38,1)(-23,-6)(37,4)(23,12)(14,6)(-9,-6)(-16,-19)(11,-2)(2,22)(6,-1)(9,15)(-4,0)(-5,6)(-5,-23)(-1,-21)(10,2)(-23,4)(1,-5)(1,1)(33,17)(-19,13)(-2,-5)(3,-14)(-7,-13)(-12,9)(-35,13)(44,13)(0,4)(-8,-2)(0,-4)(39,-6)(45,-11)(-10,-8)(-26,11)(-43,-8)(-7,-3)(2,5)(23,1)(-7,16)(-16,0)(-9,-1)(-8,-1)(6,-16)(1,11)(-2,9)(-4,13)(16,0)(9,3)(36,-14)(-29,10)(13,-16)(-19,0)(17,-12)(9,-3)(18,-2)(21,-4)(-28,12)(-38,-7)(-4,-8)(1,-16)(40,12)(1,4)(7,10)(-40,-4)(-12,2)(7,7)(10,8)(-25,18)(13,4)(13,-17)(18,-13)(-3,-23)(16,1)(10,-4)(-23,25)(1,23)(-6,-6)(19,-25)(-32,-10)(-23,14)(8,10)(31,-2)(42,-3)(-24,-12)(-10,7)(-11,0)(18,15)(-31,-16)(-16,14)(7,-7)(23,25)(-11,-3)(2,4)(-8,-26)(15,3)(-13,4)(8,22)(7,-17)(-12,1)(-3,4)(-10,8)(6,5)(18,-8)(-17,-4)(-26,-4)(0,0)(9,1)(14,-10)(1,-1)(2,-9)(1,-5)(-13,-12)(-4,5)(12,11)(12,10)(12,8)(13,14)(-12,1)(-7,7)(-37,-27)(-20,3)(16,-19)(34,23)(30,3)(10,18)(1,-19)(7,-21)(-36,-20)(-35,-4)(-20,7)(19,4)(16,25)(-12,8)(21,4)(17,-18)(-6,-17)(-15,9)(8,12)(10,9)(-4,-14)(-16,1)(3,3)(21,12)(2,-6)(18,-3)(-34,-15)(-1,-1)(-8,4)(20,10)(6,3)(7,9)(-19,14)(-16,-3)(-4,-5)(-1,-10)(18,-2)(12,-15)(3,-7)(-15,8)(-25,4)(15,1)(2,-11)(17,0)(-28,10)(2,-3)(-22,17)(27,0)(2,13)(14,-5)(2,-3)(16,9)(-23,2)(-26,-5)(-3,-13)(1,-15)(15,6)(-22,11)(-6,0)(-11,0)(25,-17)(43,12)(24,-20)(-36,13)(2,-15)(5,6)(34,0)(-21,17)(-28,21)(-15,6)(-9,-11)(27,-7)(-2,-6)(1,6)(3,7)(16,-9)(-15,-10)(8,-15)(-18,-6)(12,19)(-35,-7)(4,0)(18,-12)(-6,-1)(11,-1)(-30,6)(37,-2)(2,6)(3,-9)(-32,16)(-9,-8)(27,-5)(22,-14)(-32,17)(-4,7)(4,13)(32,-1)(14,-5)(0,4)(-8,-17)(0,10)(-30,-16)(8,1)(-28,-2)(-6,2)(-11,3)(9,9)(3,-4)(-8,21)(8,-16)(7,10)(26,-28)(-27,8)(1,12)(-24,16)(26,9)(33,-3)(-9,-6)(-28,-9)(-22,-21)(-3,2)(15,5)(-6,0)(26,-11)(15,-7)(6,15)(5,12)(-13,-8)(10,-10)(12,-2)(27,6)(14,5)(-43,8)(-14,-4)(-13,-7)(-2,2)(7,6)(-24,-3)(5,7)(-14,5)(33,22)(28,-16)(2,-10)(-33,-15)(-21,11)(-4,13)(37,6)(14,-13)(19,7)(-2,-10)(-14,4)(-25,-5)(-22,-4)(16,8)(12,-1)(7,22)(-26,-12)(-11,-14)(-3,-14)(17,-5)(-2,6)(11,5)(4,14)(1,-10)(1,15)(13,-1)(8,6)(-6,-22)(-32,-14)(-6,1)(-21,9)(23,19)(3,12)(1,2)(8,-18)(17,-19)(24,-4)(-23,19)(3,10)(-24,-1)(-7,-7)(-39,11)(23,14)(36,4)(10,3)(-18,-17)(-35,-4)(7,-25)(18,12)(18,-4)(12,15)(3,-3)(-3,-5)(5,-3)(-13,1)(21,7)(6,0)(18,-4)(-20,10)(2,1)(-5,5)(-9,-9)(-22,-13)(-38,-11)(19,4)(6,23)(37,-2)(6,-4)(-11,-19)(-16,16)(-28,0)(3,-4)(17,-10)(19,-6)(9,7)(-8,-3)(13,-6)(11,-10)(-12,-8)(-6,1)(-1,23)(7,7)(-21,22)(-25,2)(11,15)(28,-12)(-6,-22)(9,-2)(-3,12)(30,9)(-24,-15)(-12,-9)(-10,6)(8,11)(6,4)(15,-6)(-4,-5)(-16,-21)(-12,4)(-7,-6)(-1,19)(-25,11)(13,21)(25,-12)(25,-23)(-29,-7)(-35,5)(-24,9)(6,-8)(20,0)(25,-1)(3,14)(-8,0)(-19,-11)(28,-25)(26,-9)(-14,9)(-37,-1)(-43,14)(35,11)(14,5)(39,-15)(-5,-16)(-14,4)(-31,10)(7,2)(34,6)(25,13)(-15,16)(4,-16)(-29,-18)(22,-15)(-11,16)(32,17)(-16,19)(-12,-1)(7,-5)(-17,-4)(20,1)(-23,-9)(10,-3)(-31,10)(-5,-10)(15,-5)(32,-26)(3,11)(-15,-3)(-17,12)(12,-10)(22,14)(11,16)(-7,2)(-35,-15)(-6,-20)(2,13)(7,-7)(-4,-1)(-28,1)(23,0)(-1,-3)(36,6)(-23,24)(11,-1)(-35,-10)(21,-26)(-11,7)(30,5)(-15,19)(2,15)(-3,5)(14,5)(9,-11)(-2,-19)(-32,-21)(-17,3)(-21,-4)(24,-4)(-13,-3)(12,11)(6,23)(33,-4)(11,-4)(-24,-3)(-22,3)(4,4)(17,-1)(2,-1)(-24,4)(-18,-4)(-7,4)(22,4)(1,-1)(5,-13)(-28,0)(18,4)(12,22)(19,3)(-24,8)(-4,-17)(7,-11)(12,-8)(10,-8)(12,5)(-11,8)(-2,21)(-38,-3)(-1,-11)(-29,-12)(22,4)(34,-3)(23,6)(-11,-17)(-8,-1)(-18,7)(16,12)(-29,3)(30,-4)(4,6)(41,-3)(-30,-13)(-1,-9)(-2,13)(18,-3)(-2,9)(-9,-6)(7,17)(14,4)(-29,-19)(-21,0)(-5,-11)(3,9)(19,-18)(-30,0)(11,7)(1,24)(-2,10)(7,11)(-8,-9)(4,-8)(-18,-18)(0,11)(4,-8)(6,14)(14,-4)(7,-3)(1,-14)(-27,-14)(-13,11)(20,1)(21,9)(-9,-3)(-31,1)(-29,-7)(7,-9)(37,4)(23,16)(0,9)(-30,10)(-3,-11)(29,-8)(-1,-9)(-11,4)(-18,6)(19,8)(25,-4)(23,0)(-8,-1)(-8,-6)(0,-3)(15,-2)(-22,1)(-24,9)(4,-2)(35,16)(26,9)(-9,-12)(-28,-19)(1,-24)(-24,0)(28,-5)(-25,10)(16,3)(-20,7)(-6,17)(11,-1)(15,5)(14,-2)(16,8)(-12,9)(15,-4)(-36,-8)(-1,1)(-14,-2)(11,-6)(16,-16)(-22,-4)(5,-3)(5,-7)(3,3)(-18,21)(-18,22)(-5,-5)(37,6)(4,-23)(10,-3)(-31,-17)(-14,9)(-14,0)(15,-9)(-9,-3)(33,-10)(-12,4)(31,-1)(10,5)(-7,14)(-6,21)(-15,2)(6,-7)(0,0)(5,11)(25,-10)(-15,-16)(4,8)(-23,18)(1,-9)(-30,-16)(0,-5)(29,1)(20,10)(7,3)(1,24)(-20,1)(-4,3)(-1,-12)(22,6)(-19,1)(-9,-8)(-26,-11)(1,-6)(-33,9)(5,-6)(11,5)(26,3)(21,-4)(-1,-6)(9,-19)(-26,9)(15,4)(-14,6)(26,8)(15,8)(-4,-4)(14,-17)(-6,0)(20,24)(-24,14)(6,-1)(4,-17)(20,3)(-37,2)(-33,-7)(-23,-15)(20,-16)(-1,5)(-9,7)(-26,-9)(4,6)(5,-14)(18,1)(28,13)(6,1)(26,6)(0,-13)(5,18)(-39,-2)(-36,-8)(20,-7)(38,5)(37,8)(-4,-13)(-21,0)(-1,-9)(-27,20)(-12,-2)(-8,15)(3,2)(-2,4)(-30,-9)(28,-4)(21,-14)(23,3)(3,8)(2,4)(-14,0)(-2,-2)(-23,5)(6,4)(-2,-12)(17,-6)(15,-5)(-15,2)(-25,16)(-24,13)(12,-13)(12,-16)(26,-14)(-29,0)(1,7)(-21,2)(0,4)(5,-11)(8,-11)(34,21)(-3,11)(-22,13)(-38,-2)(-13,1)(42,7)(40,-8)(44,4)(3,-6)(-12,-3)(-6,-12)(0,7)(-12,-9)(-16,2)(-11,-7)(16,5)(19,-4)(0,-8)(-3,8)(-15,24)(-11,11)(-13,-9)(10,-23)(-4,-13)(-22,-6)(-29,18)(2,0)(37,20)(5,0)(-11,4)(-35,2)(26,-21)(24,6)(23,-16)(-3,9)(9,-9)(6,3)(-10,-2)(-34,14)(-7,1)(-3,5)(14,-9)(15,11)(3,6)(-12,3)(-23,-21)(18,-4)(28,12)(-5,21)(-1,-14)(-8,-23)(-9,4)(-31,2)(14,18)(-1,-26)(13,0)(-18,-17)(9,19)(13,13)(10,5)(8,-8)(-32,-15)(-33,11)(-16,-1)(12,14)(35,-20)(42,2)(5,0)(-11,26)(-15,3)(-3,7)(-7,-24)(14,-3)(-2,-16)(18,22)(-31,-6)(-7,2)(-28,-18)(-10,21)(34,2)(23,11)(19,-1)(-39,-7)(-16,-15)(-16,-25)(30,12)(1,17)(3,-1)(-7,6)(-15,-1)(10,9)(6,3)(41,0)(2,8)(-3,-13)(-17,-15)(-20,3)(-33,11)(-29,17)(37,-7)(11,-13)(22,7)(-33,4)(-7,-3)(-5,-9)(10,5)(18,14)(13,3)(1,-4)(-19,-1)(1,-5)(-11,6)(29,-11)(-5,-17)(30,-11)(3,12)(-4,14)(7,5)(-35,-4)(18,-9)(-11,-14)(46,13)(-22,19)(-24,9)(-20,-26)(2,-7)(29,-11)(9,1)(15,-14)(-16,13)(-32,11)(-22,23)(12,-13)(12,6)(6,-11)(-28,23)(15,-2)(13,-15)(17,-11)(-28,-18)(-11,2)(23,7)(41,22)(22,20)(-7,-15)(-28,1)(-33,-14)(1,-3)(24,0)(21,6)(-24,0)(-31,-20)(-7,-9)(-8,7)(35,-3)(-4,13)(41,-7)(-41,9)(11,-9)(-22,19)(16,-7)(-10,3)(15,-15)(10,11)(-6,12)(-4,-2)(-14,6)(1,3)(-24,11)(16,-8)(4,-27)(-5,-11)(6,-2)(25,5)(24,15)(-6,12)(-15,16)(-26,-12)(7,7)(16,1)(27,12)(-37,-24)(-11,-20)(-11,-16)(16,4)(-19,4)(-2,23)(29,11)(13,5)(-14,-12)(-31,-10)(-2,-8)(36,8)(19,16)(-22,24)(-11,-18)(-4,-19)(24,-21)(6,-4)(-2,9)(-5,20)(11,-1)(13,-6)(12,-8)(-17,15)(-3,-7)(1,3)(7,1)(-4,-2)(-7,-8)(-26,-5)(-23,12)(-20,-1)(20,12)(18,7)(9,-10)(13,-12)(7,8)(-10,8)(-32,7)(-23,-16)(6,-4)(30,-18)(-1,15)(-15,6)(-35,16)(24,-11)(25,10)(3,11)(-28,11)(20,-1)(6,-21)(8,-19)(-30,-14)(-8,3)(9,13)(15,-7)(33,18)(19,-4)(16,7)(-27,-9)(-8,-4)(-6,-7)(9,-4)(4,8)(-2,3)(-21,11)(-38,-17)(-30,8)(9,-26)(3,-2)(13,5)(21,15)(13,25)(13,10)(-15,-3)(5,-1)(2,-9)(9,3)(9,-14)(-34,-2)(-20,5)(-13,-7)(44,1)(-5,-20)(27,5)(-26,-8)(7,13)(-15,10)(-18,9)(-4,8)(-27,2)(1,4)(8,-20)(8,6)(42,4)(18,17)(23,-15)(0,-12)(17,-4)(-7,12)(-3,-10)(-37,-13)(-27,-16)(-6,15)(-6,25)(3,18)(-33,8)(2,-13)(28,2)(-2,-24)(10,-11)(-19,-15)(21,18)(-4,8)(8,-12)(-19,-14)(34,1)(-14,2)(15,12)(-35,7)(-1,4)(19,-1)(36,-13)(41,17)(-7,1)(-23,0)(-5,-23)(6,-8)(19,2)(-1,27)(2,12)(-18,7)(-40,-12)(5,4)(21,-14)(35,-15)(-32,-24)(-38,13)(-18,5)(13,18)(11,-6)(1,1)(-6,-13)(12,1)(-10,-7)(5,-3)(10,3)(26,28)(-12,14)(-15,3)(8,-7)(28,5)(-7,-7)(-20,-8)(-25,-3)(-14,-5)(-4,-7)(0,5)(16,26)(-7,1)(24,-14)(1,0)(10,21)(-17,17)(17,-4)(22,-19)(13,-16)(-32,-13)(-28,-8)(-20,11)(9,4)(-4,22)(20,-4)(10,-6)(9,-22)(-21,-14)(-8,9)(9,25)(2,17)(18,-13)(-11,-19)(-11,3)(10,12)(27,10)(41,-8)(-43,-15)(-41,-6)(-19,8)(29,18)(13,6)(-20,-19)(11,-17)(26,-4)(14,14)(-18,11)(-1,6)(-12,0)(-3,13)(0,-13)(27,-11)(1,1)(-8,11)(-2,13)(9,-26)(-1,-8)(7,-1)(-21,19)(-23,12)(-30,0)(12,2)(7,-16)(35,4)(17,-22)(3,23)(-28,-7)(-12,4)(-6,-17)(-15,7)(10,22)(-6,15)(5,-8)(-28,-22)(19,-3)(0,-6)(11,7)(-16,-8)(12,0)(19,14)(28,11)(20,15)(-14,-22)(-25,-26)(-5,-3)(-19,18)(25,8)(-6,-10)(36,4)(6,14)(-7,-5)(-39,-26)(-44,-20)(7,20)(10,23)(34,5)(0,-27)(12,-14)(-34,-3)(-20,27)(-10,2)(31,21)(30,-6)(1,8)(-24,-10)(-25,-15)(22,0)(24,-13)(17,-5)(-6,-2)(6,7)(0,17)(-18,-15)(-5,4)(16,4)(18,22)(4,13)(-27,-1)(-25,2)(-22,-6)(0,-5)(0,-11)(-8,-5)(-12,-2)(32,-10)(3,-2)(-1,-5)(0,1)(4,10)(-5,-9)(3,21)(20,-8)(20,23)(-30,-27)(-2,-8)(12,-17)(-8,24)(-28,17)(-29,17)(30,2)(1,-16)(16,-2)(-15,-2)(20,0)(22,-8)(-17,0)(-6,12)(-28,-12)(11,-2)(-5,8)(15,18)(24,0)(23,-7)(-16,8)(1,-15)(9,-6)(18,-14)(-36,9)(-16,-7)(-11,-4)(33,-15)(-6,-5)(5,2)(2,9)(13,15)(-8,-9)(-25,16)(-26,9)(2,6)(17,-19)(18,-20)(10,-2)(-15,20)(-14,-5)(11,13)(-12,-5)(13,18)(-40,-7)(12,-4)(11,-18)(40,6)(22,-17)(-16,0)(-10,1)(-7,6)(-10,19)(-6,-9)(-23,-5)(-10,0)(-20,14)(9,11)(29,-15)(5,-24)(1,-3)(10,5)(5,3)(-14,18)(-36,12)(-11,3)(12,-19)(8,-14)(11,2)(15,-6)(4,6)(-4,-8)(16,4)(-18,-3)(36,16)(-36,2)(25,-8)(0,-6)(-8,18)(5,9)(-40,-5)(40,-11)(-7,7)(38,8)(1,-11)(19,-7)(0,-1)(0,5)(-5,-10)(-43,8)(-18,4)(1,17)(24,-9)(-9,14)(-3,-17)(14,11)(25,-22)(-6,2)(-11,2)(4,-6)(-20,10)(-21,-5)(-38,16)(23,1)(11,-14)(-1,12)(13,-11)(-6,-6)(3,-4)(-37,19)(-4,24)(35,-1)(-4,-24)(37,2)(-3,1)(20,18)(-42,-19)(-19,-12)(12,-9)(-2,-3)(-4,14)(10,4)(44,11)(11,-13)(-36,-1)(-29,-5)(15,7)(-6,7)(3,18)(-20,-11)(18,-19)(13,-11)(4,-4)(9,23)(1,-16)(-13,17)(12,4)(-29,3)(-1,-20)(0,-24)(-1,14)(27,17)(-38,13)(11,-11)(-5,1)(22,-1)(5,-6)(5,7)(-23,-3)(15,21)(-20,-1)(16,14)(-14,4)(15,-2)(-17,-13)(-13,-4)(-11,-12)(16,0)(-1,4)(21,4)(2,-10)(10,-9)(-30,-6)(11,11)(-12,1)(-12,1)(-31,1)(32,-3)(41,0)(10,-5)(-15,-5)(0,9)(-1,9)(14,-9)(0,-1)(29,8)(11,13)(-30,-8)(-19,-15)(-42,-9)(30,-4)(-4,-5)(26,11)(-29,4)(14,12)(-14,-4)(6,6)(-9,-2)(5,5)(6,-3)(-2,-8)(13,9)(-15,10)(11,0)(5,0)(5,4)(-5,13)(-2,1)(8,-2)(-21,-11)(7,-18)(-22,-5)(14,10)(-37,8)(19,-4)(4,-4)(15,0)(-8,4)(9,-10)(-14,-2)(16,-5)(-2,4)(12,1)(-10,-14)(0,-1)(-12,11)(15,19)(4,0)(23,-16)(7,-12)(9,-1)(11,-2)(-12,0)(-17,-3)(-1,17)(-28,3)(2,-4)(3,-20)(-1,-6)(0,20)(-39,4)(34,7)(9,-1)(13,2)(-4,-10)(-34,4)(17,-6)(-4,25)(14,-23)(-11,0)(9,-25)(-5,23)(-17,2)(-5,6)(26,-3)(-1,4)(0,12)(-4,-14)(29,16)(-7,-18)(-4,-8)(4,-21)(7,8)(2,11)(-8,4)(-31,1)(-16,16)(-15,6)(36,9)(-5,-17)(24,-4)(-12,0)(6,18)(-33,1)(17,-12)(22,-18)(21,3)(2,8)(-32,16)(-4,-14)(-27,-14)(38,-4)(15,14)(6,3)(-27,-22)(-32,-15)(7,1)(18,13)(24,-1)(-8,7)(-14,1)(-10,13)(-15,-2)(20,7)(20,-7)(-6,5)(0,-10)(-31,9)(42,-15)(-34,-8)(24,8)(-40,15)(33,7)(-13,-9)(17,0)(-12,14)(16,9)(8,6)(-18,-21)(-2,1)(-22,4)(0,3)(-35,-2)(37,-2)(-8,1)(18,-19)(-6,-17)(34,1)(18,4)(-2,0)(-22,2)(-11,5)(-19,15)(32,0)(2,4)(17,-14)(-10,3)(-16,-17)(-31,7)(-34,-7)(9,3)(29,-16)(20,21)(-19,16)(-28,24)(11,-14)(26,-11)(40,-13)(-25,13)(-16,9)(-33,5)(0,-26)(26,3)(7,10)(-4,24)(6,-13)(24,-6)(14,-5)(-4,18)(-25,-17)(24,-6)(-5,1)(-14,5)(-16,-4)(-10,-17)(15,8)(5,16)(-23,-4)(23,-15)(8,-24)(38,-4)(-7,18)(-3,3)(-27,16)(7,4)(-7,22)(-6,6)(-8,-4)(-17,-10)(16,-15)(11,7)(-10,-13)(1,-3)(-14,-8)(33,9)(18,16)(12,2)(-26,13)(-28,-2)(-8,-20)(34,-7)(4,-12)(-29,25)(-28,2)(13,10)(20,-13)(-7,-18)(-18,1)(13,5)(-5,14)(20,-1)(0,8)(3,9)(-9,-13)(-27,-10)(24,-25)(-11,-3)(4,-1)(-29,26)(19,2)(18,3)(30,-9)(0,14)(2,-8)(-4,-5)(-15,6)(9,5)(-4,8)(21,1)(-14,11)(14,6)(9,-17)(-12,-16)(-11,-9)(-14,16)(4,18)(-26,-8)(-32,4)(23,0)(19,2)(9,-9)(-1,-17)(-14,-2)(6,2)(-7,11)(-2,-5)(22,-14)(-13,-12)(19,5)(-15,3)(-4,10)(-6,12)(-3,0)(12,-14)(17,-1)(-17,12)(-11,14)(7,0)(2,0)(18,3)(3,-12)(20,-18)(-24,-8)(-29,7)(8,15)(-1,-1)(-6,3)(7,0)(32,-7)(25,1)(-24,7)(-40,19)(-13,9)(7,-5)(33,-9)(24,-25)(17,-18)(-33,0)(-44,-2)(1,26)(38,6)(32,21)(-32,-7)(-9,-18)(1,-18)(25,-17)(-19,10)(-16,14)(-8,10)(6,-1)(-12,-1)(-15,-6)(18,5)(4,5)(33,-3)(7,-2)(-1,2)(-11,11)(-5,-14)(16,-1)(0,-16)(-13,7)(-21,-14)(3,6)(4,-6)(28,-6)(-4,-3)(-18,17)(-28,23)(-8,14)(9,0)(12,-15)(23,-6)(-19,8)(16,7)(-39,6)(23,-7)(0,-7)(15,-2)(0,-19)(15,7)(-1,1)(-23,18)(-30,7)(17,-9)(18,-1)(26,2)(-26,15)(-11,-19)(0,-26)(15,-11)(30,22)(-10,2)(-9,-9)(-18,-10)(-11,21)(-17,10)(-13,-4)(-12,-16)(8,-4)(-1,13)(14,18)(15,11)(35,0)(19,-19)(5,-17)(-35,2)(-38,-2)(-28,13)(16,-1)(3,22)(13,9)(-16,-13)(12,-4)(-12,-5)(26,0)(-15,-5)(44,3)(-4,18)(1,-8)(-2,-1)(14,-27)(39,-10)(0,-21)(-32,2)(-33,9)(-39,18)(31,15)(-7,9)(25,7)(-4,-15)(21,2)(-19,-18)(-18,11)(-17,-13)(3,-1)(17,14)(15,12)(4,12)(-27,-23)(6,-11)(-11,3)(10,18)(-8,14)(14,1)(-21,-15)(2,5)(9,-8)(11,-6)(-22,-15)(-20,-2)(-2,22)(2,10)(17,-6)(-2,-1)(21,0)(-1,12)(11,-21)(3,-10)(-25,3)(28,26)(19,15)(45,6)(-38,-17)(-26,-2)(-20,-1)(14,5)(21,-9)(3,-2)(-2,11)(-28,-2)(-14,-11)(-12,-17)(10,-13)(17,14)(33,4)(15,12)(-25,-5)(-18,8)(7,-7)(23,-14)(4,-17)(-21,15)(1,-8)(16,2)(5,-8)(4,11)(-5,0)(-14,3)(-8,14)(6,18)(29,8)(17,-1)(-17,-22)(-29,-14)(-25,-5)(17,-1)(19,1)(5,-6)(-26,2)(-10,12)(-8,-2)(15,7)(19,-10)(23,11)(-3,17)(-37,-9)(-39,-13)(4,-25)(30,17)(13,11)(-29,22)(-2,-7)(22,-3)(10,-6)(-6,11)(-21,11)(27,-1)(-18,-4)(13,-2)(-15,-2)(19,-18)(-8,-21)(-8,11)(-28,-3)(19,11)(18,-16)(36,10)(-1,-6)(-20,-8)(-34,2)(-4,9)(21,-1)(22,6)(6,-14)(-36,9)(-8,-14)(0,4)(37,16)(3,8)(-32,1)(-25,-1)(-19,10)(17,0)(0,2)(-1,-6)(12,1)(-12,-2)(11,-12)(-29,0)(-2,-7)(-11,14)(-7,7)(38,-6)(34,8)(21,-13)(-8,-5)(-25,-2)(-6,18)(-25,7)(36,-24)(-1,-7)(17,11)(-43,13)(10,-5)(3,-13)(7,-4)(12,4)(-7,13)(7,0)(-5,4)(25,-24)(-11,9)(-8,-8)(-41,-1)(6,5)(16,2)(20,3)(3,-2)(1,7)(10,3)(6,-8)(-9,-15)(-3,-6)(-10,-5)(-31,-4)(-24,2)(12,1)(45,23)(28,19)(-9,-2)(-12,-14)(12,-1)(32,13)(12,10)(-33,-6)(-43,-2)(-8,4)(9,-2)(34,-6)(8,-15)(20,4)(-1,6)(-24,11)(-9,-1)(-30,-11)(19,-9)(8,-12)(13,-2)(-28,-6)(-21,-3)(5,-2)(1,15)(18,22)(22,22)(-11,-18)(-3,2)(-33,0)(26,16)(-2,-21)(3,-22)(6,-18)(-2,4)(22,0)(-2,6)(-2,14)(-9,18)(-4,15)(-8,-17)(-8,7)(-1,-2)(11,14)(-18,-6)(-11,1)(-17,-17)(32,6)(-3,0)(28,13)(-25,-2)(-7,-2)(-2,1)(29,-25)(38,7)(-13,-6)(2,7)(-25,-6)(-3,4)(-10,-5)(14,-9)(-15,6)(-16,9)(-8,8)(15,-1)(10,6)(-1,0)(21,-10)(-17,3)(-13,7)(-44,10)(32,-18)(20,-1)(19,2)(-16,7)(-19,-1)(1,7)(12,14)(-6,5)(14,-4)(-16,0)(36,-6)(-23,-18)(21,-8)(-17,3)(17,20)(-16,-10)(16,-13)(5,-19)(-4,8)(-26,-12)(-34,2)(-20,-6)(-15,8)(21,7)(41,19)(3,0)(7,5)(-24,-10)(0,9)(-4,6)(23,-11)(22,-13)(4,-11)(-7,17)(21,6)(-19,-10)(7,4)(0,5)(18,19)(6,-13)(-40,-2)(15,-12)(-6,11)(20,10)(-17,-2)(-38,-6)(11,-8)(10,17)(37,4)(-29,-15)(0,-22)(-6,4)(31,8)(-27,10)(-25,-12)(-31,7)(28,5)(30,-12)(15,12)(-24,-14)(-10,22)(-21,-25)(-8,21)(8,-24)(22,12)(-4,-17)(-4,5)(15,14)(41,5)(-15,18)(-21,-7)(3,-8)(-2,-1)(-5,-4)(-37,17)(-8,1)(-6,7)(10,-11)(36,0)(34,0)(-8,15)(-25,-4)(-27,2)(37,-25)(27,4)(2,-20)(0,2)(-42,0)(0,13)(-36,16)(-3,-23)(-1,-11)(21,-16)(18,16)(-13,-4)(0,6)(5,-10)(31,4)(13,-8)(-6,13)(-24,2)(-40,21)(-1,-2)(22,14)(40,-14)(-3,-13)(-24,-7)(-23,10)(4,21)(-7,-7)(-15,6)(23,-24)(29,14)(27,-2)(-7,22)(4,0)(-23,-24)(1,-17)(-12,-12)(28,12)(-25,-2)(-16,-6)(6,2)(0,23)(20,1)(-44,14)(-7,-16)(-8,15)(13,-5)(40,3)(-16,-17)(-7,-8)(-17,6)(19,8)(2,-1)(-14,-19)(-18,11)(28,6)(13,3)(20,-14)(-34,-12)(-22,3)(-20,-2)(41,-1)(7,0)(24,2)(-39,5)(35,-6)(-23,-9)(26,-5)(-10,8)(5,9)(-20,21)(-8,-6)(7,13)(8,-14)(-4,21)(4,-1)(1,14)(-3,-21)(19,-17)(-7,-7)(-19,12)(4,1)(18,-9)(30,-4)(-12,6)(4,15)(16,11)(-28,0)(3,-6)(-11,-1)(14,11)(-16,-15)(-26,-22)(27,-12)(-13,-3)(13,7)(-25,14)(27,18)(8,4)(-11,-18)(-25,3)(-20,13)(3,17)(11,-15)(26,-14)(23,-23)(-20,12)(7,-4)(-21,9)(42,-3)(-4,-4)(-10,10)(-24,-3)(-25,15)(12,-20)(-3,-4)(-14,7)(24,3)(-5,-2)(2,0)(-37,15)(3,-4)(12,3)(17,6)(10,11)(10,-22)(-2,-5)(-23,-10)(0,9)(1,7)(27,5)(4,-3)(11,-15)(-18,3)(-19,16)(-6,-5)(34,-2)(28,-19)(15,21)(-30,6)(-29,8)(-12,-18)(13,-4)(9,-4)(17,19)(-3,-12)(-7,1)(-25,0)(-12,21)(20,3)(0,-8)(-6,-5)(-1,-1)(28,-3)(-5,6)(-15,-15)(-25,-9)(44,3)(22,17)(12,11)(-27,-19)(8,4)(-21,2)(5,10)(-21,-3)(12,-3)(-17,-11)(7,5)(21,-1)(-5,5)(15,-20)(-44,-14)(31,-7)(-6,18)(0,6)(-5,5)(1,-2)(4,1)(-27,-8)(-21,-18)(6,4)(17,26)(-9,1)(5,13)(16,-20)(23,6)(18,-19)(-9,16)(-30,-4)(-24,11)(-17,-15)(18,5)(31,-6)(22,1)(11,19)(-32,15)(14,-10)(14,-6)(-1,-9)(-10,9)(-40,-9)(4,7)(4,4)(-6,-3)(27,-25)(-30,11)(14,15)(-2,27)(36,-13)(19,-15)(3,-20)(-41,13)(3,10)(-8,19)(2,-23)(-23,-18)(-30,0)(40,13)(-3,5)(8,-18)(-20,7)(14,14)(15,12)(12,-6)(-24,-4)(16,-15)(-34,4)(21,-11)(-37,20)(30,-18)(-17,10)(2,-18)(-14,21)(8,-14)(16,10)(22,-15)(22,12)(19,-14)(-3,21)(-11,-14)(4,18)(0,-14)(-8,1)(1,-22)(-27,9)(-2,0)(-43,23)(2,2)(-1,24)(10,2)(-5,-25)(22,-22)(21,-8)(8,21)(-7,8)(-26,-16)(-10,-11)(-13,8)(38,7)(5,-2)(19,-15)(-10,17)(34,19)(5,6)(5,-7)(-36,-12)(6,7)(-32,-8)(9,-3)(-22,-14)(5,-8)(21,16)(12,10)(9,18)(-2,-26)(2,-11)(14,-18)(1,5)(-1,9)(0,-2)(4,6)(-7,12)(-17,10)(-23,-10)(10,-17)(14,5)(5,5)(-5,18)(-2,-1)(-16,19)(3,-16)(-16,11)(3,-19)(-26,0)(-5,-17)(31,-1)(10,2)(-9,-2)(-19,12)(17,13)(1,4)(19,5)(-13,-2)(9,-2)(-41,-15)(15,-8)(27,-4)(22,10)(-39,15)(-30,5)(12,4)(13,-22)(14,-5)(-17,5)(27,-2)(16,-1)(5,-21)(-35,-1)(3,-2)(17,3)(39,8)(-27,6)(-32,6)(-11,4)(8,-7)(4,4)(-19,2)(9,22)(7,6)(4,9)(-13,4)(-12,-23)(7,-8)(-6,-6)(9,1)(15,4)(31,-14)(19,8)(6,-1)(-1,-2)(2,12)(-14,-12)(-38,17)(-2,-13)(14,-3)(15,-8)(4,-2)(-5,-4)(16,9)(-12,13)(-20,-1)(-35,1)(-19,-8)(-8,26)(14,-15)(38,-11)(32,-24)(31,-5)(-10,24)(-23,12)(-2,14)(-17,-4)(10,-4)(-24,-2)(27,-8)(0,-8)(-13,-4)(-27,-3)(8,-2)(18,-11)(-18,-8)(-1,23)(19,8)(9,6)(-30,-14)(-34,2)(34,6)(28,15)(26,3)(0,3)(9,-8)(-14,-7)(-38,6)(-38,3)(-13,9)(2,-17)(-6,-19)(33,4)(2,7)(27,3)(-14,-19)(-8,13)(-28,24)(-26,28)(23,-8)(31,-16)(26,0)(21,-4)(10,15)(-4,-8)(0,6)(-11,-14)(-14,-17)(-12,-6)(13,-5)(3,2)(-22,4)(-38,4)(-12,-4)(24,-2)(15,-9)(10,25)(-20,-15)(11,11)(6,-13)(28,13)(11,2)(27,3)(-22,-16)(-19,-13)(-3,4)(17,3)(15,-1)(-6,-17)(-34,10)(-30,-2)(-12,23)(0,15)(2,5)(9,-14)(29,-2)(-10,7)(-2,16)(-8,-14)(8,12)(-2,-27)(-15,4)(15,-13)(-5,-1)(34,-3)(20,2)(22,13)(-8,6)(-24,15)(2,9)(-5,-18)(-7,-3)(-27,-9)(-3,13)(-9,-11)(-8,-12)(15,-3)(35,1)(4,1)(-4,-7)(-31,0)(21,23)(-17,-1)(3,-3)(1,-8)(-10,24)(1,10)(-27,3)(6,0)(12,0)(26,0)(-7,0)(19,4)(-18,-8)(21,-24)(0,-17)(7,-3)(14,2)(-1,19)(20,18)(-39,11)(-35,-12)(-38,-11)(32,4)(31,-16)(28,-13)(-11,-8)(-29,15)(6,3)(-7,-11)(13,7)(-16,0)(15,4)(5,-22)(-24,-6)(-6,3)(-25,25)(37,7)(-9,20)(25,-3)(-4,17)(2,-15)(3,-4)(-2,-11)(6,-6)(11,-17)(11,4)(8,-2)(-41,18)(-2,7)(-33,16)(6,-11)(-13,-20)(12,-3)(29,13)(-14,-3)(15,-2)(-23,-15)(20,18)(-29,-9)(-10,1)(-32,-12)(15,16)(19,-1)(39,13)(-13,-1)(14,21)(-10,-14)(41,-1)(-22,-10)(-8,13)(-32,-20)(0,5)(17,-5)(9,2)(17,-12)(-20,9)(17,7)(12,6)(-10,-14)(-22,11)(-14,7)(-6,-2)(11,-20)(11,-10)(19,-4)(-13,8)(-24,-4)(-8,6)(-11,15)(6,2)(24,-7)(34,4)(23,9)(-11,14)(-5,-23)(-27,4)(-25,-3)(2,10)(19,-8)(31,-8)(-21,-12)(-13,11)(1,5)(14,21)(-23,-13)(-9,7)(5,-12)(8,0)(-24,-14)(-3,-4)(35,6)(11,21)(-14,5)(-34,-5)(0,-20)(14,-12)(2,4)(-7,16)(-12,14)(22,-8)(9,-13)(19,-5)(-7,-10)(-10,10)(-26,5)(9,21)(32,-16)(33,0)(9,-7)(7,14)(-1,12)(-11,11)(-11,-2)(-16,-27)(9,-19)(-4,15)(6,28)(-5,3)(-19,-11)(10,-3)(-30,0)(34,-12)(-19,-4)(25,5)(-42,-3)(22,1)(-2,4)(11,20)(-20,-19)(-23,3)(-10,-3)(2,19)(9,-18)(1,-15)(-6,-5)(30,19)(24,14)(5,-4)(-11,-20)(-25,-18)(14,8)(-21,7)(19,27)(0,-7)(13,6)(6,-6)(-28,10)(-14,8)(-15,3)(7,-11)(-6,-20)(14,-10)(-17,15)(-4,13)(4,-6)(33,-23)(19,0)(-4,-6)(-21,4)(-19,-4)(9,23)(0,6)(23,-11)(6,-4)(0,6)(-12,18)(-6,-18)(-3,-13)(-2,-12)(-24,5)(-3,0)(-11,14)(17,-8)(32,20)(10,0)(-9,27)(-21,-7)(10,2)(3,-4)(-13,0)(-1,-14)(-23,-13)(13,-9)(24,11)(43,9)(2,-12)(-31,-12)(-21,-8)(-4,0)(-5,5)(-9,6)(-2,15)(-3,-4)(33,-15)(-4,5)(2,17)(-44,17)(3,-16)(0,-25)(32,-19)(1,7)(1,0)(-18,22)(-4,4)(12,7)(11,6)(22,9)(14,15)(7,-4)(-16,-18)(-28,-19)(4,-8)(-10,3)(13,21)(-18,9)(27,7)(27,-20)(16,-6)(-27,-7)(-25,2)(-10,-17)(35,-6)(22,-5)(17,1)(-33,12)(2,-1)(-41,1)(5,-4)(-18,21)(16,12)(31,14)(-26,-18)(-10,-14)(-26,-12)(4,3)(11,5)(11,7)(26,12)(12,13)(-7,-15)(-13,-11)(-26,8)(-17,-3)(9,12)(-2,-11)(3,19)(-4,5)(31,-16)(20,-18)(-16,-23)(-21,10)(-20,12)(-4,17)(24,13)(-8,9)(18,-1)(-14,-10)(41,-20)(-9,-9)(-13,-1)(-28,24)(22,0)(18,-5)(6,-28)(10,10)(-12,19)(-15,25)(-6,-1)(20,-21)(16,-3)(-36,-6)(-4,12)(18,4)(38,13)(8,8)(-37,-18)(-30,-22)(-8,-16)(33,18)(12,-1)(0,-7)(0,2)(1,5)(-21,0)(-2,-21)(-19,11)(-7,19)(-28,10)(37,-11)(41,0)(18,-14)(-22,17)(-32,-17)(18,2)(11,-4)(-10,12)(-37,19)(-7,-8)(18,1)(26,-11)(-2,9)(1,-6)(3,12)(-18,-6)(-15,1)(-14,0)(13,10)(27,-7)(10,-20)(14,-21)(-4,-1)(-30,10)(1,12)(-30,22)(17,-6)(-10,2)(20,-8)(-7,19)(20,-19)(15,-15)(35,-5)(-3,8)(-19,2)(-6,-8)(-8,4)(-12,4)(-24,-2)(11,-8)(4,15)(-10,-1)(-20,15)(21,1)(12,-10)(10,-3)(-28,-15)(29,15)(9,6)(3,9)(-42,-8)(1,1)(16,-14)(19,6)(-18,-8)(3,9)(8,-10)(-14,5)(4,-10)(-11,13)(5,-12)(-14,2)(-13,-18)(19,-3)(-13,8)(13,21)(3,21)(25,3)(17,-15)(-2,-8)(-12,-4)(-27,9)(-24,-3)(-3,1)(6,4)(12,-7)(27,5)(13,-10)(-16,20)(-11,-4)(6,19)(1,-19)(-4,9)(-34,-11)(21,-1)(-14,-7)(6,9)(-18,0)(20,-5)(29,-23)(26,-5)(8,-10)(-14,5)(-27,6)(-13,0)(-19,16)(20,-6)(15,10)(-1,-5)(-28,22)(-12,8)(43,8)(39,-2)(17,1)(-37,-6)(-22,5)(-25,-7)(6,-5)(14,-25)(3,-4)(21,-13)(-32,25)(-17,10)(7,1)(3,-25)(26,-19)(-30,20)(2,15)(-27,9)(-2,3)(25,-8)(13,-2)(5,-26)(-29,6)(25,9)(-8,19)(6,4)(-34,2)(35,-18)(22,4)(21,-3)(-35,19)(-6,-16)(-21,1)(20,-13)(3,0)(21,7)(18,-8)(-21,17)(-13,1)(0,19)(40,-6)(30,-7)(1,-4)(-13,3)(-15,-17)(-34,3)(-30,1)(7,26)(-3,-13)(8,-9)(-14,-7)(2,-1)(7,-1)(10,0)(6,14)(25,7)(13,-7)(17,-17)(-8,-19)(-12,-13)(0,6)(-4,6)(3,25)(-8,9)(-24,-2)(-30,-20)(9,4)(24,7)(12,6)(-17,-8)(-25,3)(-10,3)(28,-2)(41,-5)(37,-5)(-12,-2)(-8,14)(-12,-10)(-27,5)(-26,-7)(-34,17)(15,1)(2,-16)(36,5)(-15,11)(-13,18)(-24,-6)(22,2)(-1,-8)(20,-7)(-5,-13)(11,16)(-3,-8)(-13,-1)(-3,-5)(1,12)(25,15)(37,-14)(-9,3)(-34,-22)(-44,6)(0,-5)(19,9)(26,-13)(14,-9)(21,-12)(-2,11)(-33,18)(-17,8)(-8,-6)(24,-3)(-16,15)(0,-1)(-21,-16)(34,2)(26,23)(38,27)(-36,-18)(3,0)(-41,-6)(10,3)(0,-15)(11,-11)(-16,-7)(-33,-9)(7,7)(3,2)(-11,8)(23,9)(-3,10)(16,2)(-37,-22)(18,0)(16,14)(26,12)(2,2)(-30,-23)(-14,-6)(8,-18)(11,19)(4,4)(0,17)(13,-1)(21,12)(17,5)(-3,-18)(-32,-11)(-41,-8)(-5,21)(0,10)(2,-3)(-13,-13)(-4,-13)(15,4)(36,-3)(-6,-6)(-2,4)(-41,15)(37,-6)(16,-20)(25,1)(0,14)(-29,7)(13,-7)(-22,-10)(36,-5)(-34,6)(-12,13)(-41,23)(31,-3)(34,-7)(8,-21)(9,3)(-38,-4)(32,15)(-39,1)(33,-7)(-22,-6)(38,0)(-20,11)(0,-4)(-10,-13)(23,-1)(5,-2)(-20,0)(-19,-7)(-1,15)(-3,-3)(16,13)(8,3)(20,16)(-1,10)(-7,-15)(-4,-11)(10,2)(5,4)(0,5)(1,-13)(-28,-2)(-12,-19)(-31,5)(20,-10)(19,24)(0,-16)(10,21)(-3,-20)(21,14)(-16,-22)(2,-1)(-32,-13)(20,22)(9,15)(14,2)(-5,-18)(-12,-13)(16,-1)(-12,4)(-10,17)(14,13)(23,4)(20,-8)(-38,1)(-17,-9)(-4,-9)(15,-4)(14,17)(-4,21)(-10,7)(-20,-11)(5,-3)(26,-4)(4,6)(-35,-7)(-21,-5)(7,3)(18,6)(-14,-9)(-13,-12)(-4,-15)(14,3)(-11,14)(-16,15)(-17,7)(-1,-5)(33,-17)(5,0)(15,-10)(2,-3)(19,-10)(19,-4)(-7,25)(-4,23)(-10,12)(-19,-24)(17,-21)(-27,2)(4,0)(-2,0)(20,-2)(9,8)(-15,15)(-19,-3)(8,-10)(-18,-11)(41,9)(14,26)(34,15)(-43,0)(-44,-7)(-35,-5)(45,-6)(24,-19)(15,-12)(-46,3)(-20,16)(6,1)(41,8)(29,-15)(-10,9)(-19,-19)(11,9)(32,2)(20,-5)(1,14)(-11,2)(-39,23)(-35,-8)(13,-11)(43,-12)(-9,8)(-40,13)(-1,8)(22,-1)(16,-10)(-23,-1)(9,-14)(12,1)(-14,-1)(2,12)(-13,0)(20,0)(-14,-23)(8,3)(-25,-1)(5,20)(-22,-14)(13,-12)(2,-13)(36,22)(-6,4)(-18,3)(-33,-17)(-2,-3)(23,16)(4,-5)(16,8)(-20,-19)(22,8)(-5,-14)(27,2)(-10,-2)(4,20)(2,-1)(3,-7)(7,6)(4,-2)(9,13)(-1,-9)(-45,11)(-34,9)(-2,1)(30,-13)(37,-1)(-12,-13)(-18,8)(-27,-12)(28,14)(30,8)(29,7)(-31,-2)(-26,6)(-33,0)(21,-2)(23,-25)(-9,3)(7,-6)(-20,9)(27,-6)(-30,5)(22,7)(14,-15)(-1,-15)(-8,-3)(3,19)(32,1)(-19,-9)(-28,-10)(-18,18)(-12,4)(18,-9)(-14,-10)(4,0)(-20,24)(30,1)(32,1)(24,-16)(-12,4)(-6,18)(-14,-2)(18,-2)(-10,-4)(-1,16)(-26,-12)(7,-20)(11,3)(23,21)(-12,4)(-4,-17)(-38,3)(5,16)(-17,16)(13,-23)(-14,1)(-3,-20)(-16,12)(28,-5)(-2,-1)(38,11)(-32,-19)(21,16)(-13,0)(18,21)(15,-21)(10,-6)(2,-21)(-15,19)(-18,3)(18,7)(-28,-17)(17,-21)(-19,7)(22,7)(0,1)(-15,-9)(-14,19)(-33,20)(-7,15)(-8,-7)(30,-18)(7,3)(33,-7)(-12,10)(4,-8)(10,-8)(24,6)(3,-5)(-5,6)(-25,-1)(-8,-2)(-4,4)(-15,3)(15,17)(-11,12)(26,-19)(1,-22)(-11,-1)(-19,3)(-3,18)(4,-14)(9,6)(-12,-5)(11,6)(11,-2)(22,-8)(2,-10)(-8,18)(-30,0)(-5,5)(-3,-24)(34,-3)(-25,1)(-7,24)(-25,9)(35,-2)(-8,1)(25,0)(-3,6)(-3,-24)(-2,7)(-18,-8)(9,0)(3,2)(17,-4)(4,12)(-28,-24)(3,6)(31,8)(38,24)(11,11)(-27,-9)(-2,-18)(-6,0)(-1,-9)(-13,3)(-22,4)(2,1)(-11,13)(-2,-13)(9,11)(-15,-10)(28,7)(-18,-7)(19,-9)(-30,-14)(-5,5)(9,8)(0,-1)(40,-15)(13,-10)(32,-6)(-17,20)(-24,17)(-30,6)(5,6)(-21,2)(13,19)(6,-5)(12,3)(-10,1)(-34,-4)(-13,-13)(18,-26)(36,4)(27,15)(-20,13)(-23,-3)(2,-17)(13,-5)(-16,-12)(3,5)(-4,12)(16,2)(-13,-4)(-7,-12)(-15,18)(1,-2)(21,3)(11,-19)(5,-6)(-26,15)(-2,5)(20,6)(8,-25)(-7,-6)(-32,4)(-15,22)(22,-7)(10,15)(-6,1)(-9,10)(-10,-26)(32,-9)(-6,-6)(6,28)(-31,-12)(26,5)(-10,0)(1,21)(-12,-7)(-8,-2)(26,2)(5,6)(45,-10)(-28,-11)(-2,-5)(-22,10)(30,4)(-7,4)(0,-21)(-26,-1)(-17,6)(-21,2)(-1,-3)(17,-1)(20,5)(19,-4)(2,15)(-14,12)(5,-8)(0,-6)(18,3)(-5,12)(-8,7)(-13,-20)(-16,-8)(16,-17)(8,17)(23,16)(8,-9)(16,-10)(11,0)(-16,10)(-9,-7)(-13,1)(11,-3)(7,2)(8,-16)(-29,1)(-2,3)(-4,4)(20,-1)(-33,-4)(-25,13)(8,-4)(11,-5)(35,-12)(2,-3)(-2,10)(-40,-5)(-15,21)(-3,-7)(37,-4)(11,-21)(19,6)(-34,4)(1,21)(6,4)(31,4)(-16,-6)(-15,-9)(-17,1)(12,-1)(13,9)(11,2)(-19,-12)(-14,-5)(3,-3)(7,12)(27,2)(-30,-13)(9,-10)(-22,-1)(38,20)(-26,-3)(-9,6)(-9,3)(4,2)(10,2)(-30,-18)(19,13)(-12,-10)(18,6)(-14,-1)(0,7)(-10,6)(22,-14)(9,-3)(33,-4)(-21,0)(14,2)(0,11)(26,19)(-26,11)(3,-22)(-22,-7)(17,-13)(-40,13)(17,-1)(11,-5)(11,9)(5,-9)(-34,5)(21,-21)(3,4)(31,13)(-22,21)(-38,-5)(10,-3)(15,-14)(38,18)(-41,3)(-6,11)(-16,4)(12,-3)(-20,-11)(-23,-2)(-13,-13)(-1,7)(4,-20)(30,8)(-3,-12)(-5,3)(-22,-8)(37,-1)(21,8)(13,4)(-17,11)(-14,-9)(21,0)(24,-15)(-6,18)(-3,-7)(-1,5)(0,-13)(-24,5)(-25,23)(34,-11)(18,-12)(8,-23)(-34,16)(6,5)(16,9)(41,-7)(6,2)(-18,-1)(1,2)(-30,20)(8,3)(-37,5)(21,-7)(7,9)(-3,-16)(-9,2)(-18,-5)(39,18)(2,0)(-3,4)(-21,-14)(1,-12)(-9,-22)(9,20)(-22,17)(0,2)(14,-3)(36,-7)(34,17)(-14,-6)(-30,-7)(-38,-20)(9,-10)(10,-11)(7,4)(-16,5)(-10,21)(-7,-2)(17,-1)(31,-4)(-4,24)(-37,3)(-42,-8)(1,-15)(40,2)(37,1)(20,15)(-17,-11)(-34,-11)(-17,-10)(11,21)(-4,24)(2,-3)(8,-3)(44,0)(-7,6)(-22,1)(-21,-12)(45,-3)(-2,-1)(16,-2)(-44,4)(-21,-9)(-15,13)(27,-18)(5,8)(-12,-19)(17,17)(0,-9)(9,13)(-9,-19)(-3,-2)(2,-8)(-2,16)(32,-4)(13,-10)(-25,11)(-22,23)(-26,27)(2,0)(15,-3)(-3,-22)(5,-20)(-16,-14)(27,18)(-6,12)(30,15)(-14,-6)(7,-6)(-23,-4)(-12,6)(9,-8)(-3,-12)(14,-22)(-26,-6)(22,17)(1,19)(7,19)(-29,0)(18,-18)(-2,-4)(12,-6)(-37,19)(8,4)(3,4)(21,2)(-8,9)(16,-11)(6,-13)(13,-26)(-27,-4)(5,-7)(0,18)(26,-4)(0,18)(20,-9)(7,3)(7,-13)(6,-2)(-43,17)(-43,6)(-40,-1)(18,-8)(-1,-9)(25,7)(0,-6)(38,15)(-13,1)(-19,-1)(-5,-11)(-14,12)(-1,3)(-3,3)(40,-15)(8,-3)(9,15)(-31,-2)(15,1)(-24,-11)(27,15)(-22,2)(-9,-1)(-11,-21)(14,6)(20,1)(-2,3)(27,6)(-20,-10)(5,11)(-20,-7)(-2,-6)(7,1)(23,9)(40,27)(7,8)(-21,-26)(-14,-13)(-2,-22)(-3,8)(-13,5)(-29,19)(14,-7)(27,1)(15,-5)(-21,19)(-34,6)(-27,4)(-5,-7)(7,-27)(38,-10)(37,-3)(22,17)(-1,3)(-11,5)(-19,-11)(-27,9)(-21,-7)(-3,15)(11,-16)(-7,-2)(-13,-8)(-17,-5)(27,2)(29,-3)(28,5)(3,-7)(2,-10)(-2,9)(-4,-1)(-36,13)(-27,6)(4,18)(39,-1)(30,-22)(-25,6)(4,16)(1,19)(17,-24)(-6,-2)(7,-20)(6,0)(-2,-24)(-8,0)(-32,4)(-28,8)(-29,10)(25,3)(30,2)(16,4)(-13,-3)(-1,-10)(-4,-7)(-9,8)(-15,22)(-6,3)(17,-3)(2,-13)(11,-1)(-23,13)(14,0)(-13,-2)(15,-4)(-31,3)(27,-1)(29,-6)(4,9)(-25,10)(1,1)(12,-5)(3,-5)(1,4)(4,8)(9,7)(-20,5)(0,-2)(2,4)(18,-19)(-2,2)(-12,-9)(-36,4)(7,-26)(24,3)(10,13)(-30,12)(-19,-13)(19,-16)(13,-8)(16,17)(2,17)(10,-4)(-34,-15)(3,-1)(-11,27)(29,1)(-24,-4)(27,-21)(0,2)(3,10)(5,-1)(5,0)(22,-21)(-6,-5)(8,9)(-7,19)(-8,12)(-30,7)(-4,-6)(2,-10)(10,-13)(-12,-9)(-13,9)(-3,-2)(-10,-11)(11,4)(-3,11)(24,12)(-9,-8)(-5,4)(1,-5)(-9,7)(32,-7)(-22,21)(-11,9)(-44,-4)(7,-11)(17,-22)(9,4)(-14,1)(25,23)(7,-14)(12,-1)(-17,-6)(27,9)(12,4)(5,4)(1,8)(-15,-14)(14,-7)(-1,-5)(8,19)(-36,5)(-35,-15)(5,-10)(13,1)(-7,-2)(3,-1)(8,-6)(30,15)(-5,-8)(4,10)(-12,3)(19,-3)(-11,-19)(24,-11)(-30,5)(-18,18)(-20,17)(31,-8)(29,-23)(-1,-8)(-15,27)(-4,27)(9,12)(-15,-11)(10,-25)(9,-24)(8,-5)(-6,13)(-19,11)(-22,11)(-2,6)(18,-13)(32,-16)(-16,-18)(-22,20)(6,4)(29,17)(26,-4)(-22,-10)(-25,-4)(-20,-10)(0,23)(11,-16)(9,9)(-3,-14)(5,27)(-1,-11)(-8,-5)(-24,-15)(9,11)(22,7)(3,15)(2,-2)(-4,11)(-16,-6)(-20,0)(10,-11)(27,4)(7,1)(-33,-5)(-12,-7)(-5,-8)(43,-3)(30,-15)(21,-4)(-43,3)(-35,16)(-37,9)(2,8)(11,5)(-8,8)(35,-8)(-4,-18)(34,-12)(-38,19)(25,-4)(2,17)(29,-13)(-12,10)(-6,-13)(16,10)(-27,2)(-19,1)(-37,-14)(23,-6)(1,-1)(15,16)(8,4)(11,5)(-24,-10)(-26,2)(18,-17)(0,-7)(32,-3)(-3,13)(25,16)(-1,5)(8,5)(-21,-6)(-6,6)(-20,-18)(-3,1)(-13,-14)(5,15)(31,-7)(-4,18)(6,1)(-8,0)(1,-19)(1,-15)(9,3)(-14,15)(-4,18)(-20,1)(42,-21)(12,-9)(6,-3)(-43,23)(-38,-2)(9,-4)(26,-16)(20,0)(-23,2)(-10,18)(-14,9)(6,5)(-9,-7)(10,-18)(10,-8)(21,8)(-7,8)(19,-2)(13,-18)(28,-4)(-9,2)(-12,1)(-21,11)(5,-8)(5,-11)(12,-15)(-23,5)(-14,25)(-3,19)(7,17)(-12,-20)(-5,-17)(11,-6)(-2,4)(10,11)(13,-1)(24,11)(1,9)(-26,5)(-26,-9)(-29,-7)(21,8)(-1,11)(3,7)(-27,-17)(31,5)(2,0)(18,6)(10,-15)(1,-20)(-13,-16)(0,11)(-16,2)(16,0)(-34,-4)(39,21)(-32,13)(9,-1)(-26,0)(43,11)(-10,0)(26,-13)(-6,3)(27,10)(-1,16)(-25,-27)(-10,-15)(-22,-13)(-4,6)(-5,7)(-6,4)(4,5)(5,5)(-1,-17)(26,6)(3,-10)(1,11)(5,-1)(13,2)(34,4)(-14,-8)(-25,1)(-27,-5)(7,1)(5,9)(-5,-8)(-21,14)(-20,-15)(3,23)(23,-19)(3,9)(1,-10)(-39,10)(7,3)(19,8)(32,-10)(18,-19)(-3,-20)(7,16)(-7,11)(-16,21)(-37,-3)(-8,-9)(12,-3)(3,-17)(25,16)(-17,-22)(7,6)(-14,-20)(18,0)(17,12)(-18,-2)(-10,12)(14,5)(33,23)(24,11)(-24,-20)(-35,0)(0,-21)(-4,12)(31,1)(-32,8)(26,-3)(3,-13)(-9,1)(-27,15)(-37,9)(8,12)(3,-2)(17,-6)(-3,-12)(6,-7)(16,9)(-2,0)(0,-5)(-15,-10)(18,2)(9,-14)(-13,-2)(11,8)(-16,8)(35,-1)(7,-13)(-10,16)(-37,9)(-19,9)(0,0)(21,-12)(13,-12)(31,-23)(8,-7)(2,-5)(6,26)(-6,5)(7,0)(-12,-8)(-26,9)(-35,1)(-6,2)(-3,-8)(-4,1)(8,-10)(4,3)(-2,11)(7,-6)(4,16)(10,-6)(-22,16)(11,-21)(-7,-4)(3,-12)(-10,-5)(22,-1)(11,10)(3,14)(-23,19)(14,1)(-4,1)(5,0)(-13,-12)(2,-3)(36,-22)(13,17)(-3,6)(-45,28)(-12,-8)(14,9)(25,-22)(-9,-5)(-21,0)(-9,22)(-1,-1)(22,-16)(7,-17)(-13,-11)(-7,-9)(-17,-2)(11,1)(10,15)(13,2)(-18,4)(8,3)(13,16)(5,7)(-35,-10)(-32,-1)(-1,8)(3,17)(44,-13)(-8,7)(-3,0)(-45,14)(32,-23)(2,-18)(7,-16)(11,20)(5,-5)(-4,15)(-22,-1)(7,9)(40,-1)(-9,-22)(19,7)(-8,2)(32,10)(-2,1)(6,-5)(-12,16)(-18,4)(-36,-16)(-30,-3)(22,-16)(5,4)(31,-13)(-29,6)(-3,12)(-13,-3)(16,-5)(27,-3)(-8,8)(-5,6)(12,-9)(27,-8)(-17,-1)(-8,4)(-37,-8)(28,3)(-31,1)(41,17)(4,8)(18,0)(-9,10)(2,1)(9,12)(-11,-19)(-15,-24)(9,-9)(5,8)(18,9)(-28,-16)(3,5)(-21,-1)(15,4)(7,-5)(-5,-7)(-5,4)(-25,8)(-10,7)(-8,8)(21,-1)(10,12)(-5,0)(-15,5)(8,5)(7,10)(-10,-16)(-16,-5)(15,-2)(13,-1)(2,-15)(-31,-18)(15,14)(13,-3)(14,4)(5,3)(-13,-4)(19,13)(-2,-12)(32,17)(-29,-21)(-29,-16)(-36,-6)(-1,24)(26,3)(36,-9)(31,-25)(-2,3)(4,20)(-7,22)(-11,3)(-13,-5)(-15,-12)(13,-8)(-9,4)(0,7)(-34,1)(-2,2)(12,-1)(-1,14)(25,-5)(0,-3)(17,-4)(-35,-4)(6,-14)(-17,16)(22,12)(-17,18)(18,-24)(-2,-7)(18,-15)(7,10)(19,-3)(-4,3)(-1,-3)(-1,-8)(3,-2)(-24,8)(-14,0)(-2,15)(42,-9)(13,1)(13,-11)(-20,0)(-10,-2)(-7,17)(-2,6)(-3,-1)(-6,-9)(18,-2)(-20,-5)(-10,1)(5,-2)(16,21)(21,-2)(-12,16)(-2,-6)(-4,-15)(-8,-24)(17,11)(2,2)(18,4)(1,-20)(3,4)(-35,9)(-43,14)(-5,9)(-3,-17)(3,-7)(-14,-11)(-1,23)(38,-8)(-14,20)(21,5)(-35,7)(-5,-19)(16,-9)(35,2)(41,6)(-1,-18)(-17,-1)(-6,1)(4,11)(-22,-2)(-12,-4)(-13,8)(19,10)(16,6)(1,4)(-1,0)(-1,-9)(9,-5)(-4,-23)(-4,4)(-1,0)(27,8)(-2,-4)(-3,5)(-6,16)(0,17)(-18,-14)(-8,-7)(-26,0)(-10,-4)(-28,2)(31,-19)(32,5)(25,6)(-42,16)(-38,-3)(-21,0)(40,-10)(37,14)(35,0)(-19,5)(-6,5)(-37,-21)(-9,-10)(-12,-27)(21,10)(16,-6)(8,1)(1,-12)(-21,19)(-19,9)(-20,22)(15,2)(-9,8)(-3,-6)(-20,-3)(13,-15)(11,0)(0,8)(31,12)(26,-3)(15,1)(-37,-9)(-16,-6)(11,-25)(24,0)(18,8)(18,7)(-22,6)(-24,-16)(-28,8)(7,14)(15,14)(-7,-1)(19,-26)(-21,-7)(6,-12)(-11,3)(22,19)(17,22)(10,17)(-20,-13)(-9,-4)(4,-1)(15,13)(-1,-1)(-2,-19)(-25,-8)(-9,-21)(-4,11)(18,-13)(26,13)(4,-11)(17,-6)(-3,-13)(5,10)(-24,4)(-28,12)(-28,1)(19,22)(30,-2)(21,-2)(-32,-26)(-29,6)(-7,-5)(41,27)(22,-6)(0,10)(-10,-7)(-32,3)(-1,13)(-2,6)(19,7)(15,-27)(-2,-19)(1,-4)(-30,1)(1,4)(-19,11)(3,3)(6,8)(13,-10)(14,-3)(-29,9)(4,-5)(-24,15)(22,-6)(6,-1)(-1,5)(-18,-2)(-6,10)(27,-9)(35,4)(19,-9)(-12,-4)(-25,-16)(-18,-4)(13,15)(6,18)(-7,14)(-8,3)(4,-14)(13,2)(-25,1)(-1,-4)(20,-20)(8,-4)(-4,0)(-30,2)(14,-20)(13,20)(-3,-1)(-7,9)(-33,-13)(-1,17)(-12,-6)(32,13)(24,-16)(9,0)(-37,-13)(-34,16)(-5,21)(23,1)(4,-19)(-5,-21)(-3,6)(6,17)(17,20)(-1,4)(7,6)(21,2)(18,-16)(-9,-15)(-17,0)(1,2)(8,-3)(14,-10)(-16,15)(15,3)(-33,-13)(-7,-27)(-14,11)(29,15)(14,20)(-17,2)(-6,-5)(-13,2)(7,-9)(-15,11)(11,4)(2,-15)(31,-12)(16,-12)(32,14)(-22,5)(-35,14)(-38,-7)(-11,-5)(6,-19)(7,12)(4,-7)(-1,14)(26,-18)(5,2)(28,-9)(-5,13)(12,14)(-40,-6)(11,-6)(5,-21)(43,-2)(-18,3)(3,8)(0,14)(-13,-5)(-3,8)(-30,-7)(-5,7)(-35,-17)(-7,-12)(-6,-12)(0,23)(-6,23)(-1,23)(5,-13)(17,-19)(26,3)(13,6)(16,9)(2,-27)(18,-11)(1,8)(4,1)(-32,5)(-11,-18)(-10,17)(16,13)(-13,13)(-11,-13)(-18,-2)(25,8)(-11,13)(43,-2)(10,-5)(45,2)(-16,-7)(-6,-3)(-27,-7)(-10,7)(-35,2)(27,4)(12,-13)(13,-10)(-7,-14)(-1,18)(1,5)(-22,2)(-6,-21)(-10,-10)(6,-5)(-16,12)(-5,18)(-14,17)(25,-4)(1,-13)(19,7)(-3,3)(-2,4)(-1,-24)(10,-15)(23,-4)(13,9)(-17,17)(-21,-9)(-19,-9)(0,-16)(-4,22)(23,1)(-21,17)(2,-4)(-41,17)(41,-9)(11,-15)(14,10)(-28,3)(-13,16)(-15,-20)(3,1)(2,-2)(20,11)(-10,1)(20,3)(23,1)(14,14)(-12,5)(-31,-5)(-19,-23)(13,-12)(18,3)(26,14)(13,3)(-8,1)(6,-5)(-37,7)(19,-9)(-14,-2)(22,-11)(-21,2)(15,-8)(8,-6)(-10,11)(5,22)(-6,20)(19,-5)(-25,-15)(10,-6)(-9,-18)(-1,12)(10,8)(7,4)(20,2)(-8,-3)(7,21)(-20,-9)(-8,-6)(-2,-8)(26,9)(-6,5)(2,-3)(-34,-9)(-1,-12)(-2,3)(36,-12)(16,5)(-33,6)(-27,24)(1,4)(20,4)(2,-25)(-8,-14)(1,-9)(22,25)(10,0)(4,3)(-38,0)(-37,21)(-23,7)(29,-13)(4,-22)(21,-18)(9,-5)(35,14)(14,15)(-4,-9)(-10,-8)(-37,-18)(7,-1)(4,-6)(5,-1)(-35,5)(6,4)(29,19)(24,9)(-30,17)(-33,-19)(2,7)(25,-21)(35,11)(-11,-1)(-13,14)(-13,3)(-8,-20)(9,-6)(8,7)(-12,7)(6,-4)(4,-5)(0,1)(0,3)(5,6)(30,8)(-15,4)(-8,-9)(10,9)(20,-4)(-2,-2)(-29,-9)(-43,5)(-20,5)(7,2)(7,0)(-1,5)(2,-16)(18,-9)(-6,-24)(15,5)(-19,10)(30,25)(-37,13)(-5,1)(-32,-8)(27,1)(36,-19)(37,1)(-6,-11)(-30,26)(0,6)(-11,5)(-1,-11)(-23,-21)(2,-4)(29,4)(-5,6)(19,0)(-34,-7)(13,3)(-5,7)(26,5)(4,3)(14,-2)(-17,-2)(11,-17)(-36,-1)(16,-16)(-21,8)(37,-10)(-14,24)(1,10)(-16,9)(11,-22)(5,-10)(16,-12)(19,0)(19,-7)(-1,14)(-37,9)(-42,2)(4,-15)(11,-8)(8,21)(-33,24)(-8,15)(20,-23)(28,-20)(2,-17)(-23,8)(-26,21)(26,17)(15,-6)(8,-26)(-37,0)(22,21)(-5,6)(27,-6)(-20,-4)(-2,-1)(17,8)(23,-2)(-7,18)(-11,4)(-15,-7)(33,-16)(11,2)(-21,9)(-7,8)(-43,-25)(-1,-1)(-31,9)(20,22)(18,2)(9,-15)(-8,-14)(-14,-13)(-4,6)(-1,-2)(11,-3)(33,2)(16,16)(1,9)(-35,6)(4,-6)(-18,-8)(-3,4)(-18,-1)(30,21)(21,-25)(7,-16)(-11,-27)(-24,10)(-1,16)(-11,25)(16,0)(-10,6)(-6,-18)(16,2)(4,-12)(2,18)(-3,-9)(25,17)(26,-13)(-10,9)(5,-9)(9,-3)(-18,-9)(0,-11)(-46,-6)(43,19)(-30,21)(13,21)(-43,-9)(-12,-13)(-11,-10)(1,4)(-1,9)(35,-12)(2,-12)(21,-17)(-10,1)(9,19)(22,21)(-21,8)(-13,1)(-27,-1)(17,14)(27,-19)(14,-8)(-18,-14)(-6,-7)(-28,-3)(5,1)(14,11)(28,5)(10,9)(-27,-6)(-19,-17)(26,-4)(11,22)(1,24)(-3,-3)(-13,-15)(14,0)(-25,-12)(11,-9)(9,-3)(-2,14)(7,16)(-36,-24)(9,2)(-3,-9)(22,10)(-3,-8)(24,-7)(2,17)(-15,-4)(-28,12)(20,-27)(26,14)(8,10)(-33,12)(-26,6)(-19,-2)(31,7)(1,-23)(13,-11)(-34,-3)(4,0)(18,-2)(34,-5)(31,3)(-29,11)(-36,-4)(-14,4)(2,-17)(-2,1)(-1,3)(-3,8)(22,5)(4,6)(4,2)(-24,3)(12,1)(26,6)(44,-9)(-31,-15)(5,-21)(-3,-8)(30,-6)(-7,18)(2,15)(1,21)(8,-16)(-44,-6)(-35,3)(-5,24)(33,5)(6,-17)(-3,-13)(6,4)(8,12)(-27,8)(-9,2)(10,-4)(1,3)(-29,3)(-15,1)(23,-15)(15,-4)(24,-11)(-10,-1)(-5,-19)(-33,6)(-14,5)(-3,13)(0,2)(0,-6)(6,-6)(28,-5)(32,14)(-10,16)(2,-8)(-29,1)(35,-6)(-16,1)(2,-11)(6,2)(9,12)(-9,13)(-44,2)(-11,-12)(40,-22)(0,7)(-8,7)(-20,11)(29,-19)(33,2)(-16,12)(11,3)(-28,3)(36,-14)(-32,-1)(21,15)(-27,-9)(15,5)(-6,-27)(-12,3)(-18,-14)(-24,19)(30,18)(2,17)(35,-10)(-34,0)(35,3)(-31,3)(21,-3)(-21,-2)(10,7)(-12,-19)(-9,-1)(-3,-20)(9,24)(20,5)(-4,6)(-17,-2)(11,-22)(24,13)(29,1)(-11,0)(-17,-14)(-30,-17)(-28,-1)(-6,11)(44,1)(0,21)(-17,11)(-36,17)(4,1)(5,-27)(29,-22)(-1,-23)(11,15)(5,8)(31,11)(-1,2)(-36,2)(3,4)(27,11)(-5,-6)(-40,-8)(-39,-21)(24,13)(35,1)(21,21)(19,-17)(-13,6)(-11,-12)(-37,-1)(5,-14)(12,5)(9,17)(-17,9)(1,-20)(22,-10)(27,0)(14,8)(-9,-4)(-27,1)(-19,4)(-9,14)(-9,8)(25,-12)(10,-12)(24,-16)(-37,22)(-9,19)(-4,13)(21,-5)(-2,-2)(-11,-2)(-11,-3)(12,-15)(20,-4)(14,-6)(-27,18)(-24,-3)(-22,1)(38,-12)(11,7)(4,16)(-4,11)(21,4)(28,-11)(-40,-23)(0,-3)(-12,9)(1,-2)(1,14)(-14,-17)(25,4)(-35,-16)(-1,11)(-18,-5)(-1,-9)(7,-2)(37,12)(28,2)(-12,-4)(-31,8)(-10,6)(-4,-10)(8,-20)(-12,1)(6,4)(-14,8)(30,-5)(26,9)(18,12)(-5,-6)(-25,-10)(-3,-4)(-14,15)(9,11)(-9,-3)(15,12)(-4,-4)(22,-13)(-11,-23)(23,5)(-31,23)(5,-4)(-19,0)(38,-11)(-26,26)(-15,7)(-25,-6)(23,-26)(38,3)(7,1)(13,23)(-8,-22)(19,9)(-31,-12)(-14,8)(-27,-8)(8,-6)(-18,15)(-4,-7)(-15,3)(38,-20)(28,21)(29,-5)(-26,5)(-38,-3)(-23,10)(19,0)(42,-14)(33,12)(-20,11)(-6,3)(-17,-12)(10,-6)(-4,-7)(9,-13)(8,-17)(-3,0)(-14,11)(6,2)(-17,0)(22,11)(-19,19)(16,17)(-33,-23)(8,3)(-22,0)(0,16)(-24,-10)(23,-17)(18,-1)(8,9)(-32,14)(-23,4)(6,3)(14,4)(40,-18)(24,-6)(5,-6)(-43,0)(-41,1)(13,-2)(30,10)(29,-11)(14,15)(-3,-11)(-19,6)(-27,-7)(16,19)(27,-5)(18,-12)(-37,-14)(-25,-4)(-5,17)(21,18)(30,-4)(4,-12)(-3,-16)(-16,6)(-29,3)(-9,7)(-26,15)(17,4)(1,2)(34,2)(-15,-8)(-9,-5)(-28,-16)(12,17)(1,9)(13,-9)(-21,-5)(12,-10)(14,-1)(6,0)(6,7)(-6,11)(37,4)(-15,-6)(4,13)(-40,-1)(18,15)(-22,-2)(25,-4)(-27,-18)(14,-11)(-19,-12)(12,12)(-11,4)(-2,-2)(-5,1)(2,-3)(6,16)(6,-3)(12,-7)(-7,-9)(19,-3)(-24,2)(1,2)(-3,-1)(6,17)(26,-11)(3,9)(32,-9)(-4,7)(-7,-10)(-14,-3)(-11,-9)(9,-2)(11,0)(5,19)(-1,-3)(-9,6)(-15,-9)(-24,18)(8,-1)(25,13)(9,-15)(-22,-4)(-2,-2)(0,5)(24,-11)(-7,-2)(7,-12)(-41,21)(-13,-3)(-20,8)(17,-12)(0,-15)(3,-5)(20,16)(0,-5)(-1,-6)(-20,-23)(15,4)(-7,7)(7,2)(-5,12)(17,8)(-3,9)(-7,-3)(25,10)(-16,-3)(-9,-6)(-38,0)(25,2)(12,10)(4,-18)(15,0)(21,-4)(4,13)(-28,0)(-19,11)(3,3)(2,9)(17,-2)(-14,-12)(-3,-19)(-6,-14)(6,-5)(16,23)(11,-7)(24,18)(-4,0)(-16,22)(-1,-24)(15,-10)(-13,-8)(3,2)(-35,2)(34,0)(-10,11)(30,-1)(-26,-2)(1,9)(-7,-14)(-19,3)(-20,-18)(-30,13)(1,9)(-4,20)(12,1)(6,-2)(26,-23)(-9,-14)(36,-21)(-30,19)(41,21)(-44,17)(0,-2)(-45,-7)(10,-9)(21,-2)(15,-18)(31,12)(25,11)(13,27)(-28,-17)(-8,0)(-24,-22)(27,-3)(-17,-21)(40,-5)(-23,0)(14,-4)(-26,20)(-16,14)(-17,14)(-3,-1)(34,-9)(-17,7)(-7,4)(0,-3)(40,-9)(4,-13)(-28,22)(3,2)(18,11)(33,-6)(-31,-15)(7,-4)(2,-16)(-13,0)(3,-14)(3,-1)(25,9)(-36,5)(1,15)(21,7)(42,9)(-32,3)(-19,1)(-31,-13)(0,4)(9,-8)(-1,9)(27,-22)(-14,-7)(-5,-4)(-23,-2)(2,1)(-5,0)(-10,21)(-16,17)(4,12)(13,-16)(36,1)(33,3)(-9,20)(-7,1)(2,-17)(12,-21)(7,-6)(-17,-8)(20,3)(0,9)(-4,28)(-1,14)(-24,-1)(-11,-24)(-20,-4)(-15,-22)(11,-2)(-15,-3)(-2,9)(17,22)(20,12)(36,-10)(-7,-18)(1,-10)(-14,7)(-28,14)(-20,-3)(-24,5)(34,-7)(37,-10)(5,4)(-14,8)(-16,3)(26,-3)(6,4)(-10,8)(-6,6)(-2,-17)(-4,9)(-10,2)(-12,16)(25,-13)(-11,-5)(30,-2)(-30,-8)(-2,-13)(-42,-16)(-1,4)(29,12)(3,0)(-2,15)(-11,-4)(-5,13)(-5,-21)(-13,10)(10,3)(3,8)(35,-7)(15,-5)(30,19)(-7,11)(9,11)(-35,-21)(-20,-8)(0,-27)(37,11)(21,-7)(-35,12)(-35,-1)(-13,14)(29,-10)(5,10)(-14,-23)(-9,2)(14,-12)(12,11)(1,10)(6,10)(12,1)(-4,11)(-28,-12)(-28,-6)(-11,2)(3,-3)(37,13)(22,-23)(1,3)(-13,-3)(16,11)(5,6)(-8,1)(-16,-1)(9,-1)(-14,-8)(-14,10)(22,-15)(5,-3)(19,-8)(-29,18)(20,18)(12,-13)(19,-3)(-19,-20)(-16,11)(-27,-10)(25,7)(-4,-10)(33,10)(4,12)(-10,15)(-25,5)(-7,-6)(10,3)(12,-9)(10,-8)(-12,4)(3,12)(-20,13)(12,-1)(19,-10)(11,-23)(14,-16)(-8,6)(-6,6)(-7,1)(-19,-12)(-15,10)(5,3)(3,1)(15,-13)(-14,-8)(13,4)(-31,-6)(1,3)(-12,-12)(39,21)(9,2)(24,11)(5,-6)(-25,12)(-13,7)(-31,-10)(11,-1)(-24,-3)(-2,12)(2,-2)(12,-2)(-4,-6)(19,-7)(-10,-1)(19,9)(-8,13)(24,-7)(3,8)(-20,-24)(-24,-4)(-12,-24)(1,2)(10,15)(4,15)(7,15)(18,-2)(7,-14)(16,-13)(-35,-3)(-12,1)(6,-4)(28,14)(29,7)(0,11)(-23,-5)(-5,-1)(0,-11)(5,-9)(-24,15)(-13,1)(28,-4)(26,-17)(12,7)(-26,9)(-9,12)(-23,2)(14,-7)(8,1)(-2,12)(7,-11)(-1,-7)(6,-14)(-17,27)(-13,-15)(-4,6)(26,-25)(7,24)(12,-3)(-33,22)(-24,-1)(15,9)(10,-10)(12,-9)(-45,-3)(-12,-15)(24,0)(43,-3)(33,9)(-44,0)(-7,8)(-16,4)(5,-4)(-10,-18)(-25,0)(-4,2)(-24,7)(15,-6)(-1,-5)(41,14)(-13,19)(21,-3)(-43,-23)(16,-15)(-22,5)(11,22)(25,5)(12,16)(-10,2)(-13,11)(8,-3)(18,-28)(-14,-23)(17,-7)(25,14)(-10,-4)(-19,5)(-19,3)(4,12)(-9,6)(12,1)(32,-4)(35,-19)(7,-10)(-38,13)(-39,-4)(-43,5)(17,-19)(0,3)(17,-2)(-22,10)(18,14)(-18,14)(-2,16)(-24,-10)(44,-3)(9,-15)(36,-2)(-42,-11)(21,3)(3,19)(23,7)(-12,-13)(-31,-2)(-2,-18)(28,18)(24,-2)(4,7)(-24,-15)(9,-10)(-2,1)(-10,22)(-40,-9)(-7,9)(-11,-15)(0,8)(-18,-4)(39,4)(34,15)(-1,-6)(-9,-7)(9,-25)(20,4)(-9,15)(-13,21)(5,1)(24,-24)(-26,-4)(-13,-1)(-17,8)(2,-8)(7,-3)(-7,10)(15,7)(3,11)(-19,-7)(-3,-7)(23,7)(43,-7)(9,-5)(-7,-23)(-6,16)(-21,-2)(-35,1)(-39,-5)(21,0)(3,9)(-1,12)(-17,18)(6,10)(34,-16)(-9,-6)(3,-6)(-30,11)(26,1)(26,7)(27,-7)(-13,3)(-24,-11)(11,10)(16,-6)(29,12)(-28,-18)(-17,-7)(-32,-17)(24,-1)(16,19)(18,6)(-1,9)(-21,-21)(-7,5)(-6,-2)(-3,12)(1,6)(-21,0)(15,3)(10,-2)(9,-4)(19,-13)(3,-15)(-14,-7)(-32,2)(-25,-3)(12,0)(-1,7)(-3,8)(-12,14)(33,1)(19,5)(40,-14)(-6,-16)(-18,5)(-31,7)(-27,18)(7,-6)(7,-7)(38,-7)(26,3)(11,23)(-9,-6)(-23,3)(4,-2)(-18,3)(-4,-6)(-12,-14)(6,0)(6,-7)(-21,15)(-8,-5)(-21,-8)(5,-21)(28,19)(3,-1)(36,19)(-7,-13)(23,25)(-7,4)(9,-11)(13,-13)(7,-22)(-12,8)(-3,9)(-36,16)(10,-5)(-36,-22)(5,-5)(-11,24)(22,28)(2,6)(-3,-24)(-16,-25)(12,-13)(-14,7)(-8,8)(-2,15)(4,5)(44,15)(7,-23)(12,-3)(-23,0)(-8,16)(-8,5)(2,-9)(-16,8)(8,-6)(5,7)(10,-22)(-1,15)(-12,-13)(3,25)(-19,-17)(-4,7)(-13,-17)(-11,7)(29,4)(-1,-1)(35,11)(-33,-9)(36,-7)(-29,-19)(20,-10)(-4,17)(38,-3)(-21,-3)(-4,2)(-35,18)(13,15)(-33,-19)(11,-10)(13,9)(10,9)(10,-3)(-18,-7)(-5,-11)(11,9)(10,11)(1,18)(-34,0)(-18,-9)(17,2)(34,2)(4,5)(1,-6)(-5,-21)(30,-8)(-14,4)(-22,2)(-28,11)(25,3)(15,23)(21,-26)(0,-18)(8,-7)(10,21)(-37,18)(-5,-16)(-7,4)(38,-6)(-4,1)(-33,1)(2,-15)(-11,17)(29,-21)(-21,18)(-11,-14)(-20,2)(27,2)(22,22)(-13,17)(-14,-2)(11,-5)(15,-25)(7,9)(4,3)(24,25)(-29,-19)(-17,-20)(-8,2)(20,2)(3,5)(-2,-16)(15,-10)(2,13)(-2,14)(-27,14)(-20,4)(-28,-6)(2,2)(-11,-7)(11,-6)(25,4)(14,-15)(8,1)(-38,1)(24,-2)(19,2)(25,-13)(-39,16)(-23,12)(-15,11)(20,-9)(18,-16)(-15,-16)(15,2)(-12,1)(9,-2)(-28,2)(3,-7)(21,5)(8,0)(9,4)(-2,7)(31,-7)(0,14)(0,11)(-9,13)(-14,-14)(-29,-8)(-36,-4)(-18,7)(6,-7)(42,-1)(29,-12)(-2,6)(-39,-16)(-26,-2)(1,9)(32,22)(10,24)(40,-19)(-2,-20)(18,-7)(-32,-3)(7,-2)(-16,2)(5,3)(-6,16)(2,-14)(-12,19)(-15,-16)(-17,-2)(18,-17)(15,13)(15,3)(-22,0)(-32,-5)(-13,-1)(0,14)(2,-5)(16,20)(9,-13)(14,19)(26,-3)(4,11)(-6,-12)(-27,-7)(2,-3)(31,7)(-18,-8)(-17,2)(1,5)(20,-10)(2,-8)(-42,-11)(-17,11)(28,0)(27,0)(33,-3)(-14,-1)(-4,11)(-14,-6)(-7,4)(-22,1)(20,18)(-3,-6)(13,3)(-9,-11)(15,12)(16,-6)(4,11)(1,-13)(-33,-16)(-37,-13)(-11,9)(0,-3)(24,20)(15,10)(20,19)(-24,-19)(19,-23)(-19,-9)(40,9)(-3,-1)(2,14)(-27,-6)(-13,5)(27,-18)(17,-4)(-19,9)(-2,-6)(-28,-4)(25,4)(-26,7)(44,16)(-21,-13)(13,18)(-11,-1)(-5,-4)(6,-2)(-32,-18)(31,22)(-4,-21)(4,24)(-41,-8)(-17,14)(-7,-7)(4,2)(29,2)(1,-4)(30,-4)(-12,-8)(22,-3)(-1,5)(19,15)(-8,12)(-15,-4)(-22,-24)(14,-17)(3,-3)(-8,15)(-26,2)(-12,13)(-1,10)(40,11)(30,-15)(27,-22)(-4,-13)(-29,2)(-23,22)(-32,2)(13,6)(14,-8)(16,12)(-14,-7)(-6,7)(16,-15)(7,10)(23,-23)(-13,19)(5,-3)(0,-2)(-12,5)(-12,-9)(-32,8)(17,-18)(21,1)(15,19)(-9,7)(-24,6)(8,-21)(6,-6)(15,8)(12,5)(3,-2)(-10,-17)(-4,-1)(-4,-1)(0,17)(-16,11)(10,2)(27,-17)(15,-14)(1,-2)(-36,8)(2,5)(-25,18)(12,1)(-17,3)(24,-2)(-8,-13)(4,4)(-11,-24)(4,16)(-23,-12)(-17,26)(8,-7)(11,11)(14,2)(14,8)(14,-1)(-12,-7)(-30,-10)(-7,3)(27,-4)(20,1)(-2,-16)(-35,4)(-19,-3)(4,10)(-2,-9)(23,8)(-4,3)(1,14)(-19,-7)(-13,-8)(5,-16)(27,14)(21,12)(29,4)(-32,-17)(6,-18)(10,3)(12,20)(-30,-2)(-38,10)(-1,-1)(16,2)(17,-26)(11,-1)(9,7)(9,15)(18,-11)(5,15)(-23,-15)(-16,-9)(4,-23)(32,27)(-2,8)(-14,10)(-19,-15)(-19,-4)(1,-13)(12,12)(6,-2)(-18,26)(8,-19)(9,6)(-5,-21)(-44,20)(26,-5)(18,0)(29,-3)(-33,19)(4,-3)(14,4)(25,0)(-2,17)(-36,-16)(-11,-21)(-4,0)(35,7)(3,9)(19,-14)(-19,-7)(-12,-12)(-4,13)(9,5)(-12,0)(-17,-18)(-30,4)(-6,22)(29,24)(32,-7)(14,-16)(-41,-23)(-19,10)(14,9)(35,26)(-7,-4)(-22,6)(-33,-3)(-2,5)(22,-5)(0,-18)(34,3)(4,7)(8,9)(-28,-25)(-27,-25)(-8,-14)(-8,14)(0,10)(9,25)(14,-12)(21,-5)(-14,-22)(25,22)(-13,-4)(9,-4)(-39,-26)(13,-1)(-9,9)(0,7)(1,20)(36,-3)(31,11)(13,-20)(7,-2)(-35,-6)(-26,20)(-25,10)(24,12)(19,-7)(3,5)(-23,4)(-7,-10)(-16,2)(43,-14)(-1,24)(16,1)(-18,-3)(-18,-7)(-15,-1)(-19,10)(-5,-7)(32,-2)(-4,-10)(19,-12)(-7,-13)(36,-6)(6,0)(-2,15)(-33,12)(-10,3)(11,-21)(-4,-6)(0,14)(-6,15)(27,-2)(26,-18)(-4,8)(-3,0)(-12,17)(-15,-5)(4,13)(10,-7)(6,6)(-12,-12)(0,-8)(2,3)(2,8)(2,-1)(9,-25)(-7,-8)(-36,19)(-15,26)(29,1)(34,-12)(23,-19)(-1,-2)(-1,-1)(-21,8)(-38,13)(-29,18)(-7,10)(-2,-20)(-9,-10)(4,-1)(31,-2)(44,-6)(-1,-19)(14,26)(-42,0)(-15,-7)(-4,-7)(36,7)(32,13)(-42,4)(-26,-7)(-26,1)(30,5)(-11,10)(-4,6)(-27,-8)(41,2)(25,-8)(13,2)(-37,-20)(-6,-4)(-13,-16)(39,26)(-8,1)(22,4)(-45,-28)(22,17)(-18,5)(17,15)(-23,-16)(-5,7)(3,-14)(11,10)(28,-7)(7,6)(5,7)(-20,13)(-18,-1)(-3,-19)(8,-9)(20,18)(4,16)(12,5)(-10,-13)(-30,-5)(-10,-18)(-3,-7)(11,-12)(-7,10)(15,0)(33,-1)(12,-15)(-3,-4)(-19,13)(9,10)(-18,23)(-14,0)(-24,5)(18,-10)(3,9)(-9,-8)(-14,-3)(25,-27)(24,6)(5,17)(-30,15)(6,7)(-12,-8)(-1,-13)(-21,-8)(31,-14)(23,14)(19,15)(-18,21)(-10,9)(-8,-2)(5,-12)(-21,-13)(-8,-4)(3,4)(16,-3)(28,-12)(-16,-13)(4,1)(-18,2)(28,17)(-18,15)(-8,15)(-38,-22)(7,1)(8,-13)(9,21)(13,-14)(-18,12)(24,-10)(12,-11)(17,-21)(-5,9)(9,10)(-10,21)(10,-6)(-23,-6)(22,-12)(-35,-1)(-4,17)(-1,-9)(24,5)(29,-15)(4,3)(13,1)(-2,11)(6,11)(-28,0)(-16,-6)(-9,-15)(12,3)(-24,12)(-10,10)(-6,-21)(26,-9)(16,-12)(21,1)(-18,-3)(-3,12)(-3,18)(33,-4)(9,0)(-6,-15)(-6,8)(-21,6)(-24,21)(-29,9)(-16,6)(21,-1)(26,0)(17,-2)(11,-9)(-25,-21)(18,-7)(-22,-9)(-6,21)(-18,-8)(-9,15)(13,1)(-19,-4)(-10,-3)(29,-7)(17,4)(20,-1)(-29,5)(1,14)(8,-16)(8,-24)(2,-9)(-1,13)(3,23)(-15,4)(12,-7)(6,-10)(-7,7)(7,16)(-30,10)(3,2)(0,-23)(7,4)(28,-1)(-33,14)(-2,-1)(-25,-22)(6,-8)(-3,-22)(3,19)(2,17)(15,19)(7,1)(6,4)(-8,-16)(14,1)(8,-8)(30,18)(-8,-20)(-22,-19)(-16,-10)(8,12)(29,9)(0,9)(-24,5)(-18,-10)(-13,-3)(20,-19)(-7,4)(-5,-10)(3,15)(-16,17)(20,5)(0,3)(16,-6)(8,-9)(-28,-15)(22,-13)(2,-6)(33,-4)(-22,26)(-36,9)(6,-2)(22,-18)(3,-7)(-34,18)(3,15)(2,18)(33,8)(-42,-14)(23,-21)(-4,-26)(40,0)(-24,5)(-14,22)(-16,13)(14,18)(16,-16)(-1,-3)(24,-20)(-8,20)(20,-15)(-18,13)(-26,-15)(-11,-4)(5,-15)(24,-9)(-14,17)(-27,15)(-24,9)(-2,-19)(14,8)(30,-11)(-13,6)(2,-16)(-6,26)(24,2)(-9,-8)(-8,-23)(10,-3)(-10,-1)(0,20)(-6,6)(24,14)(18,-10)(-23,1)(-15,3)(-5,7)(25,11)(31,6)(2,-7)(9,2)(-12,-14)(5,4)(-20,-11)(-24,11)(-28,-13)(-9,-6)(2,-3)(25,2)(-7,7)(9,-8)(-15,2)(29,-6)(18,0)(9,1)(-4,15)(-8,-2)(-29,8)(13,-20)(-18,5)(20,2)(-25,5)(35,12)(15,-6)(4,-3)(-21,-23)(-18,5)(-19,14)(-23,0)(12,-12)(-3,-6)(26,26)(-35,12)(10,-4)(-22,-14)(35,-13)(-4,4)(15,-6)(-35,1)(14,14)(13,21)(16,-4)(-1,-8)(6,0)(27,12)(-1,-20)(-6,-21)(-2,13)(25,14)(-23,12)(-28,-23)(-14,8)(11,-12)(1,23)(-2,-7)(8,8)(14,-12)(4,-13)(1,13)(-26,-1)(-17,-1)(-7,-2)(44,12)(10,-1)(-18,-5)(-8,-25)(7,20)(40,-11)(-18,6)(10,-7)(-36,-2)(-15,19)(-26,-9)(10,2)(7,-6)(-12,9)(26,12)(-10,0)(17,7)(-6,-6)(26,-8)(-13,-13)(-18,-12)(17,10)(-6,0)(2,14)(-42,-13)(33,1)(13,-10)(32,-1)(-7,-6)(6,19)(10,12)(-28,4)(2,-22)(-22,-8)(14,12)(-20,-3)(2,16)(27,-11)(-12,19)(-22,-25)(-40,15)(-7,6)(36,12)(18,-17)(-4,-22)(5,9)(-14,20)(32,11)(-5,-10)(30,1)(2,12)(-2,10)(-27,1)(-11,-9)(-29,-13)(-6,-8)(-21,0)(-6,8)(16,-3)(19,-8)(0,1)(25,12)(23,-8)(41,6)(-16,-13)(-26,4)(-15,-6)(16,-8)(15,16)(-17,-20)(-4,-5)(-21,-20)(35,2)(1,10)(11,8)(-8,11)(-35,-2)(16,-1)(-3,3)(-1,17)(-23,1)(-21,-4)(18,-15)(-12,-9)(19,16)(9,-8)(27,2)(-2,-24)(-18,1)(-21,21)(6,23)(18,2)(6,-18)(0,-5)(5,0)(14,21)(-14,6)(2,15)(6,-18)(-19,-22)(-18,-15)(8,-8)(31,13)(2,-5)(-25,17)(-10,7)(11,5)(-1,3)(-19,-21)(13,18)(20,4)(13,6)(-11,-11)(-20,-13)(19,0)(-9,9)(-12,5)(-9,12)(-23,-8)(-3,-3)(-26,-8)(17,9)(24,7)(12,-11)(-4,-1)(3,3)(1,-1)(22,-3)(-3,-8)(5,24)(6,-7)(-15,-2)(11,-19)(-41,1)(11,-1)(-25,13)(11,-4)(-14,-4)(24,-17)(29,18)(10,-8)(-20,11)(-30,-27)(-19,22)(-1,-10)(24,25)(37,2)(27,21)(-22,-20)(-23,-12)(-29,-9)(14,22)(13,-13)(21,-15)(14,-2)(19,13)(-12,18)(-4,-10)(-24,-14)(21,6)(-1,-7)(14,18)(-34,-18)(-26,1)(-24,-8)(8,2)(1,-10)(14,7)(8,5)(-2,2)(-17,-15)(0,9)(29,8)(33,11)(3,-16)(0,2)(-18,-3)(-8,-2)(-28,2)(-24,3)(23,1)(13,4)(15,15)(-28,-2)(5,-7)(-9,-25)(18,-3)(7,5)(23,14)(-22,6)(-4,4)(-5,-14)(12,1)(-2,2)(6,24)(-7,12)(-7,-9)(16,-8)(15,-5)(1,14)(-20,-15)(-20,10)(9,-10)(-21,2)(37,-15)(4,-15)(33,-4)(-5,-9)(-2,16)(-37,16)(-26,24)(5,-17)(40,-10)(5,-7)(-39,27)(-24,3)(23,-8)(30,-27)(-2,4)(-15,15)(14,25)(11,8)(-21,2)(-39,2)(6,-15)(22,-11)(35,-25)(10,-5)(16,-14)(-33,1)(-15,7)(-14,16)(0,22)(-16,15)(-11,-7)(-8,-22)(-9,-23)(-17,5)(16,2)(11,7)(42,8)(-2,-1)(-5,-3)(-16,-25)(-11,14)(-2,12)(20,12)(8,2)(19,1)(-39,-12)(11,-4)(-11,-18)(11,26)(17,4)(29,19)(9,-19)(5,6)(-31,8)(-6,-1)(-18,-5)(16,-10)(-12,2)(-20,-5)(-27,-9)(20,6)(-7,-13)(10,-2)(10,-1)(0,8)(-11,5)(-39,-1)(0,4)(31,-9)(14,-11)(45,-7)(-17,-1)(26,15)(-2,10)(9,13)(-15,-8)(-7,-6)(-12,2)(16,0)(-8,15)(21,-16)(-13,11)(7,-22)(4,23)(-26,3)(-12,14)(10,-22)(15,-6)(5,-4)(-18,14)(11,0)(16,8)(-21,4)(1,-10)(-43,3)(2,4)(-7,5)(23,-12)(8,-10)(10,-8)(-16,-6)(12,-14)(13,0)(12,1)(4,4)(-14,7)(23,-9)(-1,20)(0,-1)(-24,24)(2,-18)(4,10)(23,-9)(0,19)(-29,0)(-39,3)(-12,-9)(26,-8)(30,-14)(-17,5)(-2,11)(-7,-2)(14,-15)(-13,-6)(14,7)(21,4)(23,-6)(-8,13)(5,0)(2,6)(-23,-18)(0,13)(-23,-13)(-3,-3)(-21,-22)(18,9)(33,18)(3,13)(-18,-11)(5,-18)(-12,4)(-19,15)(1,11)(30,-5)(45,-3)(-5,12)(-40,-2)(-23,-6)(-29,-25)(-3,-1)(4,18)(3,22)(32,8)(5,-11)(30,-7)(3,1)(-4,9)(-30,-5)(-20,-13)(16,-23)(-8,10)(-13,7)(-2,25)(6,3)(29,10)(-8,-9)(2,-19)(-23,-15)(-8,-3)(26,0)(19,19)(8,11)(-24,-3)(-29,-19)(-13,-22)(-3,0)(35,16)(24,-1)(31,6)(-29,-15)(-24,8)(-14,-5)(24,-7)(10,-7)(1,12)(13,-2)(-15,14)(-18,-7)(-3,18)(-13,-12)(20,18)(-28,-3)(14,17)(-11,-23)(21,11)(-2,-7)(9,6)(-2,-18)(17,-6)(-2,10)(-7,9)(-13,4)(8,-4)(5,11)(-5,9)(6,3)(3,-19)(-6,-4)(-40,-10)(-6,8)(15,-6)(34,0)(-5,-3)(-15,8)(8,-5)(24,-12)(38,-17)(-37,21)(-42,7)(-30,23)(-2,-21)(11,-6)(24,-16)(5,17)(17,-1)(-2,3)(17,9)(-26,6)(4,13)(-11,-5)(10,14)(-13,-18)(1,-10)(7,4)(4,0)(-5,-8)(-1,-8)(-26,1)(1,15)(24,-1)(10,20)(12,-10)(-42,2)(24,-13)(13,13)(-3,8)(-31,4)(-34,1)(0,-12)(32,-14)(-5,-4)(39,11)(-2,9)(9,-10)(3,-25)(-3,-5)(35,18)(2,27)(8,19)(-33,-18)(-43,-10)(-3,-13)(14,4)(13,2)(-34,3)(-7,-8)(-3,-16)(8,-14)(11,16)(-6,-3)(-8,12)(-18,-9)(10,15)(37,6)(35,15)(7,4)(2,-4)(-44,-28)(8,-5)(-31,8)(24,1)(-28,7)(-7,-7)(6,25)(12,-22)(37,-6)(7,-10)(9,14)(-15,-7)(-5,1)(-18,0)(-23,6)(-2,11)(27,14)(25,16)(-17,-17)(3,-10)(-19,-24)(-14,-11)(-2,3)(-2,23)(41,18)(13,-15)(-5,-7)(-5,-17)(-40,11)(29,-16)(-27,13)(23,-16)(2,-1)(14,8)(-28,23)(-19,0)(12,-6)(41,-14)(-2,15)(-7,8)(-22,-10)(15,-9)(17,1)(18,7)(-13,14)(-36,-5)(-28,13)(-8,-3)(18,-9)(-9,-15)(36,-17)(10,13)(22,15)(-7,17)(-24,-24)(-6,-15)(-12,-11)(21,0)(9,22)(11,9)(-18,17)(3,-21)(-12,-7)(-10,-8)(-19,18)(12,-8)(28,12)(12,-16)(-15,-2)(-18,-6)(22,19)(7,4)(22,3)(-27,-7)(-30,0)(-1,-4)(1,-4)(33,11)(8,14)(12,6)(-10,-1)(-7,-17)(-1,-11)(-20,0)(-32,6)(-22,6)(4,2)(34,-14)(32,-5)(20,-2)(-28,13)(-24,-11)(-9,-6)(-1,6)(-6,15)(-2,15)(-1,-6)(11,-14)(-10,-1)(-6,4)(-17,23)(12,-19)(8,-11)(18,-25)(24,2)(28,1)(-8,28)(-42,-4)(-27,1)(20,-23)(40,10)(14,-3)(-9,-4)(-3,-6)(-25,5)(-10,17)(-20,14)(5,8)(-6,3)(-9,1)(-1,-8)(5,-20)(4,-10)(3,-6)(33,19)(2,8)(1,-6)(-30,-8)(14,-11)(30,18)(12,7)(-9,-6)(-36,6)(15,9)(-11,0)(20,3)(-33,-28)(-3,21)(-5,-3)(0,4)(6,-19)(11,-9)(21,12)(20,12)(-18,-6)(-9,0)(-25,-3)(-2,6)(-12,-15)(4,12)(-2,0)(0,22)(33,-9)(9,7)(25,-12)(-18,-11)(6,-23)(-3,5)(-4,6)(-12,21)(8,-5)(8,7)(16,-13)(-12,-3)(-1,-10)(-7,-8)(16,5)(13,-4)(5,25)(-41,-6)(-36,-4)(2,-3)(0,19)(9,6)(3,-13)(24,-25)(1,14)(-5,18)(8,22)(23,-14)(-2,0)(-27,-8)(-26,2)(-23,-2)(-4,8)(27,9)(45,-11)(5,-22)(-23,10)(-11,3)(17,14)(-10,-22)(-1,-4)(6,11)(8,1)(6,-1)(9,-6)(9,21)(-6,-2)(-15,0)(-10,-4)(-9,15)(6,3)(27,-18)(-15,-11)(-22,-9)(-30,9)(19,14)(-5,2)(17,1)(-18,-2)(38,0)(16,-15)(6,-10)(-26,-5)(-25,20)(-5,-15)(5,-2)(-2,-20)(7,26)(22,16)(-10,27)(15,-13)(-31,-21)(7,-26)(10,-8)(-8,12)(14,13)(-27,22)(28,5)(-2,-13)(29,-6)(-7,-13)(-22,19)(-33,-3)(15,12)(22,8)(8,-8)(-20,-9)(-4,-17)(24,-9)(10,14)(0,-6)(-20,17)(-5,-22)(25,11)(1,-8)(0,15)(-34,1)(-8,3)(17,-14)(16,-16)(11,-3)(-12,-4)(2,18)(-20,8)(-22,19)(-21,0)(27,6)(27,-17)(0,-18)(-8,-8)(9,9)(2,14)(-6,-6)(0,11)(4,10)(-6,13)(0,-7)(28,2)(-1,4)(-3,-15)(-5,-16)(8,-14)(3,14)(-18,16)(3,3)(-41,-7)(20,-12)(-20,-17)(22,2)(-11,3)(12,28)(-10,-8)(-5,-18)(1,-24)(29,18)(9,4)(6,21)(-25,9)(-32,22)(20,-7)(-15,-12)(40,-22)(-42,-1)(-2,1)(-38,13)(7,-2)(30,7)(30,4)(33,4)(-4,-11)(-13,-2)(-38,-1)(8,-1)(2,9)(41,-10)(-23,-8)(-7,-27)(-28,8)(5,3)(-12,22)(-5,1)(27,8)(29,-22)(8,-12)(-32,-11)(-31,5)(-21,-3)(-10,23)(7,3)(0,17)(1,-17)(36,12)(29,-10)(24,-1)(-15,-12)(-6,1)(-17,-7)(-3,11)(22,-3)(15,14)(-25,7)(-11,1)(16,-1)(12,-19)(5,-1)(-41,13)(-4,18)(-34,7)(34,-28)(37,-5)(18,-12)(-20,17)(-3,-9)(8,0)(6,9)(-38,13)(3,25)(13,-12)(25,-21)(11,-16)(-2,-4)(-13,5)(-1,17)(-4,10)(-8,-6)(-6,-26)(-19,-4)(25,11)(-35,22)(-7,8)(-31,10)(-1,-7)(-1,-1)(16,-14)(36,-12)(39,1)(17,7)(-15,14)(-16,4)(-18,-15)(4,-9)(-11,-14)(2,7)(-23,15)(-10,9)(21,5)(29,-11)(-1,5)(-36,-4)(7,2)(42,-19)(21,-10)(5,-10)(-23,-6)(-12,19)(-10,16)(11,4)(-8,-3)(4,-22)(-14,4)(30,9)(-11,20)(19,5)(-16,0)(10,-10)(0,-6)(18,-15)(-9,11)(-11,15)(-2,-3)(1,-19)(2,-3)(-24,19)(-2,15)(-9,1)(30,-13)(-18,8)(-18,-20)(-39,5)(13,-14)(37,6)(33,-1)(1,-10)(-29,13)(-28,11)(20,16)(15,4)(31,-13)(-34,-16)(17,-26)(-39,11)(25,26)(-6,9)(40,-26)(10,-11)(9,7)(5,16)(-6,-8)(-6,-3)(-37,-15)(0,-8)(-8,9)(30,2)(-16,22)(-3,-21)(-15,21)(19,-3)(13,0)(3,-8)(-9,5)(2,-1)(16,-4)(-6,-20)(0,6)(4,15)(16,19)(-7,-3)(-35,-12)(-3,-15)(10,20)(1,10)(-17,11)(-30,0)(30,-1)(9,8)(-7,-10)(-26,-17)(-26,-7)(2,-9)(25,8)(31,-20)(34,3)(4,-6)(-16,26)(-21,0)(-29,-9)(7,-21)(4,-2)(12,5)(-28,14)(-22,21)(4,4)(32,-5)(6,-16)(-14,4)(-13,-7)(17,-8)(25,0)(-3,18)(-5,20)(-36,10)(22,-19)(-1,-22)(7,-11)(-1,9)(3,25)(2,2)(-33,4)(-16,2)(30,14)(5,-13)(16,-8)(-34,-7)(17,18)(16,-1)(21,-21)(-6,-8)(-22,0)(-33,2)(11,-11)(-16,-9)(5,7)(-14,2)(7,7)(-5,9)(18,3)(24,-6)(35,-8)(0,8)(-33,14)(-3,16)(-35,3)(0,0)(-29,-18)(34,-17)(32,-7)(3,5)(4,15)(3,-1)(11,-4)(-6,0)(-34,4)(19,-4)(-18,0)(40,-9)(-28,18)(-7,-1)(-36,7)(-1,-5)(-3,-2)(1,9)(22,-17)(8,-1)(4,-17)(8,1)(26,-7)(22,-4)(-13,13)(-25,19)(-32,0)(-14,-6)(-11,-8)(0,15)(36,17)(-1,-7)(-1,-9)(-45,-14)(30,-5)(1,10)(8,7)(1,11)(5,-22)(-3,0)(-32,-3)(5,2)(35,-14)(2,-8)(33,25)(0,10)(16,11)(-39,-4)(-32,-11)(2,0)(18,-3)(19,2)(-8,7)(3,1)(-11,-5)(3,0)(6,-2)(29,7)(-11,-7)(-33,8)(-15,5)(1,2)(31,-25)(-8,0)(41,-17)(-22,9)(-7,5)(-43,12)(16,-5)(-3,-8)(30,-12)(8,-3)(20,-7)(-13,17)(0,23)(8,3)(-19,-8)(-29,-1)(-21,-3)(44,-3)(22,-14)(14,-2)(-15,-3)(10,10)(-31,14)(14,17)(-16,-8)(25,6)(-16,4)(20,-11)(-21,-19)(-15,-25)(-30,22)(3,4)(32,25)(34,4)(-3,9)(1,-13)(-24,-22)(23,-2)(-27,-11)(-3,4)(-27,12)(3,5)(0,1)(10,-9)(23,20)(8,3)(-6,-2)(-28,-16)(-8,-11)(34,7)(-15,16)(-15,25)(-39,7)(-2,-27)(14,0)(10,-18)(15,9)(-9,-23)(15,6)(12,4)(32,16)(9,4)(-6,0)(-37,-9)(-7,-14)(4,-6)(20,11)(-14,15)(-11,13)(-8,-21)(-2,4)(23,-21)(30,5)(15,-16)(-6,7)(2,6)(17,10)(-22,17)(-43,1)(-21,2)(19,-7)(25,3)(4,-4)(10,-11)(10,-10)(-17,-17)(-11,2)(-2,-1)(1,8)(-21,-8)(-16,10)(20,-6)(23,5)(8,-5)(-26,13)(-7,5)(-13,-7)(1,9)(-20,11)(13,2)(6,4)(14,6)(18,-3)(30,-1)(-8,1)(-34,18)(-23,-18)(14,-1)(10,6)(2,18)(-4,-6)(-3,-21)(13,-4)(6,-21)(-3,-4)(-25,-21)(-13,17)(-2,12)(32,9)(-3,11)(2,5)(-8,-8)(38,-17)(26,-11)(-18,3)(-24,11)(-20,14)(6,16)(15,-4)(-10,-7)(-6,-3)(9,7)(-10,-5)(-5,3)(-46,-4)(24,4)(20,-12)(46,-21)(-6,-12)(-28,0)(-15,14)(19,23)(25,7)(-27,-1)(-37,-7)(17,-14)(2,7)(33,3)(-5,15)(8,3)(-6,-5)(-21,-11)(21,5)(-12,-10)(8,10)(-13,-12)(-3,16)(-13,-3)(15,12)(23,6)(23,14)(5,-23)(-4,-22)(6,-6)(-6,8)(-5,2)(-39,-14)(-15,7)(-16,12)(12,20)(-2,-18)(-3,-8)(19,-2)(16,10)(-6,2)(3,-13)(-10,8)(8,12)(-18,0)(4,-9)(18,-15)(9,-2)(-15,-5)(-27,-5)(-24,12)(17,13)(17,21)(39,-10)(-19,5)(21,-12)(-20,9)(-4,-12)(-9,2)(13,-4)(12,-8)(-27,4)(-35,-5)(-1,19)(32,-2)(21,4)(27,-14)(-7,6)(9,-3)(-3,-7)(-19,-2)(-15,5)(-27,7)(6,-14)(-1,-10)(22,12)(19,16)(28,10)(-27,-21)(-17,-25)(-40,3)(14,17)(-15,26)(5,-14)(12,-2)(26,-16)(9,-2)(-34,1)(-24,13)(3,17)(21,-14)(32,-20)(-9,-5)(0,21)(9,19)(-3,4)(1,3)(-19,-16)(13,-17)(3,-6)(-20,20)(22,-1)(-21,-10)(14,-21)(0,16)(13,6)(-9,11)(-44,-8)(-6,-4)(13,3)(44,12)(19,-2)(8,-9)(-11,-14)(11,-5)(-15,13)(10,-10)(-20,-2)(20,-19)(-24,13)(-20,1)(0,8)(-6,-6)(4,6)(-12,7)(-8,10)(26,-8)(-19,-5)(34,1)(-5,0)(22,-12)(-10,-16)(5,5)(-16,11)(-22,24)(-3,0)(22,9)(27,-11)(-27,18)(-20,-17)(-14,-6)(1,-15)(29,17)(3,3)(26,-8)(-42,2)(6,3)(-17,12)(38,-23)(5,-5)(17,-12)(-14,13)(9,-7)(-15,1)(-22,2)(-38,11)(30,0)(26,0)(21,-9)(-33,5)(-17,-8)(-13,3)(31,18)(30,8)(26,-5)(-21,-18)(-23,-15)(-11,24)(-9,16)(11,25)(-23,-23)(-2,-10)(3,0)(-5,-2)(17,0)(-31,1)(38,2)(8,-3)(39,-5)(-22,15)(-32,1)(-10,-3)(30,7)(32,15)(-1,-2)(-5,-20)(-33,-16)(-12,3)(-34,3)(31,-11)(-11,4)(29,11)(-15,7)(33,2)(-16,4)(14,1)(-7,-18)(14,-16)(-19,12)(-8,18)(-34,10)(-9,-12)(-26,-22)(13,-12)(17,20)(35,8)(33,19)(-22,-4)(-35,7)(-22,-23)(26,-13)(34,2)(12,7)(-27,9)(-26,-5)(-1,-1)(14,-7)(31,-15)(10,-2)(19,10)(-31,12)(-19,16)(-11,-9)(14,1)(-4,-8)(3,-9)(3,6)(-4,-11)(12,7)(6,-16)(-4,21)(-5,9)(-9,19)(4,-23)(9,-1)(10,-13)(-3,24)(-20,-4)(10,0)(3,-10)(15,7)(-22,10)(6,-7)(-14,5)(14,0)(11,0)(2,-22)(-10,-16)(-22,1)(-2,7)(-2,9)(9,4)(-19,-1)(-13,15)(15,9)(20,13)(26,-27)(7,-14)(5,2)(-7,10)(-26,9)(5,-13)(-12,9)(10,-15)(-14,0)(15,4)(-24,11)(-5,-5)(-8,-13)(27,-5)(19,-7)(10,-9)(2,-6)(-21,20)(-7,3)(-4,13)(-3,-5)(0,17)(-18,11)(7,10)(-15,-18)(-6,-23)(9,-27)(31,23)(34,25)(-15,25)(-32,-2)(-29,-3)(-5,-2)(7,-19)(-1,-21)(37,-17)(10,5)(2,0)(-32,14)(-4,-7)(19,19)(4,-7)(-2,16)(-14,-10)(-14,-3)(-15,-7)(-5,-5)(28,-6)(37,-1)(-1,14)(-24,5)(-27,14)(3,0)(36,18)(-10,1)(11,-16)(-38,-3)(-4,-3)(-22,18)(43,-3)(2,-18)(29,-12)(-4,-14)(27,21)(-15,15)(-14,20)(14,-25)(16,-26)(18,-18)(-12,7)(-14,3)(-37,-7)(-7,16)(-6,16)(26,21)(-22,-21)(17,-14)(7,-20)(6,22)(-17,17)(5,11)(36,-12)(34,-9)(-12,3)(-26,6)(-4,10)(-2,-7)(-18,-1)(-4,-17)(-24,-7)(33,1)(-19,15)(19,14)(2,-17)(-18,0)(12,-1)(1,18)(3,1)(-33,2)(6,6)(20,-12)(24,-13)(1,-18)(1,0)(-30,-1)(-10,14)(9,17)(16,23)(-19,4)(-18,-1)(8,-22)(13,-9)(-4,-11)(-2,1)(-5,5)(31,-11)(-16,14)(-9,-2)(-24,11)(-6,3)(22,-11)(0,12)(27,-8)(-1,11)(26,-8)(-6,-10)(-7,-2)(-24,-17)(-19,4)(-27,-10)(-19,6)(25,12)(24,-3)(-1,-6)(-21,2)(4,21)(20,3)(14,1)(6,-11)(22,-1)(-8,-7)(1,12)(-25,11)(16,-4)(-11,-6)(16,12)(-20,-13)(13,-10)(-4,-13)(-5,19)(-36,7)(-27,4)(39,-9)(23,-6)(-3,-5)(-38,9)(3,-8)(30,-6)(1,2)(-13,23)(-28,-5)(3,3)(-16,-5)(39,2)(7,-2)(6,-20)(-9,4)(-13,-12)(11,12)(-12,-8)(9,9)(-17,2)(10,15)(12,2)(23,4)(-7,5)(-7,-10)(16,-18)(20,-11)(25,8)(-3,5)(-3,18)(-17,5)(-31,14)(-17,-6)(-20,-21)(12,0)(14,5)(33,5)(-3,-1)(-3,-27)(-11,1)(-1,-12)(5,9)(-22,-3)(7,-6)(-36,12)(41,2)(17,18)(36,-15)(-18,13)(-14,3)(-10,11)(0,3)(-1,-2)(-8,-8)(-11,-17)(-6,-15)(-5,-2)(-14,-7)(17,1)(-4,15)(9,25)(-7,-5)(-10,-14)(34,-13)(16,4)(23,-4)(-34,10)(-8,1)(-24,24)(24,-15)(-6,8)(7,-9)(3,19)(9,11)(32,-16)(-16,-19)(2,-12)(1,11)(15,16)(-16,-9)(-17,0)(-22,5)(-19,-5)(-10,12)(4,-28)(8,22)(7,-2)(-6,26)(4,5)(4,-12)(32,-19)(22,-5)(-18,13)(-35,2)(-28,-14)(3,-16)(-9,14)(-3,10)(-5,19)(41,5)(10,-9)(8,-7)(-1,-2)(11,5)(0,3)(-14,-18)(7,-1)(23,-10)(-23,-8)(-15,1)(-10,-7)(41,7)(26,-8)(20,19)(-31,-7)(-7,10)(-9,0)(16,26)(-32,4)(9,-20)(-18,-6)(16,-12)(-38,13)(34,-3)(23,8)(38,-2)(-29,-10)(-32,6)(-22,4)(1,7)(-1,-12)(-21,7)(-17,-6)(6,0)(2,-11)(38,-3)(5,5)(38,-1)(-22,-2)(-19,12)(-5,-13)(9,11)(18,-14)(-3,18)(-18,-5)(-15,-5)(-27,-12)(3,-3)(27,-4)(9,19)(15,20)(11,15)(-16,-21)(-12,-21)(-38,-19)(43,2)(-8,7)(18,13)(-41,-2)(12,1)(-19,-10)(17,21)(-13,15)(37,14)(1,-8)(9,-11)(-6,4)(-8,-19)(24,2)(-22,-20)(6,22)(-34,-17)(-11,5)(1,-4)(14,19)(40,-7)(13,-6)(23,7)(-7,0)(-20,4)(-28,-22)(-34,26)(4,6)(27,-5)(29,-25)(24,-23)(-4,9)(3,9)(-5,10)(4,-3)(-7,6)(-16,-4)(-6,-5)(-4,-6)(-8,15)(-32,26)(-7,7)(23,-4)(5,-9)(1,11)(-25,-6)(19,-6)(22,-11)(32,-10)(16,-7)(-41,-1)(-32,-1)(-2,21)(40,11)(30,27)(2,-16)(-33,-9)(-9,-26)(-8,-7)(32,2)(15,2)(-16,21)(-21,6)(-29,-3)(-3,-10)(26,-19)(5,18)(6,-13)(-20,1)(-21,8)(20,19)(2,2)(39,-6)(-29,7)(-1,8)(4,2)(-4,-15)(-2,-12)(-19,-15)(-6,-3)(9,18)(0,-7)(10,-4)(-9,-4)(10,13)(-10,4)(-21,-10)(-33,-3)(2,-10)(34,-7)(16,-10)(2,15)(-26,17)(10,25)(18,-10)(22,-18)(-9,-5)(4,9)(-30,21)(11,-18)(16,8)(24,-22)(-11,12)(-35,3)(13,16)(-7,-7)(16,-9)(1,7)(-8,-4)(-21,2)(1,-21)(34,18)(29,-8)(-38,1)(-38,-20)(-17,2)(27,19)(37,2)(-2,-6)(-11,-18)(-15,12)(13,6)(1,12)(4,-10)(13,0)(18,1)(-20,7)(-6,-3)(-4,-9)(28,-3)(-32,-9)(-3,-4)(-20,2)(24,19)(-13,18)(16,-7)(3,6)(15,-19)(3,-2)(-28,-5)(7,9)(-24,7)(0,-15)(-20,8)(6,2)(31,13)(25,5)(-4,-10)(-25,9)(-17,-24)(4,9)(28,-15)(12,22)(-2,13)(-18,12)(-10,-13)(-6,1)(21,-23)(-28,0)(32,-8)(-13,27)(35,5)(-4,12)(-16,-13)(-28,-1)(-26,-13)(2,-6)(18,3)(33,-4)(20,7)(-1,4)(-37,13)(-6,-10)(-4,-7)(5,-11)(-6,22)(17,-9)(4,5)(-13,-23)(-30,10)(15,-7)(-2,20)(2,7)(-26,-3)(41,-21)(4,-2)(27,8)(-20,9)(3,3)(-26,1)(11,-6)(-16,-9)(32,9)(-32,4)(28,-12)(-33,2)(26,7)(0,15)(27,-10)(-21,5)(-22,-3)(7,-17)(17,4)(24,0)(-30,12)(-12,-11)(-32,-8)(23,8)(-4,6)(9,10)(3,-4)(23,-11)(28,-3)(-7,9)(-23,6)(7,-10)(17,0)(36,-3)(-8,15)(-40,-1)(-45,8)(-35,3)(-2,-3)");
            #endregion
            #region 27
            Inputs.Add(27, "ToBeFilled");
            #endregion
            #region 28
            Inputs.Add(28, "ToBeFilled");
            #endregion
            #region 29
            Inputs.Add(29, "ToBeFilled");
            #endregion
            #region 30
            Inputs.Add(30, "ToBeFilled");
            #endregion
            #region 31
            Inputs.Add(31, "ToBeFilled");
            #endregion
        }
        public static IEnumerable TcD01P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
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
                yield return new TestCaseData("").Returns(int.MinValue);
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
                yield return new TestCaseData("").Returns(int.MinValue);
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
                yield return new TestCaseData("").Returns(int.MinValue);
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
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData("1").Returns(0);
                yield return new TestCaseData("2").Returns(1);
                yield return new TestCaseData("3").Returns(2);
                yield return new TestCaseData("4").Returns(1);
                yield return new TestCaseData("5").Returns(2);
                yield return new TestCaseData("6").Returns(1);
                yield return new TestCaseData("7").Returns(2);
                yield return new TestCaseData("8").Returns(1);
                yield return new TestCaseData("9").Returns(2);
                yield return new TestCaseData("10").Returns(3);
                yield return new TestCaseData("11").Returns(2);
                yield return new TestCaseData("12").Returns(3);
                yield return new TestCaseData("13").Returns(4);
                yield return new TestCaseData("14").Returns(3);
                yield return new TestCaseData("15").Returns(2);
                yield return new TestCaseData("16").Returns(3);
                yield return new TestCaseData("17").Returns(4);
                yield return new TestCaseData("18").Returns(3);
                yield return new TestCaseData("19").Returns(2);
                yield return new TestCaseData("20").Returns(3);
                yield return new TestCaseData("21").Returns(4);
                yield return new TestCaseData("22").Returns(3);
                yield return new TestCaseData("23").Returns(2);
                yield return new TestCaseData("24").Returns(3);
                yield return new TestCaseData("25").Returns(4);
                yield return new TestCaseData("26").Returns(5);
                yield return new TestCaseData("27").Returns(4);
                yield return new TestCaseData("28").Returns(3);
                yield return new TestCaseData(Inputs[3]).Returns(371);
            }
        }
        public static IEnumerable TcD03P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData("0").Returns(1);
                yield return new TestCaseData("1").Returns(2);
                yield return new TestCaseData("2").Returns(4);
                yield return new TestCaseData("4").Returns(5);
                yield return new TestCaseData("5").Returns(10);
                yield return new TestCaseData("10").Returns(11);
                yield return new TestCaseData("11").Returns(23);
                yield return new TestCaseData("23").Returns(25);
                yield return new TestCaseData("25").Returns(26);
                yield return new TestCaseData("26").Returns(54);
                yield return new TestCaseData("54").Returns(57);
                yield return new TestCaseData("57").Returns(59);
                yield return new TestCaseData("59").Returns(122);
                yield return new TestCaseData("122").Returns(133);
                yield return new TestCaseData("133").Returns(142);
                yield return new TestCaseData("142").Returns(147);
                yield return new TestCaseData("147").Returns(304);
                yield return new TestCaseData("304").Returns(330);
                yield return new TestCaseData("330").Returns(351);
                yield return new TestCaseData("351").Returns(362);
                yield return new TestCaseData("362").Returns(747);
                yield return new TestCaseData("747").Returns(806);
                yield return new TestCaseData(Inputs[3]).Returns(369601);
            }
        }
        public static IEnumerable TcD04P1
        {
            get
            {
                yield return new TestCaseData("").Returns(-1);
                yield return new TestCaseData(@"aa bb cc dd ee
aa bb cc dd ff
aa bb cc dd aaa").Returns(3);
                yield return new TestCaseData(@"aa bb cc dd ee
aa bb cc dd aa
aa bb cc dd aaa").Returns(2);
                yield return new TestCaseData(@"aa bb cc dd ee
aa bb cc dd ff ff
aa bb cc dd aaa cc").Returns(1);
                yield return new TestCaseData(@"aa bb cc dd aa
aa bb cc dd ff ff
aa bb cc dd aaa cc").Returns(0);
                yield return new TestCaseData(Inputs[4]).Returns(383);
            }
        }
        public static IEnumerable TcD04P2
        {
            get
            {
                yield return new TestCaseData("").Returns(-1);
                yield return new TestCaseData(@"abcde fghij").Returns(1);
                yield return new TestCaseData(@"abcde xyz ecdab").Returns(0);
                yield return new TestCaseData(@"a ab abc abd abf abj").Returns(1);
                yield return new TestCaseData(@"iiii oiii ooii oooi oooo").Returns(1);
                yield return new TestCaseData(@"oiii ioii iioi iiio").Returns(0);
                yield return new TestCaseData(Inputs[4]).Returns(265);
            }
        }
        public static IEnumerable TcD05P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(@"0
3
0
1
-3").Returns(5);
                yield return new TestCaseData(Inputs[5]).Returns(326618);
            }
        }
        public static IEnumerable TcD05P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(@"0
3
0
1
-3").Returns(10);
                yield return new TestCaseData(Inputs[5]).Returns(21841249);
            }
        }
        public static IEnumerable TcD06P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData("0\t2\t7\t0").Returns(5);
                yield return new TestCaseData(Inputs[6]).Returns(5042);
            }
        }
        public static IEnumerable TcD06P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[6]).Returns(-1);
            }
        }
        public static IEnumerable TcD07P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[7]).Returns(-1);
            }
        }
        public static IEnumerable TcD07P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[7]).Returns(-1);
            }
        }
        public static IEnumerable TcD08P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[8]).Returns(-1);
            }
        }
        public static IEnumerable TcD08P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[8]).Returns(-1);
            }
        }
        public static IEnumerable TcD09P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[9]).Returns(-1);
            }
        }
        public static IEnumerable TcD09P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[9]).Returns(-1);
            }
        }
        public static IEnumerable TcD10P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[10]).Returns(-1);
            }
        }
        public static IEnumerable TcD10P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[10]).Returns(-1);
            }
        }
        public static IEnumerable TcD11P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[11]).Returns(-1);
            }
        }
        public static IEnumerable TcD11P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[11]).Returns(-1);
            }
        }
        public static IEnumerable TcD12P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[12]).Returns(-1);
            }
        }
        public static IEnumerable TcD12P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[12]).Returns(-1);
            }
        }
        public static IEnumerable TcD13P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[13]).Returns(-1);
            }
        }
        public static IEnumerable TcD13P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[13]).Returns(-1);
            }
        }
        public static IEnumerable TcD14P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[14]).Returns(-1);
            }
        }
        public static IEnumerable TcD14P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[14]).Returns(-1);
            }
        }
        public static IEnumerable TcD15P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[15]).Returns(-1);
            }
        }
        public static IEnumerable TcD15P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[15]).Returns(-1);
            }
        }
        public static IEnumerable TcD16P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[16]).Returns(-1);
            }
        }
        public static IEnumerable TcD16P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[16]).Returns(-1);
            }
        }
        public static IEnumerable TcD17P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[17]).Returns(-1);
            }
        }
        public static IEnumerable TcD17P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[17]).Returns(-1);
            }
        }
        public static IEnumerable TcD18P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[18]).Returns(-1);
            }
        }
        public static IEnumerable TcD18P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[18]).Returns(-1);
            }
        }
        public static IEnumerable TcD19P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[19]).Returns(-1);
            }
        }
        public static IEnumerable TcD19P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[19]).Returns(-1);
            }
        }
        public static IEnumerable TcD20P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[20]).Returns(-1);
            }
        }
        public static IEnumerable TcD20P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[20]).Returns(-1);
            }
        }
        public static IEnumerable TcD21P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[21]).Returns(-1);
            }
        }
        public static IEnumerable TcD21P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[21]).Returns(-1);
            }
        }
        public static IEnumerable TcD22P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[22]).Returns(-1);
            }
        }
        public static IEnumerable TcD22P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[22]).Returns(-1);
            }
        }
        public static IEnumerable TcD23P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[23]).Returns(-1);
            }
        }
        public static IEnumerable TcD23P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[23]).Returns(-1);
            }
        }
        public static IEnumerable TcD24P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[24]).Returns(-1);
            }
        }
        public static IEnumerable TcD24P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[24]).Returns(-1);
            }
        }
        public static IEnumerable TcD25P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[25]).Returns(-1);
            }
        }
        public static IEnumerable TcD25P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[25]).Returns(-1);
            }
        }
        public static IEnumerable TcD26P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData("[0,0][1,1](1,0)(0,-1)(0,1)(-1,0)(-1,0)(0,1)(0,-1)(1,0)").Returns(2);
                yield return new TestCaseData(Inputs[26]).Returns(-1);
            }
        }
        public static IEnumerable TcD26P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[26]).Returns(-1);
            }
        }
        public static IEnumerable TcD27P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[27]).Returns(-1);
            }
        }
        public static IEnumerable TcD27P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[27]).Returns(-1);
            }
        }
        public static IEnumerable TcD28P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[28]).Returns(-1);
            }
        }
        public static IEnumerable TcD28P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[28]).Returns(-1);
            }
        }
        public static IEnumerable TcD29P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[29]).Returns(-1);
            }
        }
        public static IEnumerable TcD29P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[29]).Returns(-1);
            }
        }
        public static IEnumerable TcD30P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[30]).Returns(-1);
            }
        }
        public static IEnumerable TcD30P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[30]).Returns(-1);
            }
        }
        public static IEnumerable TcD31P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[31]).Returns(-1);
            }
        }
        public static IEnumerable TcD31P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(Inputs[31]).Returns(-1);
            }
        }


    }
}
