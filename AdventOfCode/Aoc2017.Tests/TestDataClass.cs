using System;
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
            Inputs.Add(7, @"mypyemv (1058) -> tdssotr, pebnvks, zaulju
snslv (48)
aytbgf (30)
mkcrsy (42)
shwcd (42)
muwcoy (63)
dabfreg (49)
iblvv (68)
qqircn (401)
pwpnfx (67)
tlnztuz (60)
ctglahh (17)
pjkgn (170) -> pstttg, xdkoxrg, cvuvxi
ulasjv (114) -> tkeney, zaffbku
ojoim (139) -> obebr, zxwlsj
vhxxnj (109) -> ooaouu, vraxbmd
blbjzdr (40)
iuctosc (12) -> bqmayvq, yjzvbcb, takuy, qlsfhyp
mfafdfn (73)
egfrye (72) -> uwxizpk, igbamrm
cqokt (1487) -> sjmfsib, ubspq, wsaugv
ekorcyg (67)
sfyxd (83)
trkiub (65)
muvvc (92)
wfhzyz (224) -> swtggik, nczykbr
acvqze (46) -> itnagm, iehtjmy
atzmoh (85)
euqymh (108) -> wswanrt, lvwdcah, akpna, siwgip
ijxbxya (323)
izaggi (44)
xokweon (14)
kpiqwq (158) -> agvmnh, tfgkfd
lomas (52)
hmktr (42)
xemdot (63) -> xfbrfa, erorjt, opbpuun
xjljqp (15)
ruknk (35)
eupceiw (49)
hhdggir (21)
qzmgft (64)
xidme (10)
rwcrct (56) -> muwcoy, srpls
swtggik (62)
iehtjmy (99)
glsiv (21)
cdgfh (97)
nvuinv (82)
yrnvih (51) -> looatgs, sscwxvb, wpktell
jrwyr (62)
lfabu (50)
rzmad (5)
fulkuc (136) -> ltyun, vqzrfnp
wlhee (8)
szrhxg (58)
stiwccj (44)
kutxm (25)
jglsot (19)
zxicur (34) -> tkvxw, volvsy, mmtjv
dcdqv (17) -> xvlegev, nsiusgl, ypnoao, wlwzm
scrgj (63)
ororw (58)
lixut (29)
cqtkp (48)
mdxokdp (190) -> qilpxc, ertyni
xvdaje (43)
ertyni (83)
blthoo (416) -> xyoog, ryapaif, brepu
nhjlyw (20)
zezwh (40)
byazn (17)
btacot (71)
lccyzb (72) -> wrsfojv, bpphd, epkiz, hihsf
ohihh (6)
nafjxju (347) -> hptnh, zcyjg
tlzypd (66)
mkctoct (77)
xbaqsb (97) -> tpyhuwu, goxylms
cejttl (63)
eyzlc (12)
gmxxgje (97)
ydajdel (245) -> ydbfv, qoxynmi
ilpcfbv (88)
jbwvuqa (18)
wjtsdig (34)
fyiomy (1541) -> sgejm, oywep, vlbiiv
amxwjmq (87)
rmgua (6)
takuy (86)
jklzso (27)
qskbkjv (78)
dvpfhj (92)
ivyfvsy (8) -> fptxhow, xepmnz, dxlgbw, vzako
cebrhdf (42)
tkkaoqc (77)
ovgheo (64)
lqpnpz (31)
rjdcj (82)
xlezv (87)
hniys (265) -> prchlcp, uvamrg
nqonz (210) -> nikle, hsjgdl
rrvjgum (162) -> mdhmfy, cdgfh
wwewd (60)
fgnkr (126) -> ibmga, unsssb
bzbmtk (51)
kmdjw (93)
rqppagm (93)
rsush (244)
uavhq (38)
rdawn (31)
ilamw (26)
dzbqtuv (32)
ohnhqg (87)
qyrmgm (43)
qdeqxky (40)
csawtu (36)
ywmuda (50591) -> sswubza, jjsvzup, hriuldj, nddyl, rhlbu, ruukc
nypczc (28)
bvsey (74)
mjzkn (84)
fsjyp (63)
qaavkjk (241) -> gspvb, jrwyr
znesvt (62)
bfnfh (44)
wtedsf (76)
fvfzs (78) -> foicoy, zqqwfsl
xawwkeu (42)
wlwlu (60)
xswxrrf (161) -> slbstvc, narre
vqrgyeu (690) -> lzjyxw, dtxdpox, braccf, ttxbgy, vkqgyqv, jwlto, crdiqm
bnylq (29) -> ejtrjtd, nlxjjxw, vszskh, qwresy
ojcor (20)
vxxqlw (66)
qrwrsw (74)
qkruzdo (17)
hriuldj (6752) -> entepy, hcsqc, vpwwvup
hczrs (99) -> lwjzn, vvifz, lbqtlwu, spgvou, hhjylgi, ervdb
pcgfozu (113) -> zgikmp, acincpn
cwbnz (8)
xvaya (8)
xyebfi (1088) -> rsush, wxrgtti, thufa, hyiurrf, efoqm, uplvccb
txypjh (73)
bsaud (38)
mavjmb (16)
igyjzmj (49) -> fsjyp, sbmrcz, ewjxaid
blssf (73) -> nypczc, oknwj
ichbonq (293) -> hwkclx, qaoygb
senunnx (96)
kvmcuy (1173) -> blssf, ghnims, hagdle, wwiei
urqute (86) -> ffojoq, iblvv
ginxj (10)
adxktmm (53)
vmejikv (1281) -> hbcnhi, zvbxsh, bpgqat
braccf (266)
mouemac (9)
ydbfv (31)
sggmn (61)
ndjsvna (86771) -> orflty, upcttms, cdllr
ecnra (157) -> onggzld, hnlzfo, ssspogy, eyzlc
ldwvnvr (72)
rjihyh (96)
dlfly (78) -> rdawn, izuwus
xdglmq (66)
aysnc (142) -> cebrhdf, uwswfv
lvwdcah (13)
tgfwmr (44)
hvlha (35)
ptuptho (283)
otuscl (1217) -> fulkuc, nwtyz, urqute, lyaszvd
uuwxren (41)
fwltc (15)
nsdmz (200) -> xidme, jvbywje
gcndqm (35)
yhwjhjq (47) -> vsvqb, txypjh
dtobnc (30) -> fvzkg, bvsey
kqazfnj (45)
wsdxxey (191) -> avntwr, ynfhkg, eiitagr
aygufuz (96)
oxbck (82)
bpcvuic (165) -> ginxj, jxdojc, yqpdpc, vsxpvjg
lsepilv (99)
xxfgrym (64)
ldatid (44)
znyle (367)
jtsfhtl (255) -> cbopz, hlgfih
yfasy (22)
gmrgmk (32)
rslnynd (89)
smntgp (202) -> bosue, lwpjj
exjob (13)
etxmacn (14)
mytar (209) -> nbujb, dabfreg, bsqhq
sjmfsib (264)
bvtwdp (75)
xykxl (72) -> mrkkga, tkkaoqc
acincpn (33)
uhtqjnr (179) -> gapar, znill
emfcg (1116) -> aqfyjhl, gikkpk, czdkuo, cedhxw, ptuptho, hniys
foghgll (67)
rwmrhlm (14)
roecqp (1134) -> bziunp, ecnra, bpcvuic
hurkk (12) -> qslsdtg, vwlzyq, boszvbo
phdxan (20)
nikle (59)
zkgbmgm (77) -> smbrw, yyqbv
rvdbo (88)
mfeed (43)
dygaged (89)
looatgs (19)
uigjohl (1555) -> zslpkcc, oquxa, kpiqwq, fvfzs
sbotg (88)
kvdwl (43)
yskbqg (11) -> vjvmzpj, dbcczgx
oypkcb (15)
yjchb (58)
fsztlli (50)
xoknhd (134) -> aytbgf, sxkmsi
hyiurrf (68) -> mwalo, fjahqnz, stiwccj, bvzurvv
nkuur (1240) -> dxbxbo, medzho, yfasy
idhsp (148) -> npdbx, zuziby
jwlto (182) -> hmktr, qmpdncq
eziybgr (23)
grnajbj (26)
npdbx (61)
lbqtlwu (213) -> kbdwm, uwfgkl, gwgodil, lrdeob
drndkqk (168) -> xokweon, wieeikb
uuioune (83)
wwiei (109) -> kjitif, ozupxsh
polsl (921) -> zrcxh, gvcmhx, hgvmyza
rdjxdt (76)
nrzrezq (49)
eescab (62)
onqfuf (30) -> tzgzrq, mkctoct, wsdxfo, scbrb
rmlqc (91)
hnalr (63)
dycnkbi (22)
tzgzrq (77)
lyaszvd (36) -> bjcuq, kmdjw
xepmnz (80)
vraxbmd (84)
seygew (176) -> phocz, hlmune
wqcsem (16716) -> mwzswq, qmlaw, ydajdel, zxicur
naifggq (87)
yyqbv (89)
dbgxe (135) -> imdjavh, wmaamu
pjmhz (19) -> brgavyz, esjurlp, lhqak
wlwzm (229) -> tsmzdk, fwvhiss, ceudr, uwazw, qfiva
rgswd (64)
pwioc (75) -> zzwgd, vxxqlw, xdglmq
eymgei (225) -> pwtps, shwcd
xitky (40)
kpyvxm (76)
gkjvxop (84)
infmrxl (56)
ptjajhf (50) -> quozn, zvyualm
kdqwwif (54)
okahbh (63)
spgvou (217) -> mavjmb, dvkfej, jtnbs
jxdojc (10)
qhdjhrx (69)
ialitr (42) -> akpdkoi, mzzobb, vpynma, lkooh, jfshm, fwygrf
vcgzwm (28)
fwygrf (305) -> ocoupnc, omgbz
cbudcq (111) -> cqamyg, dsxnt
medzho (22)
nqppb (1202) -> emzadp, bvtfsnv
ejwvtdi (73)
rtvvtqm (386) -> zbxnrw, knbui
udebtlr (81)
mcosbxa (40)
ztale (139) -> qhdjhrx, bglby
wsdxfo (77)
knbui (9)
cwpxg (34) -> wsceh, wypqz, qytybg
hzwmfmm (22)
ltyun (43)
ooaouu (84)
xhrsff (38)
ceudr (294) -> wswfp, otymwch
dhgwl (1826) -> ydtdz, oyfjp, jpoikof
kcskisn (177) -> gzmuxt, ifxlnmy
dtxdpox (82) -> uuijugi, dmjrx
mrkkga (77)
aptjif (114) -> sfsqlr, uhldcdr
nbpzp (39)
tywon (68)
dngdv (86) -> picnyuy, rqppagm, yzdqm
xjweui (19)
sfsqlr (93)
hpxuh (45)
nbujb (49)
afpecm (93)
slbstvc (74)
cbryc (76) -> dgwpdyh, fadosqb
jczlwrg (97) -> mcvmt, ysptuct
adyaz (58)
kcpxll (29) -> cykkbh, rvdbo
zbxnrw (9)
betps (17)
zdguboh (45)
zqqwfsl (71)
bvzurvv (44)
mvhjvsx (74)
yksfjd (172) -> okobh, tgfwmr, zkjxiqd, sksyosg
fszzls (1508) -> lskwu, ymaow, uigjohl
fudnt (58)
tjlzt (51)
rthgd (226)
zqakqf (152) -> axaojh, bbojjz
jsoaf (85) -> peuzd, kervui, lccyzb, rtvvtqm, pxfxcwi
kayutk (135) -> cqtkp, ertegmg, xcmjj
eccqmq (61)
gxmjfay (56)
uhldcdr (93)
atgslqo (189) -> ypflzv, vxrjtk
tmqmur (51)
eusabu (51)
rrhqyi (88)
dlblhs (50)
mygap (82) -> rwnwac, jnqyz, geaqa, bacdnzx
iyylin (244) -> nlnalmy, tuvvzii
jsmmy (149) -> rjihyh, njftjr, mjpctj
lgiwxh (110) -> hsrzvw, mwtpyul
pihmrxm (7418) -> nqlzz, kpvixun, ecgci, hzltk, kayutk
sxmeh (1344) -> eqfhg, ptjajhf, oglxcmb
hcsqc (88) -> xbyqz, ubwbr, mygap, kcgsp, zlkpb
crayus (20)
zvbxsh (45) -> mkaznh, hfhdret
quehgo (76)
kmkfzcz (20)
dwlbh (89)
badmffy (33)
zilhzgj (327) -> jihuf, jdylgmm
tuvios (10) -> mgtxs, uapgx
crnkf (86)
jedncgk (166) -> bzbmtk, wgwmd
uxpdj (18)
uapgx (65)
kapgfn (71)
viytym (1583) -> jcswni, hdhay, drndkqk
vjabq (163)
ywigueo (31)
ypnoao (2033) -> zpyjk, sfyxd
yanhp (28)
xdkoxrg (36)
onggzld (12)
tzdhk (2466) -> mfeed, ftjqj
wbmho (596) -> htfkm, xatcr, sotsaq, xemdot, jdphz
fzorad (72)
dalfsy (81)
pidgo (1422) -> gxqhw, wrpla, lncrnjm
teivbkx (88)
wwmczwe (38)
iqxuy (186) -> grxsygp, zariy
zxwlsj (49)
kjmlecw (13)
vevsn (21)
cvuvxi (36)
akpna (13)
censvvb (47) -> hekhmmx, fhbsh, zilhzgj, qaavkjk, ykfuiik, dngdv
ulwogj (52)
xiplruw (67)
sddzrpe (20)
uwswfv (42)
ofgni (68)
duilk (154) -> icyem, qmiwmcd
uoineor (8)
grhiyhw (138) -> lixut, ieexpjt, vsqpyrc
hztml (155) -> rwizsex, fwxzdr, zpgad
wpktell (19)
nsiusgl (36) -> hmeqffk, yvnguxg, jrwro, uhtqjnr, xswxrrf, atgslqo, eymgei
niuavpj (80)
bmuxik (1638) -> vtxojlh, betps, byazn
zmvaqzk (56)
ygvihck (1847) -> hurkk, yrnvih, qhvtakl
vpynma (81) -> rjdcj, nvuinv, bbyfznm, oxbck
hmeqffk (77) -> letlj, ihtqyi, szrhxg, ggdgz
yqpdpc (10)
zvyualm (33)
ebmlo (14)
qquhmw (8)
eiajcj (50)
zrcxh (61) -> nrzrezq, hfauih, eupceiw, dsfrgq
bfbjr (2512) -> sddzrpe, kmkfzcz
yrmfqoy (78)
iaxol (89) -> dywxgkl, badmffy
qmlaw (191) -> vxagjlw, bzziw
luedvgo (51)
qnyjwud (18)
gzwdr (198) -> bqsjvdf, iqyhxcw
ghnims (72) -> blkpn, jglsot, kwxszx
sczhwf (6688) -> tlbdrz, emfcg, mtlrg, bjnxl
jmtvijt (52)
qscxur (97)
qfiva (210) -> dvpfhj, nwtgwj
orflty (82) -> xnfff, rgoiojv, hnovowe, qsidq, ncrxh
liopy (51)
dztfd (14)
kiyra (1333) -> xykxl, smntgp, vopguxl, ihrwjcv
oogodf (487) -> jtsfhtl, pwioc, jtbnzi
rhsppv (110) -> apitzsg, cxewh
rhtin (91)
dkjgzys (124) -> fuzpme, qjhiy
tyuftbm (196) -> vvdnnin, tlzypd
jnqyz (71)
wmiupn (30)
vioxf (58)
cslvss (10) -> teivbkx, ozqmk
wswfp (50)
nwosqhj (720) -> zmbunn, zkkvo, rhoexv, ojoim
wwudvj (58)
tovzpw (41)
sksyosg (44)
brepu (7)
ykkcei (19) -> espnx, wqcsem, sgknjo, sczhwf, dbkkk, obxht, etyuvh
izuwus (31)
xxtwrvp (63)
aqfyjhl (111) -> bvxlrk, dlamw
tysys (9)
mmjvskv (14)
yugpzh (108) -> kvdwl, xvdaje
ejtrjtd (93)
ibmga (50)
etxziey (228) -> xvaya, qquhmw
azyzcr (72749) -> hciyw, pihmrxm, ywgvt, dcdqv, dieqdax, fszzls
dbcczgx (84)
vdaipmp (39)
erxsplp (49)
hagdle (13) -> fagghhk, gisbvap
esqjbr (76)
kcgsp (350) -> ckflx, wlhee
ownte (89)
dbxwe (1571) -> cwpxg, nmqbvpq, dtobnc
mlqhbm (87)
prchlcp (9)
omgbz (52)
msshu (93)
fmltl (73)
jdphz (195) -> wwewd, jyljgi
hzltk (191) -> dycnkbi, hzwmfmm, ynfor, bflcu
owyvbh (36)
ihtqyi (58)
zmbunn (59) -> dygaged, yzgavqk
goxylms (54)
eknhj (24)
etyuvh (16720) -> atwydaw, ulasjv, qvgqro, hfwvb
ookiv (67)
krrqud (257)
bziunp (69) -> ofgni, tywon
tquiwoi (53)
zyfceqn (96)
sxkmsi (30)
nefuqmx (36)
stzod (62)
letlj (58)
aledvka (348)
bqqmp (58) -> zqakqf, ulnegp, cjxht, tclpy
jbttm (58) -> stzod, eescab
ojspxc (92)
bdjhzp (28) -> bdxixic, zyfceqn, pzjttn, psfvjcp
ypflzv (60)
qscii (51)
gdise (7)
uflkv (172) -> scfmycd, tdocp
mvllqsx (55)
yvnguxg (309)
mwtpyul (47)
uzuqqja (28) -> jhouok, zmvaqzk
htfkm (303) -> ordnoxv, ohihh
hdefj (60) -> kfofavd, sfnmpjd
kfnpyl (25)
epkiz (83)
xnasc (99)
enlerk (82)
bdfgsx (385) -> yhohp, vcgzwm
bcslfkc (208)
mlxtf (267) -> qnzrznc, lfabu
zpyjk (83)
vjvmzpj (84)
cxewh (36)
huozxzo (89)
fkstubd (99)
rkddlwk (1718) -> pjkgn, wilmnmv, duilk
uwazw (224) -> atzmoh, fpart
hbhvg (32)
ruukc (26) -> cidcth, eqoivx, ccdvhvz, ialitr, dkszj
siwgip (13)
igxruya (186) -> lymfmlp, ouxhs
lzsao (39)
dlamw (86)
cdutkux (215) -> vevsn, gofcp
wvzeiwz (141) -> dppnlm, jedncgk, didaob, guzxauy, ltzsoxk, dkjgzys
qmpdncq (42)
fnsflkm (77)
drnxkqu (61)
bzziw (58)
wyciek (45) -> iyaxfqg, lythu
aanhl (6)
imobzk (192) -> uoineor, zhlbg
jkhfw (85)
jlosq (84)
htfhn (1523) -> xoknhd, yugpzh, bniphb
bgute (51)
zzitpl (77) -> zddflk, uxbkndn
hsrzvw (47)
dmjrx (92)
tfwfd (41)
smbrw (89)
uxcmt (199) -> lgwgc, ebximw
xbyqz (268) -> fntqeb, etmlid
kjitif (10)
oknwj (28)
brgavyz (48)
fhbsh (197) -> jlosq, ckzmd
pdhmgx (18)
yjzvbcb (86)
qwresy (93)
ucuhiy (81)
uyzts (40)
erorjt (84)
hhjylgi (73) -> senunnx, aygufuz
nthwie (98) -> cblwb, drnxkqu
wrsfojv (83)
ppkmfx (1457) -> bzqoi, hdiqnt, igyjzmj
uwfgkl (13)
vzpakr (35)
nxyku (41)
nwtyz (152) -> zigvdka, gcndqm
tmrukz (82)
mkaus (82)
ebximw (62)
kmbky (263) -> rgswd, xxfgrym
ckzmd (84)
ulnegp (196) -> azgcixi, hibvd
cbato (81)
fhhim (63)
ybayf (35)
bvfrrlk (6)
mluvdn (49) -> ilpcfbv, sbotg
jvamv (20)
lzqmapb (65)
cedhxw (273) -> owxjs, rzmad
icyem (62)
mwfweu (7)
vlbiiv (28) -> uyzts, xitky, jzxslw, mcosbxa
cfynk (60)
vwlzyq (32)
vsxpvjg (10)
pmiwg (7)
gcbwu (401)
ippiayw (40)
oywep (84) -> jmtvijt, lomas
gbbqu (60) -> igxruya, zhjrvb, mytar, vkgmm, rrvjgum, mdxokdp, iuctosc
upvqdc (35)
tkvxw (91)
yofaj (17)
mcvmt (65)
lythu (80)
spcxr (103) -> tfwfd, frmkl, nxyku
ocoupnc (52)
yirlhg (347) -> jklzso, pbrakxw
dieqdax (3809) -> xsmnbd, nwosqhj, cbsqsb
jppbqj (39)
wtbkj (1625) -> xeaftl, euqymh, qaybrra
czpmzex (61)
hdiqnt (182) -> xvmmt, yanhp
uqmxlbi (87) -> sgevc, payocx, bkapyf, btkish
dxlgbw (80)
cbsqsb (86) -> xvapp, rthgd, spcxr, fgnkr, vquis, dutblrl, aysnc
otymwch (50)
yfxiz (52)
zkvyo (246)
rhoexv (95) -> gmslbkd, kapgfn
ynfhkg (49)
nkallms (92)
tdssotr (81) -> scrgj, okahbh
vpwwvup (1168) -> rexdsi, hpkqdn, pqvvi
jzxslw (40)
xvmmt (28)
vwubn (80)
dywxgkl (33)
lkooh (223) -> igrfqy, znesvt, qaddd
obebr (49)
owlxwub (39)
ubspq (94) -> coxuj, oiiufpg
hmqyh (255)
jztwlhz (111) -> xfzbans, brlrqy, zdguboh
vcguzz (94) -> fjvazs, blthoo, jsmmy, ichbonq, ujrnrd
jdylgmm (19)
snoxm (42)
kaqrd (80) -> ifuvb, nneqad
ihrwjcv (146) -> zezwh, ippiayw
mkaznh (46)
bqsjvdf (40)
zhjrvb (214) -> btacot, ajgkut
ifxlnmy (95)
geaqa (71)
sochjt (833) -> pcgfozu, yskbqg, ooqtpgb
uuqzc (64)
narre (74)
dgwpdyh (99)
jjzna (1427) -> obpbif, wzvubdc, idhsp
qobvna (21)
ggdgz (58)
boszvbo (32)
cqxfcqr (47) -> owyvbh, nefuqmx, fmlqbe
eaayvc (26)
ervdb (202) -> hhdggir, qobvna, glsiv
vsvqb (73)
cfrcn (14)
bosue (12)
agvmnh (31)
bjcuq (93)
rgziu (47) -> bdfgsx, muewwty, hhyqt
bdxixic (96)
hmslvhd (64)
cqamyg (83)
ypvcfg (83) -> aledvka, bazgple, gazra, wfhzyz, yksfjd, uflkv
wsceh (48)
apitzsg (36)
rgsktf (152) -> ibigmtm, nggqv
psfvjcp (96)
hfauih (49)
bazgple (80) -> ookiv, ekorcyg, xiplruw, zygeve
fecfcyc (81)
klpjlll (7)
tsmzdk (394)
jjsvzup (7439) -> bmuxik, hczrs, kvmcuy
tfsenz (52) -> whpgoe, kpyvxm
vzako (80)
rdmyua (373) -> ovlle, mwfweu, kxsio, zfvnm
yzdqm (93)
nawecgw (30) -> zvatf, sixatzk, bgwym, ztale, cbudcq, vhxxnj
hlgfih (9)
lgwgc (62)
qaoygb (72)
zcnkvpn (88)
sgejm (162) -> ywjdepk, xsbbpem
lmpji (117) -> uavhq, wwmczwe
uuijugi (92)
zpgad (41)
ndxlz (39)
tclpy (78) -> shnov, qskbkjv, awscps
kxsio (7)
oglxcmb (116)
awscps (78)
ajgkut (71)
gapar (65)
zsezyi (48) -> pwpnfx, foghgll
lakdjt (18)
vquis (130) -> cofbsq, snslv
demwz (90)
zefog (15)
akpdkoi (385) -> trycav, lmeql, puhlt
xcxuhpd (665) -> onqfuf, tbhokxb, wsdxxey
lampfo (26)
qlsfhyp (86)
ijpak (93)
cmwxozx (75)
mzzobb (369) -> phdxan, nhjlyw
vkgmm (328) -> cfrcn, mmjvskv
ckflx (8)
czgpah (18)
dsfrgq (49)
pzjttn (96)
mwalo (44)
dajhp (90)
vdjyb (73)
shnov (78)
sythobq (263) -> fpgjkf, ulwogj
yzgavqk (89)
eqfhg (14) -> vxlasq, wjtsdig, xerwajl
bvtfsnv (84)
trycav (8)
xjlyt (54)
xmkxjgq (53)
cvenf (12)
mgxgsx (74) -> jjtsj, anykkx
gwwrlp (92)
ieexpjt (29)
gowhuw (86)
bbojjz (80)
vkqgyqv (162) -> bdgcym, yfxiz
fzpjtgv (243) -> klpjlll, pmiwg
dzjhdt (140) -> sudoea, rwmrhlm, etxmacn
ammhz (85)
ibigmtm (61)
bpgqat (21) -> yjchb, kcyuui
xerwajl (34)
pyentj (85)
dbkkk (3209) -> otuscl, dhgwl, fyiomy, wtbkj, dbxwe, jsoaf, htfhn
rexdsi (64) -> ijpak, msshu
bsqhq (49)
picnyuy (93)
okobh (44)
zcyjg (22)
upcttms (4492) -> polsl, sgamtw, sxmeh, vmejikv, nawecgw
efomsfh (35)
pstttg (36)
lymfmlp (85)
jknlaad (141) -> yvovprt, qposz
idngwil (53)
qpism (1332) -> kutcu, etxziey, acvqze, xkari, mgxgsx
xxohf (36)
rxocfu (31)
qjhiy (72)
mtlrg (1379) -> kcpxll, dbgxe, vpiug, xbaqsb, wnqqem, wyciek, vzfmojd
rhlbu (11221) -> xnmoq, fzpjtgv, lftjq, cdutkux, krrqud
zsdog (148) -> xxtwrvp, hnalr
xnmoq (113) -> fzorad, ldwvnvr
rwizsex (41)
hfhdret (46)
xvlegev (477) -> kaqrd, egfrye, fmxhbs, jztwlhz, zkvyo, nofuzdd, lhjmsy
qaddd (62)
fjvazs (93) -> grrfq, hlfmjm, crnkf, gowhuw
fswhx (23)
qoxynmi (31)
duwat (39) -> libqry, tyuftbm, ivyfvsy, nqonz, xuqosu
bniphb (42) -> awcvbgl, quehgo
emzadp (84)
bqdtj (84)
obxqu (185) -> cwqzpce, dztfd, ebmlo
atuotwh (30)
lhqak (48)
sotsaq (315)
qmiwmcd (62)
ikjorey (94) -> ojspxc, uktjzbb
wzvubdc (92) -> rslnynd, dwlbh
oiiufpg (85)
pebnvks (123) -> hjfuq, snoxm
nggqv (61)
bqmayvq (86)
xvarjo (51)
rvqwfsn (84) -> rxowzf, xvarjo
rgoiojv (5) -> czxjike, mlxtf, uqmxlbi, sythobq, jnmrl, kcskisn, znyle
efomf (87)
ynfor (22)
hihsf (83)
bkapyf (70)
gikkpk (40) -> hyohkqq, ktfzzi, dalfsy
fvaow (54)
ilcvskn (201) -> jmjxm, cvenf
zddflk (74)
wmaamu (35)
smkqkas (39)
cbopz (9)
vszskh (93)
gpkrbvt (91)
yodja (82)
bvcujod (85)
bdjhrqu (199) -> kjmlecw, exjob
uwxizpk (87)
hnlzfo (12)
qilpxc (83)
pryxkzp (57) -> zmaqz, gvangx
mjpctj (96)
fadosqb (99)
xuqosu (298) -> fwltc, cqvwrm
lbmkk (79) -> eusabu, dchdrpf, liopy
zhyhc (41)
xkari (70) -> efomf, ohnhqg
lcblh (674) -> nhzxvd, lbmkk, iqxuy
ouxhs (85)
bvxlrk (86)
etmlid (49)
rujeuns (23)
mgtxs (65)
tvxhhko (69) -> xgdqc, afpecm
bflcu (22)
fmlqbe (36)
qnzrznc (50)
dwogs (48)
tlbdrz (7) -> gcbwu, lgatvlk, diflt, bnylq, yirlhg, rdmyua, qqircn
ezpwfm (50)
yunufd (51)
ecgci (107) -> pdgdceb, qyrmgm, nzxlkrf, bjcgvr
tkeney (96)
pdgdceb (43)
puhlt (8)
gzfqvb (78)
jyljgi (60)
czqieu (81)
pjmolr (376) -> czgpah, pdhmgx
nhzxvd (104) -> qzmgft, uuqzc
gjfmnpu (25)
ykfuiik (205) -> ycmcpqd, qdeqxky, emsuiot, miimy
brlrqy (45)
vvifz (169) -> lkvdgsk, nqrgm, pohuglk
cweuc (37)
vxlasq (34)
cblwb (61)
cykkbh (88)
esjurlp (48)
vjzteyv (33)
kpvixun (35) -> eccqmq, eeqon, zdgotwb, sggmn
bacdnzx (71)
tuvvzii (17)
plnuv (81)
tmrvz (37)
peuzd (236) -> nlyrnm, kjdboj
tpyhuwu (54)
wwunqd (85)
ttxbgy (254) -> bvfrrlk, xomgh
vjsezr (173) -> upvqdc, ruknk, vzpakr
ftjqj (43)
ysptuct (65)
czdkuo (283)
sgevc (70)
zslpkcc (220)
fptxhow (80)
oltfpgi (53)
sscwxvb (19)
cmupq (20)
yfblca (26)
thufa (124) -> arzanp, tlnztuz
gzmuxt (95)
bpphd (83)
vzfmojd (39) -> xqsynow, uuioune
cbsbti (303) -> izaggi, nwgqq
lrdeob (13)
libqry (182) -> vdjyb, ejwvtdi
whpgoe (76)
yfnxyuz (99)
foicoy (71)
lkvdgsk (32)
zhlbg (8)
kgxpfbq (42)
nlnalmy (17)
nlxjjxw (93)
lncrnjm (21) -> ldatid, bfnfh
hapofa (18)
owxjs (5)
kcyuui (58)
jnmrl (325) -> vaswfpp, tpurix
zmaqz (49)
mehhq (95) -> wtedsf, esqjbr, gbqklts
mwzswq (161) -> mfafdfn, fmltl
eeqon (61)
fmxhbs (144) -> tjlzt, tmqmur
blkpn (19)
gspvb (62)
obxht (4918) -> viytym, exqzjfk, wbmho, ppkmfx, ypvcfg, ygvihck
bjbxg (115) -> gxmjfay, infmrxl
grxsygp (23)
quzye (64)
sbmrcz (63)
pxfxcwi (370) -> ctglahh, yofaj
ywjdepk (13)
payocx (70)
zvatf (151) -> cejttl, fhhim
bqozbpx (89)
zkkvo (120) -> ndxlz, nbpzp, lzsao
gigyjrm (55)
avntwr (49)
rdpvd (17) -> zhyhc, tovzpw, uuwxren
hdhay (88) -> fvaow, xjlyt
xmgiw (55)
wilmnmv (26) -> bqdtj, mjzkn, gkjvxop
didaob (92) -> zcnkvpn, rrhqyi
ovlle (7)
lljlud (156) -> hbhvg, ynvqqj
gvangx (49)
npgsug (85)
swjbm (50)
nmqbvpq (18) -> vwubn, niuavpj
uxbkndn (74)
iyaxfqg (80)
sgamtw (1011) -> jczlwrg, bjbxg, obxqu
lwjzn (205) -> ojcor, pkqwu, jvamv
gofcp (21)
lmeql (8)
dqsam (325) -> vjzteyv, akbfb
sudoea (14)
ezbhdds (52) -> njnaiiy, rdjxdt
yfcqbsh (35)
axaojh (80)
ipgbw (1691) -> fmnkdey, arfng
sakar (6)
miimy (40)
rwnwac (71)
eiitagr (49)
azpiyc (19)
abdgd (748) -> seygew, rvqwfsn, cslvss
zariy (23)
kwxszx (19)
auxqn (1005) -> qaukdzx, dzjhdt, rhsppv, farye, jbttm, rwcrct, zsezyi
gxqhw (75) -> qkruzdo, uaqeuxd
atwydaw (106) -> fsztlli, swjbm, orqxo, eiajcj
qsidq (1554) -> hmqyh, xwclpv, zkgbmgm, tvxhhko
lftjq (85) -> tuswre, pdkxrqw
lgatvlk (134) -> huozxzo, ownte, tgcmnm
vqzrfnp (43)
pkqwu (20)
xqsynow (83)
zlqcp (53)
bitvw (92)
ejasze (196) -> aanhl, rmgua
tmbndw (153) -> xxohf, csawtu
xnfff (1995) -> dlqpyk, yhwjhjq, lmpji
cfourk (474) -> hdefj, bcslfkc, imobzk, ejasze
fntqeb (49)
eeuew (19)
jpoikof (77) -> alkfw, cwbnz
rxowzf (51)
lxmwuh (271) -> wlwlu, cfynk
wgwmd (51)
tfgkfd (31)
igbamrm (87)
sixatzk (217) -> atuotwh, wmiupn
dworfuk (6)
ngsbw (81)
cwkbizg (54)
gbqklts (76)
czxjike (27) -> npgsug, ammhz, xakmmr, pyentj
yvovprt (7)
zaulju (131) -> bsaud, xhrsff
phbuzyw (58)
hpkqdn (166) -> kgxpfbq, vgokyp
eqfuzz (70)
xddbpyw (57) -> plnuv, udebtlr, fecfcyc
ycmcpqd (40)
azgcixi (58)
xatcr (211) -> yfblca, grnajbj, tnmtz, lampfo
diflt (273) -> dzbqtuv, pprqvx, gmrgmk, aqpxn
wswanrt (13)
gazra (248) -> dlblhs, ezpwfm
nlyrnm (84)
igrfqy (62)
jfshm (369) -> crayus, cmupq
ywexlv (18)
luoapw (18)
sgknjo (80) -> qpism, bfbjr, vqrgyeu, tzdhk, xyebfi, gbbqu, rkddlwk
efoqm (88) -> yrmfqoy, gzfqvb
grrfq (86)
dwoad (58)
ssspogy (12)
arzanp (60)
kervui (212) -> ovgheo, quzye, hmslvhd
xsmnbd (318) -> tmbndw, bdjhrqu, grhiyhw, mluvdn, zzitpl, ilcvskn
mywtvif (18)
nqlzz (125) -> lwyux, fnsflkm
hfwvb (51) -> bvcujod, wwunqd, jkhfw
sptmayo (61)
crhzwz (58)
gisbvap (58)
cidcth (2400) -> dwogs, nnpbg
ywgvt (2102) -> censvvb, kiyra, jjzna
wxrgtti (64) -> dajhp, demwz
boundtr (7)
cqvwrm (15)
wnqqem (205)
dvkfej (16)
dtkoit (37)
szirq (49)
hdbhw (128) -> sakar, dworfuk
imdjavh (35)
pqvvi (110) -> yfcqbsh, efomsfh, ybayf, hvlha
ooqtpgb (101) -> nbtvxq, eaayvc, ilamw
yhohp (28)
znill (65)
bglby (69)
zkjxiqd (44)
oquxa (220)
qvgqro (128) -> bqozbpx, bjjyh
ncrxh (1679) -> aptjif, glwgh, xddbpyw
jtbnzi (91) -> gpkrbvt, rhtin
nwtgwj (92)
iqyhxcw (40)
awcvbgl (76)
stktqgc (70)
qslsdtg (32)
nqrgm (32)
bdgcym (52)
ktfzzi (81)
obpbif (117) -> fskdg, yunufd, bgute
sswubza (4286) -> lcblh, rjgycab, dkyiz, sochjt, rgziu, nqppb
dlqpyk (85) -> kdqwwif, cwkbizg
hptnh (22)
jtnbs (16)
xeaftl (50) -> mvllqsx, xmgiw
kfofavd (74)
unsssb (50)
hgvmyza (151) -> oltfpgi, xmkxjgq
mmtjv (91)
hsjgdl (59)
dchdrpf (51)
wypqz (48)
hibvd (58)
vaswfpp (21)
tgcmnm (89)
eiouio (19)
jcswni (150) -> fswhx, pxsjll
kjdboj (84)
wbked (19)
lwpjj (12)
wieeikb (14)
opbpuun (84)
gshbd (58)
rjgycab (1220) -> cmwxozx, bvtwdp
vpiug (131) -> cweuc, dtkoit
wrpla (11) -> erxsplp, szirq
kbdwm (13)
scbrb (77)
tukvj (91)
dkszj (1260) -> bdjhzp, ygqkwae, pjmolr
bgwym (83) -> qscxur, gmxxgje
glwgh (300)
guzxauy (206) -> ywigueo, phpbf
exqzjfk (1075) -> cbryc, xjcadip, zsdog, rgsktf
xakmmr (85)
ccdvhvz (1616) -> jolmd, nthwie, nsdmz, lljlud
ydtdz (93)
zlkpb (366)
mdhmfy (97)
ubwbr (192) -> adyaz, phbuzyw, vioxf
nnpbg (48)
qaybrra (60) -> gjfmnpu, kutxm, kfnpyl, ueeuim
ynvqqj (32)
mwrvamc (37)
dxbxbo (22)
ifuvb (83)
dkyiz (750) -> jknlaad, cqxfcqr, iaxol, pryxkzp
jrwro (125) -> muvvc, bitvw
cofbsq (48)
entepy (1294) -> uzkekjp, zaftnv, yrsto
frmkl (41)
zaftnv (172) -> ywexlv, mywtvif
nneqad (83)
bjnxl (1974) -> rdpvd, tuvios, uzuqqja, dlfly, hdbhw, pbnqtmw
ygqkwae (248) -> yodja, tmrukz
nczykbr (62)
gvcmhx (177) -> iuypybg, blbjzdr
zzwgd (66)
vtxojlh (17)
ltzsoxk (238) -> yjoghk, zefog
xvapp (14) -> adxktmm, zlqcp, tquiwoi, idngwil
xfzbans (45)
lskwu (1466) -> uxcmt, ijxbxya, mehhq
jhouok (56)
nwgqq (44)
ordnoxv (6)
alkfw (8)
uaqeuxd (17)
zdgotwb (61)
vxrjtk (60)
hciyw (68) -> roecqp, kmurcv, wvzeiwz, pidgo, ipgbw
fskdg (51)
yjoghk (15)
ewjxaid (63)
hjfuq (42)
xcmjj (48)
ujrnrd (359) -> vdaipmp, jppbqj
upmfk (55)
srpls (63)
bjjyh (89)
fuzpme (72)
pbrakxw (27)
hlmune (5)
ozupxsh (10)
qytybg (48)
gwgodil (13)
uvamrg (9)
zaffbku (96)
cnoiggb (23) -> eqfuzz, stktqgc
eeznlcw (18)
ueeuim (25)
xomgh (6)
cdllr (7915) -> xcxuhpd, duwat, mypyemv
kmurcv (81) -> vjsezr, gzwdr, hztml, vdspqsj, iyylin, ikjorey
scfmycd (88)
zfvnm (7)
oyfjp (63) -> oypkcb, xjljqp
dsxnt (83)
yrsto (86) -> sptmayo, czpmzex
bjcgvr (43)
pdkxrqw (86)
btkish (70)
akbfb (33)
fpgjkf (52)
qaukdzx (80) -> qscii, luedvgo
vopguxl (78) -> mvhjvsx, qrwrsw
fwvhiss (46) -> mlqhbm, naifggq, xlezv, amxwjmq
tuswre (86)
eqoivx (1680) -> ezbhdds, tfsenz, leelb, lgiwxh
dppnlm (84) -> gwwrlp, nkallms
xgdqc (93)
wsaugv (218) -> eziybgr, rujeuns
pprqvx (32)
volvsy (91)
zigvdka (35)
zygeve (67)
anykkx (85)
qposz (7)
tdocp (88)
quozn (33)
arfng (29)
farye (128) -> lakdjt, jbwvuqa, luoapw
vsqpyrc (29)
njnaiiy (76)
hhyqt (403) -> eeuew, azpiyc
muewwty (45) -> yfnxyuz, xnasc, lsepilv, fkstubd
fvzkg (74)
ozqmk (88)
jvbywje (10)
bbyfznm (82)
lzjyxw (266)
vgokyp (42)
pohuglk (32)
dahggdi (19)
wqmly (67) -> ucuhiy, ngsbw, cbato, czqieu
itnagm (99)
hnovowe (2085) -> cnoiggb, vjabq, pjmhz
nzxlkrf (43)
hwkclx (72)
vvdnnin (66)
orqxo (50)
cwqzpce (14)
iuypybg (40)
qhvtakl (108)
hyohkqq (81)
jmjxm (12)
bzqoi (103) -> kqazfnj, hpxuh, rzriujy
zgikmp (33)
xjcadip (256) -> mouemac, tysys
rzriujy (45)
ymaow (89) -> nafjxju, cbsbti, lxmwuh, dqsam, kmbky, wqmly
lhjmsy (208) -> tpacy, eiouio
emsuiot (40)
xsbbpem (13)
uplvccb (62) -> rmlqc, tukvj
leelb (94) -> gigyjrm, upmfk
espnx (11107) -> auxqn, vcguzz, cqokt
jihuf (19)
ryapaif (7)
jolmd (163) -> dahggdi, wbked, xjweui
lwyux (77)
tpacy (19)
uzkekjp (124) -> mkcrsy, xawwkeu
sfnmpjd (74)
vxagjlw (58)
gmslbkd (71)
xwclpv (193) -> lqpnpz, rxocfu
vdspqsj (230) -> mavhgq, eknhj
fwxzdr (41)
njftjr (96)
dutblrl (212) -> gdise, boundtr
hekhmmx (287) -> smkqkas, owlxwub
pbnqtmw (68) -> uxpdj, hapofa, qnyjwud, eeznlcw
aqpxn (32)
vmpywg (7) -> ykkcei, azyzcr, ywmuda, ndjsvna
hlfmjm (86)
nofuzdd (14) -> wwudvj, fudnt, ororw, gshbd
cjxht (312)
kutcu (170) -> tmrvz, mwrvamc
fjahqnz (44)
fpart (85)
ffojoq (68)
phocz (5)
xyoog (7)
tbhokxb (222) -> dwoad, crhzwz
zuziby (61)
jjtsj (85)
mavhgq (24)
tpurix (21)
pwtps (42)
nbtvxq (26)
crdiqm (102) -> enlerk, mkaus
pxsjll (23)
nddyl (5976) -> abdgd, bqqmp, oogodf, cfourk, nkuur
fagghhk (58)
fmnkdey (29)
uktjzbb (92)
ertegmg (48)
phpbf (31)
coxuj (85)
xfbrfa (84)
hbcnhi (7) -> lzqmapb, trkiub
tnmtz (26)");
            #endregion
            #region 08
            Inputs.Add(8, @"n dec 271 if az < 3
f inc -978 if nm <= 9
g inc -336 if ga < 2
egk dec 437 if y < 5
z dec -550 if g == -336
mx dec 12 if bqr == 0
mx dec 433 if ns == 0
ic inc 506 if g <= -327
ga dec -560 if ic != 506
bqr dec 570 if az >= -9
g dec 372 if egk != -429
f dec -863 if b >= -9
gyc inc 844 if av >= 7
cr inc -781 if mx >= -453
ga dec 346 if cr == -781
b inc -162 if z < 554
nno inc 504 if g <= -700
mx dec -32 if vkg <= 6
mx dec -961 if nno < 509
az dec 320 if ic < 510
nm dec 594 if ga != -354
cr inc -784 if az <= -311
bqr inc -321 if mx > 547
y inc -951 if egk > -438
y inc 703 if y <= -950
vkg inc -852 if g > -716
n dec -596 if az < -316
n dec 410 if e <= 4
f inc -693 if ic <= 510
egk dec 498 if zqo != 7
rn inc 626 if u == 0
bqr dec -770 if bqr > -898
n dec 193 if ic == 506
egk inc -263 if e == 0
cr dec -473 if mx <= 554
vkg inc 667 if e != 10
ga dec 793 if v <= 5
f dec -673 if v != 0
g inc 797 if g >= -708
n inc 361 if v == 0
y inc 399 if zqo == 0
av dec -894 if zqo == 0
az dec 785 if z <= 559
y inc -121 if nm < -593
v inc 873 if vkg > -189
ns inc -205 if n >= 80
cr dec 452 if ns != -202
nm dec -35 if f < -799
ic inc 790 if zqo > 3
gyc dec 456 if nm <= -565
rn inc 198 if y != 32
y dec -917 if f == -806
e dec -694 if zqo != 7
nno inc 676 if rn < 825
u inc 414 if ns >= -213
f dec -405 if bqr <= -113
g dec 456 if ga > -1145
by inc 613 if nno != 1185
n dec 414 if ga >= -1131
ga dec 844 if u <= 418
av dec -404 if ga >= -1974
g dec -171 if ns > -208
av dec -302 if f == -403
ic inc -935 if y >= 30
u inc -807 if bqr > -126
az inc -536 if v >= 865
vkg dec -77 if vkg == -185
n dec 209 if n == 83
u inc -92 if y >= 26
ic dec 43 if u != -491
ic inc 701 if z == 550
bqr inc -473 if e != 699
av dec -44 if egk != -1198
e dec 134 if ga == -1974
v dec 479 if mx <= 544
n inc -748 if y >= 21
bqr inc 726 if u >= -492
z dec -368 if ns == -205
y inc -296 if e >= 694
f inc 271 if nno >= 1177
y dec -881 if cr < -1535
nno inc -493 if az > -1649
z dec -434 if v != 882
bqr inc 783 if e <= 694
gyc inc 930 if gyc != -1
nm dec -712 if e < 696
mx inc -342 if nno > 685
av inc -292 if gyc > 927
rn inc -269 if rn <= 831
vkg dec -799 if nno == 687
v inc 31 if vkg < 694
egk dec -227 if v != 913
ga inc -248 if u == -485
ga dec -655 if ic >= 228
nm inc 335 if by != 613
av inc 251 if u >= -477
bqr inc 834 if ns >= -209
gyc dec -580 if rn > 549
u dec 390 if e < 701
cr inc -936 if b > -170
nm dec -60 if g < -188
ic inc -226 if by < 615
y dec -698 if zqo != 0
vkg inc -938 if av == 904
vkg inc -131 if zqo == 0
y inc -792 if zqo < -3
gyc dec -43 if ns < -211
ga dec 783 if az <= -1637
az inc -359 if cr <= -2479
e inc -117 if v != 908
rn inc 231 if av < 898
nno inc -594 if z != 1354
egk inc -119 if b >= -170
mx dec 866 if mx != 214
g inc -688 if mx < -655
ga inc 451 if z <= 1352
bqr inc 315 if g != -876
vkg dec -636 if egk != -1090
bqr inc -395 if by < 610
mx inc 914 if ga < -1908
by dec -623 if egk > -1090
ns dec 219 if vkg >= -380
egk dec -976 if av >= 896
egk dec -681 if ic != -1
vkg inc 971 if nno < 101
nno dec 490 if bqr > 2060
u inc 479 if z <= 1358
z dec -552 if nno < -389
y inc 696 if nno <= -405
nm dec 876 if nno >= -399
f dec 197 if nm > -670
f inc 584 if e <= 575
av dec -548 if y <= 616
cr dec -975 if mx >= -664
vkg dec -532 if egk > 567
cr inc 115 if zqo <= 2
e inc 315 if nm <= -663
e inc -850 if ns > -430
vkg inc -72 if z < 1906
b inc 7 if y != 618
cr dec -270 if by < 613
v inc 505 if ns > -430
ga dec 51 if nm != -670
z dec -657 if zqo <= 1
u inc -777 if nm == -663
y dec -37 if nno < -396
gyc inc 62 if f < -322
z inc -565 if az > -1996
e dec -223 if vkg <= 516
nno inc 481 if e == 34
rn inc 316 if nno >= -406
e dec 531 if ns <= -423
vkg inc -940 if v >= 1408
by inc 935 if b <= -152
rn inc 254 if ns < -416
gyc dec 822 if zqo > -6
n inc 334 if b < -155
by inc 987 if nno == -397
gyc dec -701 if ic >= -6
nno inc -764 if z <= 2568
nno inc -541 if mx == -660
ns dec -327 if ns != -424
z inc -328 if bqr == 2064
cr inc 550 if cr != -1385
ga dec -441 if rn <= 1123
gyc inc -461 if zqo == 0
egk dec 554 if ic < -6
av inc 300 if zqo == 0
nno dec 324 if av <= 1754
y dec 235 if b > -165
rn inc -1 if v < 1415
b dec 230 if y > 413
mx inc -836 if b <= -384
av dec 464 if zqo != -7
rn inc 208 if egk >= 563
e dec 385 if v >= 1413
g dec -443 if z < 2240
v dec 296 if nno < -2027
nm dec 394 if az != -1992
u dec 609 if nno == -2026
nno dec -178 if ns > -428
f dec -340 if z >= 2231
e dec 124 if u > -1783
bqr dec -221 if bqr == 2064
rn dec -427 if by != 2539
n dec -242 if cr == -840
az dec 267 if y < 418
by inc 737 if cr <= -833
rn inc -938 if ic >= 1
az inc 181 if zqo >= -6
f inc -874 if z >= 2233
cr inc -867 if vkg <= -414
mx inc 424 if ic >= -6
f inc -125 if g <= -435
az inc 30 if n < -625
av inc -575 if y < 418
ga dec -726 if ns <= -418
u dec 1000 if b >= -393
ns inc -88 if av < 720
ns inc -80 if f < -983
z dec 73 if e != -613
bqr dec 350 if nm > -1065
az inc 247 if gyc > 980
v dec -156 if g != -435
mx inc 32 if f > -996
b dec 349 if mx < -1032
mx dec -934 if nm != -1067
ga inc -502 if egk < 573
gyc inc -106 if nm == -1057
ga inc 669 if mx != -102
nno dec -335 if g >= -438
g dec -757 if v != 1566
cr dec -887 if z == 2233
rn dec -768 if by < 3280
bqr dec -289 if gyc < 890
u inc 817 if by > 3265
nm dec -136 if by <= 3270
b dec 192 if y == 417
f inc -787 if b <= -929
f dec 188 if f == -988
cr inc -488 if nno != -1846
nno inc -116 if az > -1807
cr inc 899 if by < 3278
nno dec -454 if b >= -928
f dec 237 if cr != -409
e inc -910 if b != -926
zqo dec -710 if egk > 564
v dec 651 if cr != -407
z inc 45 if ic < 10
rn inc -16 if n > -633
u dec -433 if n != -636
z inc -55 if vkg >= -425
y inc 536 if v <= 916
nm dec 269 if cr == -409
vkg inc -811 if gyc > 875
y inc -269 if rn <= 1576
rn inc -445 if av >= 709
av inc -131 if ic != 1
egk dec -35 if y <= 687
mx dec -947 if nm == -1326
bqr inc -296 if nno >= -1399
vkg inc -176 if az == -1809
z inc -7 if ga <= -1058
v dec -105 if v != 908
by dec -935 if g > 315
y dec -674 if rn <= 1132
ga dec -482 if v <= 1026
nm dec 500 if f >= -1176
by dec 653 if f < -1177
cr dec 156 if mx == 841
ns inc 446 if u > -1535
e inc 256 if mx < 840
av dec -883 if nm == -1826
gyc inc 204 if by < 4198
g dec 158 if av > 1456
z dec -314 if av <= 1466
egk inc -367 if cr > -568
by dec -847 if f <= -1171
f dec -361 if z < 2532
z dec 647 if ns == -146
z inc -416 if z <= 1892
e dec 138 if cr <= -571
ic inc -393 if gyc < 891
zqo dec 338 if e < -605
zqo dec -644 if ic == -390
ns inc -790 if b != -917
az dec 136 if av == 1465
nm inc 971 if gyc != 884
av inc 171 if ic != -390
u inc -715 if zqo <= 1024
av inc 27 if zqo != 1021
n inc 845 if zqo < 1023
cr inc -576 if v == 1019
y inc 456 if ga >= -583
mx dec 843 if f > -823
v dec -589 if ns != -926
e dec -797 if nno > -1395
g dec 828 if bqr >= 1925
vkg inc 176 if az > -1949
nno inc 261 if zqo < 1017
f inc -429 if b == -926
f dec 658 if mx == -2
e dec -221 if gyc < 890
y dec 362 if v < 1605
rn inc 849 if v != 1610
b inc -650 if y <= 1363
ic inc 39 if g != -668
by dec -365 if u > -2248
nm dec 779 if u == -2247
nm inc -482 if cr <= -1137
ns dec -873 if nm == -3087
e dec -993 if rn <= 1979
vkg dec 291 if n <= 220
nno inc 937 if nno > -1139
bqr inc -321 if b <= -1570
av inc 86 if v < 1612
by inc 872 if gyc > 878
egk inc 858 if bqr > 1603
e inc -199 if ns <= -62
az dec 600 if v >= 1615
nno inc -115 if g < -660
ga inc 614 if f > -1910
g inc 950 if zqo > 1009
f dec -319 if cr == -1141
gyc dec 498 if nm <= -3078
u inc 61 if z != 1464
av inc 127 if zqo > 1012
ic inc -78 if f < -1573
b dec -601 if nm <= -3082
av inc -475 if gyc < 396
av dec 613 if gyc < 383
vkg inc 425 if rn <= 1981
nno inc 543 if az >= -1946
rn dec 280 if vkg >= -1096
ns dec -366 if gyc <= 388
v dec -558 if egk == 1093
vkg inc -446 if ns <= 301
y dec 617 if b <= -970
n dec -890 if az != -1947
vkg dec -102 if nm != -3092
e inc -668 if ga < 33
zqo inc -305 if e >= 529
vkg inc -97 if vkg != -997
rn inc 188 if nm < -3087
cr dec 613 if rn < 1700
v dec 647 if g < 284
az dec -205 if e == 531
av inc -359 if vkg == -1091
y dec 252 if ns >= 301
n inc 251 if f != -1593
mx inc 438 if gyc < 385
by dec -984 if nm != -3087
mx dec 354 if ic < -425
by dec 395 if ns > 298
egk inc 119 if b == -966
gyc inc -887 if vkg == -1091
rn inc 898 if ga != 30
mx dec 35 if y >= 485
e inc 889 if ns != 300
ga dec 992 if b > -968
g dec 432 if cr > -1755
nno dec -669 if gyc > -504
bqr inc -442 if rn == 1697
u inc -44 if b > -976
u inc 5 if gyc <= -497
gyc inc 36 if ns <= 304
nm inc -528 if b >= -973
y inc -617 if mx <= -400
g dec 47 if e >= 1418
b inc 292 if egk != 1083
vkg inc 734 if ga <= 30
n inc -678 if b != -691
ic dec 581 if vkg >= -365
u dec 562 if b == -683
nno dec 751 if cr > -1757
egk inc 709 if gyc != -461
n inc -347 if rn == 1697
gyc inc 960 if cr <= -1751
z dec 627 if ns < 310
gyc dec -190 if z < 842
v inc 868 if mx == -398
n inc -280 if b != -683
n inc -302 if e == 1420
av dec -389 if g != -209
nm inc 241 if ic == -1018
n inc -493 if nno <= 157
f dec -932 if n == -466
u inc -880 if y >= 480
y dec -697 if egk < 1807
az dec 332 if nno != 149
g dec 971 if z <= 848
by inc -510 if z >= 849
u inc 103 if bqr < 1161
av inc -830 if gyc > 678
rn inc 110 if ns < 306
b dec 616 if ga < 40
egk inc -749 if y <= 1176
z inc 669 if ns != 301
n dec 365 if nno >= 152
ns inc -464 if egk > 1801
e inc -516 if by > 5894
bqr inc 934 if g < -1165
nno inc 224 if cr < -1744
f inc -480 if n >= -456
gyc inc 101 if g > -1168
cr inc 501 if e == 905
z dec -836 if f < -643
ic dec 750 if rn != 1808
u dec -318 if gyc <= 687
ga inc -631 if av >= 430
nno inc -261 if ga > -606
b dec 723 if by >= 5889
ns inc -109 if bqr != 2095
cr dec 731 if e >= 903
nno dec -251 if b >= -2024
mx dec -206 if rn > 1810
ns dec 249 if rn > 1799
u inc 201 if egk < 1809
vkg dec 283 if z > 2338
rn dec -759 if u >= -3141
f dec 540 if y != 1186
by dec -523 if z == 2345
by inc -894 if ga > -608
rn inc -418 if cr >= -2489
bqr inc -837 if nno > 361
cr inc -485 if zqo == 711
y dec -672 if nno == 364
g inc 159 if nm == -3087
vkg inc 873 if az >= -2074
b inc 83 if z != 2347
gyc inc 321 if e < 904
e dec 283 if gyc < 689
f dec 257 if b >= -1948
by inc -526 if az < -2063
cr dec 119 if b == -1939
e inc -534 if g <= -1016
bqr dec 923 if av == 430
gyc dec 513 if bqr > 334
u inc -756 if z > 2339
nm dec 343 if gyc >= 165
bqr inc -114 if ga <= -601
gyc inc 355 if cr >= -3091
gyc dec -458 if mx >= -398
by dec 24 if v != 1519
cr inc -155 if v <= 1526
v dec 512 if av >= 427
f dec 297 if f > -911
nno dec 783 if ns <= -524
az inc 985 if ga > -592
cr inc 300 if egk >= 1800
vkg dec 542 if mx == -391
zqo dec -844 if bqr == 218
av inc 860 if gyc == 985
nno dec -253 if nno != 366
v dec 542 if b >= -1941
z dec -76 if ns > -526
y inc -336 if az == -2073
nm inc 995 if egk > 1793
f inc -95 if e < 622
zqo inc -46 if rn > 1379
b dec 470 if av <= 1299
gyc inc 839 if f >= -1304
bqr inc -766 if bqr < 227
n inc 980 if v < 460
bqr dec -757 if ns >= -528
g dec -507 if f > -1308
mx inc 249 if ns > -522
av dec 524 if g < -507
e dec -962 if rn > 1397
ns inc 139 if zqo < 666
av inc -443 if zqo <= 656
z dec -753 if rn != 1391
g inc 616 if v <= 474
ga dec 196 if nno < 618
av dec -317 if gyc > 1826
f dec -673 if cr < -2939
b inc -670 if zqo > 670
cr inc -948 if ga <= -795
av dec -977 if zqo == 665
f dec 521 if ic != -1764
ga inc 342 if nno != 618
av dec -989 if gyc >= 1823
rn inc -118 if mx < -137
ic inc 874 if nm < -2429
cr dec 441 if by > 4996
az dec 920 if cr == -4333
by inc 486 if z >= 3168
zqo dec -614 if u <= -3897
zqo inc -359 if g > 105
cr inc 725 if av <= 3257
nm dec 816 if mx >= -133
f inc -174 if az < -2996
n dec -832 if egk <= 1803
z dec -351 if av > 3257
rn inc 814 if egk == 1802
rn dec 516 if bqr > 206
ic inc -181 if ns >= -383
cr dec 476 if av < 3261
rn dec -446 if mx > -141
rn dec 966 if bqr > 213
u dec 426 if b != -2408
ic inc 841 if ic >= -1071
u inc -990 if n < 371
gyc inc -436 if az != -2991
egk inc 673 if by == 5485
g dec -510 if egk >= 2474
v inc -104 if ic != -225
b dec 862 if ga != -452
n dec -733 if mx != -132
b dec -726 if nno > 618
f dec -259 if rn == 597
e inc 51 if nm == -2435
y inc -251 if ns >= -388
bqr inc -684 if u >= -5325
bqr inc -427 if b > -3278
n inc 526 if mx >= -149
f inc -727 if egk != 2475
ga inc 345 if g >= 622
ic dec -398 if ga > -113
rn dec 581 if egk < 2478
rn inc 926 if g < 614
ns inc 469 if nno != 615
n inc -870 if vkg > -311
mx inc 124 if ga <= -103
z dec -983 if ns != 96
vkg dec 530 if mx < -18
rn dec -899 if g < 625
gyc dec 98 if g < 627
av inc -497 if n < 760
nno dec -115 if egk >= 2470
z inc 610 if z > 4156
mx inc -184 if ns > 91
cr dec 724 if nm != -2438
ns dec 527 if nno > 727
ns inc -177 if cr >= -4811
v dec 423 if rn != 921
vkg dec 658 if av >= 2755
y inc -464 if bqr > -890
nm dec 440 if e < 673
ic dec -963 if mx == -18
n dec -613 if by < 5488
v inc -412 if egk < 2482
vkg inc -278 if y < 1609
by inc 200 if e == 672
ns inc -627 if v == -51
n dec -176 if e == 672
n inc -511 if gyc <= 1289
zqo inc 589 if ga == -108
v dec 533 if egk < 2485
zqo dec -93 if n > 1536
e dec -618 if nno < 742
gyc inc 258 if f != -1139
ga inc 562 if vkg >= -1254
n inc -492 if f > -1158
rn dec -267 if nno < 738
v dec -263 if y < 1603
vkg inc 206 if mx == -18
av dec -610 if n <= 1060
by dec -352 if mx <= -24
zqo dec 74 if vkg >= -1046
ns inc -251 if ga > 457
cr dec 531 if n != 1047
ga inc 892 if by < 5683
vkg inc -687 if b >= -3273
av inc -208 if v <= -580
g dec 550 if az != -2985
ga dec -595 if gyc >= 1548
egk dec -240 if zqo >= 930
b dec 262 if az == -2992
egk dec 831 if ga < 1055
zqo inc 928 if ga > 1044
nno inc -90 if gyc >= 1542
e inc -47 if f < -1144
u dec 131 if zqo > 1871
g dec 268 if f != -1148
b dec -964 if n <= 1045
gyc dec -952 if az > -3001
egk inc 324 if vkg != -1735
by inc -460 if av == 3167
bqr inc 494 if nm >= -2878
by inc -616 if rn < 1191
ga dec -150 if u != -5312
ns dec -535 if av == 3161
rn inc -720 if ic > 1135
n inc -821 if gyc < 2508
n inc 670 if ns < -705
f inc 419 if ga == 1197
mx dec -96 if nm >= -2876
vkg inc -270 if n < 909
z dec -907 if ns < -700
ns inc 160 if gyc >= 2491
av dec -250 if e > 1240
f inc 768 if ns >= -542
ga inc 443 if gyc > 2498
rn dec 107 if g == 72
ga inc -420 if mx != 74
mx dec -763 if ic == 1140
b inc 586 if gyc <= 2505
mx dec -948 if gyc > 2509
zqo dec -384 if vkg < -1991
z dec 234 if rn > 1072
gyc dec -821 if v > -590
z inc 83 if v == -584
egk dec -835 if b <= -2941
cr dec -495 if v > -590
by inc 259 if cr <= -4852
cr inc 530 if mx != 77
vkg inc 381 if g <= 80
by dec -71 if az == -2992
mx inc -453 if g > 64
ic inc 410 if vkg > -1618
f inc 945 if n == 901
y dec 409 if nm >= -2884
z inc 870 if vkg >= -1606
av inc 187 if z >= 5521
nno inc -852 if ga > 1212
cr inc 788 if av < 3608
e dec -182 if by != 5143
nno inc -706 if ga >= 1228
vkg inc 782 if z < 5532
mx dec 839 if nno > -219
v dec 267 if b > -2952
v inc 901 if gyc == 3321
g dec -820 if rn != 1079
ic dec -221 if zqo <= 2259
ga inc -784 if e == 1425
ga inc -569 if bqr >= -404
u inc -206 if mx <= -1212
gyc inc -685 if nm == -2881
e dec 269 if mx <= -1208
av dec -207 if by >= 5137
nno inc -109 if ga != -131
ga dec 3 if ic != 1761
zqo inc 181 if nm < -2866
y inc -15 if by >= 5140
rn dec -617 if g != 884
g dec 574 if mx < -1213
ga dec -775 if bqr >= -404
ic dec 186 if v < 55
gyc dec 497 if ns >= -552
z dec 619 if nno >= -319
b dec -753 if av == 3809
by inc -890 if n != 901
b inc -714 if z == 4902
n inc 927 if v <= 43
b inc -107 if b <= -2947
nno dec 707 if y == 1183
vkg dec 199 if az <= -2996
gyc inc -684 if cr <= -3523
z dec -518 if zqo == 2429
ga inc -220 if cr >= -3527
zqo inc -922 if y <= 1183
rn dec 852 if gyc != 2138
nno inc 419 if ic == 1577
rn dec -951 if by <= 5130
av inc -557 if z == 4904
mx dec 599 if g > 327
az dec -594 if u != -5525
gyc dec 187 if y > 1173
v dec 2 if e >= 1153
gyc inc -814 if ns < -540
zqo dec -401 if av != 3249
ic dec -511 if g == 318
g dec -447 if g == 318
zqo dec 965 if by != 5146
gyc inc 658 if vkg != -824
nm inc -663 if e > 1156
n inc -974 if zqo <= 954
n dec 363 if az <= -2389
ga dec 300 if v <= 53
n inc -402 if y > 1186
b dec 839 if bqr >= -406
rn inc -188 if v > 57
av inc 952 if rn < 852
bqr inc 973 if v == 56
f dec -234 if b > -3899
nm dec -96 if zqo != 949
e dec 141 if ic != 2084
ga dec 146 if g > 755
av inc -333 if ga > -33
z dec 698 if e == 1015
e dec -493 if z >= 4200
v dec 234 if v >= 48
az dec 572 if vkg < -831
vkg dec 164 if u >= -5527
ga dec -933 if rn != 846
gyc inc -180 if ic > 2081
vkg dec -305 if z >= 4198
ic inc 50 if cr == -3526
egk inc -956 if zqo <= 939
n inc 265 if z >= 4215
az inc -574 if nm <= -2776
bqr dec -19 if ic == 2141
ga inc -682 if cr != -3525
g dec 864 if g > 764
ns inc -746 if f < 452
g inc -969 if f >= 450
ga inc -127 if e < 1518
v inc -903 if egk == 3043
cr dec 714 if nm < -2775
f inc 33 if ga != -835
bqr inc 919 if bqr != -382
nm dec -489 if z < 4210
vkg dec 962 if gyc != 1611
z inc -698 if ga >= -844
z dec 645 if e <= 1510
ns dec -501 if y != 1174
az inc -314 if av < 3868
mx inc -207 if ns == -792
z inc -604 if zqo < 952
g inc 466 if g > -1067
b inc -704 if nm >= -2295
nno dec 284 if e != 1500
cr dec 58 if z < 2263
rn dec 494 if ic > 2148
nm dec 211 if by < 5141
by inc 150 if av >= 3862
gyc inc -716 if b <= -4596
u dec 466 if ns > -798
mx inc -935 if cr == -4288
bqr inc 275 if b < -4587
v dec 771 if egk == 3043
vkg inc -902 if u != -6000
b dec -683 if nno == -1311
egk dec 525 if v == -1860
az inc 708 if by > 5284
y inc -820 if ic >= 2137
az inc -720 if zqo <= 940
u inc -299 if zqo < 955
bqr inc 248 if rn == 846
g inc 148 if n > -441
nm dec 213 if egk >= 2509
ic inc -840 if g < -928
f inc 98 if by >= 5287
nm inc 909 if v != -1863
vkg dec -856 if y >= 360
v inc -156 if zqo == 946
bqr dec 908 if gyc >= 900
zqo inc 836 if f == 581
ns inc -157 if ns == -792
egk inc -899 if z == 2259
ga dec 658 if ic < 2142
nno inc -278 if by < 5291
egk inc 502 if f > 580
z dec 807 if y >= 363
nm dec 612 if nno == -1583
y inc 914 if ns <= -942
gyc inc 419 if v != -2013
g inc 897 if v <= -2015
gyc inc 107 if vkg >= -1709
bqr inc 224 if z < 1460
mx dec 809 if ga < -1488
cr inc -401 if av < 3875
ns inc -521 if by == 5290
az inc -269 if ga == -1494
b dec -688 if by != 5294
n inc -746 if mx < -2225
y inc -452 if e < 1509
z dec 495 if n <= -1175
av dec 204 if egk != 2117
cr inc 30 if ga >= -1498
y dec -821 if gyc < 1437
av dec -105 if bqr != -543
by inc -897 if egk < 2130
az inc 392 if vkg != -1703
egk inc -34 if ga <= -1490
mx dec -635 if av >= 3658
gyc inc 307 if zqo < 1787
v dec 263 if v >= -2018
n dec 574 if f < 582
f inc -432 if g < -28
z dec 259 if av == 3663
zqo inc 472 if b == -3909
e inc -779 if bqr > -545
zqo inc 187 if v > -2282
e dec -395 if y != 1652
y inc 312 if az < -3021
ga dec -324 if egk < 2082
cr dec -409 if az < -3023
nm inc -790 if bqr != -533
ga dec 252 if ga <= -1493
ic inc -932 if u <= -6292
e inc -547 if vkg >= -1698
nno inc -171 if b != -3909
g dec -891 if vkg < -1690
ga inc 441 if egk < 2089
z dec -708 if ic != 2147
nm inc -402 if b == -3919
f inc -374 if u != -6291
ic inc -48 if ga >= -1312
egk dec -19 if b > -3911
av dec 305 if ga >= -1313
g inc -475 if mx < -1588
vkg inc -269 if vkg == -1700
gyc inc -535 if f > 572
nno dec -382 if ns >= -1475
nno dec 650 if y <= 1959
y inc 148 if zqo <= 2442
by dec -223 if u != -6286
y inc -319 if ga > -1313
nno dec 13 if av == 3358
ga inc -402 if gyc > 1198
rn inc 37 if f == 581
gyc inc -884 if rn > 882
ic dec 676 if zqo <= 2438
u inc 417 if ic != 2098
n inc 930 if zqo <= 2449
av inc 509 if ns >= -1477
y dec -981 if y < 1779
az inc -780 if ns < -1472
f dec -834 if by != 4622
ic inc 721 if av == 3867
e dec 916 if g <= 400
zqo inc 169 if cr > -4254
nno inc -685 if z == 1406
v dec -920 if zqo > 2440
nno inc 91 if gyc < 317
n inc -395 if nno != -2459
egk inc -746 if v == -1359
av inc 66 if cr == -4260
gyc inc 40 if ga > -1711
egk inc 914 if y < 1788
g dec 176 if u != -5869
b dec -550 if vkg >= -1974
g inc -545 if ic < 2824
nm inc -645 if cr <= -4256
b inc -103 if ns >= -1477
g dec 166 if zqo >= 2436
nno dec 665 if by <= 4618
rn dec 622 if nno > -3130
nno inc -591 if b < -3461
az inc -807 if egk >= 2272
g dec -417 if f >= 1425
by dec 547 if by != 4606
cr inc -579 if e != 212
nm dec 650 if e == 208
b dec -65 if by > 4064
b inc -263 if ns <= -1473
az inc -784 if g >= -494
b dec -193 if z > 1415
bqr dec 143 if zqo >= 2443
nno dec 385 if g >= -496
v dec 352 if ic != 2814
nno dec -521 if by != 4065
ga dec 198 if az <= -4612
by inc 926 if b > -3404
bqr inc -697 if zqo == 2441
vkg inc 124 if mx < -1588
u dec -564 if bqr < -1237
v inc -763 if ic >= 2812
egk inc 339 if az > -4611
z dec -617 if mx <= -1588
av inc -876 if cr >= -4837
n dec -600 if mx == -1595
v inc -354 if vkg > -1850
v inc 194 if vkg <= -1841
bqr dec -206 if av <= 3934
rn dec 547 if z != 2033
b inc 217 if u <= -5305
v dec -230 if egk != 2264
n inc -447 if b != -3180
az inc 497 if g >= -499
e inc -527 if v < -2051
u inc -889 if by == 4995
b inc 74 if egk < 2282
ga dec -65 if v == -2052
nno inc 156 if av != 3933
rn inc -880 if av != 3934
cr dec 825 if ga == -1840
y inc 499 if e == -319
b inc 525 if mx > -1604
f inc -731 if zqo >= 2437
cr inc 398 if gyc < 360
f inc 286 if vkg > -1846
zqo inc 761 if ic > 2816
y dec -877 if rn != -1166
vkg inc -405 if ga != -1838
vkg dec -522 if v <= -2060
mx inc 281 if nno > -3586
vkg dec -203 if bqr >= -1043
vkg inc 278 if az >= -4125
rn dec 544 if b < -2573
av dec 730 if mx > -1318
ic inc 49 if n < -620
f dec -599 if nno != -3583
e inc -871 if gyc == 355
e dec -735 if mx != -1307
n dec -73 if rn <= -1707
ns inc 896 if g >= -502
z dec -480 if z <= 2023
zqo inc 595 if v < -2043
mx dec 647 if vkg == -1769
n inc 743 if nno > -3589
gyc inc 129 if cr > -5267
vkg inc 703 if mx > -1966
bqr inc 378 if g <= -487
ga dec 852 if zqo > 3035
zqo dec -43 if y > 2280
ga dec 849 if cr != -5259
gyc inc -363 if av >= 3203
vkg dec 481 if nm <= -3884
g dec 609 if f < 964
av inc -951 if n != 187
ns inc -676 if zqo == 3079
nno dec -998 if av == 2252
n dec -624 if vkg > -1544
y inc -262 if ns == -1250
av dec 248 if ns < -1250
f dec 351 if z == 2503
bqr inc 535 if ic > 2858
f inc -725 if nno > -2589
ic inc 860 if v == -2052
nno inc -211 if v >= -2055
ic dec -324 if bqr <= -126
az dec 746 if f <= -99
g dec 985 if e <= -454
f dec 434 if z < 2495
egk dec 842 if bqr == -121
gyc inc 715 if y >= 2022
ns inc -573 if nm != -3888
b dec 415 if mx >= -1951
by inc -719 if ga == -3551
n dec -783 if cr >= -5268
nm dec 409 if by > 4988
u inc -72 if av >= 2246
ns inc 338 if v <= -2050
e inc 12 if rn < -1706
ns dec -354 if nm == -4299
egk inc -589 if zqo >= 3084
egk dec 856 if vkg != -1555
ns inc -439 if zqo >= 3076
by inc -942 if cr != -5272
z inc 119 if b >= -2588
cr inc -864 if ga != -3537
nno inc -333 if gyc > 828
z inc -530 if e > -451
nno inc -113 if u > -6271
g inc -213 if mx <= -1953
y inc 107 if ga < -3536
y dec -971 if az < -4859
n dec -424 if av < 2258
ic dec 632 if rn <= -1705
az dec -701 if ns > -1576
by dec -45 if egk > 581
z inc 111 if vkg == -1547
ic dec -737 if u <= -6266
v dec 13 if nm != -4289
b inc -616 if ic < 3838
av inc 266 if b <= -3190
nno dec -699 if gyc >= 834
y dec 400 if gyc >= 835
y dec -119 if ns <= -1567
n dec 452 if rn < -1703
egk inc -254 if vkg == -1556
az inc 568 if ns <= -1580
f dec -399 if bqr < -115
zqo dec 948 if nno > -2440
rn inc 154 if zqo == 2131
f dec -21 if b != -3190
nno inc -204 if g > -1683
v dec 190 if az >= -4168
bqr inc 236 if v > -2263
cr dec 554 if nm >= -4303
gyc inc -657 if e > -449
e inc 65 if nm != -4306
v inc 340 if az > -4171
mx dec 527 if nm <= -4296
g dec -426 if ic > 3819
b dec -766 if z < 2205
ic inc 822 if cr < -6677
cr inc -733 if n != 958
rn inc -759 if vkg == -1547
nm dec 588 if rn == -2315
n dec 310 if ic < 4641
n dec -24 if g >= -1274
n dec 341 if nm == -4887
cr dec 131 if av > 2513
zqo inc -78 if gyc < 181
mx inc 368 if vkg < -1537
gyc inc 157 if zqo >= 2053
rn inc -871 if vkg <= -1544
bqr dec 299 if egk == 576
cr dec 27 if b <= -2423
rn dec 848 if az < -4170
av dec 836 if egk <= 577
v dec -334 if cr < -7576
f dec -820 if u == -6271
az dec -367 if egk == 576
by inc -267 if bqr != -192
bqr dec 95 if cr == -7575
ga dec -641 if bqr == -279
ns inc -776 if y != 2821
by dec 177 if cr != -7575
nno dec 656 if g >= -1261
z inc -641 if az >= -3789
rn dec 93 if v != -1911
az dec -664 if f > 1139
ic dec -565 if e >= -380
by inc -600 if ga == -2894
zqo dec 580 if g <= -1263
zqo dec -324 if by != 3784
gyc dec -987 if ns != -1570
gyc dec -921 if mx >= -2111
by inc -529 if ic < 5211
av dec 272 if ic == 5210
nno inc 745 if e < -374
ga inc 893 if by >= 3782
egk dec -936 if bqr >= -284
vkg dec -146 if nno <= -1679
y inc -686 if ga != -2000
b dec -659 if u < -6265
b dec 418 if n < 629
az inc 613 if ns == -1563
vkg inc 385 if ga != -2017
egk dec 54 if az == -3802
vkg inc 330 if by == 3786
f inc -243 if u != -6271
gyc dec 751 if ns != -1574
nno dec -285 if ga <= -2006
vkg inc -257 if v >= -1921");
            #endregion
            #region 09
            Inputs.Add(9, "{{{},{{{<,u,!{}!>,<'e<',>,<{!!o!>!>!,<\"!!oa!> o!!!>}!!!>!!!>,!!>},{<!>,<i>,<,!!u!!!!!!!>a\"o!>},<eu!!!>!!!>!!!!!>!>,<>},{}},{{<!!!>i,a!!oa!!i!>,<!>,<o>,<!!}{!!!!\"!!,!!',!!!>'>},{<'{}\"'!!\">},{}},{{<!!u>,{<>}},{{<o{e<!>},<o!!}!>iu<e!>,<eo>,{<,!!!!!>!i!!!>}a'o,e<!!o!>},<,!>,<>}}},{{},{<>,{<!>,<}!\"!!o>,<aoo,>}}}},{{{{<,\"\",>,<i>},{{<!!,<'!>,<u{o!!!>!>e!<{oe}!!i'>}}},{{{{<{o'!>!>},<>}},{{<<!>},<'!!!>!,!>!!!>!!u!>!!}!!<!>!>},<!!!>,,a>},<!>,<!>,<i!!!>}!>},<\"!>,<<{o}\"'!>},<!{>},{{<au!!!>!!!!}!'eo!!!{!>u!!!!!!!,!!!>'u!iu,>}}},{{{{{{},{{},<oe!!!i!!<!!!>!!!>a!!!><i{,!>},<}o!!!>\">}},<!e,!!''!!!!,ue!>},<<!o'>}}},{<,>,{<!>,<>}}},{{<<o''!}<i!u!!i{!!u,>,<ea{!}!!!>!>},<'>},{{{},<!!u!>,<!>{>}},{{<,!!!>,<!!{,!!!>{ei!!>},{<!>},<a}u>}}},{{{<<!}<!!!>>},{<ua'i,,!!'>,<ia!!!>},<>},{}},{},{<,'i},,,!{!!o!!!>,>,<>}}}}}},{{{{<!>,<>,{<u!>,<{i!!!>o>}},{<>,{<!!!>,<,!!!>,<<!!o>,{<'!!'!>,<\"!!{a\">,{{}}}}},{{<!!!>aoo,!!e!>u!>{'{<!>oo!!!>},<>},<{,a<!>,<a!>},<uii!>,<!>!!'{>}},{{{{{<!!u{u\"oo>}},<i!!a>},{<!!a,}!>'!>,<{!<!>eaa!!<!>},<!>\">,<{}e!ao!!o<!>,<!>},<u'\"}\"!!!>>},{}},{{<!!o!!a!>},<}}}o!!\"iuuu!!!>>},{{<!!!>,<!>u{'!>,<u,<!!!><!>},<<{!!!>!>,<>,{{<\"}!!!>,<,!>!>},<!eu!>,<!!!>},<e!o<{ae>},{}}},{{<!>,<!!{a\"!>!!!!!>,<>},{{<!>,<'!ae!!!>\"!!a!!!>!!ia>},<a!>,<>}}}},{{{},<!!!>{!>!,<>}}}},{{{{<'\"!!!>},<!>!>u!>,<>},{}},{<ui!\"i>,{}}},{{<,}o{>,<!!!>!!<!!u>},{<!!\"!!a,'\"!!a{,!>''a',!>},<>,<!>}<u,!>},<{>}}},{{{{{{{}}},<!,>},{<!!!>},<!>,<!>!!'!>},<<'}!>!>!>ua>,<o\">}},{{{{{{}},{{<!!i<\"u!!!>}o!a>},{}}}},{<ea\"'e>}},{{<a!!o'o!!}<!!a!!o!!!!'e!!!!!>!!!>o!o{!!\">,{<aia!!!>}}!'!>,<>,{<!!!!!>},<iaa{!a<!>,<!<>}}},{<a}!>,<a!!!>u\"!>},<\"!>{}a'!>,<}!>,<!>},<!!!!!>},<>,{{<!>\"'{e,<\"e{>},<o{!!!>e}!'>}},{<}!!'!!!>},<{!>},<!}{'!>},<ue>,{<!!!!'o!!iu!>,<!>,<ao!>o!\",!!!>>,{{<!>i{!,!!!>e!!!>,<\"e!!!>!>>},{<au!\"!!\"{,<!!}i,,\"!>},<!!!>,<!!i{uo>}}}}}},{}},{{{{<i!!!!!>!>,<!!!>!!!!!!i!!'{!,!!!!!>,<>},<!!a!!\"e!>},<{u!>},<a!>},<!\"!!!>!>!!,o>},{{{<<a}{!!!>\"i!!,!>uu!!{,>},{{<<!>}o>,{<\"i}\"u!>},<!!!>!!i!{!>,<a<!!}u!!!>!>},<!>>}},{}}},{<{!!!>!!!>!}>}}},{{{},{<!}i,!\"!!o!>},<o!!!ue<!!!!!,!!<eu!!}{}>,{<e!,i!{!!{u',>}}},{{{{<{!!!!u!>,<!>},<!!i!>,<i<<\"\"!!!>},<<!>u>,{}},<!!!!!>!iu!>},<!!>},{<!!!>!!!!!>!>,<!!>}},{{},{<i'!>},<!>{'i!!!>!>,<i>,{}}}},{{{<,a<!e<>,<u}{''}'\"!!!!!>,\"!!a!!}o}>}}},{{<>,<!>},<{{!>!u{ia>},{{},<{iue{oau,!>!,i!!!>}!!!>}!!!>e,>}}}},{{{{<!>\"<!>,<<!!,!!!>!>},<!>ia!!'!a>}}},{{<!!e}\">,<\",<>}},{{{<\",!>,<!>},<i\"!><!>!!!e'>,<'!!!!!>>},{{},<!}!!!>eu!!,!!<!>,<i>}},{{},{{<!!!>},<!!!>!>,<!>,<u!!},!!e!>,<!!!!!!!>o>},{}},{{<,!>,<!!oi{!<<!>},<!!!>{uu!>},<eo!!a>}}},{{<u!!!>!>,<a!>,<eo'\"!!>,{{<!>!!uo>}}},{{<o!>},<!!!>e>},{{{},{<\"a!!i!!!{!!!>,<eia\"!!!!'!!}!!!!oo!>,<>}},{{<\"'a}!>,<<!!!>'a!>!!uuu!!!>'}e>},{<!e}!>},<!>,<{!!!e>,<!!!>!!<!>},<!!!>a!!ai!>},!ei',a>}}},{{<'i{>},<!!'a!{<!}<!>!!!>>}},{<!!io,!!\"!}u!!!><o!!'\"!>{>,{<a!>!>},<<a!!o'>}}},{{{<<!>\"'a!>},<!>},<!i!a>},{<u!'!>},<u!>},<i{\"!>o!!<u!\">}},{<!>!!!>!,!!,!>eu!>},<<!>,<e>}}},{{{{{<!>,<>,<i!!!>,a!>,<!e!!{!!!>}!>},<,!!!!!>eu!!e>}}},{}},{{{{{<!!e!>},<!>},<\"u!>},<i!!!>u!!,!>},<oo>},{<!!!!!!!>u!!!>>}},{{{<>},<i!!{u{!<,!,e!!!>},<!!!>},<!!u\"!o!!!>e!>,<!>!>},<>},{{},{<',!>\"{{!!!>}!!a!>>}},{{{},<\"<,a{!!o{\"!!\">}}}},{{{<>},{<oa}o<<'!>,<,!'<>}}},{{<!>!!e!>e!!>}}},{{},{{{{<e!>,<u!>},<!>,<e!>,<}>},{{}}},<,!!!>!>!!!>!!!>e!!!!i!!}!!{<}e!!u!>,<i{>},{{<e\"o!!\"!',\">}}},{{{{<}!>,<u!<!>,<a>}}}}},{{{<auiu!!!>}!ei>}},{{},<!>a!!,}a!e>},{{<!>,<i'\">},<!!!>,<!}au!!!!!>,<}',!!!>},<!!!>>}}}}}}}},{{{{{{<!>,<>,{<!!\"!u!!u!>},<''!>{!!!>'\"!!!>!!!>ou>}}},{<u!>!>>}},{{{{<{!\">,{<!\"!>},<}!!oe!!!>u!!!>!!'!!!!,>}},{},{{<i!>},<!!>},<!!},}!!!!<!>>}},{{<!!o!!!>!}!!!>ou\">}},{{{<!!}!!o!!!>!>,<!>,<!!!>>},{<!>!>a,!!!!e!!oao!!!>,<!o!<!>,<!>!!!!uie!!!>>}},{<,<o!!!>'!!!!!>!>},<!!!>!>},<!!}o{!!{!!!>>,{<}u,!\"!!!>{}u}}!!i{>,<'!!}!!!>!!u!>,<!>},<<!i<{u{\"!!>}},{{<o{!>},<ae!>},<a!!!><a!'>,<ue!>u\"\">},{{<!>,<<'!!!>!>},<!!<!!!\"!!{a!!}!!!!!>!!u<>},{{{},<!>},<e\",}o}!'!oa!>,<a>}},{<,'!!!>,\">,{{<e\"ou>}}}},{{<!!!o{'i\"!>,<<<!>},<!a!\"e!!!}<{!!!>'u>},<e',!i,{e!!!><!>,<!!\">}}},{}},{{{},{<}{,!>i!!!>!!a!!!>!!\"<e>}},{<e!!!>!>,<,a'!}<'!>,<{!!!!\"!>},<>},{{{<!>,<a,!>,<!>,<,!!u<a!!{e'{i>}}}},{{{{{<i>},{<'>,{<iu<!!a}e}a!!},!!!>!!\"!oe!!ao>}}},{{},{<a!>,<i!>!>,<i!a>,<!!u!>},<!!!!!}<!!,o!!<,'i,'!i>}},{{<u!{i!!!>},<!>a>},{<!>,<!!!!!>!ui!>},<\"aoa>}}},{{{},{{<a\"!!!>},<!!}<!>!!<!>},<}!>,<>},{{<'!!!!<!>,<<!>'i!>u,!'!>,<ui>},{<!!e'!!!!!>!>!>},<!!>}}}},{{{<<,'!!\"e!!!!}!>,<!!!>!>},<!>,<>}},{<\"!o!>},<ea!,{ia!>},<o>}},{{{<}>},{}}}},{{{{{<<ae!i!>,<\"!!!>\"i<ua!u!>},<>},<i>}},{<!!!!!>\"a!!!!!>,<'u\"!!!<<!!!>!!!>!>!!!>,<}>,{{<'!o!>},<!!!>,\",'a!!!!a''uui!!!>},<>},<!>}!!}!!oo!!!!,!>!!}{e,e\"ii!>>}},{{},<!!e!!\"{a<!!!>>}},{{{},{}},{<!o,!!o{!>!!!>'!>ou'a,>,<e!!!a!<e,!!}>},{<!!a!!\"!>,<,,}u!!!!}!!!!!>a!!!>},<!u\"{u},!!{>,<a!!!!!>!!!!,!!e!!\"!>},<!>,<oa'>}},{{{<<o}!>,<\"o!!e!!!!!>},<!>,<\"{!>},<'o>},{{<!o\"u!>!a!>},<\"}>},{<o!!!i'!>>}}},{<e!a!>},<!!!>{oa!!}iii!ei>,{{},{{<e!!{\"!!!>o>},{<{a!!aaa\"!>'>}}}},{{}}},{{<o\"{'!\"!>,<oo!!<!!!!'!!u<ia>}}},{{{{<o>},{}}},{{{<o!>a'ouo,,ou}au}>}},{<!\"u!!!!!>},<!!!>{!!!>!>},<\"{,!!}\"\"e<>,{}},{}},{<!>,<!>,<e{ou{e!>,<>}}},{{{{{<!!!>\"a!'!>},<\"{<{!!\"!o!u>}},<a'!>},<<!!!!!>,<u{!>,<{>},{{{<,!\"e{!!o!>,<!>{'!!e!!!!!>,<i!!u>,<!\"<!>,<>},{<!>},<!!!>!>},<,'!}!>,<e'}!!!>u>}},{<!'!!!>}!>oe!>>,{{}}}},{{},<!!!!a!!!>,<>}},{{{{{<\"!>,<a\",!!o!>'!\"eo>},<u!!!>i!oao!!'ai!>},<<!{{>},<!!!>!!o!!!>>}},{{}},{{<\"!>iu\"!!!>>},<'''!!!>ia!>},<i{}!!i!>},<o}a\">}}},{{{<!e>},<a!>,<<}!!!>'>}}}},{{{<u{u<,>},<!>,<,!}}!>},<'!!!>,<!!o},a'!!{!,!>,<u}>},{}}},{{{<\"!>\"'!>e!>},<{'{!!!!!>>,{}}},{{{}},{{<>}},{{<!><u!>,<!!!>,<{\"!!i,}!!!!!>'aa>},{<<i!!!!\"a!e!!!>,>}}},{{{<}',\"!!!>!!>,{}},{<,!>},<o!>eooa!>>}},{{<!!{!!}>},<!!<!>},<}!>,<!>,<!>,<,a,},i!!!!!>a\"!>!!!!!>o>},{{},<,'!ee'!!,{>}},{{{<!!!!u<u!>},<ao'>},<!>},<'ii!>oeaee!>,<{!>,<e!>>},{{{<'o!!>}}},{<uia}{'!>},<{!!!>>,{{}}}}}},{{{{<a},>,<!>,<{!!!>!!!>},<{!>},<!!!>!>a!!!>{!>},<u>}},{},{{{<!!!!\"!o!!!>!!!>a>,{<<!>,<u,'!!!>,<<i!>},<}\"!>},<u>,{{<e}!>,<!,!>},<!!!>!ae\"!!!>!!!<!>},<<>},<<!!!>!e!>u!aa!>},<!>,<\"<!>\"u<e!>!!{>}}},{{<,{!!a<a'}u\">}}}},{{},{}}},{{{<iu,>,{<!!'}>}},{{<!>iau!!,!>},<eu!>,<\"!!a!!!>!>>},<,o}\"!a>}},{{<!>},<o!!!>u,e!!i!>},<}!<!!!><>,{{<!!!>ua!>,<uaa{u!!o<e!!!>!>,<ie!>o>}}}}},{{{{<,e!!!>,<{ea!{,!!e{ua!!!>!!u{{}>}},{{<u!>o!>,<\">},{<!>},<i<!>},<ei!!!><!>},<!>},<!!!>i!!\"!i{>,{}},{{},{<}}>,<o!\"i!{\"!iu{\">}}}}},{{{{{<o!!!!!>eo\"!>},<<!!!>!>!>,<!>!>},<\">},<i!>!<!>},<'!o!!!>!<ua{!!!>\"a,{}!!,!>},<>}},{},{{{{{{}},<!!!!!>}!!!>{!',!>},<!!e,!>ua!>},<!!\"i!>},<>},{{{<!!'{a}!!!!<u{uu'!!!>!!!>,<!!{!!>}},{<!>,<o\"!!!<,!>},<a!!a'!>,>}}}},{{<oo!!a{,!!!!!{!!,e>}}},{}},{{<!!!>,<>,{{<!!o<!{o}\"u,!!!eo!!a!>>}}},{}},{{<!i!>},<}!>},<e!>,<i}\"{{{!u>,<!!!>!>'o<,<!{'>},{{<'!!!>{!!!>},<!!!>!!!>!>},<eu\"}e!>,<>}}},{{{<a<,,!!!!!>e\"!\"!!!>!!!>!>!!e}i!!ae>}},{{}}}},{{{{<!>,<>},<u!>},<{!>,<!!{!{!!i!>},<e!<!>ue',>},{{{<!!!>!!'<!!!>,<!>,<,,>}},{<!>},<i'!oao\"ao!>,<i!>},<,\",!>},<>,{}}},{{<<!!{!>,<!!!>\"!!<}!>e!!!>}>},{<'<}!!\"'}<i>}}},{{{}}}}},{},{{{{{},{{{<i!!!>\"!!!>,<!a!>},<ai!!!>!>'>}},{{{{<!>,<u!>},<!!}i!!i{}!'!>'!!!o>},<a'a!}}!>}!>!!!>\",!oi!!'o!!!!<>}},{},{{},{<,!>},<o!!!!!>,<ao<!!!>!>},<!>,<!!!><o!>,<<>}}}}},{{{},{{<a!a}>},<a'!>>}},{{{<!!,o!>o!u}!!!,o!,u!!''o>},{{<<ao}eoee!>,<>},{},{{{<!!'{!>!!!>'i!>},<}aui<!!!!oi!>u'>},<{}!>,<!!\"!>},<!u}e<<!!>},<>}}},{{{}}},{{{{<\"!o>}},{<oi!!!>}!}!u>,<}>},{}}}},{{{{<o!>,<!<!!,!>,<!>\"!!a!o{o!!!>,<{>},<\"}a!!!>!!{!!<o!!}!!{<{{u,'!>},<>},{<}<!!!>!!i,!!!!{!!!{!!!>'!!<'!>},<,e>,{<!!<'}!!!>!>},<oi!!!>u>}}},{{{{<!!!>{ao\",,oiei\"!!!>,!\">},<!>},<i{!i!!o!!!>!>!!!>{<i>},{<!>!!!>eao'aoua!!!>>},{{<!>},<\"}\"a!!!>!>},<!!a!>!!e'u\"!>},<i!!,>}}}},{{<i\"i'!>,<!>{!!!>'!!!!i!!!>}e!>,<!!!>!!!><!!>},{{<o'!!<{'>},{<,,'uoo<u}>,{}}}}},{{{},<>},{{<{!!!>!>eouie!!'{\"!>!oou>},{{{}}}}}},{{{<!!uoi!>},<,\"!!!>o>},{{<aa{!>,<!>'{!!u,{!!!>!>>},{<!>},<{!>},<e!\"!!'<!>,<!!\"o{a,o!!u!!>}},{{<\"u!!!>\"{!!!><!!}!i!!'>,{<ae<!>,<!\">,<e!!<,!!!>e!>e{\"uo,!>,<!>o'!>},<>}},<<\"!>,<,!>},<!!!>'!!\"!!<a!!'o!>,<\"!i!!!><>}},{{{<,'!!!>!,!!>},<!!!>!!{!<e}\">}}},{{{{},{{{{<>}},<i!!e!!'!>,<iie<!!e,}<!u!!{>},{<o!!!!!>!!!!!!!>},<>,{}}},{<!u'!>},<}\"!>\"!!!>e!!!!<\"!!!!a!!a>}},{{{<e!>!><a,!>,<o!!a!!a\"!!!>!>},<u!!>,{<}!!'!>,<!>,<<!!o!>,<!!,>,{}}},{{<\"!!{a!!!>},<!!!>,<u,>},<'u!<o,>}}},{{{{{{<<eu!!!!!>!!o}!!!!e!!ieo}\"!o>}}}},{{}}},{{{<!!!>},<iei!>,<\"'o}!!!>!>,<u!a'!!<>},{{<a,!!!!ao!!!>{!e!>},<!>!>,<au!>,<>},<{'u!!<'!>},<!!!!!>!o!!a!!!>!!{}o!>!\"<,>}},{{},{{{{{<a<!>},<!!<a\"!>,<!>},<!>>}},{<!!!!!>{!u!!!>eu!!!>i{o!\"!!>}},{<!!{}!>}!>!!!>},<!>!!!>!>},<>}}}}},{}},{{},{<<{<<!>>,<!!!>e!>},<eui!>>},{{}}}}},{{{{},{{},{<'i!}}o<<!!e!!!><<!!!>!!!>!>,<\"!!>}},{{},<'!!!!}<!>!!!>ou<u!>,<!<>}},{{<''o<!!i!!<e{o!!!!{>},{{},{<,o>}},{<}i!>,<'>,{<!>,<!>},<i!>},<\"{,o>}}},{{}}},{{{<!!,ee'!a'oa\"{!!!>\"!>o!!!!<>}},{{{<!e!!'{{!>!>{<'o}!>},<,!>!!o!i\"!!!!,>}},{{<{!>},<!}!>,<!>},<>},<,o>},{{<\"!e!>,<!>}!!!>\"}>,<!!!>!!!>',!!>},{{<a!!!!o!!!!ua>}},{<!>,<!!}\">,{}}}},{}},{{<e\"a}!>,<<'!!u<>},{{<,'>,{<a!!'>}},{}},{{<!!!>,<e!!<<a!'\"'!!!>,<a!!!!!>a>,<!>},<!>,<>},{<o!!!!!!!!!>!!!\"<!!!>!!a!!!!!>!!!>,!>},<,!>},<!!o!>,<!\">}}},{}}},{{{{{<o!\"!!!!!>},<<!!o!!!>\"!!!>!!}e>,{}},{},{{<!>,<'!!<!!!>},<!>},<o!!!u<u!!!!>}}},{{<',}!>'!>}!!!!!!!>i\"a<!>o!<!>,<,>,{<!,!>},<a'!!!>ea}'!>!i>}},{{},<'\"\"'!!e!>,<!>!,\"{a}{ua>}},{{{{},{}},{}},{<,!i!!!a!!!>ea!>!>,<a,!>},<!>},<!,!>i,>},{{{}},<}e!!!!!!,iaee>}}},{{},{{}},{{}}}},{{{<}!>'{}'\"!>i!!!!!>'\">,{<!>a!}!>},<\"!!a!>e!!!><!}o'>}},{},{{{<a!!>},{{<e!!'io'!!'i!!!o!>,<a!>,<e>,{{<',\"!!!!!!!>}ii!>},<!>,<}!>!!!,!>,<>}}},{<!!{!>,<!!!ui{aa{,e>}}}}},{{},{{},<i!>a>}},{{<o>},{{{<!!!!!>{e\"!!!>>}}},{{<iia!!io!!\"'>}}}},{{{{}},{<!!<a!>\"!!!>!!!>!>,<\"e!>>,{{<u'!>,<,<<<}!!!!ua!!!!!>\"'!!{{o!!\"!u>}}},{{{<e}!!!!!{'''>},<a!>,<{'>}}},{{{{<{i!!'!u!>,<{!>'!!{!!eo{!\"e{>}}}},{{{{<!o!>,<'!!i!>,<!!!>!!!!!!{a!!>}},<!!!>!!!!}ia!!!>!>,<}a!!'u!>,<e!>,<!a,>},{},{<!!u\"!>!!!>!!!!!>},<>,<ua,o!}!>a!>},<!>,<>}},{{{}},{<u,{,,e!>!u!>,<u!<,a!!u!>},<!>},<>,<{!>},<ae!u!u!',!>!e!>!>!>},<!!\"ue!>},<>},{{{<!>},<ae!>o!!!>,<'<<}!!!>!>},<>},<!!{i>}}}},{{{{<!>},<e}a!>o,>}},{{}}},{{{<e<!,!,i!!!!!>!!!>i<>},<!>,<!!!!!>!>},<<!>,<'u<>}},{{{{<!!!>'!!!>!!a!<i<!>!!!u>},<,!>'{\"{!!!}!>},<{uei'{!>},<!!!!!!!>>},<o!!,>},{<>,{{<!!!>,!!{!!ue!o\"!!!!!!u!>},<'!u,<>},{{<!<<!>i}i'>},{}}}},{<!>},<o>,<!!\"!>},<!>},<}!!{!>!!i>}},{{{},{{},{}}}}},{{{{{{<!>},<!!e!>e<!!!!>},{}},{{<!!!>>},{<e,o!>,<!>},<'!!,!\"!!a!!'!!{!!!!u>}}}},{{{{}},{<}!>!>u,{>},{<>,{}}}},{{{<!!!<!>oe!>!e!!!>a!>,<>,{<,e!!\"}!>e!!!>o!!!!iu!>,<!!>}}},{<!>},<!!!'!!,{!>'a\"!{{!!i!>>,<\"<!!>},{{<{i!!{,{<\"}u!>!ei!!}!!!>!>,<!>},<!!i>,{}}}}},{{{{{<u{!!'!>},<<\"!>!!!!!>!!}{<>}},{<!},!>!!e'!!uo!!,!!!>}'\"a<!!!>'>,{{<!!!>!>},<!!!!'!>i<!>,<>}}},{{{}}}},{{<!!o>},{<{!>},<!!!>!!!>ua!!!!!!!>!!!!!>\",!!!>,<\"!!!>,<!!<,}{>,<!>!>,<!!!!<!,!!!!,o!!ui\"!!!>'>}},{{{{{{}},{<!!i}!!{!!u'}\"u!!uoi!>!>!!!>!!!>\">}},{{}}},{{{{},{<<!!},<<}\"'ai>}}},{<!!!>>}},{{{},<}!>},<'!!!>},<!u!>}<!!!}!>,<!>},<i!!!>!}>},{<>}}},{}}},{{{<<\"!>!!!!{!!!!u!\"i!>}i>},<!!au}>},{<!!!>!!<a!>,<!>},<}!>,<{>},{<!>},<!!!!!>!!ia'!!e,o,>}}},{{{{{<!!!!o,}!\"<!>,<!!\"}!!!>,<>}},{<>},{<o!>,<}>,{{<{!>},<e}!>,<}!!!>e{!>!!a\"'!,>},{{{<<!>,<,>},<!>,<}e<>},<}e!>,<>}}}}},{{{{<}!>,<ae!!!>\"!!!>a>},{{{<!>},<!a!!!i!!!>!!\">,<}}!>},<!!'eu',!a<>}}}},{<!!\"{>,<e!!}!!!>!>},<{\"!!!!'i,!!!!!>e!!!>},<>},{<!!!>a!>\"<e!u!{>,{<{!><o'!!!!,i{!i!!e>}}},{{<<>},{{{<{{i!>,<!ue>},{<!>},<!io!!o!\"e},{!!!!,!!a}!!>}},{},{{}}}},{{},{<!>,<!>,<>,{<ao!>>}}}},{{{<\"!>>,<i!!!!!!!\"!i!!!>i!>},{{<{'i!o>},{<'<!>},<!!!}!>},<ai<u>}},{{<>,{{<}{{u!!{,e!!!!!!!>u!i'!!!>{e!!!!!!,>},<!!!>!>\"!>,<\"{\"{}io!>,<!>},<!o>}}}},{{{},{{{{{},<!e!!i!!!>'u'i{}!!!>!!!'!!}o}>},{{<!!!>!!'i,e<u{,au!!!><!>},<\"{>}},{{<>,<!!o!a<!!!!!>},<!!e!>},<<o,i!>},<!>},<>},{{<!{>}},{{<!!{>},<!!u{iee!!!!!>!!,!>,<'oo!>!!!>},<<!>!\"u!!}>}}}},{{{<o!>},<!!a!!!!u!>,<,!!o>}},{{},{<!>!>},<{!!}!u'!>!>,<!!<u'>}},{<}!>},<{!u{<!>e<<!!!,!!!!a!!a}!>,<>,{}}},{{{<e>,{{<!!<!!>},<{,\"u!ea>}},{{<'i!!<'u!>},<i>},{<a\"a'!,\"!>ei!!!!!>!>},<\"!!!>>}},{<\"!!{!>{<!>,<<i,!!!!!>},<u!>},<>,{<}!<{{'!eaueu<!!!!!>!!!!<o>}}},{{{<{o!>},<!u,{i!>!!aio>},<!>\"}\"!!{a!!a'u,\"{!!!>\"}<}>},{<!!!>,<!>,<!o!>},<aa!o!'>},{{<u<>},<i!!oi!!,!>},<a<'>}}},{{{{{<!>},<}{eeo!!!!<a<!!!>!>}'!>!>>},{{<!!!>>},{{<e!a!!e!>,<{}!>},<>},{<<io!}!!!>>}},{}}},{<!>!!}e!!!>,<{!>'>},{{<,{!>,<!!}!!,<}>},{<<!>,<au>}}},{{{{<!!e!!!>u\"!>},<'<,u!!!>>},<\"!>'!!e!''!!!>,\"!>,<!!!'{'>},{{<a'}<!>},<!!}!!!>,<!>},<o!!!!!>,<!ia!>},<{!u!!!!!!u>,{}}}}},{{{<e!\"e!\">},{{<<>,{}}}},{{<aa!!!>{aa<i!!,!!!>!!<},!>},<>,{<o{'!>},<a!!{>}},{<!!e''!!!>e>}},{{<u}o!}!!!>{o!!<,!!!>,!!!>!>},<i>}}}},{{{{{<o!>,<e!!e!>!!!!!<!!u,!!!>,<!!!'ua>}}},{{},{},{<!>,<!'!!au!!!>u<<!>!>,<e>,<au\"\"!<!a!>,<!>,<'e,>}},{{<!!!>},<'{!>},<!>!!!>!>,!a!>},<<\"o>},{<}i!!'ai!>,<!!>}}},{{{<!!}!>},<!>,<!!!>\"!!!>>}}}},{{{<\"}>},{<!!!>!!!>!!}>}},{{<!!,!>,<e!>'\"uo\"''<!>,<i>},{<!>}<o{>,{<!!!>},<o!>,<!>,<>,<!!!!!>},<!!!{o!>!e!!!i!>,<o!>,<!!!u,'!>!>,<!eu>}}}},{{<\"}ie!>,<ua},!>,<{,e>,{}},{{<o!<e\"{>},{<,aoe!>,<!!\"{\"!!<\"'\"!>},<a!!!a!!!>e>}}}}},{{{{{},{}}},{{{{}},{}},{}}},{{{{{<<ua!>ui!!!!!>u,}ua\"<!{!!!><>},{<'\"'!!}\"{>}},{<!!!>{!>},<!!<oa!a!>,<!!<\"{!!!!!>ao>}}},{{<iu!!!><}'!!>},<oe!>>}},{{<!!e!!!!!>u,!!i\"!e!!ii!!!>!>},<>,{<!!a},!>,<!>,'!>,<{,!>eao!>},<e>}},{{<!!a,>,<!!!!!>'{i>}},{{{<i!>,<!!!>ao!!!>'!!,!>},<<!!\">,<!u>},{{<'}>},<u!>,<!!!>!>'!!!>},<'!>!>},<!>,<<e,ao!o!>>}},{{{{},{<!!!>a>}},{{{<!!!!!>!>,<!>,<!'!!u!!u!!!!!<,!!!>!!!>io!},{,{>},{{<!!e!>},<o\"!!!>{>}}}}}}}}},{{{{<e\"{u}\",!{!,>}},{{<u!>,<{!>,<\"!!!>,<,>},{<,<\"<!!!>,<>,{}}}},{{<'!>,<!!!>!!e!!!>!>,<{!!!>,a{u!>,<!!!!o>,{<!<!!!!}!i!!!>!!},'!,>}},{{},{{<!!!>ee\"!!ei!!!!!>!>u\"!!!>>},{<!>},<,}<,}a<!>!>},<'>}}},{<{!>i!,<a<!!!<!>},<ueeu>,<a!>a}}oe!!,oi!{{<u>}},{{{},<!i\",'o>},{{{<!u!!!>!!iu!!!!u\">}},{{<<ai!o\"!!!>o>,{<!!!>!>,<!!!>,<a!>,<o,<i'ue{!>},<!!{!>},<>,{<oo!>},<!!!>!<>}}},{{<a!!}!!>}}},{{<e!,\"!!!>>}}}},{}},{{{}}}},{{{{<\"!>,<>},<u\"!!!>!!a!!!>,,}'!!}!a'ee>},{{{}},<e!!o\"!>},<'!!!!,i,>},{{}}}},{{{{{<!>o!>,<uo}!!!>{<'!!i,!>},<>},<!>!>!!'{}ia'!>,<'<e>},{<i!>},<!>,<!!!>aieu,'!!\",!!!!}>,{<}a!!!e!>,<!!!>!i\",<o!!!>u}u!{<!!,>,<'{>}},{{<,!>},<ao!>},<!!!>!!!>{}!!!!!!!>!!!!!u}<!>'{!>>}}},{{<e!!!!!>,aa{!!!>!>!>},<!!!>!>!>,<!!o>,<o'!>},<!!!>!{,!>},<!!!!<!>,<!>},<a,!{u<>},{<<!!,!!!!a!!!>,<a!>,<{!><!>},<eue{<!!!>o!!!i>,{}}}},{{{<!>,<e!,>,<e'<a!!!!\"e!!ia!>,<!!!u>},{{<e<u>},{<!,!>},<{!>!!!!u!>},<!!!>,<>}}},{},{{<i{<i'}!!!!!!!><!!!>{u!>i\"\"\"!!!>!>},<!!{>,<,u!!!>{'!>,<<{{<<!>!!o!>!!!>ee<!!!>>},{{<\"!>,<!!u!!ue!i'ui}ea!>},<e!!!!a'\">},{<!!e!!}!>},<!!!>>}},{<}<'!!!!!>!>},<<\"aeu>,<}!!!>\">}}},{{{<i!>!\"!!!>!,!!!a!!}!>,<!!ao{>,{}},{<!!!>''!>,'a}a!!!>u!u<>}},{<!!{!!!>},<!>!oo!!!>!!u'>}},{{},{{<!>},<o<\"!!!!!ueou\">}},{<!!!>e!!!\"!!\"a<!!'i!>,<{!!<!!>,{<io!!!>ai!!'!!'!!!>,<!>u!>},<>}}}}},{{{{{{<>}}},{{{{}}},{<o}!!!!!>,<oo'u!>},<,'!o!!u'>}},{{},<a!>u!!\"!>},<!!!!!>!!>}},{{{{<oio{!!,ueu{>},{<!>,<!>},<ie!!\"{a!u!o!!!!,\"{>}}},{<{'a}!>},<i!!!>},<'!}!!<!!!>>,{}},{{<!>,<!!!>},<o<'!>},<!!!>ie!>,<<<'!!!>,<!>,<!!!!!>},<>,{{}}},{{{<!>,a'!\"{!>},<oiu!}o!>,<a{!>,<\"'o>},<e!o!>}{,\"!!!<!!!>,<\"!e!!!!<<>},{<<>}}}},{{<'ai!!!!!>!,o,!!u!!!\",i!!\"ua>,{{<i{a!>o>}}},{<i!!a!>,<!!!>!!<o\"ei{!!}!!!>!!!>\"\">,{<a\">}},{{}}}},{{{{<'<>}},{{},{{<!!!!!>},<!>e>},{{<u!!!!,!!!>!!!>>},<<i\"{!>!>,<oa!!,,!>,<>}}}}},{{{{<i!!a}o}<,!>},<!>i,'!>},<>}},{<!<\"'\"!a'!>}!oau!!}!>'<!!!>,<o!!e!>>},{{<a\"!!\"!!!>\"!!!!!><\"ii!>,<!!\"!!<au>,<a!!{,,\"u!!e'!>{>},{<<!!!>{>}}},{},{<!!!>\"!>},<!!a{!>'!>\">,<i!>!!!>>}},{{},{<!!!>!!!>!!!>!>},<e\"!>o!>i\"ie<>,{}},{{}}}}},{{{<{}!u!>!o{oe!!!>u>}}},{{{{<!!,eouu!>},<!>},<ai!>,<u}{<>}},{{<a!>u!!!>a{{}!>,<,<u\"!>o>},{{<!io!!'{!!!>\"!!a'}!!,!!!>>}},{{},{{}},{{<<<u{\"{!!eo!!>}}}},{{<u!}<!><<!!a\"e!!!!,!!!!!>e!!!>,<i!>},<!!!!!>>},{{<!!!!!!!!!>,<'a!!i!>,<a!>!!!>},<!!>},<{o!!u>}}},{{{<u!>,<\"!>},<!!,\"!'}',!!'ia!>u!>},<u>},{{},{<>}},{<!!!>,!>a!<>}},{{<'i!!!><!!i!!a,\"{\"ii{oi!!{>,<uu!!iu!!!>},<\"o{!!!!!>!!!!!!!>},<u!>,<!oa!>eu<>},{{}},{{<<>,{<!!aae{!>,<u!>!>'}!>},<,>}},{{<uo!!!>,}{,\"e{e'>}},{{<!!<'i}!!>},{}}}},{{<,!!e!!!ou!>!!,e!>,<<ea'>},<!>},<{}}}u}a'<!>,<a!!<{'>}}}}},{},{{{{<ee!!!>}!!au!>!!!!!>!!!>>,{{{<i!!>},<o>},<i!a!!!>!!au\"a'ii!!!>!>,<!'u>}},{{{<!u{!!!>}o\"!>,<!!!>!!!>a>}}},{{<!\"<!!}!!a}\"au'{,<<!!!!<i!!!><>,{<!>!>},<!>,<,>,{}}},{<!>,<<!!,e'!!u!!!'!o\"a!!'>}}}},{{{{{<u{>}},{<>,{}}},{{{<'a>},{{{{{<a!>!!'!>,<}!>!>!!!>},<!a{uao!!!>{u>},{<!!}>}},{<!!uoo!'!,!!!!aio!<!!!!!>!!!>!!!\"!>,<!!!>{>,<!!!>'!!\"!!!>,}\"a<oa!><}<<i}a>}},{<!!!<!>},<oui>}},{<}ouo!>,<,!!!>\"!!!>>}}},{<!!}{\"!!!>e>},{{{{<,!!!!!>!>,<<{a\"e!>},<{!>,<,!!!!<{!!!>!!!>>}}},{{<<e!ou!!ae{!!!>,<!>},<!>{!\">},<!>!>},<!i!!i'e!>'i>}}},{{{{<aoo\",io}<!!!>e!'{e!>!!!>i>},<!!!>i}!>},<>},{<u!>},<!!!!!>!!!!'!!!>,<!><a!!!>>,{<!>!!!>ie!a!>!u!!{e!>,<'i!!!>!>,<>}},{<i!!!>!>,<u\"o'e{}{>,{<}<!>},<!>},<}!>{{!i!>},<'!!!!o!!{!>},<!!i>}}}}},{{<\",i!>},<!>>}}}}}},{{{{{<i}e<<e>}}},{{{{{}},<!oe!>},<!>,<o}i'\"e!!{!!<\"\"!!}}!!!>>}}},{{<<!>\"!>}!!e!!!>!>>,<\"'!!u!!!>,<i\"!!!!eua>},{<i!},eo!>},<u!io>,<!!!>},<!>},<!!!'!>!>,<!'aie!!}a>},{<a>,{{<'\"!>,<!>,<!>,<>},<!>i'<!>,<\"!!eaao!>},<<!>},<}e!>>}}},{{{{<<a!e!!{!!!!!>!o'!!o,!>},<,<>},{<<o!!!>!>},<!!,!>},<!>},<\"i>}},{<\"!!!>o!!!!!>}!>,<a\",!>!!!>>,{}},{}},{<<a!!oi!!!>\"\"!>\"!>,<!>,<<>,<!!!>!>,<e,i{!>},<<!!}i!i<a\">},{{{<!!!>,<!oi'<!}>},{{<\"u!!'a<>}},{{},<!>!!e\",}a!!!>,<{{!!!>,oi>}},{{{},{}},<e!!!>},<<!><!!u!!!><!!io!>,<}u!!'>}}}},{{},{{{<!>,<!>!!!{>}},{{<uo!>!!ae!!!>,>},{<u!>,<!!!>}e>,<{!>!!!!!>!!a!!{!!<>}}},{{},{<!!!>},<o!!!>u\"e,!<<>,{<!>!>},<!,i<}eio\",{<!>,<!!,>}}}},{{{{<'ai!}i!!!!e!>},<e'o!>,<!!!>!>},<!>e!>},<>},<}!!!>>}}},{{{{}}},{{{<e!>,<>},{{{<!!!>>},{{{{<}o\"u!!a\"!'!a!>u!o!>!!!>,<!>},<!>a'!!>},{<>}},<{a{!>>}}},{<i'!!!>!!!>>,<u>}},{{{},<!!'{o!>,<<!>},<,o!!i!>,<','!!!>i!\"eu>},{{{<au<>}}},{{{{<}<e!<{!!!>eo!!,{e!!{\"u<>,{{<>}}},{<!!{{!!,o'!!!i<!>a\"{'!ii{o,!>,<<>}},{<o!>ea>,<!>},<}!>,<uu!a!>\"!!!>!>,<!>,<>}},{<!!!\"'!!!>!>},<{>,<<a!!!!!>>}}}},{{},{<aa'i!!!!,!!!><,!!}!!!>u{i>},{{{{{},{{{<!>,<!>!!!>},<!>,<!!,o!!!!!>e!>}\">}},{{<!!!>!>!!u!!,u!!!>,<!>''!!!{!}a!>,<ea!!!>a!>,<>,{}}}}}},{{{<!!!>!!!>},<{!!!!!'!>},<!!!>>}},{<,!>},<!!!iu!>{>}}},{<}!!o,!!!>},<u}!>!!}'!!!>!!!>!!u'!{}!!!>>}}},{{{{<{u!!!>!>},<{>,<u!>},<!>},<!>},<}!>},<\"!>},<e'!''oi}!!!!u\">},{<>},{}},{},{{<',!<ia!!!>,<\",a!!!>!''!!{<\"\"!>\">,{<!>!>,<!}<e!u\"!>},<!!!>a!!!<!!!>>}},{<!!!>!>},<i!!!>'!>,<'!>},<!!{!>},<!>},<{>,<!!!!!eo!>!>},<{!!!>'o<{i!!'\"o!{i!>},<>}}}}},{{<!>},<e>},{{{<!>,<'<!>},<!!!>a'!>},<!<!!!>!>},<!>},<>},{<{!!!>aue'!>,<}!!>}},<\"i!!!>,!!{ea!!!!o,!u{!!u}!>},<!!!!!i>},{{},{{}}}}}}},{{{{}},{{{<{!>,<>,<a{\"!>},<!!o}a!a>},{{<{\"<{au<!o>},{}}},{{{{<,,}i!!!><!!!>!a{',euu!>,<!>!!!!,uo>}},{<{!>,<!!!>},<'o<a!!}ua>}},{{<!'>,{<!{!>,<o!!!>u!!!!\"!>},<}\"!!!!!!\"'!>},<i}}{>}},{{{<<!!!>,<'!>,<u!>,<!!!>a!!'!!\"!>},<au>},<>},{<>,{}}},{{<e!!!>e'!!!!!>}iaa<i!>},<!!!u>},<'!!!>ai\"uo!>,<>}},{{<>},<!>!!!>,<!eo\"}\"e'oa,>}},{{{{},{<,o!e!!!>>}},{{<oa!!{!>},<e!!<\">,<{!!!>'u}!>,<>},{{},<<ae>}},{}}},{{{<\"\"'a!!!!\"!!!>>}},{}}},{},{{<>},{<\"<!!,!!!>,!!!ai!>!!!!u>,{{<!>,<!>!>!>},<\"}iu\"o!!}o,!>,<>}}},{{{{<{!!!e,!>!!!>},<!!!!oe>}},{{<>}},{<>,{{<a,e!>},<'<\"!>,<!>},<>},<!{,aaa}!!}'<!!!>\"'!>,<>}}},{{{<>},{}},<!!!>},<<!>},<!!!e{!>},<!>},<<!!!>,<!!u!>},<<,!!!>>},{<!>,<!!!!!>,!!!>,o!>,<u,'i,>}}}},{{{{<>,<!>,<eau,!>!>,<ui!>},<!!!>>},{{{},{<o>}}},{}},{{},{{<e!>,<!!!ou}!>},<!!o<!!!>!!{!}!>!,<ua!a\">}}},{{{{<oo\">,{<>}},{<!>,<!>e!!o!>,<o!>,<{o\"a<!!!!\"e!>},<{\"o>}},{{},{<uo,'!!<u!!!!!>},<}<!!!>!!e!!\"a\"}}\">},{{<i!ia!!<}aae!!i!!!<!!,\"!!!>\"!!u!!e>,<!>,<!!u{\",<<'>},{{<i!>,<e!>,<>},{<!!!>},<!!!!!!!>a!!!><!>},<<e!!\"{!!!!!>e!!'>}}}}},{},{{},<!>,<}>}},{{{{{{<,<!!!!'>}}},{{<}!>},<!!\"!>e{!!{!>,<ouo!>!!,!!iaeo!!'>}}},{{{{<<oioui!o!{eae>}}}},{}},{{{<!!!>!>},<}u!!!!!>>}}}}},{{{<a}\"}!,o,o!!!,\"<}!>},<o!!a>,{}},{<}!!!>},<i!>eoo!><\"o,,<!>!>},<!\"!!,>}}},{{{{},{{<'iui!>ea{!!!!!>,!!!i!>,<u!!!>,<!!!<!!oo!>>}}},{{{{},<>},{<a!a>,<'i!!!>,<io,!>,<!>,<!!!>!!!>!>},<{!>},<!u>},{{{<!>,<!!!>},<>},{{{<!!!>ii!!<!!!>ai!>},<}oa!>!>,<>}},<e\"!!!!!,uu!!!>'!>,<a!!<\"!!i>}},{}}},{{<'!{!!!,!!{\",>},<<!!,!!'!>{!uo!!!>>}},{{{<i<ee<!>},<,!>,<!>},<!!!>!!<!!!i>},{<!!!!o!>},<,>}},{{<>},{}},{{{<>}},{}}}},{{{{{<\"!!a>}},{{{<o!i\"i<,e\"u'>}}},{{<'!>,<!!!!'a!!!>!!ee!!a!!}>},{}}},{{{<!>},<o!>},<<!!!>,>},<>},{{<i}<e!!!>o\"!!}<>}},{<i!!e!>},<!>,<!!!>!>,<{!!,!>\"!>},<{!!!>!!!!i'>,{<u!!!!'a>}}},{{{{<'i{<<<!!!>!><>,{}},{{<!>},<{\"}i!e}e!>>},{{<\"!!!>!!'u!>,<u'!!\",!!}!<!>},<!>!>,<!>,<!!eu!>,<>}}}},{{<!>,<!!!!e!>},<}i!!ei!>,<!o'>,{{{},{}},{}}},{<}!>},<'!!e!!\"\"'a!!'o>}}},{},{{{}},{{<'>},{{{{<!!e{!!!!>}}},{{{<!,<<!!!!>}},<a!!a{!>},<!!<\"!>,<i>}}},{{}}}},{{{{<u!>},<o!>,<'>,{<{!!!>!>,e!<!!!>',!!!><\"\"ao>}},{{{{}}},{{<!!uaau!>},<!!!!<i!>,<!>,!!,!>},<>},{{{<!!!>,<a!!o,}!!<\"<>,{<!>},<!>,<!>},<!>!!!>!>,<!!,!>},<}!>,<>}},<<}<{!!!>}!>,<!!!>ao{'iuu!!uo>},{{<!e!!a{}{!!e''>,<e!>,<!>!>},<u<,!>,<!i!!!>>}}}}},{{{<{!!!><<!\"\",i,!{<i\"!oa\">,{{{},{<!>},<u!,o>}}}},{{{<!!!>},\"!,\",o{i'oa{!>},<'!{i>}},{{<>,{}},{<'!>,<>,{<'<!!{ua\"!!!!!>i>}},{{{},{{<!{e!!!>}}!>},<a!>},<,ii!!!>},<\"i}>},{}}},<a!>,<<!{!<!>,<!>,<>}}}},{{{<{!>},<a!!!>},<\"<!!!!!>!!!>'!!\"a!>,<o,{<!!!>a>,<!\"!!!>!!!>,<!!o}!!!!!>,'<u!!!u>},<!!>},{<\"!!,<!!!>,<!!iu!>,<!!\"!>},<!!!>!!u<u{o\"!!\">}},{<ou>}}},{{{{<{!a}''i,!i>}}},<!>ua!!'!>},<!!\"eoa}!!!>,<ea>}}}},{{},{{{{<!!e}u}>}}}},{{{<<!!\"!>!>},<>,{}},{{<i}>},{<,e!>},<i!>!i!'!!!>,<<,,{!a!>},<i!!!>'!!!!!>}>}}}},{{{},{<{!>!>!i!!u{!>!o>},{{<!>,<<!!iue!'}!>!i>},{}}},{{{{}},{<!!a!!!>'u>,{}}},{{{<,>}},{{},<!!!>!>},<},\"<a!>a!>,<!>,<!!!>ei}>}}},{{<ia\"!!\"!>,<!<!!'!>},<o,!>!}}!!!!!!a!>,<!!!!>},{<!>o!!!!!>,<!!!!i!>!!!>\"o,!>},<i'!>},<<!>,<>,<,u!!i}o!!<i!!o!>!>},<!!!>a\"o>}}}}},{{{<}!!{!>!!oie<!>},<i<!!!>i}!!!>e!>,<>},{{{{<>},{{<!!!>>}}},<!>!>'<!>},<i!!,{!!e!!!!!!e{!!<\">},{<\"{u\">},{{{<!!i!!!>!>>,<<!!oo!!o{!>},<e!>!>,<!!!>>},<}!>,<}ei<!!\"'<{!!e!>o}!>,<>},<<!>}<!>,<!u!o'!>,<,a'iu'<\"!!!!!>>}}},{{{<!>!!!>!!!>!!>},{<i!!e\",e!>,<}!>!!!!e>}},{{<u!!i{}\"!>},<!>!>},<{o>,<!!!>},<!>,<>},{{<!!e!>>,{<!!a!>,<a!!{u!>,<!>},<!!\"<!!>}},{{{},<u<!!!!a,i}\"!!!>>}}},{{}}}},{{{<!>,<,'!>,<ie!!!>},<a,!!!>!u{!>},<!>,<>,<!>,<!!!<e,\"!>,<o'}!i!>'{'\"ea!!!>>},{{{{<i}!\"!!i!>,<>},{{{<ae\"ae>}}}}}},{{{}},{{},<{o!>!!!>u!>>},{}}}},{{{{{<e!>},<e!>,<a!>!>,<>,<!!!>!\"!>!>},<,!!!>!!<!i,e''\"!!a\"<!!!>>},{}},{{}}},{{{{{},{{<o!>,<}!>,<'!>,<{!!<ua>,<a!!ui!>},<,<!!!>!>},<eu\"!>!>,<!!!>},<!!>}}}},{{{{{<'>}}}},{{<!!,!>!!!>}a!!!>{\"!i!e!'i!!a!>!>,<{o,>,{{<!>a!>},<!!<<}!!\">},<!!'!!!>,<!!!>!!<,>}},<!!!e!!u\"\"e!>},<e!>},<!!!>},<{!>\"!!,}\">}},{<\"!!!><a>,{<,{},'o!>!>},<!'<e!>},<!\"ie!!!>!!{i!<>}}}},{{{<!>!>,<ua!e!{<o<<{!!,<uuo<>,{<u!!!><!!!}!!{aoe!>,<{i{!!\"!>,<!!!>u>}},{{<,ei}!>,<!>,<'>},<}!>,<}\"!!>}},{},{{{<'!!!>{}!!!>,<!!,{!!!>uu!!,iu{>}}}}}}},{{{{},{<!!!!}!!!>ua<{o{\",!>},<\"'!<!!>}},{<u!!'!>},<u!!{i!>,<!\"{u!>>,{<!>},<!>},<>}},{{<!>!!!>!,!>!>\"!!!!!>!!<!i{!>}\"\">},{<!>,<<!i!>,<!!!!!>'e<!!!!u}'i!}{!!!>},<!>},<!>>}}}},{{{}},{{{{{{},<<!>!,'>}},{<!!!>},<!>,<e\"a{{>,<>},{{},{{<!>},<!!ao!!!<e>,<!>,<a!!!}oo,,!}>},{<!>},<u!!}'<'e!>,<<{!i!>},<!>},<!>,<!!!>\"!>,<!>>},{{<!!!!o\"!>},<!!!>'!!>,<>},<!\"!>!>,<!>!>,<!!\">}}}},{{},{<!!!>>,<!>},<!<!!!!!>,!!!>,e!!!><!!!><iu!!'e!!>}},{{{<!>,<!ou{i>},{<}i<a{!>,<!ia>}},{{<,!>},<{u!!!>,<o!>,<,!>!!o!>aue'!!!>,<>},{<{a{!!!>!!!!!e>}},{{<!>!>>}}}},{{},{{{<oi{ii!i!<!>>}}},{{<{!!!!!>!\"!!!>ei!!!>!!ao''',!!<aoeo>}}},{{{{<o'{!>},<!!\"ua<!!!!!!iiae!!!>>,{<,!>,<>,<}!>,<',!!!>},<,eeeu!>>}}},{<!!e!o,{!>}!!i!{a!>,<!>,<>}},{{},{}},{<!!!>,!>!>,<>,<>}}},{{{{{<\"!!!>u'a!!!>!!}!!!!!!,,>}}}},{{<!!!>u!>,<!>},<o<o!>},<a'{u!!!>u!,!>},<<>,<,,!>au!,!>!}a!>},<!o!>,<!>!!!>,<!>},<!!i>},{<!>},<\"u}!>},<!!e>,{}}},{<!>,<<u!!<o!!e!'u!>,<}!!!>!>,<'!>},<e'>}}}}},{{{<!o!!!>!>}iu>},{{{{},{<!!!!u<>}}},{{<!!!>a{o!uoa\"!>,<!!!>u{!!!>},<!!<}u}ao>}},{<,!>},<}!{>}},{<,!a\"}'>}},{{{{}},{{{{<!!!><>},{<\"!>},<!!ii!>!>,<>}}},{}},{{{<!o!!!>{i}!!!>>},<!>},<i!>,<\">},{}}},{{<!o!!\"!>!>,<e!>}\",!>},<<<<{i>}},{{<!!!>!i!>uu!!!>ee!!!>},<!'!!u{!!i!>},<a!!!>u>},<!!!!ou!!,o!!!\"}!>,<i!!!!a>}},{{{<>}},{{<!!a!>,<!a!!\"i!!!>!>!eo,!>,<!!!>>,<!{!><!>euu!!!>,<a!{!>},<!!!>e!,!'!!!>,!!!>>}}},{{<!!o!,}\">,<!>,'u!>,<\"!>,<\">}}},{{{<a<!!\"<>,{<<{o{!>!!eio!!!!!>},<e!!i,!>,<!,u>}},{}},{{<oie\"!>!>\"!>,<!>},<!!!>e!!a!!'e>,<o{!!o{!!!>!>{!>},<>},{{{<<!>,<ie!,,\"!!!>!!!>!!!>!!!><>,{<{e!!!!!>}ia!>},<eu!!!>},<}<!!,,i>,{<'{'!>},<'!>},<<<!!ea{!!!>'{i>,<ua!>},<>}}},{<!>,<'\"!>},<\"!'!!i!!u\"!!!!!!!!!>,!!!>>,<>}}},{<!!!>,<!a<}!>e!i!>''i!!!{oaa!!\">,<,<{!>,<!>},<!>,<<!>!<!{!}e!!!e\">}},{},{{{<!!uu!!!>,<{!>,<u!!\"a<u!>{'!!!>!>'!a!!e>}},{<}!!!>!!{{u!>},<eo\"'!>,<a}!>},<!,!!!a>,<o!!!}!>,<a!>a'e!>},<>}}}},{}}");
            #endregion
            #region 10
            Inputs.Add(10, "192,69,168,160,78,1,166,28,0,83,198,2,254,255,41,12");
            #endregion
            #region 11
            Inputs.Add(11, @"se,se,se,se,s,s,nw,s,sw,se,se,sw,sw,sw,se,nw,sw,nw,se,nw,nw,s,nw,nw,n,ne,n,n,sw,n,n,n,nw,n,ne,n,n,n,n,n,s,ne,se,nw,n,sw,n,n,ne,ne,n,n,s,n,n,n,ne,n,n,ne,ne,ne,ne,ne,ne,ne,sw,ne,nw,ne,se,ne,ne,se,ne,ne,sw,ne,nw,n,se,nw,se,ne,se,ne,nw,se,se,se,se,se,se,se,se,se,se,ne,ne,se,se,se,s,ne,se,se,se,se,s,ne,se,se,se,se,se,s,s,se,nw,se,se,s,s,se,s,se,s,se,ne,s,s,s,s,s,s,s,s,se,s,s,n,sw,s,s,s,n,s,s,sw,s,s,s,s,s,nw,s,s,sw,s,s,s,s,ne,s,sw,sw,sw,sw,se,nw,s,s,s,nw,s,s,sw,sw,sw,s,nw,sw,sw,s,s,s,nw,sw,se,sw,s,s,sw,sw,s,sw,ne,nw,nw,sw,sw,sw,se,sw,n,s,sw,s,sw,sw,sw,se,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,sw,nw,sw,sw,sw,sw,sw,sw,nw,sw,sw,nw,sw,sw,n,sw,sw,sw,nw,sw,sw,sw,sw,n,sw,nw,nw,sw,ne,nw,sw,nw,se,nw,nw,nw,ne,nw,nw,sw,sw,nw,n,sw,nw,sw,ne,nw,nw,nw,nw,n,nw,nw,nw,nw,ne,s,nw,nw,nw,sw,sw,ne,nw,s,n,s,sw,nw,nw,nw,nw,nw,sw,nw,nw,nw,nw,nw,nw,nw,nw,nw,sw,s,nw,nw,nw,nw,se,nw,nw,nw,sw,ne,nw,n,sw,nw,nw,nw,nw,nw,sw,nw,nw,nw,nw,nw,ne,nw,nw,nw,s,nw,nw,nw,nw,sw,n,nw,nw,nw,n,nw,nw,n,nw,nw,nw,nw,nw,nw,sw,nw,n,nw,nw,nw,nw,n,ne,n,nw,nw,nw,nw,n,nw,nw,nw,sw,s,nw,nw,n,n,n,nw,n,nw,nw,n,nw,ne,n,nw,n,n,n,nw,se,nw,s,ne,n,nw,n,sw,n,n,n,n,n,n,n,nw,n,s,sw,n,nw,n,ne,n,nw,n,n,nw,n,nw,se,nw,nw,n,s,n,n,n,nw,n,s,nw,n,n,n,n,sw,sw,n,n,n,sw,n,n,n,n,n,n,n,sw,ne,n,n,n,sw,n,n,n,nw,sw,n,n,n,n,s,n,n,n,n,ne,n,n,ne,n,n,n,n,n,n,se,se,n,n,ne,n,n,ne,ne,n,n,n,sw,n,n,ne,n,n,n,n,n,n,se,ne,ne,ne,ne,sw,ne,ne,nw,n,sw,n,n,n,s,n,se,n,n,n,ne,ne,n,sw,n,n,n,n,ne,ne,n,n,nw,ne,n,s,n,ne,ne,n,n,ne,n,ne,sw,ne,n,n,ne,ne,ne,n,ne,n,ne,ne,ne,n,ne,nw,n,ne,ne,n,n,sw,n,se,s,s,ne,ne,n,n,ne,ne,sw,n,se,ne,ne,n,n,sw,n,n,ne,n,ne,n,ne,ne,nw,n,n,n,n,n,ne,sw,ne,ne,ne,sw,ne,ne,ne,n,n,n,ne,ne,ne,ne,n,n,ne,ne,n,ne,ne,n,n,ne,ne,n,ne,ne,ne,ne,n,s,s,ne,ne,ne,ne,ne,ne,n,ne,s,ne,ne,ne,ne,ne,ne,ne,n,se,ne,ne,sw,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,se,ne,se,ne,ne,ne,ne,s,ne,se,nw,ne,nw,sw,sw,ne,ne,ne,n,ne,ne,ne,ne,s,ne,n,se,ne,s,ne,se,ne,ne,se,ne,s,se,nw,ne,ne,ne,s,n,se,ne,ne,se,ne,ne,se,se,ne,se,ne,se,se,ne,ne,n,ne,se,s,se,sw,n,s,se,ne,ne,ne,ne,se,ne,se,ne,ne,ne,se,ne,ne,ne,se,ne,ne,ne,ne,ne,ne,ne,ne,se,ne,sw,se,se,ne,ne,ne,ne,se,ne,se,se,ne,ne,se,se,se,se,ne,se,sw,ne,se,se,ne,se,ne,ne,ne,se,se,se,ne,se,se,ne,ne,ne,ne,s,ne,sw,se,ne,se,ne,se,se,sw,se,se,se,se,se,se,n,ne,ne,ne,se,se,ne,ne,ne,ne,n,sw,s,nw,ne,se,ne,se,ne,nw,nw,se,se,se,n,se,se,s,s,nw,ne,ne,nw,se,s,nw,s,se,ne,se,n,se,se,se,se,se,ne,se,sw,sw,ne,se,se,se,se,nw,se,ne,s,se,sw,se,se,ne,se,se,se,n,n,se,se,se,se,se,ne,se,se,se,se,se,se,se,se,se,ne,se,se,se,nw,se,se,nw,se,se,se,ne,se,se,se,ne,ne,se,se,se,se,ne,s,ne,se,s,sw,s,sw,s,se,se,ne,se,se,n,se,se,se,se,se,se,s,se,se,se,se,se,se,se,se,nw,se,se,nw,se,sw,se,se,s,se,s,se,se,se,se,se,n,se,se,nw,se,se,se,s,s,se,se,se,sw,se,se,se,se,sw,se,se,se,se,se,se,s,se,n,se,nw,se,sw,se,se,se,s,s,n,se,se,se,se,nw,s,se,se,se,se,se,se,s,se,se,se,se,s,ne,se,se,s,se,s,s,se,n,se,se,se,se,se,s,se,se,sw,se,se,se,se,ne,ne,se,nw,se,ne,se,s,se,se,se,sw,se,se,nw,s,n,se,se,s,sw,sw,sw,se,se,n,ne,n,nw,se,se,s,se,se,se,se,s,n,se,se,se,s,se,se,sw,se,s,se,ne,se,se,s,s,s,n,s,s,s,s,se,se,se,s,se,s,n,s,s,se,se,sw,se,s,se,sw,se,s,se,s,s,sw,n,sw,se,se,se,sw,s,se,s,se,se,s,sw,s,se,se,s,s,s,s,se,s,se,s,s,s,se,s,se,se,nw,s,n,s,se,s,se,ne,n,se,s,se,se,s,s,s,nw,s,se,se,se,s,sw,n,se,se,s,n,s,se,se,se,se,s,se,n,s,s,s,s,ne,s,s,se,se,se,s,s,s,s,s,s,se,s,s,s,s,s,s,se,s,sw,s,se,se,se,s,s,s,se,sw,nw,s,se,se,se,n,s,s,se,s,se,n,se,se,s,s,s,s,s,n,s,s,s,s,s,se,n,s,ne,s,sw,s,s,sw,nw,se,s,s,se,sw,s,s,s,s,s,s,s,se,s,s,se,ne,s,se,se,s,s,se,se,s,nw,ne,nw,ne,s,s,s,s,se,s,s,s,sw,s,s,ne,s,nw,s,s,ne,s,se,nw,ne,nw,s,s,se,s,s,s,s,s,ne,s,s,s,s,s,s,s,s,s,sw,ne,s,s,s,s,s,s,s,s,s,s,n,se,s,ne,s,s,n,s,s,s,s,nw,ne,s,s,s,s,s,se,s,s,s,se,s,s,sw,s,nw,s,s,s,s,s,s,s,s,s,s,nw,s,s,s,s,s,s,nw,s,nw,s,s,s,s,s,s,s,s,s,s,s,sw,s,n,s,s,s,s,s,nw,s,sw,sw,ne,n,nw,s,s,s,s,s,s,s,se,s,s,s,s,nw,nw,s,nw,s,s,s,sw,s,se,ne,s,s,s,s,s,s,ne,nw,s,s,s,s,n,n,nw,s,s,s,s,n,s,s,nw,s,s,ne,s,s,s,s,s,sw,s,sw,sw,sw,s,s,n,s,s,s,nw,s,s,ne,s,s,s,s,s,s,ne,sw,s,s,s,sw,s,s,se,s,s,s,s,s,s,sw,s,s,s,sw,nw,sw,sw,s,s,sw,s,s,s,s,nw,s,s,s,s,n,se,s,sw,nw,se,s,sw,s,sw,s,s,s,nw,s,s,s,s,sw,s,sw,s,s,s,s,s,se,s,s,sw,s,s,s,sw,s,ne,sw,s,sw,sw,sw,s,sw,ne,sw,se,s,sw,s,n,sw,ne,sw,s,s,s,s,sw,s,s,sw,s,sw,s,se,sw,se,n,s,s,ne,s,sw,s,sw,s,sw,sw,s,s,sw,n,s,s,sw,sw,s,sw,sw,se,s,s,sw,s,s,sw,sw,s,s,ne,s,s,ne,sw,n,sw,sw,sw,s,sw,s,sw,se,sw,s,n,s,s,s,sw,ne,s,s,s,sw,sw,sw,sw,sw,se,s,s,s,s,sw,nw,s,sw,s,s,s,s,ne,s,sw,sw,sw,sw,sw,n,sw,sw,se,sw,sw,s,nw,sw,s,s,s,sw,sw,s,n,sw,sw,s,sw,sw,s,s,sw,sw,sw,sw,s,ne,sw,s,s,s,sw,sw,sw,sw,s,ne,s,se,s,sw,s,sw,sw,s,nw,sw,s,s,sw,nw,sw,sw,sw,sw,ne,sw,sw,se,nw,sw,n,sw,se,sw,sw,sw,sw,s,sw,sw,ne,s,s,ne,sw,sw,sw,sw,s,sw,ne,nw,s,nw,sw,s,sw,sw,sw,sw,se,n,sw,s,sw,se,s,sw,se,sw,se,sw,n,s,sw,sw,nw,sw,nw,ne,sw,sw,sw,sw,sw,nw,sw,sw,nw,sw,sw,sw,sw,sw,n,sw,ne,sw,sw,sw,sw,sw,sw,s,sw,sw,sw,sw,sw,s,sw,sw,ne,s,sw,nw,sw,ne,n,sw,sw,sw,sw,s,s,sw,sw,sw,sw,se,ne,sw,sw,sw,nw,sw,sw,sw,s,sw,se,se,s,nw,sw,sw,sw,se,sw,sw,sw,sw,sw,s,sw,sw,sw,nw,sw,sw,s,sw,sw,se,sw,sw,s,nw,n,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,s,s,sw,s,s,se,sw,sw,ne,nw,sw,nw,s,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,sw,sw,s,sw,sw,sw,sw,s,sw,sw,sw,sw,sw,sw,se,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,se,sw,nw,sw,n,ne,sw,sw,ne,sw,sw,sw,sw,sw,sw,n,n,sw,sw,n,sw,sw,sw,sw,sw,ne,sw,sw,sw,sw,sw,sw,ne,s,sw,sw,n,sw,sw,sw,ne,n,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,se,sw,se,sw,ne,sw,sw,sw,nw,sw,s,sw,s,sw,sw,sw,sw,sw,sw,s,sw,nw,s,sw,sw,sw,sw,ne,sw,se,sw,sw,s,sw,sw,sw,nw,sw,sw,sw,s,sw,sw,nw,sw,sw,se,nw,sw,ne,nw,sw,se,sw,sw,sw,n,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,ne,sw,sw,nw,sw,sw,nw,nw,nw,nw,se,nw,sw,nw,sw,sw,nw,sw,nw,sw,nw,sw,sw,sw,sw,sw,sw,nw,nw,nw,sw,sw,sw,sw,nw,sw,sw,sw,sw,sw,sw,sw,sw,s,sw,nw,sw,nw,nw,nw,sw,sw,sw,sw,nw,sw,nw,sw,sw,sw,ne,nw,sw,nw,sw,sw,sw,nw,sw,sw,sw,sw,sw,nw,ne,s,nw,sw,nw,sw,sw,se,n,nw,sw,sw,sw,sw,se,nw,ne,sw,nw,s,sw,sw,nw,sw,sw,sw,nw,nw,nw,sw,s,sw,ne,ne,se,sw,n,nw,se,n,sw,ne,ne,sw,sw,sw,sw,sw,nw,sw,nw,nw,se,nw,nw,nw,sw,n,nw,sw,sw,sw,nw,nw,n,nw,se,sw,sw,nw,sw,nw,sw,nw,nw,se,sw,n,nw,sw,se,sw,nw,sw,nw,sw,sw,sw,ne,sw,sw,sw,nw,sw,n,ne,ne,se,sw,sw,s,sw,sw,sw,sw,nw,sw,sw,s,sw,s,sw,n,s,sw,nw,sw,nw,nw,s,nw,sw,sw,sw,sw,sw,ne,nw,sw,sw,nw,sw,s,nw,sw,s,nw,ne,nw,sw,s,nw,sw,nw,n,n,nw,nw,nw,sw,sw,sw,nw,sw,sw,sw,nw,sw,ne,sw,nw,sw,sw,nw,sw,nw,sw,se,nw,nw,sw,nw,nw,sw,n,sw,nw,ne,sw,s,sw,s,sw,nw,sw,sw,nw,nw,s,sw,n,nw,nw,sw,nw,nw,sw,sw,nw,se,sw,sw,sw,nw,nw,nw,sw,nw,sw,nw,nw,sw,nw,ne,nw,nw,s,n,nw,nw,s,sw,nw,sw,sw,sw,nw,nw,nw,nw,sw,sw,sw,s,sw,nw,nw,sw,s,sw,nw,nw,nw,nw,nw,se,nw,sw,nw,sw,sw,ne,sw,se,nw,nw,nw,nw,sw,nw,sw,sw,nw,sw,nw,nw,ne,nw,sw,nw,sw,nw,nw,sw,nw,sw,s,sw,n,n,nw,nw,nw,ne,nw,n,nw,nw,nw,nw,nw,sw,sw,nw,nw,nw,sw,ne,se,nw,nw,sw,ne,nw,sw,nw,nw,nw,nw,nw,sw,sw,sw,sw,ne,nw,nw,ne,nw,sw,nw,sw,sw,sw,nw,nw,sw,nw,nw,nw,nw,nw,n,sw,nw,nw,nw,nw,nw,nw,n,sw,se,sw,nw,nw,nw,nw,nw,nw,nw,sw,sw,sw,nw,sw,nw,nw,nw,nw,s,s,se,nw,n,nw,nw,n,nw,sw,nw,sw,nw,s,nw,n,sw,se,sw,nw,nw,nw,nw,s,nw,nw,nw,sw,se,ne,nw,se,sw,sw,ne,nw,nw,ne,nw,sw,n,sw,sw,s,nw,n,n,se,nw,nw,nw,n,nw,nw,nw,s,nw,sw,nw,sw,nw,ne,sw,nw,s,nw,se,nw,se,nw,s,ne,sw,nw,nw,sw,nw,n,nw,nw,nw,nw,nw,s,nw,nw,sw,nw,sw,ne,ne,nw,nw,nw,ne,nw,nw,nw,ne,nw,nw,sw,s,nw,nw,nw,nw,nw,nw,nw,nw,sw,sw,sw,nw,nw,nw,nw,ne,nw,nw,nw,ne,nw,nw,sw,nw,nw,ne,nw,nw,nw,nw,nw,sw,sw,n,ne,nw,ne,s,sw,nw,s,nw,n,nw,ne,s,nw,nw,nw,nw,nw,nw,nw,nw,se,nw,nw,nw,sw,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,sw,nw,nw,nw,nw,nw,nw,se,nw,nw,nw,nw,nw,nw,nw,nw,se,nw,se,n,nw,nw,nw,se,nw,nw,nw,nw,n,se,nw,sw,s,sw,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,se,s,se,nw,nw,nw,nw,nw,nw,s,nw,nw,nw,n,nw,nw,nw,nw,nw,nw,nw,se,nw,nw,nw,nw,se,nw,nw,nw,ne,sw,nw,se,nw,nw,nw,nw,sw,nw,nw,nw,nw,nw,nw,nw,nw,nw,ne,n,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,se,nw,se,nw,nw,n,sw,nw,nw,s,nw,nw,n,nw,nw,nw,nw,se,nw,se,nw,ne,nw,nw,nw,nw,nw,nw,n,nw,nw,nw,nw,nw,sw,nw,n,nw,sw,nw,nw,ne,se,nw,nw,nw,nw,se,se,nw,nw,nw,nw,nw,n,se,nw,nw,nw,nw,nw,nw,n,nw,nw,nw,ne,nw,nw,nw,nw,nw,ne,nw,nw,n,ne,nw,nw,s,nw,nw,se,nw,nw,nw,nw,ne,nw,nw,nw,se,nw,nw,s,nw,nw,sw,s,nw,nw,nw,nw,nw,nw,se,nw,nw,nw,nw,nw,s,nw,nw,nw,nw,nw,nw,s,ne,n,nw,n,nw,sw,nw,nw,nw,s,nw,nw,sw,nw,n,nw,nw,nw,ne,se,nw,ne,nw,nw,nw,n,sw,se,nw,nw,nw,n,ne,nw,n,sw,se,n,nw,se,nw,nw,nw,n,s,sw,nw,sw,nw,nw,ne,nw,n,nw,nw,nw,nw,n,nw,nw,nw,n,nw,nw,sw,nw,nw,n,n,nw,nw,se,n,se,sw,nw,s,nw,sw,s,nw,nw,s,nw,nw,nw,n,ne,n,nw,nw,nw,nw,n,ne,nw,nw,nw,nw,nw,n,nw,nw,sw,nw,s,n,nw,nw,s,nw,nw,nw,nw,n,se,nw,nw,nw,s,n,nw,nw,sw,nw,nw,nw,n,n,nw,nw,n,n,nw,nw,nw,nw,nw,n,nw,n,nw,ne,n,nw,ne,nw,nw,nw,nw,n,nw,nw,nw,nw,nw,n,sw,nw,n,nw,se,n,nw,nw,ne,nw,nw,nw,nw,nw,nw,nw,ne,n,n,nw,nw,nw,n,n,n,nw,s,nw,s,nw,nw,nw,nw,n,n,nw,nw,nw,sw,nw,nw,n,nw,nw,n,n,nw,n,n,sw,nw,nw,se,nw,n,n,nw,nw,nw,n,n,nw,nw,n,nw,nw,se,nw,n,n,nw,se,n,nw,s,nw,sw,nw,nw,n,nw,sw,n,s,nw,n,nw,n,ne,n,nw,se,nw,nw,nw,sw,n,sw,nw,nw,n,nw,n,nw,n,n,s,nw,nw,n,n,n,nw,nw,nw,n,sw,nw,nw,s,n,nw,n,ne,se,nw,sw,n,n,nw,nw,n,nw,s,nw,nw,nw,nw,sw,nw,nw,n,nw,n,se,nw,ne,sw,n,n,nw,n,nw,nw,nw,sw,nw,n,s,n,nw,n,n,nw,nw,nw,s,sw,nw,n,nw,nw,nw,ne,n,se,sw,se,n,nw,nw,nw,n,s,nw,n,sw,n,nw,n,nw,n,n,ne,n,n,sw,n,n,n,n,ne,n,nw,se,se,nw,se,n,nw,n,nw,nw,n,nw,n,n,n,ne,nw,nw,nw,nw,se,sw,nw,n,n,se,se,n,n,s,nw,nw,nw,nw,n,n,n,se,nw,nw,n,n,n,sw,s,se,nw,nw,s,nw,nw,n,nw,n,n,nw,n,se,nw,nw,n,nw,ne,nw,nw,n,s,se,n,nw,sw,n,se,nw,n,s,n,nw,n,nw,ne,n,n,n,ne,n,nw,n,s,n,ne,nw,ne,n,nw,nw,n,n,n,n,nw,n,nw,nw,n,s,n,n,nw,s,nw,nw,se,se,nw,nw,n,nw,n,n,n,n,n,n,s,ne,n,nw,n,nw,n,sw,n,n,n,n,n,se,n,nw,nw,n,se,nw,nw,sw,n,n,n,n,nw,n,n,nw,nw,nw,se,n,n,se,nw,n,n,s,n,nw,n,se,n,s,nw,n,n,nw,s,n,n,n,s,nw,n,se,n,sw,n,n,n,n,s,nw,n,n,n,ne,nw,n,n,n,n,s,se,nw,nw,n,n,n,ne,n,sw,nw,n,s,sw,s,n,n,se,n,n,nw,n,nw,sw,n,n,nw,n,nw,nw,n,ne,ne,n,n,n,n,n,ne,nw,n,n,sw,ne,n,n,nw,ne,nw,n,n,n,se,nw,n,n,n,n,nw,n,sw,n,n,nw,nw,n,n,n,n,n,n,nw,n,n,n,se,nw,sw,n,nw,n,sw,n,nw,nw,s,n,se,n,s,nw,n,s,s,n,n,s,nw,n,n,n,nw,n,nw,n,ne,n,nw,nw,n,n,nw,nw,nw,n,n,n,n,n,se,n,n,sw,n,n,n,n,n,se,nw,ne,n,s,n,n,n,sw,n,n,sw,se,sw,n,n,n,nw,s,nw,n,n,se,n,se,n,nw,n,n,n,s,n,n,nw,nw,s,n,n,sw,n,nw,se,se,s,n,nw,ne,nw,n,nw,n,nw,nw,n,n,nw,nw,n,nw,nw,s,n,n,n,n,n,n,n,n,n,n,n,n,se,se,s,n,n,n,n,n,sw,n,nw,n,n,ne,n,nw,n,sw,n,n,nw,nw,s,n,n,n,n,s,s,n,n,sw,nw,n,nw,n,n,sw,n,n,se,nw,n,s,n,s,n,n,ne,nw,n,sw,n,n,sw,n,n,n,se,n,n,sw,nw,n,nw,n,se,n,sw,n,n,nw,n,n,sw,n,n,ne,se,n,n,n,n,nw,nw,n,n,n,n,se,n,n,n,n,n,n,n,n,nw,n,ne,nw,nw,n,n,nw,n,n,n,se,sw,n,nw,n,n,n,n,n,n,sw,n,n,n,n,n,n,n,n,n,n,ne,n,n,n,n,s,sw,ne,n,nw,nw,nw,n,n,s,n,se,n,n,nw,n,n,n,n,n,n,nw,n,ne,n,n,n,sw,n,n,ne,n,n,se,n,n,n,sw,nw,n,n,n,n,n,n,n,n,n,se,nw,n,n,ne,nw,n,sw,n,sw,n,n,n,se,sw,sw,n,n,n,nw,s,nw,n,s,sw,n,n,n,s,n,n,n,sw,n,n,s,n,nw,n,n,n,s,sw,ne,ne,n,n,n,n,s,s,n,se,n,n,s,n,n,n,n,n,n,n,n,n,sw,n,n,n,n,n,n,n,nw,n,n,n,n,n,n,n,n,n,sw,n,s,ne,s,n,n,n,se,n,n,n,ne,n,n,sw,n,s,s,n,n,nw,n,n,n,ne,n,n,n,n,sw,n,n,n,n,n,n,n,n,n,n,nw,n,n,se,n,sw,n,n,n,n,s,n,ne,s,ne,n,nw,n,n,sw,nw,n,ne,nw,nw,n,n,n,n,se,sw,se,n,n,n,n,n,n,n,n,s,n,n,n,ne,n,n,nw,n,n,n,n,n,n,n,s,sw,n,se,ne,n,n,ne,n,n,n,n,se,n,ne,n,n,n,ne,nw,n,n,n,n,n,n,n,n,n,n,n,n,n,s,ne,n,n,n,n,n,ne,ne,s,n,n,se,se,n,n,ne,ne,n,n,n,n,s,n,n,n,n,n,n,se,s,n,sw,n,n,n,n,n,n,sw,n,n,sw,sw,n,n,ne,s,n,sw,n,n,n,n,s,s,se,n,n,sw,n,n,n,n,s,n,se,ne,nw,n,n,n,n,nw,n,n,n,n,nw,ne,sw,n,n,n,n,ne,n,ne,n,n,n,n,n,n,n,ne,ne,n,n,sw,ne,n,ne,ne,nw,sw,n,n,sw,ne,n,n,ne,n,ne,n,n,n,ne,ne,n,n,n,n,n,n,n,n,n,ne,n,n,n,n,n,s,ne,ne,n,n,n,ne,n,n,n,sw,n,ne,nw,n,n,ne,n,sw,n,s,ne,n,n,n,se,n,n,n,nw,sw,s,ne,s,n,n,n,ne,se,n,n,n,n,nw,n,n,n,ne,n,n,n,n,n,ne,n,n,ne,sw,n,n,n,n,ne,n,n,ne,n,ne,nw,n,nw,n,sw,n,n,nw,nw,ne,se,ne,n,n,ne,ne,nw,nw,ne,n,s,ne,n,n,sw,nw,n,sw,ne,n,n,ne,ne,n,n,n,n,n,ne,n,n,n,n,ne,n,n,ne,se,n,se,n,n,s,sw,ne,n,n,n,n,nw,ne,nw,nw,n,n,ne,n,n,s,nw,n,n,n,n,n,n,ne,n,ne,s,n,se,n,n,n,ne,se,n,nw,nw,n,sw,n,n,ne,ne,n,n,sw,n,n,ne,n,n,n,ne,se,n,n,n,n,n,n,sw,ne,ne,n,ne,n,ne,se,sw,ne,n,ne,n,ne,ne,ne,sw,se,n,n,nw,n,n,ne,n,n,n,ne,n,se,s,n,ne,s,n,se,n,ne,ne,n,ne,ne,s,se,n,n,n,ne,n,n,ne,sw,n,n,s,ne,n,n,ne,n,n,n,nw,ne,ne,ne,n,n,nw,n,ne,sw,ne,n,n,s,ne,n,n,ne,nw,ne,n,ne,ne,n,nw,n,ne,n,nw,n,nw,n,n,n,se,n,ne,se,n,ne,ne,ne,sw,n,se,ne,n,n,n,sw,ne,ne,nw,s,n,s,n,n,n,n,ne,ne,ne,n,ne,ne,n,sw,nw,n,n,ne,n,n,nw,ne,ne,n,n,n,n,nw,sw,n,n,nw,n,nw,s,sw,n,sw,nw,se,ne,ne,n,ne,nw,n,s,n,ne,n,n,n,n,sw,ne,ne,n,n,ne,n,ne,sw,n,s,sw,n,ne,ne,nw,se,n,n,n,n,n,n,ne,n,n,ne,ne,ne,n,nw,n,n,ne,nw,ne,n,s,ne,n,ne,n,n,ne,se,ne,ne,ne,n,sw,ne,n,ne,n,ne,n,ne,n,ne,n,n,s,ne,ne,ne,ne,n,n,n,s,n,s,ne,nw,n,ne,ne,n,ne,ne,ne,n,nw,n,n,ne,n,ne,se,sw,sw,n,ne,ne,n,n,n,ne,n,n,n,ne,se,ne,n,n,n,n,ne,ne,n,n,ne,n,ne,n,n,n,n,ne,ne,n,s,ne,ne,s,ne,sw,n,n,ne,n,ne,ne,ne,nw,ne,s,n,ne,ne,n,s,n,ne,ne,n,n,ne,n,se,n,sw,ne,n,n,s,n,s,s,ne,sw,nw,sw,ne,s,ne,s,ne,n,nw,ne,s,ne,n,nw,n,n,ne,ne,n,n,ne,ne,n,ne,nw,se,s,n,n,sw,se,n,n,sw,ne,ne,n,ne,ne,ne,ne,ne,n,ne,n,ne,ne,ne,ne,ne,n,n,sw,n,ne,ne,ne,ne,ne,ne,ne,n,sw,ne,n,ne,ne,ne,n,ne,ne,ne,ne,s,n,se,ne,n,n,sw,n,ne,n,n,sw,n,ne,n,s,n,sw,ne,ne,ne,nw,ne,s,n,ne,ne,ne,ne,ne,ne,ne,ne,ne,sw,sw,ne,ne,sw,n,se,ne,s,ne,ne,ne,nw,ne,ne,ne,n,n,ne,ne,n,ne,ne,ne,ne,ne,se,n,n,s,ne,nw,s,ne,n,nw,n,n,ne,ne,n,s,sw,ne,ne,sw,n,ne,ne,ne,n,ne,nw,n,nw,ne,ne,se,se,nw,ne,ne,nw,n,sw,ne,ne,n,ne,ne,ne,se,ne,ne,sw,ne,ne,n,n,ne,nw,ne,n,sw,ne,ne,n,ne,ne,s,n,ne,n,ne,ne,n,sw,n,n,ne,ne,n,se,ne,sw,n,ne,ne,n,ne,ne,ne,n,ne,ne,nw,n,ne,ne,ne,s,n,ne,ne,ne,ne,ne,nw,se,nw,ne,n,se,ne,ne,n,ne,ne,ne,sw,ne,ne,n,ne,ne,ne,ne,ne,ne,n,ne,sw,ne,n,ne,n,ne,n,n,ne,n,ne,ne,se,ne,ne,n,ne,n,ne,ne,se,ne,n,ne,n,sw,ne,n,n,ne,ne,ne,ne,ne,n,ne,ne,nw,n,sw,ne,n,ne,sw,se,s,ne,n,n,sw,ne,ne,ne,nw,ne,sw,n,ne,ne,n,n,ne,nw,n,ne,s,ne,ne,ne,n,n,n,n,ne,ne,se,ne,n,ne,n,ne,ne,ne,n,n,ne,ne,ne,ne,ne,sw,se,n,n,nw,ne,ne,ne,ne,s,ne,ne,ne,nw,ne,ne,ne,n,se,ne,ne,ne,ne,sw,ne,n,ne,se,ne,ne,ne,se,sw,n,n,ne,ne,ne,ne,ne,n,ne,se,ne,s,n,ne,se,n,ne,ne,ne,ne,ne,ne,ne,ne,n,n,n,ne,ne,ne,ne,ne,ne,sw,s,se,n,se,nw,nw,ne,nw,ne,n,se,ne,ne,s,ne,ne,n,ne,n,ne,nw,ne,ne,ne,se,n,s,ne,s,n,ne,ne,ne,s,ne,ne,ne,ne,se,ne,ne,se,ne,n,ne,nw,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,n,ne,n,ne,ne,n,ne,ne,ne,ne,se,n,s,n,ne,ne,ne,ne,ne,se,s,ne,ne,ne,s,n,ne,se,ne,s,ne,ne,ne,nw,nw,ne,s,ne,se,ne,ne,ne,ne,ne,ne,ne,ne,n,ne,ne,ne,se,ne,n,ne,ne,ne,se,ne,n,ne,ne,ne,ne,ne,se,ne,se,n,n,sw,ne,n,ne,ne,se,ne,ne,ne,ne,n,ne,nw,nw,ne,ne,sw,nw,ne,ne,ne,se,ne,ne,n,nw,s,ne,nw,n,ne,ne,ne,ne,ne,ne,ne,ne,ne,n,s,ne,ne,ne,ne,ne,nw,nw,ne,ne,ne,n,se,ne,ne,ne,ne,ne,ne,ne,se,ne,sw,ne,ne,ne,ne,n,ne,se,nw,ne,ne,ne,se,ne,ne,ne,ne,ne,s,ne,ne,ne,ne,ne,ne,ne,ne,n,s,nw,ne,se,n,s,ne,ne,ne,ne,nw,ne,ne,ne,ne,ne,s,ne,nw,ne,ne,ne,ne,ne,s,n,nw,ne,ne,ne,nw,n,se,ne,n,ne,n,se,nw,ne,sw,ne,ne,ne,nw,ne,ne,ne,ne,ne,ne,ne,ne,ne,se,ne,ne,ne,ne,ne,ne,n,ne,ne,ne,nw,ne,ne,ne,ne,se,s,se,ne,ne,ne,ne,ne,ne,ne,ne,nw,ne,ne,ne,nw,ne,ne,ne,ne,ne,ne,ne,sw,n,ne,ne,ne,ne,sw,ne,s,se,ne,ne,n,se,s,n,sw,n,sw,sw,nw,s,s,se,n,s,se,se,se,se,s,n,se,se,se,se,se,se,s,se,ne,ne,ne,se,ne,ne,ne,ne,se,ne,ne,ne,nw,n,ne,nw,nw,n,n,sw,ne,sw,n,ne,ne,n,n,n,ne,n,n,nw,n,se,n,n,nw,nw,n,nw,n,s,nw,sw,nw,n,n,sw,nw,n,n,nw,s,nw,n,n,n,nw,se,nw,nw,nw,n,nw,nw,nw,nw,nw,ne,sw,n,nw,sw,sw,sw,nw,s,nw,nw,nw,nw,s,sw,nw,se,sw,nw,sw,nw,sw,se,se,se,nw,sw,s,sw,sw,nw,nw,nw,nw,sw,nw,s,nw,sw,nw,ne,sw,ne,sw,sw,sw,sw,sw,s,sw,sw,sw,sw,n,n,sw,sw,sw,sw,s,s,sw,sw,n,sw,sw,sw,sw,sw,se,sw,sw,sw,s,sw,sw,sw,sw,nw,sw,sw,se,s,se,se,s,sw,sw,sw,sw,sw,sw,sw,ne,ne,sw,s,sw,sw,ne,sw,s,sw,s,s,sw,nw,s,s,s,sw,s,s,s,n,s,s,s,s,s,sw,s,n,s,s,s,s,s,s,s,s,nw,s,s,sw,s,s,s,s,s,s,s,ne,s,n,n,s,s,s,se,sw,s,n,s,s,se,s,sw,s,s,se,se,se,se,s,sw,n,s,se,s,s,s,nw,se,se,ne,sw,s,sw,s,se,se,s,nw,se,s,sw,s,se,se,se,s,s,s,se,n,s,se,s,se,se,se,n,se,se,se,se,se,se,se,se,se,s,se,se,s,se,se,se,se,se,se,ne,se,se,se,nw,sw,se,se,se,se,nw,se,se,se,n,se,se,se,se,sw,ne,se,s,se,sw,se,se,sw,nw,se,se,nw,ne,se,s,ne,se,s,se,ne,se,se,se,ne,se,se,se,s,s,ne,se,nw,se,ne,se,ne,se,nw,se,se,n,se,se,se,se,se,ne,se,n,ne,ne,ne,se,ne,s,se,se,se,ne,sw,se,se,se,se,se,se,ne,sw,se,ne,ne,se,ne,se,ne,nw,ne,ne,se,ne,ne,s,n,ne,s,ne,ne,se,se,s,ne,nw,se,ne,se,ne,ne,ne,ne,ne,ne,se,nw,se,se,ne,s,ne,ne,ne,ne,ne,se,ne,ne,n,se,ne,n,ne,ne,ne,se,ne,ne,ne,s,se,nw,nw,ne,ne,sw,ne,ne,ne,se,ne,ne,ne,sw,sw,se,ne,ne,nw,ne,n,ne,ne,ne,ne,n,sw,ne,ne,ne,se,ne,ne,ne,ne,ne,ne,n,ne,ne,ne,ne,ne,ne,se,ne,n,ne,ne,se,ne,ne,ne,n,ne,sw,ne,ne,n,ne,ne,ne,ne,s,ne,ne,nw,nw,ne,ne,ne,n,ne,ne,sw,ne,ne,ne,ne,ne,ne,n,ne,n,sw,n,ne,nw,n,ne,n,ne,ne,n,ne,n,ne,ne,ne,n,ne,n,se,n,ne,n,ne,n,ne,n,n,ne,ne,n,n,n,n,n,s,ne,n,n,nw,n,n,n,se,ne,n,n,n,s,ne,n,nw,n,n,n,s,ne,n,se,ne,ne,nw,n,n,n,se,n,n,n,n,nw,ne,n,n,n,n,n,s,n,n,ne,ne,n,ne,n,n,se,s,n,s,n,nw,n,s,ne,se,n,n,n,se,ne,nw,nw,se,se,n,n,n,sw,n,n,n,n,n,se,n,n,n,s,nw,s,n,n,n,n,n,nw,ne,n,n,n,ne,n,se,n,n,n,nw,n,n,n,se,n,n,n,n,n,n,n,n,s,n,n,se,n,n,n,se,n,n,n,nw,n,nw,nw,s,n,n,n,n,n,n,n,n,n,n,nw,n,n,n,n,n,s,nw,s,n,n,n,n,n,n,ne,n,n,n,s,n,n,nw,nw,n,nw,n,n,n,nw,s,n,n,n,sw,ne,nw,n,n,n,n,n,n,nw,n,n,n,n,n,nw,n,n,ne,n,n,nw,nw,nw,ne,n,n,nw,n,n,n,n,ne,s,n,n,n,n,n,n,n,nw,se,s,n,s,n,se,nw,n,n,nw,nw,s,nw,nw,n,nw,s,n,n,n,n,n,nw,nw,nw,n,nw,nw,n,nw,nw,n,sw,n,nw,nw,nw,se,nw,nw,n,nw,nw,n,nw,s,sw,se,nw,n,nw,nw,nw,sw,nw,se,nw,nw,n,nw,n,se,sw,nw,nw,n,n,nw,s,nw,nw,nw,nw,n,sw,nw,sw,nw,nw,n,nw,n,nw,nw,nw,nw,s,nw,nw,nw,n,n,nw,nw,nw,sw,nw,nw,ne,nw,nw,nw,n,nw,n,nw,n,ne,n,nw,nw,nw,n,n,nw,n,nw,nw,nw,nw,nw,nw,n,nw,ne,nw,nw,n,se,nw,nw,ne,n,nw,nw,n,nw,se,nw,nw,nw,nw,n,sw,nw,nw,n,nw,nw,nw,nw,nw,nw,n,nw,n,nw,nw,nw,nw,nw,n,nw,nw,nw,s,nw,n,nw,nw,ne,s,nw,nw,nw,nw,nw,nw,nw,nw,n,nw,nw,nw,n,s,n,nw,nw,nw,nw,sw,sw,nw,nw,nw,nw,nw,nw,nw,nw,nw,sw,sw,nw,nw,n,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,ne,nw,nw,nw,ne,nw,sw,se,nw,nw,nw,nw,nw,nw,nw,se,nw,ne,nw,nw,nw,se,nw,nw,nw,sw,nw,nw,nw,nw,se,sw,sw,nw,sw,s,sw,nw,nw,sw,ne,sw,nw,nw,nw,sw,se,nw,ne,nw,nw,s,nw,nw,nw,sw,sw,sw,nw,nw,sw,nw,nw,nw,ne,ne,nw,nw,nw,se,sw,sw,s,s,nw,nw,sw,nw,ne,s,nw,nw,sw,sw,nw,ne,nw,sw,nw,sw,se,nw,s,nw,nw,nw,nw,sw,sw,sw,nw,nw,sw,nw,s,nw,sw,sw,sw,se,nw,nw,sw,nw,s,nw,nw,nw,n,nw,nw,sw,s,s,nw,nw,sw,sw,sw,sw,nw,nw,sw,nw,sw,sw,sw,sw,se,nw,sw,nw,s,nw,nw,sw,nw,sw,nw,se,nw,nw,nw,sw,nw,nw,n,sw,sw,nw,sw,sw,nw,sw,ne,sw,sw,nw,sw,sw,ne,nw,sw,sw,nw,nw,ne,n,sw,sw,sw,n,sw,sw,nw,n,nw,ne,ne,nw,nw,nw,sw,sw,se,sw,s,sw,nw,sw,sw,se,n,sw,nw,nw,n,sw,sw,sw,s,ne,nw,nw,sw,sw,n,n,sw,nw,sw,s,nw,nw,sw,nw,nw,sw,nw,s,sw,sw,nw,sw,nw,sw,sw,n,s,sw,nw,sw,nw,n,sw,nw,sw,nw,sw,s,sw,sw,sw,sw,se,s,sw,sw,nw,sw,sw,nw,se,sw,sw,ne,nw,n,sw,nw,sw,sw,sw,sw,sw,nw,sw,sw,sw,n,s,nw,nw,se,sw,sw,n,nw,nw,nw,sw,se,ne,sw,sw,se,sw,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,n,nw,sw,sw,sw,se,sw,sw,sw,sw,ne,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,nw,ne,sw,sw,sw,nw,sw,nw,n,sw,sw,sw,sw,sw,sw,sw,sw,sw,n,sw,sw,sw,sw,sw,se,sw,sw,n,sw,sw,sw,se,sw,sw,sw,sw,sw,ne,sw,sw,s,nw,sw,s,sw,sw,sw,ne,sw,sw,sw,sw,s,sw,sw,sw,sw,sw,sw,sw,n,sw,sw,ne,nw,sw,s,sw,sw,sw,sw,sw,n,s,sw,s,sw,s,sw,sw,sw,nw,nw,sw,s,sw,sw,sw,sw,sw,sw,n,sw,sw,sw,sw,s,sw,sw,sw,s,s,ne,sw,ne,sw,se,ne,sw,sw,nw,s,s,sw,nw,sw,sw,sw,se,se,sw,sw,sw,sw,sw,sw,sw,se,sw,sw,ne,sw,sw,s,sw,sw,sw,sw,sw,s,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,s,sw,sw,sw,ne,se,sw,sw,sw,sw,s,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,ne,sw,sw,s,nw,s,sw,sw,se,sw,n,sw,sw,s,sw,sw,ne,sw,sw,sw,s,sw,sw,n,s,s,s,sw,sw,sw,sw,sw,sw,sw,sw,s,sw,ne,sw,sw,sw,s,nw,sw,sw,s,s,sw,sw,sw,sw,sw,s,sw,sw,n,n,sw,nw,s,sw,sw,sw,se,s,sw,sw,s,s,s,sw,sw,n,se,sw,sw,sw,sw,s,sw,sw,sw,s,nw,sw,sw,sw,s,s,s,sw,sw,sw,s,s,sw,sw,s,s,sw,n,sw,s,s,s,se,sw,sw,ne,sw,sw,s,sw,nw,s,sw,sw,s,s,sw,s,s,sw,se,s,ne,sw,se,sw,s,s,s,sw,sw,s,sw,sw,s,n,n,s,sw,nw,s,sw,sw,nw,nw,s,sw,n,ne,s,s,ne,nw,sw,sw,ne,sw,sw,n,s,sw,ne,s,s,s,sw,s,s,nw,sw,sw,s,n,nw,sw,sw,sw,sw,s,s,sw,n,sw,s,sw,sw,s,n,sw,sw,s,s,sw,s,s,sw,sw,s,ne,n,sw,ne,sw,s,ne,s,s,s,sw,sw,n,s,s,sw,se,s,s,s,s,n,s,s,ne,s,nw,s,nw,s,s,nw,s,se,s,sw,s,s,n,s,s,s,s,s,nw,s,nw,s,sw,s,s,s,sw,s,sw,s,sw,sw,sw,sw,sw,ne,s,s,sw,se,ne,sw,nw,s,sw,sw,s,s,sw,se,se,se,s,sw,s,s,s,s,se,sw,s,se,sw,s,s,sw,sw,s,sw,nw,n,s,s,s,s,s,sw,sw,s,ne,s,s,s,s,s,s,s,s,s,nw,s,s,s,s,s,sw,n,s,nw,sw,se,nw,s,se,s,sw,s,sw,s,s,sw,sw,s,s,sw,sw,s,n,s,s,s,s,s,se,se,sw,s,s,s,s,ne,sw,nw,s,s,sw,s,s,sw,s,s,nw,s,s,s,se,sw,s,sw,ne,s,sw,s,s,nw,s,nw,s,s,s,se,sw,sw,s,s,s,s,s,s,nw,s,sw,s,s,s,s,s,s,s,ne,s,s,s,s,se,s,s,s,ne,s,s,s,se,ne,s,s,s,s,s,sw,ne,ne,s,s,ne,s,s,s,s,s,s,s,s,s,s,s,s,se,s,s,s,n,s,s,s,s,nw,s,nw,nw,s,s,ne,s,se,s,s,nw,s,s,s,se,se,s,s,sw,s,n,s,sw,s,s,ne,s,s,sw,se,ne,s,s,n,s,s,ne,s,ne,s,s,s,s,s,s,s,se,s,nw,ne,s,n,sw,s,s,se,se,s,s,s,s,n,s,se,s,s,s,se,s,s,s,se,sw,s,nw,nw,s,s,s,s,s,s,s,s,s,nw,se,s,sw,s,s,s,s,s,s,s,s,s,ne,s,se,s,s,sw,s,ne,s,se,se,se,s,s,sw,sw,s,s,s,n,s,s,se,s,s,ne,s,s,s,s,se,s,s,s,se,se,s,n,s,s,s,se,s,s,nw,s,s,s,s,ne,s,n,n,s,ne,s,se,s,s,s,s,s,se,nw,ne,s,nw,ne,se,n,s,se,s,s,s,s,s,s,se,ne,s,nw,s,s,n,se,se,se,s,s,se,se,s,s,s,se,se,se,n,s,s,s,se,s,s,se,ne,s,s,sw,sw,nw,s,se,se,se,nw,se,s,s,s,s,se,n,s,s,se,s,se,se,se,s,s,se,s,se,s,s,s,s,s,s,s,s,se,se,se,s,s,se,s,se,s,s,s,s,s,se,s,s,ne,s,s,se,s,s,se,ne,s,sw,s,s,s,s,se,se,ne,s,s,nw,se,sw,s,se,s,nw,s,s,ne,se,s,s,s,s,se,se,se,sw,se,se,s,nw,sw,s,s,ne,se,s,n,se,se,se,s,s,se,s,sw,s,se,s,se,se,s,s,sw,se,s,se,ne,sw,n,se,s,s,sw,se,nw,s,se,s,se,se,s,se,sw,s,nw,se,s,se,se,se,se,s,se,s,s,se,s,se,s,s,s,n,ne,se,se,s,se,s,s,nw,se,se,s,se,s,s,s,se,s,s,se,se,s,s,s,se,se,sw,s,n,se,se,se,s,s,s,sw,s,s,sw,s,n,s,se,se,s,s,se,s,s,se,s,se,s,s,ne,n,se,s,sw,s,s,se,ne,s,s,s,se,s,se,nw,s,s,s,se,se,nw,se,s,ne,s,ne,se,s,se,n,s,se,s,se,se,se,s,se,s,se,s,ne,nw,se,sw,ne,ne,se,s,s,s,s,se,s,nw,s,se,se,s,se,se,se,sw,se,nw,n,s,se,s,n,nw,n,se,s,se,nw,ne,se,ne,se,s,se,se,se,s,sw,n,s,sw,s,s,s,se,se,ne,se,se,sw,s,se,sw,sw,se,s,s,se,nw,se,se,se,ne,se,ne,s,se,se,se,se,ne,s,s,nw,s,ne,se,se,s,s,se,se,se,se,s,s,se,nw,se,s,se,se,se,se,s,s,n,ne,se,ne,s,sw,se,s,sw,se,se,se,se,s,se,se,se,se,se,se,se,se,s,se,s,s,s,s,se,se,se,se,se,s,n,se,s,se,n,sw,sw,se,se,se,se,ne,s,s,ne,s,se,se,se,s,sw,se,se,s,sw,se,se,se,se,se,se,s,n,se,sw,se,n,sw,se,s,se,s,se,se,sw,se,se,se,se,se,s,se,se,se,se,se,se,se,se,se,n,ne,s,ne,se,se,se,ne,se,n,n,se,sw,se,se,s,se,se,se,se,n,ne,se,se,s,n,se,se,n,se,se,sw,nw,s,se,se,se,se,se,se,se,se,se,se,se,se,nw,s,n,se,se,ne,se,se,se,ne,se,se,se,n,n,se,sw,se,se,s,se,se,s,se,sw,se,se,sw,ne,se,se,se,se,sw,se,se,se,se,se,ne,se,se,se,se,se,se,se,se,s,se,n,sw,ne,se,se,se,se,n,se,se,nw,se,nw,se,se,ne,ne,se,se,se,se,s,se,sw,se,ne,s,se,se,nw,se");
            #endregion
            #region 12
            Inputs.Add(12, @"0 <-> 659, 737
1 <-> 1, 1433
2 <-> 982, 1869
3 <-> 306, 380, 1462, 1827
4 <-> 1076
5 <-> 794, 1451
6 <-> 146, 1055
7 <-> 834, 1557
8 <-> 1333
9 <-> 849, 906, 1863
10 <-> 362, 505
11 <-> 33, 938, 1896
12 <-> 490, 913
13 <-> 189, 690
14 <-> 796
15 <-> 56, 280, 1288, 1721
16 <-> 16
17 <-> 904
18 <-> 150, 1394, 1458
19 <-> 1773
20 <-> 70
21 <-> 993
22 <-> 22
23 <-> 285, 1004
24 <-> 209, 727
25 <-> 614, 1590
26 <-> 113
27 <-> 1321, 1341
28 <-> 351, 730, 1037
29 <-> 29, 1828
30 <-> 1378, 1983
31 <-> 705, 1035
32 <-> 1042, 1519
33 <-> 11, 886
34 <-> 360, 1101, 1531, 1877
35 <-> 971, 1652
36 <-> 188
37 <-> 1935
38 <-> 38
39 <-> 39, 1472
40 <-> 84, 1110
41 <-> 483, 895, 1035, 1864, 1919
42 <-> 624, 813, 1484, 1517
43 <-> 492
44 <-> 947, 1572
45 <-> 45, 1589, 1748, 1836
46 <-> 1821
47 <-> 123, 206, 239
48 <-> 146
49 <-> 235, 871
50 <-> 172, 1672
51 <-> 504
52 <-> 585, 678, 878
53 <-> 484, 543, 1282
54 <-> 374, 723
55 <-> 1956
56 <-> 15
57 <-> 583, 1159, 1596
58 <-> 313, 580, 1101
59 <-> 1529, 1788
60 <-> 60
61 <-> 1033, 1857
62 <-> 874
63 <-> 63, 1007, 1316, 1673
64 <-> 1140
65 <-> 1136
66 <-> 1337, 1546
67 <-> 67, 1468
68 <-> 298, 951
69 <-> 906
70 <-> 20, 1977
71 <-> 1956
72 <-> 146, 1465
73 <-> 911
74 <-> 1345
75 <-> 711
76 <-> 732, 789, 1499, 1637
77 <-> 1897
78 <-> 78, 379
79 <-> 96, 462, 847
80 <-> 886, 907
81 <-> 1564
82 <-> 1362, 1680
83 <-> 225, 916
84 <-> 40, 1460
85 <-> 330
86 <-> 1370
87 <-> 87, 640
88 <-> 806, 1411
89 <-> 1732
90 <-> 603
91 <-> 547, 904
92 <-> 1106
93 <-> 782
94 <-> 401, 1039, 1148, 1356
95 <-> 95, 344, 1092
96 <-> 79
97 <-> 1555, 1649
98 <-> 133
99 <-> 866
100 <-> 116, 1183, 1450
101 <-> 964
102 <-> 521, 843
103 <-> 1002
104 <-> 675, 1752, 1760
105 <-> 447
106 <-> 625
107 <-> 200, 923, 1573
108 <-> 108, 1535
109 <-> 1938, 1984
110 <-> 992
111 <-> 410, 436, 1789, 1985
112 <-> 730, 1742
113 <-> 26, 774, 1620
114 <-> 891
115 <-> 556, 980, 1502
116 <-> 100, 405, 438
117 <-> 1220, 1747
118 <-> 417
119 <-> 1671
120 <-> 225
121 <-> 215, 1414
122 <-> 1421
123 <-> 47, 488, 1390
124 <-> 1750
125 <-> 1020, 1456, 1645, 1811
126 <-> 945, 988, 1558
127 <-> 1562
128 <-> 246, 419, 878, 1057
129 <-> 198, 214, 526
130 <-> 1572
131 <-> 624
132 <-> 1086
133 <-> 98, 430, 1950
134 <-> 1179
135 <-> 1603
136 <-> 136
137 <-> 137, 248
138 <-> 604
139 <-> 1080, 1744, 1829
140 <-> 786, 890, 1336
141 <-> 819, 835
142 <-> 142, 1657
143 <-> 590, 670
144 <-> 622
145 <-> 182, 930, 1164, 1741
146 <-> 6, 48, 72, 152
147 <-> 1880
148 <-> 1486
149 <-> 1595
150 <-> 18, 653
151 <-> 1834
152 <-> 146, 289, 1949
153 <-> 1379
154 <-> 694, 1025
155 <-> 1143, 1469
156 <-> 437, 1492, 1616
157 <-> 1044
158 <-> 410, 1391
159 <-> 1327
160 <-> 387, 892, 963, 1287
161 <-> 964, 1017
162 <-> 786, 1098, 1351, 1445, 1508
163 <-> 415
164 <-> 255, 790, 1410
165 <-> 252, 425, 1186, 1662, 1838
166 <-> 791, 1012
167 <-> 167, 836, 1922
168 <-> 1586, 1998
169 <-> 679, 914
170 <-> 1975
171 <-> 672
172 <-> 50
173 <-> 614
174 <-> 723
175 <-> 246, 747
176 <-> 400, 1338
177 <-> 573, 1617, 1724
178 <-> 473, 1572
179 <-> 183
180 <-> 200, 1380
181 <-> 1394, 1657
182 <-> 145, 1825
183 <-> 179, 399, 955, 1236, 1295, 1840
184 <-> 712
185 <-> 185
186 <-> 551, 1627
187 <-> 1195
188 <-> 36, 440, 1277, 1362
189 <-> 13
190 <-> 1111
191 <-> 985, 1372
192 <-> 496, 1137, 1283
193 <-> 827, 1053
194 <-> 610
195 <-> 1231, 1497
196 <-> 1960
197 <-> 584, 1359
198 <-> 129, 651, 714, 1663
199 <-> 1047, 1805
200 <-> 107, 180, 658, 1397
201 <-> 1590
202 <-> 1268, 1768
203 <-> 1683
204 <-> 567, 1848
205 <-> 276
206 <-> 47, 461, 1794
207 <-> 207
208 <-> 1248
209 <-> 24, 1589
210 <-> 1063, 1504
211 <-> 907, 1815
212 <-> 1948
213 <-> 388
214 <-> 129, 561, 793, 1569
215 <-> 121, 252
216 <-> 216, 1728
217 <-> 761
218 <-> 631, 816
219 <-> 459, 807, 1008
220 <-> 1231, 1447
221 <-> 713, 1541
222 <-> 856, 924, 1924
223 <-> 1103
224 <-> 1426, 1761
225 <-> 83, 120, 242, 784
226 <-> 311, 560
227 <-> 587, 667, 984, 1091
228 <-> 1852
229 <-> 229, 1198, 1204
230 <-> 1505, 1944
231 <-> 1158, 1594, 1925
232 <-> 232, 345, 1417
233 <-> 828, 1677
234 <-> 982
235 <-> 49, 1012, 1254, 1956
236 <-> 489, 893, 1545
237 <-> 988, 1450
238 <-> 1719, 1791
239 <-> 47, 736, 1027
240 <-> 1167, 1457
241 <-> 270
242 <-> 225, 814, 1873
243 <-> 243, 282, 914
244 <-> 302, 328, 559
245 <-> 1753
246 <-> 128, 175
247 <-> 1230, 1660, 1824
248 <-> 137, 537, 1423
249 <-> 1209, 1391, 1749
250 <-> 298
251 <-> 799
252 <-> 165, 215
253 <-> 1437, 1741
254 <-> 1356
255 <-> 164
256 <-> 310
257 <-> 1267, 1821
258 <-> 1177, 1876
259 <-> 1257, 1432
260 <-> 311, 1115
261 <-> 1504
262 <-> 1268
263 <-> 565, 1023
264 <-> 408, 1806
265 <-> 1009, 1144
266 <-> 599, 616
267 <-> 1182
268 <-> 1026, 1456, 1470, 1854
269 <-> 269, 686
270 <-> 241, 1445
271 <-> 1232
272 <-> 487, 863, 1286
273 <-> 1614, 1748
274 <-> 1332
275 <-> 1010, 1334
276 <-> 205, 478, 888, 1049
277 <-> 277, 1330
278 <-> 734, 1561
279 <-> 535, 1190, 1913
280 <-> 15
281 <-> 1206
282 <-> 243, 475, 1571
283 <-> 283, 1936
284 <-> 324, 702, 844, 1601
285 <-> 23
286 <-> 286, 1080, 1127
287 <-> 295
288 <-> 805
289 <-> 152, 656, 691, 993
290 <-> 595, 616, 1199
291 <-> 1028, 1218, 1844
292 <-> 1447
293 <-> 378, 1771
294 <-> 811, 1790
295 <-> 287, 367, 693
296 <-> 861, 1948, 1950
297 <-> 1631
298 <-> 68, 250, 641, 745
299 <-> 299, 898, 1152, 1574
300 <-> 353
301 <-> 990, 1340, 1960
302 <-> 244
303 <-> 1645
304 <-> 445, 448, 557, 1611
305 <-> 1350, 1442
306 <-> 3, 445
307 <-> 567
308 <-> 1799
309 <-> 864
310 <-> 256, 853, 1911
311 <-> 226, 260, 970
312 <-> 1308
313 <-> 58
314 <-> 1795
315 <-> 1225, 1627, 1903
316 <-> 1065, 1991
317 <-> 317
318 <-> 546, 1415
319 <-> 1883
320 <-> 417, 1040
321 <-> 1927
322 <-> 686
323 <-> 1018, 1619
324 <-> 284
325 <-> 1114
326 <-> 474, 872
327 <-> 439
328 <-> 244
329 <-> 329
330 <-> 85, 1868
331 <-> 331, 680, 1224, 1243, 1291
332 <-> 1748
333 <-> 1673
334 <-> 676, 1306
335 <-> 809
336 <-> 797, 1559, 1858
337 <-> 978, 1874
338 <-> 538, 1077
339 <-> 432, 1033
340 <-> 340
341 <-> 1267, 1683
342 <-> 587, 726
343 <-> 1560, 1705
344 <-> 95
345 <-> 232, 1032
346 <-> 581, 1992
347 <-> 530
348 <-> 667, 1479
349 <-> 1620
350 <-> 861, 998, 1069
351 <-> 28
352 <-> 352
353 <-> 300, 1513
354 <-> 1109, 1747
355 <-> 950, 965, 1394, 1616
356 <-> 1136
357 <-> 1443, 1698
358 <-> 973, 1814
359 <-> 1662
360 <-> 34, 921
361 <-> 1418
362 <-> 10, 668, 1656
363 <-> 450, 766
364 <-> 615, 1941
365 <-> 1071
366 <-> 749, 1375
367 <-> 295, 1708, 1925
368 <-> 383, 928
369 <-> 369
370 <-> 651, 1048
371 <-> 665, 1460, 1686
372 <-> 390, 958, 1682
373 <-> 1559
374 <-> 54, 1395, 1847
375 <-> 799, 1061, 1383, 1773
376 <-> 376
377 <-> 1463
378 <-> 293, 872, 917
379 <-> 78, 449
380 <-> 3, 1117
381 <-> 1995
382 <-> 846, 896, 1506, 1918
383 <-> 368, 477
384 <-> 1009, 1788
385 <-> 1926
386 <-> 1602
387 <-> 160, 667
388 <-> 213, 713
389 <-> 586
390 <-> 372, 1140
391 <-> 863
392 <-> 590, 1259, 1384
393 <-> 645
394 <-> 423, 1537
395 <-> 782, 1496, 1893
396 <-> 1497
397 <-> 397
398 <-> 847, 1265
399 <-> 183, 743, 1564
400 <-> 176
401 <-> 94
402 <-> 402
403 <-> 558
404 <-> 572
405 <-> 116
406 <-> 769, 1563
407 <-> 1790
408 <-> 264
409 <-> 847
410 <-> 111, 158, 1467, 1880, 1902
411 <-> 1221
412 <-> 858, 1088, 1848
413 <-> 1589
414 <-> 468, 637
415 <-> 163, 415
416 <-> 416, 817
417 <-> 118, 320, 1671
418 <-> 1029, 1987
419 <-> 128, 765
420 <-> 420, 1180
421 <-> 1170, 1766
422 <-> 563, 1400, 1904, 1926
423 <-> 394
424 <-> 730
425 <-> 165, 478, 957
426 <-> 1505
427 <-> 1478, 1780
428 <-> 1658
429 <-> 650
430 <-> 133
431 <-> 469, 1491
432 <-> 339
433 <-> 667, 1549
434 <-> 852
435 <-> 435
436 <-> 111
437 <-> 156
438 <-> 116, 874
439 <-> 327, 1387
440 <-> 188, 540
441 <-> 441
442 <-> 692
443 <-> 1037, 1153
444 <-> 758, 1064
445 <-> 304, 306
446 <-> 1072, 1495, 1890
447 <-> 105, 1665
448 <-> 304, 591
449 <-> 379
450 <-> 363, 450, 466
451 <-> 1135
452 <-> 990, 1344, 1604
453 <-> 1390, 1755
454 <-> 1853
455 <-> 1199, 1735, 1852
456 <-> 484
457 <-> 457, 1973
458 <-> 786
459 <-> 219
460 <-> 1655, 1777
461 <-> 206, 753
462 <-> 79, 668
463 <-> 699
464 <-> 1843
465 <-> 829, 978, 1820
466 <-> 450
467 <-> 770, 1475
468 <-> 414, 613, 1230
469 <-> 431, 1470
470 <-> 1292, 1659
471 <-> 603
472 <-> 719, 1398
473 <-> 178, 1419
474 <-> 326, 866
475 <-> 282
476 <-> 1512, 1669
477 <-> 383
478 <-> 276, 425
479 <-> 1029
480 <-> 603
481 <-> 991, 1878
482 <-> 1726, 1783
483 <-> 41, 855
484 <-> 53, 456
485 <-> 1814
486 <-> 1470
487 <-> 272, 1693
488 <-> 123
489 <-> 236, 1155, 1793
490 <-> 12, 1349, 1498
491 <-> 913
492 <-> 43, 1121, 1822
493 <-> 1148
494 <-> 619, 1528
495 <-> 1960
496 <-> 192
497 <-> 497
498 <-> 1185
499 <-> 1933
500 <-> 1948
501 <-> 1364, 1433, 1826
502 <-> 893, 933
503 <-> 514
504 <-> 51, 821, 1116
505 <-> 10, 905
506 <-> 506
507 <-> 892
508 <-> 508
509 <-> 1078
510 <-> 1716
511 <-> 1197, 1900
512 <-> 568, 1284, 1422
513 <-> 1604, 1817, 1927
514 <-> 503, 773, 1725, 1883
515 <-> 1396
516 <-> 542
517 <-> 1299
518 <-> 1562
519 <-> 1622
520 <-> 1254, 1868, 1881
521 <-> 102, 1765
522 <-> 1438, 1980
523 <-> 1779
524 <-> 1235, 1968
525 <-> 1267, 1484
526 <-> 129
527 <-> 1211
528 <-> 597, 1017
529 <-> 529, 609
530 <-> 347, 1737, 1890
531 <-> 851, 1320
532 <-> 709
533 <-> 819, 1091
534 <-> 856
535 <-> 279, 535
536 <-> 536
537 <-> 248, 1317, 1763
538 <-> 338, 1793
539 <-> 539, 1485
540 <-> 440, 1216
541 <-> 541
542 <-> 516, 1232, 1831
543 <-> 53, 1234
544 <-> 639, 1090
545 <-> 1898
546 <-> 318, 1208
547 <-> 91
548 <-> 569, 750, 1090
549 <-> 1720
550 <-> 660
551 <-> 186
552 <-> 642, 672, 723
553 <-> 1927
554 <-> 717, 1841, 1997
555 <-> 1938
556 <-> 115, 1453
557 <-> 304, 904
558 <-> 403, 1438
559 <-> 244, 1046
560 <-> 226
561 <-> 214, 793, 1570
562 <-> 1992
563 <-> 422
564 <-> 860
565 <-> 263, 804
566 <-> 566
567 <-> 204, 307
568 <-> 512, 1084
569 <-> 548, 985, 1910
570 <-> 665, 1844
571 <-> 735
572 <-> 404, 1026, 1111
573 <-> 177, 1994
574 <-> 846
575 <-> 723, 738, 795, 802, 926, 1215
576 <-> 1650, 1962, 1996
577 <-> 1501, 1670
578 <-> 1504
579 <-> 1016, 1729
580 <-> 58
581 <-> 346, 581
582 <-> 749
583 <-> 57, 613, 1219, 1941
584 <-> 197, 1366
585 <-> 52, 1518
586 <-> 389, 1597
587 <-> 227, 342
588 <-> 1408
589 <-> 1229
590 <-> 143, 392, 1044, 1078
591 <-> 448, 1289
592 <-> 592
593 <-> 711
594 <-> 770
595 <-> 290, 1169
596 <-> 1854
597 <-> 528, 755, 1241, 1982
598 <-> 663, 806
599 <-> 266
600 <-> 1065, 1694
601 <-> 746
602 <-> 827
603 <-> 90, 471, 480, 1083
604 <-> 138, 1003
605 <-> 1703
606 <-> 1289
607 <-> 1309
608 <-> 808, 1100
609 <-> 529, 1621, 1943
610 <-> 194, 610
611 <-> 1337, 1609
612 <-> 980, 1350
613 <-> 468, 583
614 <-> 25, 173, 1623, 1914
615 <-> 364, 775
616 <-> 266, 290
617 <-> 1514
618 <-> 1031
619 <-> 494, 1761
620 <-> 1126, 1150, 1221, 1513, 1712
621 <-> 1770
622 <-> 144, 1761
623 <-> 1367
624 <-> 42, 131
625 <-> 106, 914
626 <-> 1849
627 <-> 1477
628 <-> 1379
629 <-> 969
630 <-> 1114
631 <-> 218, 1935, 1979
632 <-> 1015, 1665, 1816, 1819
633 <-> 1326, 1628
634 <-> 1347, 1720
635 <-> 816
636 <-> 636
637 <-> 414, 1566
638 <-> 1668
639 <-> 544, 824, 1542
640 <-> 87
641 <-> 298, 1196
642 <-> 552, 1619
643 <-> 972
644 <-> 814
645 <-> 393, 1148, 1205, 1302
646 <-> 969
647 <-> 935, 1575
648 <-> 648, 1424
649 <-> 1794
650 <-> 429, 854, 1586, 1711
651 <-> 198, 370
652 <-> 996, 1996
653 <-> 150, 1919
654 <-> 654
655 <-> 658
656 <-> 289
657 <-> 978, 1954
658 <-> 200, 655
659 <-> 0, 825, 1258, 1792
660 <-> 550, 1232
661 <-> 661, 1405
662 <-> 662
663 <-> 598
664 <-> 1014
665 <-> 371, 570, 1247
666 <-> 989, 1778
667 <-> 227, 348, 387, 433
668 <-> 362, 462, 703, 1091
669 <-> 1184
670 <-> 143
671 <-> 671, 901
672 <-> 171, 552
673 <-> 1865
674 <-> 972, 1961
675 <-> 104, 1581, 1800
676 <-> 334, 1995
677 <-> 1836
678 <-> 52
679 <-> 169
680 <-> 331
681 <-> 823
682 <-> 921
683 <-> 1800
684 <-> 750, 1505
685 <-> 722, 1338, 1993
686 <-> 269, 322
687 <-> 989, 1178
688 <-> 1338
689 <-> 1535
690 <-> 13, 690
691 <-> 289, 721
692 <-> 442, 1014
693 <-> 295
694 <-> 154, 862
695 <-> 1552, 1735
696 <-> 1044
697 <-> 993, 1793, 1801
698 <-> 698
699 <-> 463, 1022, 1399
700 <-> 897, 1085
701 <-> 1782, 1987
702 <-> 284
703 <-> 668, 1031
704 <-> 704, 849
705 <-> 31
706 <-> 1909
707 <-> 1276
708 <-> 1301
709 <-> 532, 1607
710 <-> 1094
711 <-> 75, 593, 1251, 1297
712 <-> 184, 712
713 <-> 221, 388, 713
714 <-> 198
715 <-> 1607
716 <-> 1110
717 <-> 554, 1819
718 <-> 1755
719 <-> 472, 1942
720 <-> 1043, 1984
721 <-> 691, 1641
722 <-> 685, 1360, 1679
723 <-> 54, 174, 552, 575
724 <-> 1466
725 <-> 1231
726 <-> 342, 1023
727 <-> 24
728 <-> 1928
729 <-> 975, 1759
730 <-> 28, 112, 424, 1324
731 <-> 731
732 <-> 76, 1698
733 <-> 1895
734 <-> 278
735 <-> 571, 1440
736 <-> 239
737 <-> 0, 1214, 1949
738 <-> 575, 985
739 <-> 1467
740 <-> 740, 1449, 1885
741 <-> 1243
742 <-> 845, 1588, 1676, 1956, 1980
743 <-> 399
744 <-> 744, 1990
745 <-> 298, 1966
746 <-> 601, 1294, 1601
747 <-> 175, 1106
748 <-> 1433, 1565, 1795
749 <-> 366, 582
750 <-> 548, 684, 1210
751 <-> 751, 1967
752 <-> 765, 1297
753 <-> 461
754 <-> 754
755 <-> 597, 1089
756 <-> 756
757 <-> 1350, 1936
758 <-> 444, 1044, 1279
759 <-> 996, 1310
760 <-> 1943
761 <-> 217, 1333
762 <-> 1671
763 <-> 1761
764 <-> 1881
765 <-> 419, 752
766 <-> 363, 928, 1100
767 <-> 1220, 1986
768 <-> 1337
769 <-> 406, 1307
770 <-> 467, 594, 1707
771 <-> 1624, 1782
772 <-> 1230
773 <-> 514, 1266, 1305
774 <-> 113, 1198
775 <-> 615, 1753
776 <-> 1307
777 <-> 1785
778 <-> 778, 1776
779 <-> 992
780 <-> 1406
781 <-> 781, 1272
782 <-> 93, 395, 1207
783 <-> 1544, 1729
784 <-> 225, 1168, 1587
785 <-> 1050
786 <-> 140, 162, 458, 786, 1060
787 <-> 1210
788 <-> 1431
789 <-> 76
790 <-> 164, 882
791 <-> 166, 1688
792 <-> 792, 946
793 <-> 214, 561
794 <-> 5, 1561
795 <-> 575, 1208, 1875
796 <-> 14, 1205, 1427
797 <-> 336, 1006, 1352
798 <-> 1176, 1754
799 <-> 251, 375
800 <-> 840, 1471
801 <-> 801, 1246, 1897
802 <-> 575
803 <-> 1692
804 <-> 565, 859, 1978
805 <-> 288, 1447
806 <-> 88, 598
807 <-> 219, 1579
808 <-> 608
809 <-> 335, 867, 1734, 1843
810 <-> 1279
811 <-> 294, 1043, 1560, 1583, 1600
812 <-> 1487, 1527
813 <-> 42, 1405
814 <-> 242, 644, 1175, 1638
815 <-> 1050, 1177
816 <-> 218, 635, 1427
817 <-> 416
818 <-> 1765, 1999
819 <-> 141, 533
820 <-> 1238, 1393
821 <-> 504, 1755
822 <-> 1320, 1397
823 <-> 681, 1120, 1798
824 <-> 639
825 <-> 659
826 <-> 1722, 1834
827 <-> 193, 602, 968
828 <-> 233, 1835
829 <-> 465
830 <-> 951
831 <-> 1606
832 <-> 1619, 1964
833 <-> 1109
834 <-> 7, 962, 1869
835 <-> 141
836 <-> 167, 875, 1145
837 <-> 1752
838 <-> 838, 1146
839 <-> 1247
840 <-> 800
841 <-> 1337
842 <-> 1438, 1466
843 <-> 102
844 <-> 284
845 <-> 742
846 <-> 382, 574
847 <-> 79, 398, 409
848 <-> 959
849 <-> 9, 704
850 <-> 915, 1455, 1911, 1987
851 <-> 531, 1001
852 <-> 434, 1172
853 <-> 310, 1533
854 <-> 650
855 <-> 483, 868, 1598
856 <-> 222, 534, 1133
857 <-> 857, 1249, 1923
858 <-> 412, 1540, 1575, 1607
859 <-> 804, 1655
860 <-> 564, 1243
861 <-> 296, 350, 1130, 1521
862 <-> 694
863 <-> 272, 391, 1558
864 <-> 309, 1071, 1227
865 <-> 1537, 1669, 1825
866 <-> 99, 474
867 <-> 809, 867, 1004
868 <-> 855, 1539
869 <-> 1550
870 <-> 1885
871 <-> 49
872 <-> 326, 378, 1552
873 <-> 1307
874 <-> 62, 438
875 <-> 836, 1056, 1326
876 <-> 876
877 <-> 1933
878 <-> 52, 128, 1527
879 <-> 879
880 <-> 1292, 1561, 1770
881 <-> 881, 981
882 <-> 790, 882, 932
883 <-> 1322, 1963
884 <-> 1842
885 <-> 885
886 <-> 33, 80, 1765, 1959
887 <-> 1012
888 <-> 276
889 <-> 1391
890 <-> 140
891 <-> 114, 891
892 <-> 160, 507
893 <-> 236, 502, 1602
894 <-> 1525
895 <-> 41
896 <-> 382
897 <-> 700
898 <-> 299
899 <-> 1797
900 <-> 1736
901 <-> 671, 944, 1147
902 <-> 1597, 1940
903 <-> 1283
904 <-> 17, 91, 557, 1169, 1764
905 <-> 505
906 <-> 9, 69, 942
907 <-> 80, 211, 1348
908 <-> 1398
909 <-> 909
910 <-> 1683
911 <-> 73, 911
912 <-> 1929
913 <-> 12, 491, 1591
914 <-> 169, 243, 625, 1867
915 <-> 850, 1538
916 <-> 83
917 <-> 378
918 <-> 1438
919 <-> 1951
920 <-> 1814
921 <-> 360, 682, 1952
922 <-> 922
923 <-> 107, 1161, 1254
924 <-> 222
925 <-> 1691
926 <-> 575
927 <-> 1165, 1270
928 <-> 368, 766
929 <-> 1707, 1914
930 <-> 145, 1096, 1434, 1791
931 <-> 931, 1983
932 <-> 882
933 <-> 502, 1921
934 <-> 1297
935 <-> 647, 1319
936 <-> 1255
937 <-> 1210
938 <-> 11
939 <-> 1348, 1666
940 <-> 1408
941 <-> 1440
942 <-> 906
943 <-> 1977
944 <-> 901
945 <-> 126
946 <-> 792
947 <-> 44, 1400
948 <-> 948, 1045
949 <-> 967
950 <-> 355
951 <-> 68, 830, 969
952 <-> 1225, 1757, 1929
953 <-> 1534, 1726
954 <-> 1511, 1888
955 <-> 183, 1418
956 <-> 1702
957 <-> 425
958 <-> 372
959 <-> 848, 1512
960 <-> 1868
961 <-> 1509
962 <-> 834, 1678
963 <-> 160
964 <-> 101, 161
965 <-> 355
966 <-> 1740, 1866
967 <-> 949, 1802
968 <-> 827, 1534
969 <-> 629, 646, 951
970 <-> 311
971 <-> 35, 1670
972 <-> 643, 674, 1449
973 <-> 358
974 <-> 974
975 <-> 729, 1955
976 <-> 1495
977 <-> 1603, 1889
978 <-> 337, 465, 657, 1615, 1953
979 <-> 1801
980 <-> 115, 612, 1239
981 <-> 881
982 <-> 2, 234, 1411, 1511
983 <-> 1970
984 <-> 227, 984
985 <-> 191, 569, 738
986 <-> 1926
987 <-> 987
988 <-> 126, 237, 1894
989 <-> 666, 687, 1079
990 <-> 301, 452, 1903
991 <-> 481, 1435
992 <-> 110, 779, 1637
993 <-> 21, 289, 697, 1675
994 <-> 1151, 1639
995 <-> 1090, 1798
996 <-> 652, 759, 1229
997 <-> 1253, 1380, 1553
998 <-> 350, 1812
999 <-> 1128
1000 <-> 1566
1001 <-> 851
1002 <-> 103, 1229
1003 <-> 604, 1156, 1232, 1420
1004 <-> 23, 867
1005 <-> 1085, 1174, 1899
1006 <-> 797
1007 <-> 63, 1282
1008 <-> 219, 1008, 1977
1009 <-> 265, 384, 1731
1010 <-> 275, 1438, 1474
1011 <-> 1289
1012 <-> 166, 235, 887, 1342, 1471
1013 <-> 1013, 1886
1014 <-> 664, 692, 1229
1015 <-> 632, 1015
1016 <-> 579
1017 <-> 161, 528
1018 <-> 323
1019 <-> 1684
1020 <-> 125
1021 <-> 1036, 1450
1022 <-> 699, 1600, 1962
1023 <-> 263, 726
1024 <-> 1295
1025 <-> 154, 1025
1026 <-> 268, 572, 1610
1027 <-> 239, 1269
1028 <-> 291, 1275
1029 <-> 418, 479, 1957
1030 <-> 1184
1031 <-> 618, 703
1032 <-> 345
1033 <-> 61, 339, 1033
1034 <-> 1166, 1291
1035 <-> 31, 41
1036 <-> 1021, 1228
1037 <-> 28, 443, 1227
1038 <-> 1178
1039 <-> 94, 1578
1040 <-> 320, 1992
1041 <-> 1041
1042 <-> 32, 1486
1043 <-> 720, 811
1044 <-> 157, 590, 696, 758, 1433, 1739
1045 <-> 948
1046 <-> 559, 1241
1047 <-> 199, 1962
1048 <-> 370
1049 <-> 276, 1885
1050 <-> 785, 815
1051 <-> 1051, 1290
1052 <-> 1165
1053 <-> 193, 1446, 1488
1054 <-> 1081
1055 <-> 6
1056 <-> 875
1057 <-> 128, 1137
1058 <-> 1112, 1173
1059 <-> 1226, 1538
1060 <-> 786
1061 <-> 375, 1639, 1988
1062 <-> 1748
1063 <-> 210, 1692
1064 <-> 444
1065 <-> 316, 600, 1689
1066 <-> 1709
1067 <-> 1067
1068 <-> 1068
1069 <-> 350
1070 <-> 1196
1071 <-> 365, 864, 1827
1072 <-> 446, 1142
1073 <-> 1931
1074 <-> 1529
1075 <-> 1075
1076 <-> 4, 1717, 1879, 1969
1077 <-> 338
1078 <-> 509, 590
1079 <-> 989, 1282
1080 <-> 139, 286
1081 <-> 1054, 1992
1082 <-> 1115, 1451, 1704
1083 <-> 603, 1271
1084 <-> 568, 1233
1085 <-> 700, 1005, 1939
1086 <-> 132, 1745, 1901
1087 <-> 1519
1088 <-> 412
1089 <-> 755
1090 <-> 544, 548, 995, 1768
1091 <-> 227, 533, 668, 1141
1092 <-> 95
1093 <-> 1271, 1946
1094 <-> 710, 1102
1095 <-> 1546
1096 <-> 930
1097 <-> 1288
1098 <-> 162, 1933
1099 <-> 1456
1100 <-> 608, 766
1101 <-> 34, 58, 1108
1102 <-> 1094, 1938
1103 <-> 223, 1117
1104 <-> 1457, 1605, 1654
1105 <-> 1105
1106 <-> 92, 747
1107 <-> 1699
1108 <-> 1101, 1201
1109 <-> 354, 833, 1285, 1874
1110 <-> 40, 716
1111 <-> 190, 572, 1440
1112 <-> 1058, 1193
1113 <-> 1113
1114 <-> 325, 630, 1853
1115 <-> 260, 1082
1116 <-> 504
1117 <-> 380, 1103
1118 <-> 1118
1119 <-> 1353, 1871
1120 <-> 823
1121 <-> 492, 1196
1122 <-> 1122
1123 <-> 1725
1124 <-> 1892
1125 <-> 1344
1126 <-> 620
1127 <-> 286, 1138
1128 <-> 999, 1268
1129 <-> 1129
1130 <-> 861
1131 <-> 1874
1132 <-> 1913
1133 <-> 856
1134 <-> 1185, 1767
1135 <-> 451, 1975
1136 <-> 65, 356, 1487
1137 <-> 192, 1057
1138 <-> 1127, 1782
1139 <-> 1240
1140 <-> 64, 390, 1385
1141 <-> 1091
1142 <-> 1072, 1587
1143 <-> 155, 1143
1144 <-> 265
1145 <-> 836, 1401
1146 <-> 838
1147 <-> 901, 1483
1148 <-> 94, 493, 645, 1167
1149 <-> 1818
1150 <-> 620, 1237, 1264
1151 <-> 994, 1844
1152 <-> 299, 1167
1153 <-> 443, 1947
1154 <-> 1803
1155 <-> 489, 1163
1156 <-> 1003, 1635, 1668
1157 <-> 1340, 1809
1158 <-> 231
1159 <-> 57
1160 <-> 1558
1161 <-> 923
1162 <-> 1590
1163 <-> 1155
1164 <-> 145, 1164, 1283
1165 <-> 927, 1052, 1678, 1934
1166 <-> 1034
1167 <-> 240, 1148, 1152, 1462
1168 <-> 784
1169 <-> 595, 904
1170 <-> 421
1171 <-> 1667
1172 <-> 852, 1195, 1323, 1444
1173 <-> 1058, 1389
1174 <-> 1005
1175 <-> 814
1176 <-> 798
1177 <-> 258, 815, 1401
1178 <-> 687, 1038, 1331
1179 <-> 134, 1179
1180 <-> 420
1181 <-> 1181
1182 <-> 267, 1677
1183 <-> 100
1184 <-> 669, 1030, 1969
1185 <-> 498, 1134, 1673, 1750
1186 <-> 165
1187 <-> 1893
1188 <-> 1236, 1365
1189 <-> 1334, 1732
1190 <-> 279
1191 <-> 1620
1192 <-> 1257
1193 <-> 1112
1194 <-> 1770
1195 <-> 187, 1172, 1964
1196 <-> 641, 1070, 1121, 1729
1197 <-> 511, 1273, 1607
1198 <-> 229, 774
1199 <-> 290, 455, 1860
1200 <-> 1901
1201 <-> 1108
1202 <-> 1378
1203 <-> 1591
1204 <-> 229
1205 <-> 645, 796, 1250
1206 <-> 281, 1824
1207 <-> 782
1208 <-> 546, 795, 1700
1209 <-> 249
1210 <-> 750, 787, 937
1211 <-> 527, 1981
1212 <-> 1212, 1369
1213 <-> 1512
1214 <-> 737
1215 <-> 575
1216 <-> 540, 1216
1217 <-> 1312, 1340
1218 <-> 291, 1586
1219 <-> 583, 1554
1220 <-> 117, 767
1221 <-> 411, 620, 1221
1222 <-> 1612, 1710
1223 <-> 1223, 1374
1224 <-> 331
1225 <-> 315, 952, 1263
1226 <-> 1059, 1928
1227 <-> 864, 1037, 1823
1228 <-> 1036, 1613
1229 <-> 589, 996, 1002, 1014, 1906
1230 <-> 247, 468, 772, 1821, 1837
1231 <-> 195, 220, 725
1232 <-> 271, 542, 660, 1003, 1232, 1606
1233 <-> 1084, 1366, 1738
1234 <-> 543, 1408
1235 <-> 524
1236 <-> 183, 1188
1237 <-> 1150
1238 <-> 820, 1521
1239 <-> 980
1240 <-> 1139, 1240
1241 <-> 597, 1046
1242 <-> 1646
1243 <-> 331, 741, 860
1244 <-> 1522, 1870
1245 <-> 1245
1246 <-> 801
1247 <-> 665, 839
1248 <-> 208, 1932
1249 <-> 857
1250 <-> 1205
1251 <-> 711
1252 <-> 1888
1253 <-> 997, 1593
1254 <-> 235, 520, 923, 1382
1255 <-> 936
1256 <-> 1718
1257 <-> 259, 1192
1258 <-> 659, 1917
1259 <-> 392
1260 <-> 1260
1261 <-> 1261, 1376
1262 <-> 1936
1263 <-> 1225
1264 <-> 1150, 1567
1265 <-> 398
1266 <-> 773, 1373
1267 <-> 257, 341, 525
1268 <-> 202, 262, 1128
1269 <-> 1027
1270 <-> 927
1271 <-> 1083, 1093
1272 <-> 781
1273 <-> 1197
1274 <-> 1760
1275 <-> 1028, 1827
1276 <-> 707, 1900
1277 <-> 188
1278 <-> 1463
1279 <-> 758, 810
1280 <-> 1920
1281 <-> 1942
1282 <-> 53, 1007, 1079
1283 <-> 192, 903, 1164, 1690
1284 <-> 512, 1584
1285 <-> 1109, 1285
1286 <-> 272
1287 <-> 160
1288 <-> 15, 1097, 1905
1289 <-> 591, 606, 1011
1290 <-> 1051
1291 <-> 331, 1034
1292 <-> 470, 880
1293 <-> 1501, 1899
1294 <-> 746, 1294
1295 <-> 183, 1024
1296 <-> 1580
1297 <-> 711, 752, 934
1298 <-> 1298
1299 <-> 517, 1299
1300 <-> 1300
1301 <-> 708, 1301
1302 <-> 645
1303 <-> 1355, 1492
1304 <-> 1361, 1746
1305 <-> 773
1306 <-> 334, 1325
1307 <-> 769, 776, 873, 1333
1308 <-> 312, 1851, 1966
1309 <-> 607, 1459, 1496
1310 <-> 759
1311 <-> 1381, 1520
1312 <-> 1217
1313 <-> 1983
1314 <-> 1314
1315 <-> 1315, 1647
1316 <-> 63
1317 <-> 537
1318 <-> 1973
1319 <-> 935, 1517
1320 <-> 531, 822
1321 <-> 27, 1837
1322 <-> 883, 1664
1323 <-> 1172
1324 <-> 730
1325 <-> 1306
1326 <-> 633, 875
1327 <-> 159, 1553
1328 <-> 1974
1329 <-> 1939
1330 <-> 277, 1515
1331 <-> 1178, 1590
1332 <-> 274, 1332
1333 <-> 8, 761, 1307, 1333
1334 <-> 275, 1189, 1482
1335 <-> 1478
1336 <-> 140
1337 <-> 66, 611, 768, 841
1338 <-> 176, 685, 688, 1449
1339 <-> 1339
1340 <-> 301, 1157, 1217, 1630
1341 <-> 27
1342 <-> 1012
1343 <-> 1408
1344 <-> 452, 1125, 1622
1345 <-> 74, 1835
1346 <-> 1860
1347 <-> 634, 1428
1348 <-> 907, 939
1349 <-> 490, 1349
1350 <-> 305, 612, 757
1351 <-> 162
1352 <-> 797, 1818
1353 <-> 1119, 1353
1354 <-> 1436
1355 <-> 1303
1356 <-> 94, 254
1357 <-> 1419, 1664, 1680
1358 <-> 1358
1359 <-> 197
1360 <-> 722, 1909
1361 <-> 1304
1362 <-> 82, 188, 1448
1363 <-> 1752
1364 <-> 501
1365 <-> 1188, 1661
1366 <-> 584, 1233
1367 <-> 623, 1394, 1781
1368 <-> 1886
1369 <-> 1212
1370 <-> 86, 1370
1371 <-> 1772
1372 <-> 191, 1473
1373 <-> 1266
1374 <-> 1223, 1981
1375 <-> 366, 1375
1376 <-> 1261, 1599
1377 <-> 1675
1378 <-> 30, 1202, 1406, 1845
1379 <-> 153, 628, 1557
1380 <-> 180, 997
1381 <-> 1311, 1407, 1666
1382 <-> 1254
1383 <-> 375, 1714
1384 <-> 392
1385 <-> 1140, 1933
1386 <-> 1949
1387 <-> 439, 1387
1388 <-> 1770
1389 <-> 1173, 1679
1390 <-> 123, 453, 1733
1391 <-> 158, 249, 889, 1945
1392 <-> 1881
1393 <-> 820
1394 <-> 18, 181, 355, 1367
1395 <-> 374, 1404
1396 <-> 515, 1860
1397 <-> 200, 822
1398 <-> 472, 908, 1622, 1701
1399 <-> 699
1400 <-> 422, 947, 1551
1401 <-> 1145, 1177
1402 <-> 1764
1403 <-> 1875
1404 <-> 1395
1405 <-> 661, 813
1406 <-> 780, 1378
1407 <-> 1381
1408 <-> 588, 940, 1234, 1343, 1603, 1865
1409 <-> 1427
1410 <-> 164
1411 <-> 88, 982
1412 <-> 1452
1413 <-> 1707, 1766
1414 <-> 121
1415 <-> 318, 1415, 1612
1416 <-> 1416
1417 <-> 232
1418 <-> 361, 955, 1418, 1737
1419 <-> 473, 1357
1420 <-> 1003
1421 <-> 122, 1973
1422 <-> 512, 1870
1423 <-> 248
1424 <-> 648
1425 <-> 1425
1426 <-> 224, 1946
1427 <-> 796, 816, 1409
1428 <-> 1347
1429 <-> 1810, 1862
1430 <-> 1430
1431 <-> 788, 1488
1432 <-> 259, 1432
1433 <-> 1, 501, 748, 1044
1434 <-> 930
1435 <-> 991
1436 <-> 1354, 1436
1437 <-> 253
1438 <-> 522, 558, 842, 918, 1010
1439 <-> 1649
1440 <-> 735, 941, 1111
1441 <-> 1707
1442 <-> 305, 1930
1443 <-> 357
1444 <-> 1172
1445 <-> 162, 270, 1636
1446 <-> 1053
1447 <-> 220, 292, 805
1448 <-> 1362
1449 <-> 740, 972, 1338
1450 <-> 100, 237, 1021
1451 <-> 5, 1082
1452 <-> 1412, 1572
1453 <-> 556
1454 <-> 1454
1455 <-> 850
1456 <-> 125, 268, 1099
1457 <-> 240, 1104
1458 <-> 18, 1576
1459 <-> 1309, 1503
1460 <-> 84, 371
1461 <-> 1747, 1879
1462 <-> 3, 1167, 1807
1463 <-> 377, 1278, 1499, 1971
1464 <-> 1908
1465 <-> 72
1466 <-> 724, 842
1467 <-> 410, 739
1468 <-> 67
1469 <-> 155, 1652
1470 <-> 268, 469, 486
1471 <-> 800, 1012, 1471, 1510
1472 <-> 39
1473 <-> 1372
1474 <-> 1010, 1915
1475 <-> 467, 1658
1476 <-> 1476
1477 <-> 627, 1477
1478 <-> 427, 1335, 1907
1479 <-> 348
1480 <-> 1480
1481 <-> 1802
1482 <-> 1334
1483 <-> 1147, 1524
1484 <-> 42, 525
1485 <-> 539
1486 <-> 148, 1042, 1549
1487 <-> 812, 1136
1488 <-> 1053, 1431
1489 <-> 1708, 1931
1490 <-> 1807
1491 <-> 431
1492 <-> 156, 1303
1493 <-> 1493
1494 <-> 1853
1495 <-> 446, 976
1496 <-> 395, 1309
1497 <-> 195, 396, 1974
1498 <-> 490, 1626
1499 <-> 76, 1463
1500 <-> 1722
1501 <-> 577, 1293
1502 <-> 115
1503 <-> 1459, 1507
1504 <-> 210, 261, 578, 1521, 1718
1505 <-> 230, 426, 684, 1634
1506 <-> 382, 1921
1507 <-> 1503
1508 <-> 162, 1667
1509 <-> 961, 1509
1510 <-> 1471
1511 <-> 954, 982, 1582
1512 <-> 476, 959, 1213, 1703
1513 <-> 353, 620
1514 <-> 617, 1546
1515 <-> 1330, 1595
1516 <-> 1946
1517 <-> 42, 1319
1518 <-> 585
1519 <-> 32, 1087
1520 <-> 1311
1521 <-> 861, 1238, 1504
1522 <-> 1244, 1653
1523 <-> 1523
1524 <-> 1483
1525 <-> 894, 1525
1526 <-> 1924
1527 <-> 812, 878
1528 <-> 494
1529 <-> 59, 1074
1530 <-> 1530
1531 <-> 34, 1531
1532 <-> 1638
1533 <-> 853
1534 <-> 953, 968
1535 <-> 108, 689
1536 <-> 1589
1537 <-> 394, 865
1538 <-> 915, 1059
1539 <-> 868
1540 <-> 858, 1745
1541 <-> 221
1542 <-> 639
1543 <-> 1746
1544 <-> 783, 1544
1545 <-> 236
1546 <-> 66, 1095, 1514
1547 <-> 1628
1548 <-> 1548
1549 <-> 433, 1486
1550 <-> 869, 1550
1551 <-> 1400, 1787
1552 <-> 695, 872
1553 <-> 997, 1327
1554 <-> 1219
1555 <-> 97
1556 <-> 1840
1557 <-> 7, 1379
1558 <-> 126, 863, 1160
1559 <-> 336, 373
1560 <-> 343, 811
1561 <-> 278, 794, 880, 1561
1562 <-> 127, 518, 1562
1563 <-> 406
1564 <-> 81, 399
1565 <-> 748
1566 <-> 637, 1000
1567 <-> 1264
1568 <-> 1568
1569 <-> 214
1570 <-> 561, 1849
1571 <-> 282
1572 <-> 44, 130, 178, 1452
1573 <-> 107
1574 <-> 299
1575 <-> 647, 858
1576 <-> 1458, 1633
1577 <-> 1833, 1939
1578 <-> 1039, 1802
1579 <-> 807, 1853
1580 <-> 1296, 1580, 1907
1581 <-> 675
1582 <-> 1511, 1605, 1756
1583 <-> 811
1584 <-> 1284
1585 <-> 1817
1586 <-> 168, 650, 1218
1587 <-> 784, 1142
1588 <-> 742
1589 <-> 45, 209, 413, 1536
1590 <-> 25, 201, 1162, 1331
1591 <-> 913, 1203
1592 <-> 1820
1593 <-> 1253
1594 <-> 231
1595 <-> 149, 1515
1596 <-> 57, 1976
1597 <-> 586, 902
1598 <-> 855
1599 <-> 1376
1600 <-> 811, 1022
1601 <-> 284, 746
1602 <-> 386, 893
1603 <-> 135, 977, 1408
1604 <-> 452, 513
1605 <-> 1104, 1582
1606 <-> 831, 1232
1607 <-> 709, 715, 858, 1197
1608 <-> 1793
1609 <-> 611, 1808
1610 <-> 1026, 1964
1611 <-> 304
1612 <-> 1222, 1415, 1769
1613 <-> 1228, 1847
1614 <-> 273
1615 <-> 978
1616 <-> 156, 355
1617 <-> 177
1618 <-> 1618
1619 <-> 323, 642, 832
1620 <-> 113, 349, 1191, 1746
1621 <-> 609
1622 <-> 519, 1344, 1398
1623 <-> 614
1624 <-> 771, 1989
1625 <-> 1625
1626 <-> 1498
1627 <-> 186, 315
1628 <-> 633, 1547
1629 <-> 1706
1630 <-> 1340
1631 <-> 297, 1800
1632 <-> 1806
1633 <-> 1576
1634 <-> 1505
1635 <-> 1156
1636 <-> 1445
1637 <-> 76, 992, 1920, 1995
1638 <-> 814, 1532
1639 <-> 994, 1061
1640 <-> 1640
1641 <-> 721
1642 <-> 1739, 1945
1643 <-> 1643
1644 <-> 1644, 1908
1645 <-> 125, 303
1646 <-> 1242, 1646
1647 <-> 1315
1648 <-> 1957
1649 <-> 97, 1439, 1783
1650 <-> 576
1651 <-> 1651
1652 <-> 35, 1469
1653 <-> 1522
1654 <-> 1104
1655 <-> 460, 859
1656 <-> 362
1657 <-> 142, 181
1658 <-> 428, 1475
1659 <-> 470
1660 <-> 247
1661 <-> 1365
1662 <-> 165, 359
1663 <-> 198
1664 <-> 1322, 1357
1665 <-> 447, 632
1666 <-> 939, 1381
1667 <-> 1171, 1508
1668 <-> 638, 1156
1669 <-> 476, 865, 1699
1670 <-> 577, 971
1671 <-> 119, 417, 762, 1804
1672 <-> 50, 1672, 1687
1673 <-> 63, 333, 1185
1674 <-> 1674
1675 <-> 993, 1377
1676 <-> 742, 1813
1677 <-> 233, 1182, 1846
1678 <-> 962, 1165
1679 <-> 722, 1389
1680 <-> 82, 1357
1681 <-> 1681, 1702, 1895
1682 <-> 372
1683 <-> 203, 341, 910
1684 <-> 1019, 1948
1685 <-> 1982
1686 <-> 371
1687 <-> 1672
1688 <-> 791
1689 <-> 1065, 1689
1690 <-> 1283
1691 <-> 925, 1878
1692 <-> 803, 1063, 1732
1693 <-> 487
1694 <-> 600
1695 <-> 1695, 1794
1696 <-> 1696
1697 <-> 1802
1698 <-> 357, 732
1699 <-> 1107, 1669
1700 <-> 1208
1701 <-> 1398
1702 <-> 956, 1681
1703 <-> 605, 1512
1704 <-> 1082
1705 <-> 343
1706 <-> 1629, 1775
1707 <-> 770, 929, 1413, 1441
1708 <-> 367, 1489
1709 <-> 1066, 1862
1710 <-> 1222
1711 <-> 650
1712 <-> 620
1713 <-> 1713
1714 <-> 1383
1715 <-> 1911
1716 <-> 510, 1716
1717 <-> 1076
1718 <-> 1256, 1504
1719 <-> 238
1720 <-> 549, 634, 1720
1721 <-> 15
1722 <-> 826, 1500
1723 <-> 1880
1724 <-> 177, 1724
1725 <-> 514, 1123, 1797
1726 <-> 482, 953
1727 <-> 1914
1728 <-> 216, 1982
1729 <-> 579, 783, 1196, 1800
1730 <-> 1730, 1972
1731 <-> 1009
1732 <-> 89, 1189, 1692
1733 <-> 1390
1734 <-> 809
1735 <-> 455, 695
1736 <-> 900, 1736
1737 <-> 530, 1418
1738 <-> 1233, 1888
1739 <-> 1044, 1642, 1834
1740 <-> 966
1741 <-> 145, 253
1742 <-> 112
1743 <-> 1980
1744 <-> 139
1745 <-> 1086, 1540
1746 <-> 1304, 1543, 1620
1747 <-> 117, 354, 1461
1748 <-> 45, 273, 332, 1062
1749 <-> 249
1750 <-> 124, 1185
1751 <-> 1835
1752 <-> 104, 837, 1363
1753 <-> 245, 775
1754 <-> 798, 1876
1755 <-> 453, 718, 821
1756 <-> 1582
1757 <-> 952, 1772, 1841
1758 <-> 1758, 1830, 1878
1759 <-> 729
1760 <-> 104, 1274
1761 <-> 224, 619, 622, 763, 1868
1762 <-> 1762
1763 <-> 537
1764 <-> 904, 1402
1765 <-> 521, 818, 886, 1782
1766 <-> 421, 1413
1767 <-> 1134
1768 <-> 202, 1090
1769 <-> 1612
1770 <-> 621, 880, 1194, 1388
1771 <-> 293
1772 <-> 1371, 1757
1773 <-> 19, 375
1774 <-> 1774
1775 <-> 1706, 1915
1776 <-> 778
1777 <-> 460, 1918
1778 <-> 666
1779 <-> 523, 1846
1780 <-> 427
1781 <-> 1367
1782 <-> 701, 771, 1138, 1765
1783 <-> 482, 1649, 1783
1784 <-> 1784, 1872
1785 <-> 777, 1785
1786 <-> 1858
1787 <-> 1551
1788 <-> 59, 384, 1865
1789 <-> 111
1790 <-> 294, 407, 1969
1791 <-> 238, 930
1792 <-> 659
1793 <-> 489, 538, 697, 1608
1794 <-> 206, 649, 1695
1795 <-> 314, 748
1796 <-> 1796
1797 <-> 899, 1725, 1797
1798 <-> 823, 995
1799 <-> 308, 1799
1800 <-> 675, 683, 1631, 1729
1801 <-> 697, 979, 1858
1802 <-> 967, 1481, 1578, 1697
1803 <-> 1154, 1803
1804 <-> 1671
1805 <-> 199
1806 <-> 264, 1632, 1806
1807 <-> 1462, 1490
1808 <-> 1609, 1808
1809 <-> 1157
1810 <-> 1429
1811 <-> 125
1812 <-> 998
1813 <-> 1676
1814 <-> 358, 485, 920, 1814
1815 <-> 211
1816 <-> 632
1817 <-> 513, 1585
1818 <-> 1149, 1352
1819 <-> 632, 717
1820 <-> 465, 1592
1821 <-> 46, 257, 1230
1822 <-> 492
1823 <-> 1227, 1891
1824 <-> 247, 1206
1825 <-> 182, 865
1826 <-> 501
1827 <-> 3, 1071, 1275
1828 <-> 29
1829 <-> 139
1830 <-> 1758
1831 <-> 542
1832 <-> 1862
1833 <-> 1577
1834 <-> 151, 826, 1739, 1882
1835 <-> 828, 1345, 1751, 1835
1836 <-> 45, 677
1837 <-> 1230, 1321
1838 <-> 165, 1856
1839 <-> 1842, 1953
1840 <-> 183, 1556
1841 <-> 554, 1757
1842 <-> 884, 1839
1843 <-> 464, 809
1844 <-> 291, 570, 1151
1845 <-> 1378
1846 <-> 1677, 1779
1847 <-> 374, 1613
1848 <-> 204, 412
1849 <-> 626, 1570
1850 <-> 1850
1851 <-> 1308
1852 <-> 228, 455
1853 <-> 454, 1114, 1494, 1579
1854 <-> 268, 596
1855 <-> 1855
1856 <-> 1838
1857 <-> 61
1858 <-> 336, 1786, 1801, 1937
1859 <-> 1908
1860 <-> 1199, 1346, 1396
1861 <-> 1861
1862 <-> 1429, 1709, 1832, 1900
1863 <-> 9
1864 <-> 41, 1975
1865 <-> 673, 1408, 1788
1866 <-> 966, 1873
1867 <-> 914
1868 <-> 330, 520, 960, 1761
1869 <-> 2, 834
1870 <-> 1244, 1422
1871 <-> 1119
1872 <-> 1784
1873 <-> 242, 1866
1874 <-> 337, 1109, 1131
1875 <-> 795, 1403
1876 <-> 258, 1754
1877 <-> 34
1878 <-> 481, 1691, 1758
1879 <-> 1076, 1461
1880 <-> 147, 410, 1723
1881 <-> 520, 764, 1392, 1955
1882 <-> 1834
1883 <-> 319, 514
1884 <-> 1969
1885 <-> 740, 870, 1049
1886 <-> 1013, 1368
1887 <-> 1887
1888 <-> 954, 1252, 1738
1889 <-> 977
1890 <-> 446, 530
1891 <-> 1823
1892 <-> 1124, 1892
1893 <-> 395, 1187, 1893
1894 <-> 988
1895 <-> 733, 1681
1896 <-> 11
1897 <-> 77, 801
1898 <-> 545, 1898
1899 <-> 1005, 1293
1900 <-> 511, 1276, 1862
1901 <-> 1086, 1200
1902 <-> 410
1903 <-> 315, 990
1904 <-> 422
1905 <-> 1288, 1905
1906 <-> 1229
1907 <-> 1478, 1580
1908 <-> 1464, 1644, 1859
1909 <-> 706, 1360
1910 <-> 569
1911 <-> 310, 850, 1715
1912 <-> 1912
1913 <-> 279, 1132
1914 <-> 614, 929, 1727
1915 <-> 1474, 1775
1916 <-> 1916
1917 <-> 1258
1918 <-> 382, 1777
1919 <-> 41, 653
1920 <-> 1280, 1637
1921 <-> 933, 1506
1922 <-> 167
1923 <-> 857
1924 <-> 222, 1526, 1924
1925 <-> 231, 367, 1925
1926 <-> 385, 422, 986
1927 <-> 321, 513, 553
1928 <-> 728, 1226
1929 <-> 912, 952, 1965
1930 <-> 1442
1931 <-> 1073, 1489
1932 <-> 1248, 1932
1933 <-> 499, 877, 1098, 1385
1934 <-> 1165
1935 <-> 37, 631
1936 <-> 283, 757, 1262
1937 <-> 1858
1938 <-> 109, 555, 1102
1939 <-> 1085, 1329, 1577
1940 <-> 902, 1940
1941 <-> 364, 583
1942 <-> 719, 1281
1943 <-> 609, 760
1944 <-> 230
1945 <-> 1391, 1642
1946 <-> 1093, 1426, 1516
1947 <-> 1153
1948 <-> 212, 296, 500, 1684
1949 <-> 152, 737, 1386
1950 <-> 133, 296
1951 <-> 919, 1951
1952 <-> 921
1953 <-> 978, 1839
1954 <-> 657
1955 <-> 975, 1881
1956 <-> 55, 71, 235, 742
1957 <-> 1029, 1648
1958 <-> 1958
1959 <-> 886
1960 <-> 196, 301, 495
1961 <-> 674
1962 <-> 576, 1022, 1047
1963 <-> 883
1964 <-> 832, 1195, 1610
1965 <-> 1929
1966 <-> 745, 1308
1967 <-> 751
1968 <-> 524, 1968
1969 <-> 1076, 1184, 1790, 1884
1970 <-> 983, 1970
1971 <-> 1463
1972 <-> 1730
1973 <-> 457, 1318, 1421
1974 <-> 1328, 1497, 1974
1975 <-> 170, 1135, 1864
1976 <-> 1596
1977 <-> 70, 943, 1008
1978 <-> 804
1979 <-> 631
1980 <-> 522, 742, 1743
1981 <-> 1211, 1374
1982 <-> 597, 1685, 1728
1983 <-> 30, 931, 1313
1984 <-> 109, 720
1985 <-> 111
1986 <-> 767
1987 <-> 418, 701, 850
1988 <-> 1061
1989 <-> 1624
1990 <-> 744
1991 <-> 316
1992 <-> 346, 562, 1040, 1081
1993 <-> 685
1994 <-> 573
1995 <-> 381, 676, 1637, 1995
1996 <-> 576, 652
1997 <-> 554
1998 <-> 168
1999 <-> 818");
            #endregion
            #region 13
            Inputs.Add(13, @"0: 3
1: 2
2: 4
4: 4
6: 5
8: 8
10: 6
12: 6
14: 8
16: 6
18: 6
20: 8
22: 12
24: 8
26: 8
28: 12
30: 8
32: 12
34: 9
36: 14
38: 12
40: 12
42: 12
44: 14
46: 14
48: 10
50: 14
52: 12
54: 14
56: 12
58: 17
60: 10
64: 14
66: 14
68: 12
70: 12
72: 18
74: 14
78: 14
82: 14
84: 24
86: 14
94: 14");
            #endregion
            #region 14
            Inputs.Add(14, "ToBeFilled");
            #endregion
            #region 15
            Inputs.Add(15, "634,301");
            #endregion
            #region 16
            Inputs.Add(16, @"x3/10,pl/g,s9,x6/15,s10,x9/1,pi/c,x4/10,s15,x13/7,s7,x11/6,s14,x5/7,pj/b,x15/9,s9,x14/5,pg/i,x9/12,s5,x1/5,s11,pe/f,x10/7,pm/a,x13/1,po/i,x3/2,s10,x14/4,pj/a,x3/8,s8,x12/14,s1,pc/i,x2/6,pb/e,x12/5,s9,x14/9,s6,pl/m,x5/15,pj/o,x0/4,pd/p,x14/6,s2,x12/10,s3,x1/4,ph/n,x8/15,po/d,x7/14,pg/p,x4/1,pe/k,x10/15,s3,x8/3,pj/c,s14,x7/12,pl/p,x4/14,s12,x11/6,s7,x1/9,ph/n,x4/2,s5,pp/o,x15/10,pf/n,x2/6,pi/a,s11,x7/12,pm/l,x2/15,pc/f,s13,x3/6,s3,x14/12,pp/d,x5/7,s5,x3/11,pj/b,x0/5,s6,x3/6,s9,x11/1,s1,x10/6,s6,x7/9,pn/e,x4/11,s6,x7/10,s2,x14/5,s5,x3/10,pc/m,x15/5,s15,x9/4,s4,x14/11,pj/d,x6/9,s14,x1/15,ph/a,s3,x6/4,s9,x1/15,s7,x3/13,s3,x4/11,pf/n,x13/10,pp/m,x12/15,s1,x14/4,pn/j,x13/0,pd/l,s14,x8/1,s3,pf/p,x0/9,s1,x10/14,s9,x9/6,s15,x2/3,pn/k,x15/13,s12,x12/6,ph/d,x0/5,pf/j,x6/14,s1,pc/a,x10/3,pj/i,s1,x4/8,s15,x1/2,pc/d,x8/4,ph/b,x2/6,s10,x15/14,pf/p,x9/4,s15,po/n,x15/8,pd/k,x11/10,pc/b,x15/0,pf/l,x9/5,s9,x10/0,s12,x3/9,s3,x6/2,s11,x3/13,pe/d,x12/7,s1,x11/15,s7,x0/12,s5,x7/4,pa/m,x13/14,pl/d,s6,x1/0,s13,x13/4,s13,x14/11,s9,x10/0,pf/b,x12/2,s12,x5/11,s2,x3/13,pc/j,x2/8,s14,ph/n,s4,x14/11,pm/c,x2/4,pg/h,x13/6,pc/o,x14/9,s8,x13/0,pa/j,x11/14,s5,pe/n,x6/12,s3,x13/14,pb/g,x9/3,s15,x1/5,s3,x9/4,s7,x5/3,pn/l,x2/4,s5,x14/11,s9,x7/4,s15,x8/14,pk/e,x13/4,s15,x3/12,pi/l,x15/13,s6,x11/3,pm/b,x10/8,s6,x9/7,pp/e,x11/15,ph/o,x12/9,pm/j,s11,x10/1,s7,x0/9,pd/o,x2/1,pe/n,x5/4,pm/h,s10,x7/12,pn/b,x8/14,s2,po/i,x5/9,s3,x15/10,pg/k,x7/13,pn/a,x0/4,s3,x3/9,s9,x6/2,pe/l,x15/13,s13,x7/12,ph/c,x4/13,pa/e,x2/9,s9,x1/5,s13,x2/7,s9,x4/6,s4,x13/1,s10,x5/10,s6,x0/12,pj/d,x11/3,s6,x7/10,s1,x2/14,s3,x7/10,po/g,x15/9,pb/j,x2/8,pp/a,s5,x14/0,s11,x9/8,s1,x10/1,s4,x14/13,s6,x10/1,s2,x11/12,s5,x3/6,s13,x14/9,s6,x1/13,s2,x2/8,s10,x7/3,pd/c,s13,x4/10,pn/b,x12/2,pi/f,x14/8,s11,pg/e,x6/13,s9,x7/5,pl/o,x6/11,pm/i,x3/12,pc/n,x2/9,ph/p,x4/15,s11,x0/14,s14,x12/5,pf/o,x2/14,s13,x0/5,s6,x3/13,s3,x4/9,s10,x2/5,s12,ph/a,x12/1,s10,pn/e,x8/5,s13,x13/6,s1,x5/0,pc/g,x12/13,s13,x2/8,pa/e,x4/15,s5,x12/8,pi/f,x11/1,pm/o,x9/2,s6,x12/15,s13,x4/0,s5,x14/6,s1,x1/9,pi/a,x14/12,s14,x3/11,s13,x13/4,s7,pe/c,x7/1,s8,x13/15,pp/m,x5/4,s13,x3/7,s8,x14/9,s13,x2/1,pj/g,x8/3,s15,x0/14,s2,x2/13,pl/a,x5/10,s6,x12/15,s6,x1/13,pk/o,x4/10,s1,x0/9,s13,x15/3,pb/f,x9/5,s11,x13/2,pd/c,x3/4,pp/j,s12,x11/1,s7,x12/15,pm/o,x3/0,s4,pa/j,x6/9,pn/m,x2/5,pf/i,x6/4,pa/p,x10/14,s12,x6/0,pc/k,s5,x7/12,pg/f,x11/15,s6,x14/2,s5,x15/11,s14,x8/5,s10,x12/0,s9,x14/9,s4,x3/1,s3,x10/15,s8,x8/1,s6,x10/11,pm/p,x8/5,s15,x2/4,s6,x0/6,s15,x3/14,s4,x6/10,pd/o,x14/5,pe/p,x13/7,s12,x10/0,s6,x4/3,s12,pl/f,x7/2,s6,x8/13,s14,x10/14,pn/b,s7,x8/9,s10,x2/12,s9,x10/13,s9,x9/3,pm/c,x13/8,s12,x11/7,pb/n,x6/13,s5,x7/1,s11,pi/h,s4,x4/3,s12,x11/7,s13,x0/6,pk/b,x3/4,s2,x13/7,s4,x4/2,pm/c,x0/1,po/p,x7/6,s10,x5/2,s8,x9/8,s12,x2/14,pi/h,x11/5,pk/d,x0/15,pn/i,x11/9,pf/b,s11,x12/15,po/a,x7/0,s1,pk/b,x8/5,pd/e,x2/4,s3,x8/15,pa/h,x12/3,po/i,x4/13,s11,x10/2,pn/f,s9,x8/6,s5,pi/a,x14/0,s3,x2/11,pf/k,x13/6,s4,x14/10,s7,x11/0,pm/g,x7/15,pb/k,x13/3,s3,x4/8,po/f,x9/12,s6,x11/8,pn/j,x13/6,s10,x15/10,s7,x12/7,s11,x2/8,s15,x0/13,s15,x10/11,pc/b,x3/7,pn/f,x5/6,pk/h,x1/10,s12,x0/9,s15,x2/14,pd/g,x12/10,s6,pi/a,s15,x14/7,s8,pj/d,x12/4,s8,x9/2,s1,x3/10,pa/e,x12/4,s1,x8/2,pc/g,x11/15,s3,x1/10,pb/e,x5/8,s1,x3/9,pm/d,x0/11,s8,x9/12,s14,x10/13,pj/n,x5/4,s12,pi/d,x3/7,s12,x2/9,pn/e,x8/15,s6,pk/a,x1/11,s7,pb/m,x15/4,s4,x2/11,s4,pj/f,s4,x4/3,pc/i,x11/10,s6,x4/14,s7,x12/6,pj/m,x10/14,s13,x8/6,pl/d,x1/3,s1,x13/7,s9,x0/11,s14,x5/1,s4,pm/a,x8/13,s7,x12/7,s14,x10/9,s2,x13/4,s6,x5/7,s10,x9/8,pe/c,x7/11,pf/b,x9/4,pe/c,x6/10,pa/k,x1/4,po/c,x15/0,pm/a,x2/10,pg/k,x15/9,pn/i,x3/10,s3,x7/14,pc/m,x0/11,s12,x2/3,po/d,x9/15,s11,x14/5,s7,x12/9,pj/e,s1,x11/8,s12,x13/3,pi/m,x0/1,s1,x15/13,s11,x11/14,s11,x12/7,s7,x14/11,pf/k,x0/10,pe/n,x4/8,pl/k,x2/10,s15,x1/5,s10,x7/13,pa/i,s2,x15/6,pf/p,x9/13,pk/g,s8,ph/a,x11/6,s3,x5/14,s9,x8/13,pe/m,x3/4,pj/l,x10/0,pb/c,x9/11,s9,x10/2,s14,x1/15,pk/o,x11/12,pg/m,x13/10,pd/n,x4/9,s2,pe/o,x5/13,s5,x7/9,s3,pf/i,x2/5,s11,x6/12,pg/b,x7/2,s14,x15/14,s9,x13/11,s11,x4/2,pe/f,s2,x6/9,pg/a,x0/10,pe/l,x4/2,pc/g,x10/15,pp/d,x12/5,s14,x0/9,s11,x1/10,pb/l,x4/9,s15,pj/f,x11/15,s2,x6/5,s15,x12/0,pc/i,x3/10,s8,x14/0,s11,x8/1,s8,x2/13,s8,x5/7,pb/e,x3/13,s6,pg/d,x1/10,s3,x6/0,s7,x7/14,pe/p,x12/1,s4,x0/10,pg/n,s9,x13/4,pd/o,x3/15,pe/k,x13/4,po/f,s13,x8/12,pa/j,x3/6,s10,pd/k,x9/13,pe/h,x7/1,pc/a,x3/13,s7,x9/5,s3,x6/10,pk/l,x11/3,ph/c,x13/1,pi/a,x3/14,s8,x0/7,s14,x13/1,s7,x14/11,s11,x13/10,pm/d,x11/6,pe/n,x2/0,pc/o,x14/10,s13,x2/7,s7,x0/3,pp/d,x8/10,pc/a,x5/2,s9,x0/1,s14,x6/10,s1,x11/2,pj/n,s5,pm/p,x5/8,s3,x12/11,s8,x6/10,ph/l,x5/2,pd/m,x15/7,pe/p,x8/11,s2,x6/10,s12,x5/15,s3,x10/8,pk/i,x0/13,pd/a,x5/12,s14,x3/0,s14,x7/4,s11,x10/0,s15,x9/1,ph/i,x2/5,s2,x0/6,s15,x3/15,s11,x2/1,pn/f,s1,x11/5,s9,pl/j,x3/6,s11,x9/13,s8,x5/0,pa/e,s13,x14/4,pj/l,x2/1,s3,pc/k,x14/13,pl/j,s6,x2/5,s1,x8/11,s8,x9/1,s4,x6/11,s7,x8/5,pn/k,s12,x4/9,s2,x3/14,s14,x2/8,pd/e,x0/3,pk/l,x15/6,s4,x8/9,pa/d,x15/2,s10,x1/12,s15,x8/3,pn/h,x15/6,pd/l,x11/5,s11,x3/15,s10,x6/14,s14,x0/11,s8,x5/2,s4,x4/13,s4,x9/5,s3,x0/7,ph/k,x9/2,s13,x6/0,pl/m,x15/2,s7,x9/3,s4,ph/b,x13/8,pf/m,x4/12,pb/i,x8/10,s11,x15/5,s13,x12/0,s3,pp/l,s8,x4/5,s10,x8/15,pa/j,s14,x4/1,s13,x7/8,s12,x13/9,pd/f,x3/0,s6,x9/15,pp/b,x3/12,pj/e,s5,x4/14,s12,x13/15,ph/k,x2/8,s2,pd/o,x11/12,pg/i,x2/0,ph/j,s6,x6/12,s7,x10/7,pb/o,x4/8,s11,x11/1,s14,pc/i,x8/4,pm/p,x9/1,pk/l,x5/3,s13,x13/12,ph/m,s13,pd/c,x8/2,ph/i,x1/14,pa/o,x4/12,s15,x5/10,s7,pn/m,x4/8,pb/l,x14/7,s5,pa/f,s13,x0/11,s6,x4/5,s13,x6/8,s15,x14/15,ph/o,x6/9,s1,x8/10,pe/d,x13/5,s7,x7/10,s14,x3/5,s8,x12/10,s4,x1/8,pc/n,s1,pk/f,x7/11,s3,x14/8,s9,x10/5,s12,x12/15,s2,x5/2,s3,x0/3,ph/b,s9,x15/12,s12,x2/11,s8,x3/7,s4,x11/8,pf/j,x9/4,pk/o,x8/1,s6,x10/6,s13,pm/d,s1,x12/8,s10,ph/a,x3/11,pm/d,x15/4,s7,x5/6,pl/f,x10/2,s11,x0/12,ph/j,x2/1,s12,x0/14,s11,x13/1,pa/p,x3/7,s9,x1/13,pn/i,x7/12,s7,x1/0,ph/c,s15,x14/11,s12,x8/7,s8,x15/0,pi/o,x9/1,s12,x8/13,s9,x11/0,s5,x14/7,s11,x12/2,s2,x0/11,s13,x7/9,s14,x11/14,ph/l,x4/0,pb/i,x6/7,s2,x1/15,s6,x9/7,s10,pd/g,x5/2,s10,pm/i,x7/10,s8,x5/1,s11,x3/15,s6,x11/14,pe/l,x0/15,s5,x1/5,s13,x9/10,pi/f,x5/12,s1,x8/2,s10,x9/6,pb/g,x7/0,pk/a,x9/11,pj/c,s10,x14/2,s5,pi/h,x7/15,s10,x10/5,pb/n,x0/1,s12,x7/10,s2,x9/14,s6,x5/2,s2,pc/f,x6/11,pa/e,x8/0,s15,x15/13,pp/o,x1/11,ph/a,x2/14,pb/l,x10/13,s6,x11/7,s6,pg/f,x2/12,s4,x1/0,s10,x10/9,s14,x2/13,ph/b,x4/8,s8,x0/6,s13,x14/2,pi/g,x13/11,s3,x5/10,s9,x9/13,s8,x10/3,s11,x5/15,s5,x2/8,po/l,x12/7,pc/j,x8/1,pg/n,x5/0,s8,x8/3,s5,x10/14,s2,x0/13,pm/l,x4/12,pf/g,s10,x0/10,s3,x1/12,pj/m,x0/3,s11,x13/14,s4,x15/2,pl/b,x10/12,s13,x13/1,pm/c,x4/10,pl/k,x12/11,pn/h,x4/3,pp/j,x14/10,pd/a,x2/4,s12,x9/15,pn/i,x8/13,s7,x14/15,s7,x4/5,s5,x14/12,s3,x1/2,s15,x7/11,s11,x8/14,s8,x1/4,s5,po/a,x3/0,s1,x8/2,s5,ph/f,s9,x9/1,s3,x10/0,s13,po/j,x4/13,s3,x5/11,pn/m,x2/8,s1,x3/13,s9,x14/5,pf/h,x8/9,s12,x6/15,s14,x4/13,s8,pe/b,x6/3,s13,x0/14,pf/d,x4/13,pb/g,x2/8,ph/p,s2,x5/15,pl/n,x11/12,s2,x5/10,s11,x2/0,s4,x12/5,s12,x9/1,s8,x12/15,s6,pp/k,x7/3,s2,x12/14,s9,x0/3,pc/g,x14/1,s6,x0/15,pi/h,s7,x9/2,pp/m,x11/4,s14,x5/8,s1,x12/7,pe/c,x13/10,po/a,x11/3,pe/p,x14/5,pl/k,x13/7,pm/d,x3/1,pn/b,x14/13,s3,x6/5,s2,x9/1,s2,pf/h,x15/8,po/b,x1/14,s2,x6/8,pn/e,x0/10,pb/a,x1/3,pd/e,x0/13,s13,x10/6,pa/p,s14,x7/4,pe/m,x5/1,pd/c,s14,x9/2,s4,x11/5,pg/o,x7/15,s5,x4/10,pp/j,x1/5,pc/d,x13/8,s10,x10/5,s10,pl/k,x0/7,s13,x15/3,s10,x10/2,pm/f,x7/3,s8,x11/0,pp/e,x1/12,s14,x5/10,pi/d,x4/6,po/m,x1/2,s11,pb/a,x14/13,s1,x2/3,pf/n,x13/12,s6,x8/15,s6,x2/9,pj/k,s5,x14/7,s3,x10/5,pf/p,x6/11,s1,x8/14,s3,x6/10,pk/m,s7,x9/13,s4,x1/6,s3,x2/4,pe/n,s14,x14/5,pb/m,x12/11,s4,x5/6,pj/o,x15/1,s14,x6/4,s8,x12/3,pm/e,x9/6,s14,x3/10,pi/c,x0/6,s6,x13/14,pf/n,x11/0,s13,x9/6,pa/j,x5/2,s14,x11/0,s7,x1/2,s14,x7/10,pg/i,x2/5,pl/c,x13/7,s1,pb/n,x6/10,s4,x9/2,pl/o,x7/5,pm/g,s7,x15/2,s6,x13/5,s1,x15/8,s1,x3/5,s4,x8/6,s13,x7/10,s9,x3/0,s3,x8/5,po/d,x4/13,s5,x9/15,s9,x13/8,s14,x4/15,s12,x11/5,s11,x0/4,pi/b,x12/7,po/g,x1/9,pi/l,s11,x5/4,s14,x10/6,pd/k,x0/9,pp/n,x5/13,pl/f,x8/14,pp/b,x10/7,s9,x11/13,s5,x14/15,pg/o,x1/0,s8,x10/8,s12,x12/7,pk/j,x6/2,s1,x7/4,s14,x3/0,s12,x12/11,po/g,x14/2,s5,x0/8,pk/c,x11/6,s10,pn/o,x2/1,pb/k,x7/4,s7,x9/5,pp/c,x3/12,s2,x7/6,s12,x15/2,s9,x4/10,pe/n,x8/14,s12,x2/3,s11,x14/11,pl/c,x12/8,pb/p,x1/15,s1,pm/h,x6/4,s10,x9/12,pf/o,x13/6,s4,x3/4,s10,x0/14,pn/k,x11/8,pe/h,x15/3,s12,x6/9,pp/l,x12/5,pe/a,x4/1,s15,x14/6,s13,x0/15,s5,x5/1,s3,x2/3,s15,pc/n,x10/0,pl/f,x1/9,s1,x14/7,s11,x4/11,pi/a,x12/1,s6,x11/10,s12,x5/7,pb/l,x8/4,pi/a,x5/6,pk/b,x11/14,s14,x9/5,s14,x10/15,s10,x11/5,pj/a,s13,pp/m,x0/15,pn/e,x14/8,pc/p,x6/2,s6,x9/8,pl/o,x15/12,s7,x11/6,s11,pn/e,x3/8,ph/d,x11/12,pm/f,x6/15,pp/o,x1/8,s3,x13/11,s5,x5/9,ph/g,x8/7,pb/p,x10/2,pa/o,x0/9,s6,x7/3,s11,x2/6,pb/g,x7/12,pc/d,x4/6,pf/m,x15/11,pp/i,x9/6,pm/d,x3/12,s11,x6/1,ph/i,x3/9,pj/b,x11/14,pc/l,x9/6,s5,x7/11,s4,x1/4,pg/i,x7/6,s13,x4/10,pa/o,x6/9,s11,x7/2,ph/k,x3/9,pd/b,x5/13,s4,x8/4,pn/j,x15/10,s13,x12/14,s9,pi/d,x5/0,pa/p,s10,x15/8,pc/d,x11/5,pk/i,x3/14,po/h,x10/0,s15,x5/11,s2,x8/2,s9,x11/6,pm/f,x12/7,s15,x8/14,s2,x11/15,pj/c,x4/0,pa/g,x14/9,pj/n,x3/1,po/b,x6/11,s15,x13/15,s12,pm/p,x0/10,pk/b,s3,x5/13,s14,x4/3,pl/n,x14/12,pe/f,x5/1,s5,x14/7,pb/p,x11/3,s1,x8/1,s3,x13/7,s4,x8/3,s15,x2/15,ph/i,x0/8,s2,x2/4,s15,pl/k,x10/15,pn/o,x11/7,s7,x15/9,s9,x11/7,s12,x8/1,pc/i,x11/9,pp/o,x8/2,s9,x1/7,s13,x4/8,ph/d,x9/11,s1,x5/7,po/n,x4/11,s6,x14/3,ph/d,x8/10,s1,x4/13,pe/i,x6/11,s3,x8/1,pa/d,x7/5,s14,x2/9,pg/m,x5/7,s12,x12/14,s13,x4/11,s8,x14/8,s11,x3/5,pn/i,x4/0,po/m,x7/12,s11,x9/8,s12,x2/3,s5,x13/7,s13,pe/p,x4/5,s3,x1/3,pj/l,s13,x9/11,s1,x5/10,s6,pf/b,x8/3,s8,pl/h,x9/12,s9,x13/6,s5,x3/0,pn/b,s10,x2/13,pk/j,x14/1,ph/o,x4/0,s8,x2/12,pn/g,s12,x7/9,s15,x3/5,s1,pa/p,x12/14,s6,x2/0,s7,x12/4,po/d,x13/11,s3,x14/3,pp/c,s14,x2/0,pi/j,x12/4,s14,x11/8,s4,pd/e,x3/7,pp/m,x5/13,pi/d,x12/14,s4,x3/5,s12,x2/4,pn/a,x9/8,pk/p,x1/15,s15,x0/12,s7,x11/7,s11,x6/3,s12,x14/5,s8,x3/12,s9,x10/11,ph/f,x5/8,po/k,x10/4,s2,x12/14,s12,x9/2,pj/m,x0/6,pf/a,x13/15,s6,x6/12,pl/i,x10/8,pm/c,x2/1,pa/e,x9/10,pi/f,s4,x4/14,s11,pj/p,s9,pf/n,s7,x3/10,pb/i,s2,pn/p,x1/11,pe/j,x3/0,pk/p,s7,x1/6,pf/c,x8/14,s2,x2/5,s9,x15/0,pj/d,x9/11,s13,ph/a,x4/6,s4,x14/2,s2,x13/0,pn/d,x3/14,pb/a,x1/10,ph/d,x0/2,pn/l,s14,x1/14,s12,x9/12,pd/f,x6/3,s3,x9/8,s5,x14/5,s12,x8/13,s13,x14/5,s8,pj/p,x1/11,pd/k,x12/10,s11,x4/14,s10,x5/15,s5,x7/6,s9,x8/11,s4,x12/15,s14,x4/13,s13,pb/c,x9/7,s12,x5/10,pg/l,x12/2,pb/f,x1/13,s2,x0/3,pp/i,x10/14,s8,x0/12,pg/c,x6/11,s13,x13/0,pe/n,x14/10,s14,x3/15,s6,x11/14,s11,x10/12,pj/h,x0/13,s12,x14/15,pl/c,x1/0,pg/h,x6/2,s14,x15/7,pi/n,s2,pm/d,x13/4,s4,x5/14,pn/h,x11/9,pl/e,x7/14,s4,pn/o,x0/9,s9,x8/14,pe/c,x12/0,s12,x9/1,s7,x4/12,s8,x13/6,s8,x7/8,s4,x10/15,s12,x1/7,s12,pj/g,x13/8,pn/f,x0/1,s4,x14/2,pg/b,x11/1,s5,x3/10,s1,x8/1,pa/l,x15/7,s4,x4/5,pe/d,x10/7,s3,x3/15,s1,x11/12,ph/a,s12,x6/0,s9,x13/7,s1,x10/14,s2,x9/11,s1,x10/5,pm/d,x7/2,s15,x9/3,s3,x10/0,s3,pb/h,x1/13,s14,x11/2,s11,x6/12,s15,x3/7,s13,x10/8,pk/a,x7/5,s9,x12/13,s3,x2/5,s14,pl/i,x10/15,s7,x11/12,s1,x8/13,po/m,x4/1,pj/b,x15/2,pp/k,x9/10,pn/g,x12/8,s10,x4/7,ph/e,s14,x9/13,s11,x14/3,pi/d,s6,x7/10,pf/a,x11/5,s15,x14/7,s14,x3/10,s13,x15/1,s14,x7/13,pn/h,x15/4,s3,pi/d,s5,pf/k,x10/0,s3,x1/13,po/l,x14/12,ph/e,x13/15,s1,x5/10,pf/m,x7/9,s14,x3/2,po/p,x0/11,s2,x4/8,s15,x15/10,s3,x5/2,s9,x14/13,s6,x10/15,pg/c,x7/6,s6,x15/10,pn/j,s5,x7/12,pm/b,x1/15,pf/l,s6,x0/8,s3,x9/1,pa/p,x3/4,s12,x2/13,ph/e,s5,x10/7,pl/p,s4,x0/12,ph/j,x4/8,pn/l,x2/15,s11,x10/0,pc/j,x6/13,pb/l,x8/10,pe/i,x7/9,pp/h,x6/14,pn/a,x12/7,pe/f,x9/4,s13,x2/0,ph/o,x6/8,s15,x1/9,pn/d,x6/13,s15,pm/h,x15/5,po/g,x10/12,pd/j,x4/15,pa/c,x10/0,s6,x7/15,pk/o,x11/1,s14,x10/8,s15,pe/f,x14/11,pg/l,x7/2,s6,x5/13,s1,x12/6,s5,x2/11,pi/c,x7/14,s4,x5/15,s7,x11/0,ph/m,x7/6,s15,x9/11,s9,po/f,x0/13,s10,x15/14,pp/g,x3/1,pa/j,x9/5,pf/o,x4/3,s5,x13/11,pd/p,x8/10,s13,x14/3,s5,pl/h,x4/7,pg/k,x8/9,pd/i,s9,x7/5,ph/a,x6/2,pj/k,x1/9,s15,x6/5,s9,x4/15,s9,x13/11,s11,pm/g,x3/14,pd/j,x0/11,pe/n,x4/9,pg/p,x11/5,s3,x3/7,po/n,x8/5,pm/f,x10/9,s14,x2/1,s8,x5/14,po/d,x1/3,s13,x2/4,s3,x14/9,s13,x1/0,pc/e,x3/4,s11,x6/14,s11,x7/11,s10,x14/15,po/m,x0/6,s11,x5/4,s3,x10/2,pb/h,x12/13,pd/k,x2/6,s14,x15/1,s2,x8/7,s13,pj/n,x3/12,s1,x13/7,pg/c,x3/4,s15,x12/10,pe/i,x9/6,s14,x14/11,s10,x7/6,s14,pa/m,x10/14,pk/d,x1/9,pg/b,x13/14,s13,x10/6,s2,x7/1,po/k,x11/0,pd/i,s14,x1/5,s9,x9/7,s9,pn/k,x0/13,pm/a,x6/12,s7,x4/9,s11,x10/13,s14,x11/7,pj/i,x8/10,s8,x2/6,s5,pb/m,x1/8,s1,x12/6,s7,x10/4,s1,x2/7,s10,x3/6,s6,x5/1,s5,x0/7,s8,x10/11,s9,x1/3,s15,x9/4,pc/n,x14/6,pb/m,x10/15,s14,x14/1,s15,x9/0,s3,x2/12,pd/f,x10/3,s4,x9/13,s10,x3/2,pp/c,x9/12,s11,x5/15,s12,x4/10,s8,x1/8,s10,x9/7,pf/d,s5,x4/6,po/m,x0/7,s1,x8/9,s13,x3/4,pd/a,x15/8,s13,pf/l,x1/2,s9,x12/13,s14,x4/14,s15,x11/6,s9,x7/5,pc/p,x15/13,pb/m,x5/11,s14,x13/14,s1,x9/3,pd/j,x5/8,s6,x14/6,s14,x11/15,s2,pb/a,x0/8,s1,pk/i,x2/4,pg/j,x13/11,s6,x9/5,pl/i,x12/0,po/m,x2/13,ph/k,x10/5,pf/l,x9/2,s12,x0/1,s15,po/h,x2/10,s13,x4/15,s12,x12/10,pk/n,x7/8,s7,x1/2,s14,pf/p,s15,x0/11,pe/a,x12/5,pn/g,x9/10,pb/p,x7/12,s14,x3/10,pn/h,x8/2,s14,x7/4,s1,x5/6,s9,x2/13,s10,x1/8,s10,x12/2,s11,po/b,x9/0,s7,x8/14,s13,x12/10,s4,x1/3,pe/d,x6/4,s3,x7/2,s4,x5/15,s4,x1/13,pc/n,x14/9,s5,x12/6,pj/k,x8/14,po/h,s2,x0/10,s15,pe/p,x13/2,pj/f,x10/9,s15,x6/12,s4,po/g,x15/1,s11,ph/m,x7/4,s12,x12/13,pj/d,x14/0,s6,x3/11,pm/c,x15/0,pk/h,x7/10,pg/i,x6/11,s8,x9/12,pj/e,x3/1,s13,x4/5,s15,x8/9,po/l,x2/10,s6,pc/h,x7/3,pe/f,x1/15,s13,pa/d,x4/9,s2,x14/6,s7,pi/o,x8/0,pm/p,x4/14,s15,x6/13,s5,x1/11,pc/o,s2,x15/0,s8,x7/1,pl/k,x8/13,s11,x7/3,s12,x0/13,s4,x12/2,s11,x4/10,pp/j,x8/5,s7,x1/9,pf/h,x10/7,s13,x12/8,s13,x0/10,s11,x5/12,s8,x3/9,po/n,x2/12,s8,x5/7,pi/g,x3/15,s12,x7/12,s5,pe/n,x0/6,pk/c,s12,x13/7,s12,x10/12,po/e,x5/8,pp/h,x12/15,s12,x14/0,pe/l,s1,x1/3,s14,x10/6,s8,x9/3,s6,x5/8,pa/i,x1/15,pm/h,x4/12,s6,x14/0,pf/d,s6,x8/13,s2,x10/4,s14,x1/11,pb/c,x7/3,s14,x1/8,pi/p,x12/14,pg/k,x11/9,s7,x13/1,s12,x0/8,s11,x3/9,s4,x2/13,s8,x8/3,ph/j,x1/15,s1,x14/8,pa/c,x11/7,s9,x2/8,pj/e,x4/12,s10,x7/15,pc/m,x13/0,s4,x9/7,s5,x3/5,s11,x13/12,s4,x11/8,s2,x14/13,s9,x1/12,po/n,s11,x5/6,s3,x0/13,s7,x3/10,s10,x7/1,pc/m,x13/5,s10,x3/12,s1,x5/1,s12,ph/e,x12/2,pf/b,x0/4,s8,x11/5,po/e,x1/2,pf/d,x0/3,s12,x6/1,s11,x3/2,po/g,s1,x13/1,s12,x12/7,s9,pb/a,s14,po/h,s4,x9/11,pp/f,x10/2,po/l,x6/7,s3,x10/9,s9,x4/7,s10,pf/c,x8/14,s6,x10/4,s11,x6/0,pl/p,x11/8,s12,x14/1,s5,x9/2,pk/g,x12/10,ph/e,x13/7,s2,x14/6,s10,x2/4,s10,x9/6,s9,x14/12,pl/o,s9,x10/3,s2,x0/8,pk/d,x4/13,s12,pj/g,x0/1,pf/l,s14,x4/8,s2,x9/1,s2,x15/11,pg/d,x2/7,s7,x14/3,s1,x11/13,pm/a,x7/1,s5,x6/12,s1,x9/14,pf/d,x0/11,s11,x3/14,s6,x1/7,s9,x9/8,pc/i,x3/0,pd/o,x8/6,pj/i,x4/13,s11,x9/5,s3,x0/12,s1,x2/9,pm/g,x1/14,s10,pa/p,x0/12,s3,x2/14,s4,pj/n,x1/8,s4,x12/14,s9,x9/6,s11,x5/10,s1,x9/7,pd/i,x4/2,s11,x9/1,s9,x2/5,ph/o,s12,x4/13,pe/c,x8/5,s12,x6/14,s7,x13/10,pf/b,x15/6,pi/e,x10/14,s11,x13/6,s5,x0/10,s12,x12/14,pb/p,s14,x11/7,s12,x4/12,pc/e,x13/11,pb/d,x6/9,s3,x12/13,s14,x5/7,s5,x1/9,pi/e,x8/12,pn/j,x13/10,pd/h,s13,pj/p,x11/0,s8,pc/f,x6/15,s9,x8/2,ph/e,x10/9,pd/k,x8/3,s5,x15/11,pc/e,s8,pi/h,x4/1,s14,x14/15,s5,x0/6,s3,x10/1,pe/f,x0/7,pd/m,x14/3,pk/o,s2,x4/11,s5,x10/8,pe/g,x5/6,po/h,x4/14,pp/f,x15/11,pb/a,x1/2,s14,x5/9,pm/f,x6/11,pb/a,x12/3,pg/o,x7/4,s8,x12/0,s1,x10/4,s3,x8/2,s13,x13/5,pb/m,s6,x7/9,s14,x15/5,s12,x8/4,pc/g,x5/0,s5,x2/8,po/h,x14/5,pf/g,x13/1,s3,x4/3,s3,x13/15,ph/a,x8/12,s6,x0/14,s11,x9/2,s2,x13/4,pi/b,x3/14,pk/p,x5/11,po/e,x2/12,s5,x6/1,pl/i,x5/2,s14,x0/8,s8,x2/14,s3,x10/13,s7,x5/2,pp/f,x12/14,s1,x15/1,s13,x7/9,po/m,x0/15,s9,x2/12,s8,x4/7,pe/a,x11/9,s1,x15/0,s15,x11/3,s1,x10/14,pl/n,x12/4,s3,x10/0,s10,x2/3,s15,x15/14,s10,x4/8,s11,x14/1,pj/g,x3/5,pp/m,x7/15,s10,x1/14,pg/j,x3/5,s9,x0/7,s1,x6/8,pi/p,s14,x11/14,s6,x3/5,pa/g,x1/11,pd/o,x5/15,s6,x6/8,s7,x9/2,pe/f,x14/10,pg/p,x7/13,s6,x14/8,pk/a,x6/15,s13,x2/8,s6,pl/o,x11/15,ph/k,x10/2,s9,x7/8,pc/a,s9,x5/12,s14,x10/8,s13,x6/12,s13,x10/14,s10,pl/h,x2/12,pm/d,x7/1,s5,x0/8,s7,x2/3,pf/k,x4/5,pg/i,x14/11,s7,x6/1,pa/l,x5/14,ph/p,x0/13,pi/n,x1/2,s2,pd/e,x12/13,s5,x8/9,s5,x3/10,s10,x5/7,s2,x4/12,s3,x10/15,s3,pj/l,x13/7,pe/h,x6/4,s5,x13/9,s13,x6/3,s14,x5/13,s8,x15/0,pk/o,s2,x3/4,s5,x15/10,ph/l,x14/7,pk/f,s9,pc/h,x0/6,pg/p,x5/13,pn/h,x8/12,s8,x14/15,pa/k,x9/7,pc/p,x15/2,s14,x13/8,s14,x12/4,pi/d,x14/10,s14,x8/2,s1,pa/j,x13/10,s12,x12/1,s13,x2/5,pc/b,x4/11,po/i,x0/5,pn/d,s6,x2/10,pe/h,x5/15,s3,x0/6,pg/k,x15/5,s9,x8/3,s5,x12/2,s4,x1/10,po/i,x11/9,s14,x6/10,s4,x12/0,s13,x10/2,s13,pa/k,s11,x5/7,po/g,x4/2,s5,x6/14,s2,x4/12,s5,x14/3,s3,x8/5,s8,x11/1,pi/n,s4,x12/0,pj/f,x10/4,s10,x8/0,pm/l,x13/1,s2,pg/h,x4/2,s4,x8/1,s14,x10/11,s3,x1/9,s6,x13/7,s2,x14/4,s14,x6/5,s3,x9/12,s12,x10/8,pn/o,x11/15,s14,x12/4,s6,x10/6,pd/g,x5/11,pj/l,x8/6,pm/e,x5/7,s2,x12/3,ph/c,x7/14,s1,x12/5,s15,x7/2,s1,x6/14,pf/j,x0/3,pk/p,x9/13,s3,pi/d,s5,x4/15,s5,x9/1,s8,x3/15,s3,x14/4,s8,x7/11,pg/c,x5/4,pf/b,x2/8,s6,x4/9,pi/j,x8/11,pl/d,x2/7,pp/f,x0/3,s5,x15/9,s2,x2/5,pa/i,x10/12,s10,x15/5,s5,x2/7,s13,x6/15,pb/h,x9/8,s5,x12/4,s9,x10/5,s14,x11/7,s14,x2/9,po/c,s5,x11/15,s13,x4/7,s8,x8/12,s7,x1/0,s6,x8/6,s6,x3/10,ph/m,x8/7,s7,x4/13,s9,x7/8,pf/p,s13,x10/3,pi/k,x4/15,pp/n,x2/13,pg/f,s8,x8/14,pi/h,x9/1,s2,x10/12,pp/d,s6,x3/4,s5,pf/b,x7/6,ph/p,x8/10,s4,x9/0,s14,x13/7,pb/n,x1/12,s13,x2/9,s15,x5/14,s12,x1/0,pm/c,x8/10,pd/p,x11/6,s11,x10/8,s8,x11/12,s14,x13/2,s9,x3/12,pg/o,x15/5,s12,x13/1,s13,x12/8,s2,x9/3,pb/i,s3,x0/12,s6,x13/15,pm/j,x11/14,pi/b,x15/9,pm/a,x8/11,pf/e,s3,x6/2,s8,pm/b,x5/9,pj/g,x6/13,po/f,x8/3,pd/l,x10/14,s5,x8/1,s7,x15/14,pc/k,x7/10,s12,x9/6,pb/l,x4/1,ph/n,x10/2,s8,x14/7,pl/f,x3/4,s4,x1/6,s5,x0/5,s12,pa/c,x12/2,s11,x9/1,pp/e,x11/3,s6,pj/o,x1/13,s14,x12/11,s5,ph/k,x2/6,s7,x15/9,pj/f,x6/1,s3,x0/2,pg/i,s3,ph/b,x1/12,pj/o,s6,x14/9,pn/b,x13/4,s4,x10/9,po/d,x6/5,s10,x15/11,pj/b,x12/0,s5,x8/13,s9,x15/11,po/c,s4,x14/3,s2,x6/10,s4,x12/2,s6,pe/k,x7/15,s3,x14/3,pa/m,x5/6,pi/b,x2/10,pl/g,x1/11,s9,x10/2,pe/a,x1/5,s7,x2/9,s13,x11/10,s4,x12/3,s1,x6/9,ph/b,x15/4,pp/i,x6/2,s14,x9/8,s2,x14/15,s3,x13/12,s11,x14/10,s10,x8/9,s4,x2/4,s3,x14/3,s13,x11/15,s1,x12/3,pk/c,x4/11,s6,pe/o,s2,x1/5,s13,pc/n,x11/3,s3,x5/13,pm/h,x7/0,s15,x13/12,s13,x9/7,s3,x12/0,s15,x9/4,pi/o,x11/1,s12,ph/f,x12/0,s13,x10/11,s8,x13/2,pg/o,x12/15,ph/e,x7/11,s15,x5/0,pd/p,x9/6,s15,x7/4,pf/b,x5/6,pg/p,x10/9,s1,x2/7,s10,pa/e,x3/13,pp/b,x6/11,s10,x1/8,s12,x5/6,pi/m,x13/12,s3,x6/3,po/b,x12/9,s14,x1/5,pk/g,x11/15,pf/o,x6/12,s7,x1/7,pk/i,x2/6,pe/o,s13,x0/14,s1,x2/3,s6,x13/8,s15,x1/12,s11,x9/6,s9,x12/4,s10,x5/1,s13,x0/4,s12,x7/14,pl/c,x1/3,s7,x8/7,s2,ph/d,x10/15,s10,x14/4,s11,x7/5,pi/p,x1/0,pa/j,x9/5,pm/g,x6/3,s7,x1/9,s10,x12/4,s10,x7/0,s2,x9/2,s13,x3/7,s10,x1/4,s12,x7/10,pe/c,s5,x9/12,pi/a,x6/13,pj/n,x4/7,s10,x3/13,s11,x6/2,s13,x15/9,pp/g,x7/6,pi/a,s2,x2/10,pg/f,x4/14,ph/m,x6/8,s2,x10/14,s10,x4/1,s9,x11/7,s6,x12/5,s7,pf/a,x0/10,s12,x9/1,s9,x6/10,s6,x4/2,s8,x10/14,pj/p,x8/6,s2,x12/10,pe/h,s14,x0/11,s4,x9/6,pj/c,x14/1,s7,x9/13,s8,x6/0,s10,x5/15,s8,x3/4,s12,x8/15,s7,x14/6,pk/f,s13,x9/11,pm/c,x14/6,s4,x4/0,s13,x6/11,s7,x4/5,po/e,x3/14,s10,x1/0,s14,x12/10,s15,x11/4,s12,x2/12,pc/d,x9/11,s2,pm/a,x5/7,s3,x4/14,s11,x13/15,s5,x3/5,pd/c,x0/7,po/g,x11/12,pd/c,x3/14,s11,x6/4,pn/a,x11/0,pm/d,x7/13,pn/b,x3/1,pj/i,s11,x5/14,s12,x2/13,pe/m,x15/5,s14,x3/4,pf/h,x1/2,po/l,x10/5,pc/j,x11/0,s10,x4/1,s9,x15/11,s12,pp/f,x9/8,pm/j,x1/6,s6,x15/4,pl/o,x3/1,s10,x5/13,s14,x14/12,s10,x5/7,pk/p,x4/0,s1,x6/5,s13,x0/14,pf/l,x11/8,s12,x7/2,pd/k,x0/3,s9,x7/15,ph/c,x2/4,s5,x3/6,s13,x2/8,s12,x14/12,s9,x11/4,s15,x2/0,s10,x1/15,s7,x3/7,s14,x5/14,s5,x13/12,pn/g,x11/14,pm/f,x6/15,pi/l,x9/2,s1,x0/10,pm/n,x13/4,pi/d,s7,x10/8,po/h,x1/6,pb/d,x10/3,s12,pi/o,x12/2,pj/b,x4/7,ph/n,x15/13,pg/l,x7/12,pd/a,x3/15,pm/c,x14/2,pg/b,x0/1,s1,x10/2,pc/i,x14/7,s7,x9/0,pp/f,x15/11,pd/h,x9/13,s15,x3/8,pm/o,x15/4,s5,pf/e,x13/14,po/c,s13,pf/e,x12/7,s11,x10/6,s9,x0/11,s9,x15/3,s11,x14/0,s5,x9/10,pj/i,x4/13,pc/g,x2/3,pi/d,x13/1,s7,x6/10,s9,x9/8,pb/p,x12/1,s12,x14/7,ph/c,s2,x10/11,pl/k,s11,x4/1,s14,x6/3,ph/i,x11/7,pf/k,x9/5,s14,x10/2,s1,x13/8,ph/d,x4/1,po/c,x5/8,pp/m,x10/7,po/n,s12,x4/9,pa/b,s7,x12/1,ph/i,x13/6,po/n,x12/4,s12,x0/6,ph/k,x1/5,pa/m,x2/9,pn/d,x0/3,s5,x4/8,pb/a,x2/14,s4,x11/3,s12,x13/12,po/e,x15/5,s12,pk/n,x9/1,ph/g,s12,x13/12,s14,pl/k,s7,x6/2,s8,x11/4,pa/j,x0/12,pg/p,x13/8,s6,x3/15,s6,x7/4,s11,x0/13,s14,x2/8,s14,x6/0,s15,x9/13,s15,x5/14,s8,x8/13,s2,x15/6,s8,x13/0,s3,x12/3,s3,x15/11,s12,x0/10,s7,x13/14,pd/n,x1/2,s1,x12/0,s9,x5/2,s3,x12/8,s4,pp/a,x13/3,s6,x15/14,s2,x0/8,pm/e,x13/11,pj/b,s12,x3/12,pp/o,x7/4,pc/m,x9/11,s12,x4/14,s9,x1/11,s4,x13/4,pd/o,x11/0,pb/j,x6/10,pd/i,x4/3,s15,x12/8,s10,x0/1,s1,pb/e,x3/6,s7,x12/13,po/p,x2/11,s4,x1/7,s14,x15/9,pc/g,x2/14,ph/j,s8,x11/12,pi/g,x1/0,pe/l,s10,x9/5,s14,x10/8,pc/m,x14/9,s12,pg/e,x13/6,pm/f,x9/2,s2,x15/13,pg/n,x2/14,pe/a,x8/6,s1,x14/12,s4,x1/9,s11,x14/10,pc/i,x7/5,s6,x9/6,pd/m,x0/7,pg/p,x14/15,s4,pk/j,x8/5,s11,x1/9,s6,x15/11,s15,pb/i,x5/1,pm/g,s10,pk/n,s8,x0/14,s1,pe/g,s10,x5/7,s8,x6/12,s5,pa/o,x2/9,s6,x5/6,s9,x8/7,pe/p,x10/1,s10,x0/12,ph/o,s3,x8/14,s3,x13/0,s7,x1/10,s6,pp/k,x8/6,pm/g,x7/11,s14,x4/13,pe/l,x1/7,s9,po/i,x3/11,s5,x8/15,s4,x13/2,s15,x11/3,s3,x1/0,s6,x7/2,s14,x14/12,s12,x4/2,s6,x14/12,s10,x7/2,s9,x14/1,s4,x3/7,s6,x1/11,s5,x6/4,pk/a,s12,x15/10,pc/b,x9/3,pd/a,x8/5,pi/k,x6/15,pg/a,x7/12,po/i,x3/11,s10,x2/6,s4,x11/4,pa/b,x8/7,s9,x6/2,pe/o,x12/8,s13,x10/7,s8,x15/8,s15,x11/9,s14,x6/10,ph/p,x0/13,pm/b,x5/7,pj/k,x1/3,ph/l,x2/12,s3,pe/n,x9/6,s12,pk/i,x5/13,pd/o,x6/15,pm/b,x2/4,s6,x9/15,s8,x0/8,s9,x13/11,pj/c,x5/3,s2,x6/8,pb/a,x15/11,s8,x0/9,s10,x1/13,s12,x12/2,pj/n,x8/14,s4,x5/11,s15,x3/10,s2,x13/12,pl/d,x6/8,s13,x1/10,s8,x9/14,ph/g,x7/11,s9,x6/8,s10,x2/12,s7,pa/c,x10/9,pm/d,x3/2,s1,x11/7,po/h,x13/9,s3,x5/2,s8,x9/11,pk/l,s13,x7/12,s4,x13/8,s4,x0/14,pi/d,s8,x1/7,pj/k,x4/6,s7,x3/8,s5,x15/5,s13,x1/0,s10,x15/11,s5,x6/3,pe/b,x4/13,s3,x1/0,s4,x14/9,s12,x1/2,s4,x13/10,pp/o,x8/11,s6,x1/4,s6,x7/15,pd/l,x1/3,pi/m,x10/8,pg/e,x14/11,s1,x3/12,pa/h,x6/10,pd/m,x2/7,pp/j,x9/10,s9,pa/e,x6/15,pc/g,x7/4,s15,x14/9,s6,x2/3,pb/p,x8/1,pl/n,x9/13,pk/f,x15/1,s10,x13/2,s12,x0/3,s7,ph/b,x10/9,s1,x7/6,s15,x10/13,pk/c,x6/2,pd/j,x5/3,s7,pe/f,x2/8,s7,x13/3,s9,x7/12,s7,x5/2,pj/g,x0/12,s14,x3/13,pb/i,x15/8,s4,x0/11,po/l,x12/3,pe/d,x0/5,s3,x6/9,pa/n,x12/14,s13,x13/7,pd/h,x5/0,po/b,x6/9,s3,x7/3,s15,x5/6,pj/i,x0/13,pe/g,x9/4,pk/m,s14,x0/14,s6,x11/10,pb/l,x6/12,s6,pg/e,x14/13,s8,x3/0,s11,x13/8,s13,x11/1,ph/d,x6/3,pj/a,s7,x13/4,s9,x1/14,ph/e,x12/9,pa/m,x14/7,pj/p,x11/4,s10,x0/8,s12,x10/2,pi/m,x14/12,s7,x1/0,s11,x6/10,s12,x2/9,pl/b,x11/10,pm/e,s8,pd/i,s4,x4/1,s9,x13/7,s10,pc/k,x2/4,s13,x8/3,pb/e,s10,x10/13,ph/l,x6/12,pc/e,x3/13,ph/f,x10/8,s1,po/j,x5/7,pb/g,x2/11,ph/a,x12/7,s13,x13/1,s13,x11/3,po/i,x4/8,s1,x11/7,s2,x8/12,s2,x11/13,s14,x4/15,s3,x12/11,pf/p,x0/6,s15,x12/8,s9,x10/14,s15,x8/1,s8,x12/9,pk/n,x13/5,pf/e,x4/8,s7,x0/14,s11,x7/6,s3,x12/0,pg/b,x3/10,s15,pi/e,x9/4,pa/o,x0/3,s9,x4/8,s10,x9/7,s12,x1/14,s13,x15/13,pk/j,x7/10,pg/m,x13/4,po/d,s15,x11/15,pi/a,x5/10,s11,x2/3,s10,x12/5,pk/d,x9/11,s12,x3/14,pp/a,x9/11,s8,x0/3,s12,x14/2,pg/h,x12/6,pd/b,x10/4,pk/p,s1,x2/13,s14,x10/5,pi/l,x8/3,pe/f,x1/10,pd/n,x3/7,s10,x14/8,s12,pg/i,s15,x2/1,pb/h,x15/6,pm/o,x8/12,s1,x10/7,s4,x9/11,s1,x14/6,s4,x4/5,s12,x12/0,pk/h,x4/10,s11,x2/5,pd/m,x14/12,pi/b,x13/3,s9,x8/0,s13,x14/10,s15,x7/6,s11,x1/4,s1,pa/k,s1,x0/13,pd/c,x7/9,pe/h,x6/2,s12,x7/4,s4,x10/14,po/a,x4/1,s4,x13/15,pj/h,x10/9,pk/a,x14/12,pd/l,x8/7,s14,x1/4,pn/c,x5/12,s8,x7/1,s12,x2/0,s13,pk/h,x8/12,s1,x0/6,s3,x3/11,s13,pi/b,x9/0,s11,x7/13,s13,x9/10,s12,x3/0,s2,x9/11,pc/d,s5,x14/13,s9,x1/3,s13,x13/6,s7,x10/4,po/n,s8,x2/5,pi/p,x4/1,pe/k,x13/9,s9,x6/14,pp/j,x10/3,s5,x7/12,s1,x2/10,pe/k,x15/14,s12,x1/2,pc/n,x7/15,pj/g,x6/14,s8,x3/8,pd/f,x4/11,s2,x15/10,pm/p,x5/7,ph/l,s1,x10/1,pk/g,x3/12,po/n,x11/5,s11,x9/3,s12,x7/5,s5,x9/2,s7,x0/7,s6,x3/9,s13,x15/6,pd/m,x13/14,s14,x4/6,s8,x2/5,s4,x15/1,s5,x12/7,s5,x2/0,s7,pe/f,x12/4,pi/c,x10/2,s15,x15/6,ph/g,x14/12,s7,po/a,x0/15,pc/d,x3/12,s8,x1/5,pk/o,x3/6,ph/n,x1/2,pc/j,x11/12,s8,x6/4,s10,x1/12,s11,x4/14,pa/n,x3/6,s2,x13/8,pi/o,x7/15,ph/p,x8/6,s11,x14/1,s13,x6/4,pn/j,s8,x9/8,s12,pg/b,x10/11,pf/n,x5/15,s3,x11/0,pg/d,x15/8,s10,x13/6,pp/f,x0/7,s7,x4/6,s14,x0/2,pm/l,x6/4,ph/g,x13/3,pp/a,x5/10,s3,x4/0,po/e,x2/8,pb/k,x7/10,pj/p,x12/8,s3,x9/7,s6,x11/10,s3,ph/f,s6,x8/7,s11,x12/5,s10,x3/10,s1,x12/1,pb/i,x11/13,s15,x7/1,s9,x2/0,pg/o,x5/8,s9,x12/10,pd/f,x8/11,s7,x1/4,s1,x0/8,s4,pi/n,x6/4,po/h,x11/10,pm/g,x5/4,s4,x8/11,s7,pk/d,x12/10,s1,x9/8,pe/m,x7/10,s7,x0/14,pk/b,x9/11,s2,x2/6,s1,x0/7,ph/c,x15/12,s6,x14/2,s13,pb/g,x15/6,s14,x13/4,pe/n,x7/5,s2,x15/11,pl/h,x4/14,pk/d,x13/12,pn/e,x0/2,s12,x10/7,s5,pj/l,s10,x9/12,po/h,x1/14,s10,x0/5,s13,x2/7,pe/k,x4/9,s15,x0/11,po/b,s2,x8/7,pm/f,x11/15,pc/o,x10/6,pg/j,x2/0,s11,x12/11,s14,x14/9,pk/l,x0/1,pa/d,x2/8,pp/k,x11/7,pc/g,x3/8,s3,x11/10,s10,x14/2,s15,x1/15,ph/l,x10/0,pk/j,x15/2,s7,x4/6,po/f,x9/10,s5,x13/14,s3,x11/1,s15,pk/i,x6/10,s8,x0/9,s8,x5/6,s3,x9/4,pl/f,x14/5,s5,x7/12,pk/c,x11/14,s3,x5/15,s3,x6/12,s11,x7/14,s13,x8/0,pe/o,x6/14,pg/d,x4/1,pe/c,x5/2,pl/b,s7,x14/12,pc/h,x11/2,s15,x15/6,pa/l,x2/11,s1,x10/7,pg/k,x4/6,s1,x2/0,s15,x4/11,pe/n,x8/7,pc/a,x12/6,s4,x3/15,ph/n,x10/4,pk/l,x0/11,s9,x9/13,po/i,x14/2,pd/a,s3,x15/4,s15,x5/7,s12,x4/11,pm/h,x2/1,s9,x4/0,s14,x1/13,s11,x11/9,s4,x1/7,pn/b,x5/12,pe/k,x15/9,s6,x12/11,s2,ph/c,x8/9,s3,x11/10,pg/l,x0/15,s10,x7/2,s10,x9/13,s9,pe/n,x4/0,s7,x1/5,s8,x2/14,s5,x13/11,s15,x6/2,s9,x11/3,s1,x14/15,pp/h,x13/1,s11,x7/4,s11,pg/n,x3/5,s5,x15/7,pf/m,x4/1,pd/b,x5/12,s10,x2/10,s2,x15/6,s8,x8/13,pn/h,x9/12,pe/d,x0/14,s4,x12/1,s6,x9/5,s1,x8/14,s5,x11/10,s2,x9/1,s10,x11/12,s7,x3/9,pl/n,x5/2,s11,x10/12,s6,x2/15,s9,pd/p,x1/6,s5,x5/13,pg/n,s12,x0/8,s15,x5/6,po/k,x10/0,s2,x15/6,pc/f,x14/0,pe/b,x8/9,s10,x2/10,s5,x14/0,pf/l,x5/6,s8,x13/0,s4,x2/7,pk/m,s7,x3/10,pb/l,x15/7,s5,x14/12,pm/i,x15/8,s1,x14/12,s11,x5/11,s9,x15/13,pl/b,x6/9,s11,pf/c,x5/13,pl/p,x10/7,s15,x9/15,s7,x6/7,pb/j,x10/15,s6,x3/9,pk/a,x11/7,s4,x0/15,pb/i,x6/4,s14,pm/p,x12/2,s3,x9/3,pa/b,x13/1,pn/o,x5/3,pc/g,x10/4,pb/l,x9/6,po/c,x10/7,s10,x15/4,pj/k,x5/1,s8,x15/3,s3,x12/10,s9,x9/15,pm/f,x4/1,s4,x13/11,s11,x12/0,s15,x14/9,s15,x1/3,pk/n,x8/7,pl/e,s5,pb/k,x5/10,pd/g,s13,pl/f,x11/3,s14,x6/7,pa/b,x3/14,pe/g,x5/8,pi/b,x9/1,s1,ph/a,x13/8,s8,x0/5,pi/c,x8/6,pk/o,x7/9,pf/j,x2/6,s9,x13/1,pk/m,x5/12,s1,x1/6,s15,x10/8,s13,x9/15,s1,x6/7,s6,x0/2,s9,x8/4,s15,x3/10,s9,x6/13,s14,x5/3,pf/d,x14/13,pi/c,x2/8,s4,x13/0,pp/b,s7,x9/3,s3,x10/13,s10,x12/1,s9,x10/11,s1,pk/j,x6/15,pc/h,x3/2,s13,x1/9,s3,x11/5,s11,x4/2,pd/g,x12/6,s9,x1/9,pp/o,x3/13,ph/a,x9/15,s5,x14/11,pp/m,x13/3,s11,x10/8,s7,x2/14,s13,x3/13,s12,x14/6,s15,x5/0,pb/e,x2/11,pk/a,x13/8,s1,x9/3,s4,x2/7,pm/b,x4/10,s13,x12/8,s11,x4/7,s1,x15/10,s14,x12/4,s4,x9/11,s15,x14/1,s14,x8/15,s2,x9/6,pp/d,x3/1,s2,x14/10,pj/i,s13,x3/9,po/k,x0/14,pn/f,x6/10,s13,x1/8,s11,ph/k,x4/6,s13,x7/8,pc/o,x11/10,s8,pn/l,x7/13,s7,x2/5,ph/i,x12/13,pa/l,x3/2,s3,x7/13,s4,x5/0,s8,x3/9,po/f,x15/7,s5,x5/1,s8,x3/10,s1,x5/9,ph/g,x6/2,s10,x1/14,s14,x12/8,s14,x15/4,s11,x9/6,pa/i,x3/12,s7,x15/0,s1,x9/3,s11,x7/12,s2,x15/5,s4,x2/11,s5,x12/3,ph/b,x10/1,pd/c,s15,po/n,x8/9,pb/g,x3/15,s4,x14/4,s10,pa/c,x1/8,pg/b,x11/5,s1,pp/f,x0/4,s15,x14/7,s7,pb/o,x9/4,s5,x7/2,s3,x8/1,s3,x0/10,pp/g,x6/7,s11,x11/0,s1,x14/1,s14,x3/10,s9,x12/8,s8,x5/4,s10,pd/c,x12/11,s1,x14/1,s14,x8/3,pe/g,s10,x4/14,s13,x9/1,s11,x11/4,s15,x10/12,ph/p,x15/7,pm/c,x8/2,s7,x13/10,s1,x12/6,pi/a,x3/2,s6,x8/14,pg/d,x6/2,s6,x14/3,s4,x0/7,pp/c,x14/2,s14,x6/4,s6,x5/15,s5,x10/1,s6,x15/3,pa/d,x8/1,pj/i,x9/3,pn/a,x12/13,pc/f,x9/14,pl/m,s5,x12/13,s9,x1/2,s6,x7/11,s2,x0/4,s2,x12/3,pa/b,s9,x11/14,s3,x2/7,pc/h,x11/4,s3,x1/6,s4,x5/0,s7,x12/9,s6,x3/6,pe/l,x2/5,s2,x1/11,s15,x3/12,pa/p,x11/10,s2,pm/o,s9,x4/12,s13,pl/c,x7/2,s15,x10/15,s1,x4/14,s9,x11/13,s9,x9/2,s13,x3/10,s10,x13/5,s1,x7/12,pi/p,x9/15,s15,x2/7,pn/f,s6,x4/10,s6,x13/8,pb/p,x14/6,pf/h,x3/12,s9,x4/7,pj/g,x15/12,s10,x14/0,pk/n,x8/7,pm/b,x10/15,pe/c,s15,x8/0,s5,x7/3,s4,x6/13,pd/n,x12/0,pf/k,s13,x4/7,s14,pc/e,x10/6,s15,x3/14,s9,x12/1,s6,x15/7,pf/a,x10/9,s7,x15/14,s11,x13/5,s6,x12/2,pl/m,s8,x7/14,pd/a,x11/1,po/i,x10/4,s3,x11/13,s13,x9/15,pk/f,x4/1,pi/e,x7/10,s3,x11/5,s8,x10/12,s15,x14/9,pg/c,x1/8,s3,x4/11,po/f,x7/9,pi/k,x8/15,pm/l,x14/0,s1,x4/1,s7,pe/g,x7/5,s15,x14/12,s10,x8/6,pj/b,x14/9,s3,x15/2,pn/l,x5/13,s6,x3/9,s10,x4/13,s8,x11/12,pm/f,x3/1,s2,x9/11,s13,x12/10,s5,x7/14,s2,x1/4,s12,x10/14,s6,x5/7,ph/e,x1/11,s4,x0/10,s14,x6/14,pl/a,x1/4,s4,x12/14,s10,x8/10,s12,x6/13,s1,x9/0,pf/e,x5/3,pc/p,x2/13,s15,x5/6,s1,x15/10,pl/o,x11/8,s7,x13/1,pg/i,x0/7,po/m,x2/9,s15,x14/10,s12,x11/5,pj/f,x12/6,pp/k,x0/14,pb/m,s3,x6/13,s13,x5/4,s8,x2/13,s4,x11/7,s8,x5/0,s2,x6/9,pp/n,x5/14,s3,pb/g,x8/2,s13,pd/h,x13/11,pl/e,x14/8,s5,x0/6,s7,x15/12,s12,x7/3,pp/c,x14/9,pk/o,x15/1,s11,x2/6,s1,x14/5,pd/p,x4/3,s15,x6/12,po/j,x14/15,pf/c,x0/4,pe/p,x10/7,s13,x1/2,s8,x9/11,pl/m,x7/4,s14,x10/11,pd/o,x15/14,ph/l,x9/7,s14,x11/15,pm/o,x14/7,pp/g,x3/13,po/i,x4/9,s2,x0/14,s13,x4/8,pn/p,x13/6,po/e,x8/11,pm/l,x13/14,s13,pf/n,x1/9,po/g,x8/15,s10,x6/5,s7,x7/12,s5,x14/0,pb/l,x1/8,s6,x15/12,s10,x5/11,s14,pc/o,s11,x13/4,pa/n,x6/11,pl/b,x3/2,s9,x13/5,s13,x1/8,pp/k,x13/0,s1,x14/9,pd/l,x6/10,ph/o,x15/0,s15,pn/e,x6/1,s10,pb/p,x2/3,pe/f,x10/15,s13,x13/7,pd/k,s5,x12/6,s4,x11/5,pb/n,x2/10,po/i,x5/8,s7,x9/14,s5,x15/2,s13,x7/5,s3,x0/8,s11,x14/2,s4,pn/m,x7/15,s12,x8/11,s7,x0/4,s14,x12/7,pf/i,x3/11,pj/e,x12/0,s15,x1/6,pn/a,s12,x5/8,s4,x0/4,pi/l,x1/8,s2,x15/3,pp/e,s3,pd/c,x8/2,s11,x7/5,s14,x8/14,s5,x1/4,s4,pn/g,x13/8,s8,x10/6,pd/m,x0/14,s15,pc/e,s3,x7/11,pp/o,x6/14,pf/c,x5/0,s15,x6/8,s2,x14/5,s11,x7/10,s9,x1/12,pm/i,x6/4,s7,x10/12,s4,x15/13,s6,x14/2,s1,x3/0,s2,x1/13,s4,x12/8,s6,x5/7,s14,x13/6,s5,x3/12,s14,x2/1,s5,x13/7,pd/f,x0/5,s1,x15/8,s14,x13/0,pl/e,x5/10,ph/d,s9,x11/6,pe/j,x14/15,pp/h,x0/4,s9,x9/2,s2,x3/13,pa/d,x5/9,pj/m,x0/7,s1,x13/11,s12,x4/12,s3,x8/9,s2,x12/3,s11,pf/d,x15/4,s15,x5/7,pj/l,x2/13,s11,x15/11,pa/h,x10/2,s7,x3/7,s13,x15/6,s8,x2/13,s8,x11/9,s8,x14/3,pi/b,x13/1,s4,x9/2,s1,pe/m,x8/5,s8,x6/13,pb/p,x7/8,s9,x1/3,s8,x8/14,s1,pd/j,x12/15,pc/o,x5/0,pd/i,x9/14,s9,x6/2,s3,x11/1,s1,pg/j,x0/10,s13,pl/p,s2,x11/3,s7,x10/12,pn/b,x14/8,s14,x11/0,s12,x13/4,pa/d,x3/5,s6,x15/7,ph/j,x8/12,s3,x2/5,s11,x7/6,s4,x4/0,s4,x13/7,s8,x11/8,s8,x12/2,pd/e,x9/8,s2,x0/2,pa/h,x9/8,pb/l,x14/4,s14,x9/1,pg/k,x13/14,po/c,x3/15,pi/m,x2/5,s1,x6/8,s1,x7/4,s7,x3/11,s3,x6/0,pp/a,x12/4,s15,x13/15,s15,x12/6,s3,x0/10,pf/e,x6/14,pa/i,s5,x15/5,s5,x8/13,pm/e,x11/0,pb/h,s7,x1/5,pk/j,x12/8,s14,x15/5,s11,pc/n,x11/13,pd/b,x7/2,s4,x5/1,s3,pp/i,x4/0,s4,x15/8,pf/h,x6/11,s13,pj/c,s2,x12/2,s11,x5/3,s15,x7/12,s5,x13/9,s9,x6/12,pb/o,x8/4,pp/a,s4,x0/9,s13,x12/7,pg/j,x0/3,s12,x1/2,s13,x5/10,pl/n,s5,x2/11,pm/h,x9/4,s2,pf/l,x1/6,pj/p,x2/4,pm/g,x9/10,pe/f,x14/8,s13,x15/7,s6,x8/5,s11,x13/12,pg/k,s9,x1/8,s15,pb/o,x9/2,pf/j,x8/10,s12,x11/6,pd/m,x4/5,s1,pf/j,x8/1,pi/a,x2/0,s5,x9/6,s7,x15/12,s12,pc/e,x13/9,s1,x10/1,s5,x6/13,po/p,x10/7,s6,x9/12,pe/m,x8/11,s9,x7/0,pc/j,x5/9,pe/h,x2/13,pl/i,x0/5,pk/j,x10/9,s2,po/e,x4/15,s14,x12/8,s12,x6/1,s4,x14/12,s1,x7/1,pc/m,x6/0,pd/j,x8/5,s4,x15/13,s3,x9/11,pk/o,x15/1,pa/b,s5,x13/4,pc/g,x8/12,pn/p,s3,x4/7,pk/h,s4,x9/6,s13,x10/14,s15,x0/7,s4,x6/8,s5,x3/0,pl/a,x4/7,pc/e,s4,x14/11,s5,x6/3,pf/h,x11/0,s13,x15/8,s6,x2/4,pd/g,x11/5,s3,x0/6,s2,x15/4,pc/b,x11/1,ph/n,x0/4,s5,x12/1,pb/a,x13/7,s9,x15/4,s5,x0/13,s13,x8/4,s14,x3/11,pj/f,x12/1,pl/b,x14/0,s2,x10/3,pp/f,x8/7,s4,x9/4,s2,x15/0,s13,x14/8,s10,x2/10,pe/i,x5/11,s15,x12/4,s5,x3/7,s13,x0/2,s3,x13/6,s6,pb/c,x3/14,s1,x11/13,s14,x12/4,s7,x1/5,pp/n,x7/15,s5,x6/0,s1,x5/15,pa/h,x10/1,pb/n,x9/14,pp/k,x4/8,s9,ph/o,x12/6,s11,x3/4,pb/k,x6/10,pj/m,x13/1,s13,x4/10,pp/h,x13/15,s2,x10/2,pi/b,x14/12,s13,x7/6,pp/j,x0/1,s3,x10/5,s3,x11/2,pc/o,x1/12,s9,x14/5,ph/k,x12/11,s1,x14/13,s8,x15/11,s14,x5/10,s10,x3/8,pc/a,x2/5,s3,x0/1,s7,x13/15,ph/p,s15,x12/3,pd/k,x8/4,s13,x1/7,s6,x10/15,s9,x11/13,s13,x15/1,s8,pc/j,x4/14,s15,x8/0,s3,x3/13,s14,x14/7,s2,x15/2,pn/m,x3/13,s5,x14/11,s13,x13/6,s9,x8/12,pc/e,x7/4,s7,x11/10,s13,x5/13,s7,x6/2,pg/f,x7/0,pk/i,x1/8,s13,x11/10,pl/d,s1,x6/5,s8,x1/11,pj/h,x5/7,pk/n,x0/6,s10,x3/14,pp/j,x13/5,s14,x3/11,s4,x4/8,s4,x11/0,pl/h,x1/5,pe/f,x2/9,s12,x11/14,s8,x15/0,pn/b,s12,x14/2,po/h,x7/10,s9,x1/4,pp/j,x12/13,s3,x5/11,s5,x9/13,pd/c,x1/11,s12,x6/10,pf/n,x5/8,s6,x15/9,pp/g,x7/2,s12,x9/0,s1,pc/m,x4/3,s5,x14/11,s14,x9/1,s12,x8/4,s13,x12/1,s10,x7/9,po/l,s14,x6/10,s9,x4/13,s14,x5/7,pb/c,x2/11,s12,x8/7,pe/g,s14,x11/14,pa/o,x9/0,pc/i,x7/2,pj/m,x3/9,s14,x5/10,s5,x15/13,s7,x1/10,pk/p,s14,x2/7,s5,x13/11,s12,x7/3,s2,x2/1,pe/l,x8/11,pd/o,x15/2,pb/j,s12,x14/12,pe/f,x8/4,s10,x11/7,pl/b,x9/8,pc/f,x10/12,s7,x7/14,po/m,x0/9,pf/e,x12/5,pk/n,x9/14,s1,x13/6,s5,x14/1,s9,x4/0,s13,x5/15,s15,x12/9,pd/g,x5/14,s12,x8/3,ph/c,s3,x11/15,pe/o,s2,x4/9,pk/d,x14/1,s13,x13/3,s3,x12/5,s14,x7/1,s10,x3/8,s5,x9/15,s9,x13/7,s9,x3/2,s15,x10/15,s2,x4/14,s4,x5/15,pj/g,x8/10,s13,x12/13,s11,x15/7,s1,x3/12,s6,x8/15,s2,pi/e,x2/14,s4,x15/12,s4,x5/11,s11,pb/f,s1,x13/1,s3,x6/8,pa/n,x3/2,pm/p,x12/11,s4,x1/14,s4,x10/0,s4,x13/12,s15,x5/4,s8,x2/14,pj/i,x10/12,s1,x9/8,s10,po/m,x11/1,s3,x5/15,pa/e,x6/12,pl/i,x9/0,pm/o,x8/1,s7,pb/h,x12/3,s3,x6/15,s15,x11/0,pn/i,x13/1,s5,x11/8,pc/a,x3/1,pl/i,x6/7,s7,x14/8,pd/e,x9/2,pb/a,x13/8,pf/g,x10/6,s7,x5/3,s3,x12/15,s3,x14/10,s4,x1/7,s13,x12/10,pb/h,s9,x1/7,pf/m,x8/5,pp/a,x9/3,pe/h,x0/13,pi/b,x4/6,s10,x14/11,s2,x15/0,pd/n,s15,x14/5,pg/h,x6/3,s5,x15/14,s3,x4/10,s12,pn/f,x0/6,s5,x3/9,pk/p,x8/10,s7,x12/9,pi/o,x7/3,s6,x9/12,pl/m,x10/7,pa/p,s9,x11/0,pg/j,x6/14,s8,pm/i,x13/4,s10,x8/6,ph/o,x13/0,s3,x11/10,s10,x14/8,pj/i,x11/15,pf/p,s6,x10/2,po/a,x11/9,s15,x12/4,s1,x0/3,s8,x7/9,pn/e,x0/8,pg/j,x11/4,s12,x8/14,s2,x9/13,pi/d,x10/4,s11,x2/13,pj/o,x9/11,s15,x0/5,s15,x3/12,pg/n,x13/7,s13,x5/4,s15,x3/13,s3,x1/5,s1,x15/11,s7,x2/8,pp/k,x6/15,s6,x12/13,s1,x6/1,pm/f,x15/3,s1,x13/7,pp/h,x9/4,s15,x10/12,s2,po/d,x8/4,s1,x13/0,pa/j,x7/15,ph/i,x8/12,pd/c,x6/9,pp/a,x13/5,s10,x9/10,s4,pi/j,x5/13,pp/k,x10/15,s11,x12/3,s15,x2/13,s12,x14/7,pf/e,x12/3,pb/l,s5,x2/5,s13,x6/10,s11,x7/14,s14,x10/4,s5,x9/14,s3,x6/0,s4,x9/1,po/j,x2/4,s11,x5/0,s5,x4/7,pi/b,x8/0,pn/c,x13/14,pd/l,x7/9,s3,x14/10,s1,x7/0,s1,x11/14,s15,x13/1,pf/e,x10/14,s14,x0/6,s12,x14/3,pn/c,x12/11,pm/f,s10,x14/10,s15,x3/2,s7,x13/11,pl/n,x1/5,s7,x2/14,s1,pm/h,x5/11,pb/k,x15/12,s12,x8/5,pd/j,s14,x11/12,pb/c,x2/4,s10,x14/9,s10,x12/8,pf/a,x15/14,s11,x12/6,pi/b,x10/14,pn/g,x9/3,s6,x4/13,pp/e,x6/8,pj/g,x9/10,s12,x13/4,s15,x8/15,s14,x1/0,s12,x11/4,s15,x5/13,s9,x11/2,s13,x10/14,pm/p,x4/1,pi/c,x13/14,s15,x6/7,s15,x5/13,pm/o,x4/8,s12,x2/13,pn/k,s5,pp/d,x11/15,s4,x8/3,pf/g,x12/2,pb/c,x10/5,s2,x0/7,pd/m,x11/15,po/i,x2/1,ph/a,s15,x11/14,s14,x13/5,s11,x6/9,pi/p,x1/7,pd/f,x9/14,pg/k,x10/15,s15,x1/9,s13,x7/2,s1,x3/14,ph/f,x2/12,s2,pi/m,x15/5,pn/p,x11/10,pa/c,x12/1,pd/g,x15/5,s12,x9/3,pk/c,x7/4,pd/a,x9/0,pm/c,x14/12,s3,pf/b,x5/13,pe/l,x15/12,s14,x14/2,s5,x11/3,s3,x4/1,s14,po/p,s6,x13/10,s4,x11/3,pi/l,x2/10,s9,x1/11,pf/g,x10/3,pj/h,s3,x14/4,s10,x13/1,pf/l,x15/14,s15,x3/12,s9,x11/2,pb/d,x10/4,s11,x3/14,pn/o,x4/11,s7,x13/7,s14,x5/3,pd/f,x14/1,ph/p,x12/15,pm/d,x14/2,pl/e,s1,x1/12,s13,x5/13,s13,x10/12,pf/k,x2/11,s14,x14/13,s3,x4/10,s10,x5/12,s10,pa/d,s4,x9/0,pi/g,x10/14,s14,pa/l,x2/4,pf/k,x15/11,s2,x7/9,pd/c,x5/10,s3,pk/j,x1/7,s12,x3/10,s11,x9/2,s7,pn/h,x15/0,s13,x4/6,pf/l,s3,x9/14,s10,x12/8,pk/n,x5/13,pf/d,s8,x9/7,pp/b,x4/8,ph/e,x14/12,s7,x9/0,po/j,s5,x1/15,s9,x4/9,pg/n,s6,x13/8,pf/m,x6/9,pn/g,x8/1,s5,x13/10,pc/a,x15/9,s12,po/i,x10/2,pg/n,x14/6,s8,pm/d,x4/8,pe/n,x13/10,s7,x5/1,s2,x2/12,s5,x5/13,s15,x3/9,pf/i,x7/12,po/g,x4/8,pa/k,s8,x1/11,s6,x15/4,pc/p,x8/1,s12,x15/3,pl/m,s1,x12/11,s8,x2/10,s12,x5/14,pg/i,x10/12,s11,x6/0,pb/k,x2/1,ph/l,x3/0,pa/d,x11/15,s14,x7/5,pp/h,x4/15,pb/o,x1/12,s10,x2/7,s1,x4/11,pp/j,x15/6,pb/e,x9/5,s7,x7/0,s13,x10/8,po/j,x9/7,s3,pa/e,x6/15,pb/p,x11/7,s13,x10/1,s7,x8/13,pi/c,x0/12,s2,pd/b,x5/14,pe/n,x1/11,pj/h,x0/10,s15,pm/f,x2/14,pb/l,x12/13,s5,x9/3,s13,x7/5,pe/p,x14/9,s13,x4/7,po/g,x8/5,pj/l,s13,x14/4,ph/f,x8/7,s5,x9/6,s3,x10/5,s11,x7/9,pn/l,x6/4,s1,x15/3,pi/g,x1/7,s14,x12/13,s8,x6/11,s7,pb/f,x2/9,s13,x1/11,s15,x6/14,s6,x0/2,s8,x7/14,ph/i,x15/8,s8,x5/6,s9,x7/1,pb/j,s4,x4/3,pg/i,x15/14,pc/f,x0/11,pk/b,x12/5,pg/d,x1/10,pi/p,s3,x11/13,s12,x12/7,s10,x2/10,s7,x13/6,s12,x14/3,s13,x2/9,s15,x0/6,po/a,x9/3,s1,x10/14,pd/e,x5/7,pl/o,x10/13,pi/p,x8/11,s4,x9/13,pc/g,x11/6,pb/l,x9/3,s1,x12/6,s7,x4/3,s3,x5/15,s6,pi/j,x6/3,s11,x10/1,s4,x7/13,s2,x10/3,s4,x11/1,s6,x3/5,s2,pc/n,x1/12,s15,x4/11,pm/k,x15/10,pf/g,x9/1,s15,x2/6,s5,x3/7,pk/c,x15/10,pn/f,x0/11,s6,x8/14,s11,x4/5,s5,x11/3,pg/a,x9/15,s10,x1/4,s4,x14/13,s14,x6/10,pn/d,x13/14,s2,x10/3,pj/h,x4/8,s2,x15/9,s6,x6/1,s10,x15/5,s14,x14/0,s3,x9/15,s11,x13/1,s9,x6/14,s1,x4/2,s13,x9/3,s11,x5/13,s1,x4/8,s2,x0/10,s10,x1/6,s6,pg/d,s4,x9/2,pf/n,x0/1,pd/e,x13/7,s4,x9/1,s14,x2/4,s3,x13/0,s14,x11/1,s12,x4/8,pp/j,s3,x1/2,s14,x11/0,s13,x1/4,ph/n,x12/8,s12,x13/1,s7,x12/6,pd/j,x2/0,s12,x9/15,pg/b,s8,x1/7,pa/c,x6/10,pl/f,s12,x12/4,pd/n,x15/0,s8,x7/13,pe/k,s14,x2/11,s7,x15/7,s1,x8/10,s11,x13/5,s15,x12/10,ph/o,x13/7,s7,x1/8,pi/g,x9/7,pe/f,x5/3,pn/p,x0/8,s1,x14/15,s15,x5/9,pj/c,x11/15,pl/d,x2/1,s13,x5/8,s13,x14/11,s12,x0/15,s6,x1/11,s2,x2/15,po/g,x7/9,s6,x8/3,s15,x9/7,pn/p,x12/0,s4,x14/5,s4,x7/8,s2,pj/a,s6,x9/6,s3,x4/5,pg/h,x15/8,s12,x10/3,pl/c,x2/5,ph/d,s2,x12/0,s13,x5/9,pf/p,x10/1,s1,pg/l,x15/4,s8,x8/9,pj/n,x2/6,s5,x9/5,pd/g,x1/15,pn/a,x6/13,po/i,x5/10,s12,x3/12,s13,pe/m,x10/6,pj/b,x11/13,po/e,s5,x12/1,s5,x15/8,s12,x6/14,pl/h,x4/15,s13,x1/12,pm/b,x5/14,s9,x12/6,s3,x7/2,s3,x9/8,s11,x0/11,pp/g,x15/13,pi/m,x1/9,pn/e,x3/6,s7,x4/14,pk/c,x11/9,pp/j,x12/14,pm/e,x2/3,pk/a,x7/10,pf/e,x8/9,s3,x4/11,s3,x12/0,pm/a,x10/1,pk/n,s12,x5/6,s12,x11/8,pm/d,x3/13,s11,x0/11,po/f,x7/12,s1,x15/0,s8,x6/10,s4,x12/4,s2,x3/8,pi/n,x12/6,pd/o,x1/8,s12,x0/2,pc/b,x12/1,pf/a,x0/7,pe/k,x9/14,pm/g,x13/12,pe/p,s1,x8/10,pf/o,x2/15,s10,x10/6,s13,x4/9,s6,x13/12,s11,x6/7,pe/m,x12/3,s14,x15/1,pd/c,x4/9,s14,x10/15,pn/a,x2/1,s15,x11/10,ph/f,s12,x5/12,po/m,x4/15,pf/d,x9/10,s13,x6/13,s11,x10/0,s13,x2/3,s9,x10/15,s1,pa/n,x9/5,s4,x4/2,po/p,x14/3,s11,x10/0,s5,pn/d,x14/11,s5,x6/12,s13,x0/10,s9,x4/13,pk/j,x12/1,pb/c,x5/6,pj/d,x9/2,pp/a,s6,x15/1,pl/e,s4,x2/3,s12,ph/p,x0/12,s8,pe/f,x8/11,s7,x6/5,s5,x2/15,s10,x11/4,s8,x1/5,ph/a,s2,x2/8,s11,pi/m,x3/10,s5,x0/5,s10,x3/2,pc/e,x5/12,pk/g,x3/8,s2,x10/9,s14,x2/8,pe/b,x1/13,s12,x9/0,pk/j,x14/4,pp/i,x5/12,pc/d,x6/1,s10,x9/14,s10,x15/4,po/m,x7/3,pj/i,x8/6,pe/d,x12/4,s9,x15/7,ph/l,s10,x5/11,s7,x3/2,s9,x13/8,pi/m,x9/6,s15,x15/1,pf/b,x14/13,pd/g,x11/10,s15,x3/0,s2,x5/10,s11,x14/7,s2,x0/3,s4,x2/1,pj/f,x10/4,s3,x0/12,pl/e,x1/3,s14,x6/13,s8,x1/7,pk/h,x5/14,s13,pa/j,x2/13,s4,x14/12,s4,x13/3,pg/p,x9/8,s9,x2/13,s15,x10/3,s7,x7/9,s1,x14/8,pi/c,x9/3,pl/o,s8,x12/0,pm/j,x7/8,po/c,x3/11,s1,x0/13,s14,x11/1,pj/p,x5/7,s4,x2/10,pl/e,s6,x11/6,s15,x12/8,s5,x15/5,s13,x10/8,s14,x13/3,s15,x5/4,s10,x10/13,s12,x14/8,s4,x2/10,pi/h,x9/13,po/d,s13,x0/8,s15,x9/5,s15,x14/7,s12,x1/10,s9,pj/f,x14/2,pg/b,x5/13,pk/c,x15/10,s9,x12/7,pa/n,x9/14,s11,x6/13,s15,x14/4,s3,x7/3,pe/l,x2/0,pc/h,x12/7,s2,x10/11,pg/p,x4/3,pe/i,x8/6,s4,x11/3,po/j,s9,x4/14,pc/n,s8,x3/11,s10,x6/4,s3,x15/13,s14,x11/0,pg/p,x13/2,pk/n,x1/12,s4,x3/14,pp/f,x10/15,po/g,x4/5,s14,x1/8,s8,pl/m,s1,pb/a,x11/5,s12,x10/6,s11,x2/5,s10,x12/10,s6,x15/14,s13,x13/10,pp/k,x4/1,ph/i,x2/0,pl/j,x11/12,s7,x3/4,s1,x13/11,pn/i,x0/3,ph/j,x9/10,s11,x8/7,po/d,x15/5,s11,x13/11,s6,x12/0,s2,pg/k,x10/11,s15,x12/8,ph/i,x7/5,s14,pa/m,x6/13,pl/i,x3/1,s7,x12/5,pa/p,x2/7,s6,x1/5,s8,x14/6,s1,x10/0,pm/i,x9/7,s12,x6/8,s11,x5/9,pe/f,x2/0,s2,x1/11,s2,x3/0,pb/k,x11/12,pe/i,x13/15,s2,x8/1,s8,x7/10,pd/c,x8/0,s11,x14/12,pj/o,x5/1,s12,x11/14,pb/m,s10,x5/12,s12,x15/13,s8,x4/10,s7,x6/11,s4,x3/1,ph/k,x5/9,s13,x0/8,po/d,x2/14,s9,x4/12,pn/j,x2/14,s2,x7/3,po/e,x15/2,s10,x13/0,s9,x9/2,pl/n,s7,x14/0,s8,x2/10,s6,x8/15,s15,x11/14,pg/c,x0/10,s12,x14/3,pa/l,x4/11,pc/b,x9/1,s2,x5/6,s14,x7/11,pg/m,x15/1,s4,x12/13,s4,x10/6,pl/f,s10,po/a,x1/15,ph/i,s13,x3/13,s4,x7/14,s14,x3/1,s3,x8/5,pl/p,x0/7,pd/a,x13/15,s14,x4/5,s4,x12/1,po/h,x14/11,pe/m,x8/12,s3,x5/2,s1,x13/9,s15,x1/8,s4,x15/7,s11,x5/1,s13,x0/13,pn/i,x4/6,s8,x2/10,s2,x11/9,pd/l,x12/7,s8,x9/1,s12,x6/11,po/f,x7/14,pb/a,x9/5,pp/m,x14/13,pn/a,x1/4,s4,x13/8,s2,x0/6,pp/m,x11/8,s10,x6/0,s9,po/n,s15,x10/9,pe/m,x6/2,s15,x12/8,s10,x5/0,s15,x12/11,s12,x8/6,pa/n,s5,x14/2,s4,x15/12,pb/f,x9/11,s11,pk/g,x12/2,s8,x15/14,pi/b,x13/5,s8,x7/2,s7,x5/4,s15,pe/f,x11/6,s12,x3/4,s7,x2/9,pi/o,x5/10,s6,x1/2,s13,x9/4,s1,x10/7,pe/n,x8/5,s3,x6/1,s4,x7/3,pf/h,s8,x0/13,s6,x6/14,pa/g,x11/7,s1,x9/15,s15,x2/5,s14,x7/4,s12,x15/5,pk/m,x4/3,pb/i,x10/9,s4,x0/1,pj/g,x10/9,pp/l,x5/8,s12,x6/15,pj/a,x2/11,s14,x13/14,pd/o,x9/3,s8,pm/f,x4/5,s10,x15/6,s9,x13/2,s7,x15/5,s11,x4/1,s13,x14/15,ph/n,x2/11,s7,x12/9,s14,pg/f,x13/7,s8,x0/12,s7,x13/9,pi/d,x5/2,s11,x14/0,s6,x13/8,s2,x1/5,s4,x7/13,pf/l,s6,x3/15,s1,x5/14,po/n,x9/1,ph/d,s12,x14/15,pb/o,s7,x8/5,s14,x12/11,pj/n,x10/9,s8,pk/g,x7/3,s9,x2/11,pb/m,x6/5,pl/n,x10/0,s7,x8/12,s15,x9/14,ph/m,x13/1,s11,x12/0,pj/p,x2/7,pi/a,x13/0,s8,x2/7,pb/f,x12/15,s1,x0/14,s11,pe/d,x9/12,s10,x3/14,s4,x11/10,pn/h,x3/12,s4,x9/15,pp/m,s6,x0/13,pn/a,x9/1,s14,x6/2,pj/g,x3/13,s5,x8/7,pm/c,s14,x9/10,s8,x7/3,s1,x13/10,ph/j,s4,x5/8,s14,x7/4,pg/l,x6/14,pk/d,x1/8,pe/j,x15/12,s13,ph/l,x7/8,pf/b,x5/12,pg/a,x8/4,s7,x0/15,po/m,x7/12,pj/b,x15/5,pc/g,x11/3,s3,x12/2,s9,x11/0,s6,pb/d,x3/4,s8,x1/9,pk/f,x7/11,s2,ph/d,x8/9,s11,x2/0,s13,x4/5,s7,x9/1,pj/e,x0/15,s10,x13/4,pb/p,x3/8,pi/j,x2/1,s4,pb/k,x15/4,pp/c,x8/14,s1,x3/2,pi/j,x9/14,s1,x1/7,s14,x8/0,s10,x15/4,pa/l,x5/2,s6,x13/6,s15,x5/14,s7,x6/9,s11,pp/c,x8/13,pd/e,x0/5,s12,x10/11,pf/m,x13/3,s2,x11/5,s2,x0/9,s5,x5/15,pg/o,x2/0,pl/b,x8/4,po/n,x0/10,s15,x7/9,s3,x2/11,pg/k,x6/10,s6,x7/2,s4,x6/5,s1,pa/f,x3/12,s3,x9/6,s5,x15/11,po/m,x12/8,s15,x2/1,s15,x8/7,pf/c,x14/10,s15,x1/3,s10,x11/13,s14,x2/3,pd/k,x7/8,s11,x4/0,s3,x9/3,s6,x7/15,s12,x12/6,pg/c,x7/2,s5,x14/1,s15,x3/8,s3,x15/5,pf/i,x3/7,s4,x0/12,pc/h,x5/15,s1,x10/2,s3,x12/9,pf/l,x15/4,pa/n,x5/1,po/k,x14/2,pj/c,s4,x4/1,s10,x3/6,s9,x10/8,pk/a,x12/11,pm/p,x9/3,pn/a,x1/6,s7,x12/8,pj/e,x15/13,s6,x3/10,pp/h,x5/12,s13,x4/0,s9,x6/13,pj/o,x3/15,s3,x13/14,pn/i,x15/6,s4,x10/9,s2,x8/13,s13,x9/2,s9,x13/4,pb/c,x11/10,s5,x13/9,s7,x6/0,s11,x7/11,s8,pk/i,x13/0,s4,x2/6,pm/b,x10/4,s4,x3/9,s6,x10/0,s15,x13/5,s10,x8/1,s15,x2/3,s10,x0/6,s13,x15/7,s5,x1/3,s4,x0/15,pg/f,x6/10,pj/m,x13/1,s4,x4/14,pc/h,x11/0,s12,x13/6,s3,x1/2,s6,x14/9,s4,x15/7,s12,x2/3,pa/f,x8/7,s14,x15/0,s7,x3/14,pe/p,x4/9,s2,x6/8,s15,x2/12,s4,pb/j,x9/5,s14,x2/12,s5,ph/g,x4/5,s2,x12/11,pl/i,x5/14,s15,x13/9,s10,x2/6,s9,x12/3,s11,x5/6,pf/g,s10,x1/8,s6,pa/j,x11/2,s7,x9/10,s12,x2/0,pi/h,x4/13,pb/f,x7/3,pm/k,x4/1,pn/p,x15/7,s4,x8/2,pb/a,s2,x13/11,pg/i,x14/3,s3,x4/1,pm/h,s2,x5/11,s9,po/e,x7/8,s8,x4/1,pp/l,x12/5,s3,x8/4,pb/i,x9/5,pg/k,x7/11,ph/f,x12/3,pd/m,x14/6,s4,x7/9,pa/n,x3/12,s1,ph/f,x4/0,s11,x5/11,s10,x6/14,s3,x5/10,s5,x9/1,s15,x7/11,pb/m,x2/9,pf/i,x3/4,s6,x6/14,s3,x13/10,pp/e,x14/5,s10,x7/2,s12,x0/11,pf/l,x15/14,s13,x10/2,pd/b,x12/9,s3,x2/3,s7,x4/0,s9,x11/2,s7,x4/15,pa/i,x2/10,s13,x6/11,pk/d,x0/9,s4,x5/3,s1,x1/15,pg/i,x0/12,s7,x5/14,s11,x9/2,s7,x4/0,s5,x13/3,s7,x1/6,s12,x5/3,s14,x4/14,s2,x2/5,pe/k,x1/0,s8,x4/7,s9,pb/d,x0/1,s14,x6/9,s7,x7/8,pp/a,x2/6,pj/c,x5/14,s8,x9/12,s15,x3/13,s5,x7/12,pn/l,x13/15,s5,x14/9,po/m,x1/7,s11,x12/6,s9,x0/2,s1,x14/9,pe/h,s10,x7/4,po/i,x8/2,s13,pf/k,x11/10,pe/d,x9/3,s11,x5/2,s9,x10/6,s12,x4/14,s12,x13/0,s3,x7/15,pf/l,x8/14,s11,x1/7,po/a,x8/5,s10,x4/0,s1,x2/11,s15,x14/10,pg/c,x7/2,pe/l,x5/6,s1,x14/9,s12,x4/3,s8,x15/12,s8,x8/3,po/g,s9,x11/15,s10,pd/c,x10/7,s9,x13/5,pi/h,x11/8,s3,x10/6,s15,x9/0,s12,x2/1,pd/b,x14/12,s13,x6/9,s12,x11/12,pn/g,x13/4,s8,x10/5,pk/d,x6/2,pn/a,s13,pi/p,x15/12,pn/o,x9/2,pa/b,x13/7,s14,x5/8,s10,x3/1,pe/p,x7/0,s11,x2/6,s13,ph/b,x1/14,s3,x10/0,s1,x7/8,s15,x3/11,pk/p,x5/10,pb/c,x0/15,pi/j,x11/7,s12,x0/14,pa/h,x13/4,pc/m,x11/1,s8,x15/9,pb/o,x5/10,s9,x15/1,s10,x4/12,s15,x13/3,pe/c,x2/15,s10,pa/j,s5,x13/1,pl/f,x2/12,s10,x7/11,pa/p,x5/6,pj/l,x4/0,pa/e,x3/2,pi/b,x7/1,s8,po/c,x8/2,s14,x7/12,s9,x3/13,s3,x7/1,pi/k,x0/15,s10,ph/p,x13/12,pj/e,s7,x0/8,pi/d,s2,x11/6,pe/g,s5,x1/8,s11,x2/7,ph/l,s14,pb/a,s6,po/j,x10/13,s3,x5/9,pb/m,x6/12,pf/g,x5/1,pi/p,x11/14,s14,x8/9,pk/o,x11/15,s12,x13/5,s6,x2/4,s15,x3/14,s14,x7/5,pd/n,s13,x9/0,s5,x11/5,s4,x14/7,pi/j,x0/8,s12,x12/5,pb/a,s9,x15/2,s13,pn/m,s2,x0/13,s12,x2/7,s15,x11/14,s13,x10/7,s9,x6/1,s8,x10/9,s1,x0/1,s6,x6/7,pf/j,x2/9,s3,x12/7,s6,x2/11,s10,x15/4,pk/i,x0/5,s15,x14/3,s6,x10/2,pd/h,x3/11,pj/o,x2/7,s2,x14/10,pm/b,x0/7,s15,x13/15,pj/n,x3/5,pf/c,x11/6,pn/d,x14/9,s3,x13/11,pj/c,x5/10,pg/o,x4/12,s8,x1/13,s10,x5/2,s4,x1/3,s1,x7/9,s7,x8/11,s15,x2/10,pm/b,x11/0,pd/l,x8/14,pj/e,x15/1,s9,x14/0,s11,x6/11,pl/d,x1/12,s5,x14/9,s9,pm/p,x2/15,pn/h,s6,x14/9,s3,x2/1,pk/l,x15/4,s15,x5/13,s1,x14/7,s15,x1/11,s13,ph/g,s14,x7/14,po/p,x6/9,s3,x14/12,pj/i,s3,x3/1,s12,x6/5,s6,x14/7,pm/o,x3/4,pf/d,x2/12,s7,x10/15,s10,po/c,s1,x11/7,pn/g,x8/9,s2,x15/0,pk/a,x7/2,s1,x14/3,s15,x7/0,pd/p,x9/13,s2,x1/2,s11,x12/7,s15,x4/8,s13,x9/10,s8,x2/1,s4,x15/12,s5,x5/1,pi/a,s5,x3/2,s10,x15/14,pp/h,x10/0,pa/i,x2/5,pf/o,x7/0,pj/e,x6/13,s12,x14/15,pd/f,x12/11,s2,x0/1,pk/g,x8/11,pi/f,x2/12,s5,x9/6,ph/g,x10/11,pp/d,x12/6,s10,x4/1,s9,x8/15,s9,x6/10,s7,x12/7,s8,x10/1,pg/e,x5/12,ph/j,x0/4,s5,x5/12,s6,x7/8,s14,x12/0,s10,x4/9,s9,x15/11,s11,x0/8,pg/d,x2/12,s15,x4/6,s2,x3/2,s15,x8/5,pc/b,x3/10,s12,x15/12,pp/d,x4/13,s1,x1/7,s5,x4/8,s13,pa/i,x11/3,pl/k,x4/14,pc/o,x10/8,s5,x7/5,ph/e,x9/3,pa/g,x10/11,pk/c,x15/14,s14,x13/3,s5,pd/a,x12/15,s13,x5/0,s3,x8/9,pk/h,x13/14,s8,x2/12,pn/f,x13/8,pb/e,x3/12,s9,x0/6,s10,x12/1,s6,x5/2,pi/p,x4/6,s2,x9/1,pb/j,s12,x12/8,s9,x11/1,s6,x4/8,s14,x15/3,pc/k,x1/2,pj/l,x12/14,s2,x5/8,s9,ph/i,x12/13,pa/k,x1/2,s5,x15/12,s7,x3/0,pe/b,x10/8,s7,x7/13,s13,pm/p,x2/9,s3,x5/14,s3,pg/b,s13,pk/n,x4/0,s2,x13/1,s3,x10/6,po/m,x9/11,s2,x3/1,s2,x4/5,s5,x3/15,pe/k,x13/11,ph/d,x7/5,pe/g,s7,x6/8,s9,x11/15,po/b,x1/3,pf/k,x9/5,s7,pd/o,x8/11,s9,x6/3,pa/j,x8/11,pc/l,s9,x7/5,s3,x14/13,s9,x11/2,pn/p,x4/15,s3,ph/i,x14/12,pn/g,x2/3,po/d,x1/14,s2,x8/0,ph/j,x6/13,s14,x3/11,pm/d,s13,x13/4,pe/p,s13,x8/6,pm/o,x3/2,pg/e,x8/10,pf/p,x15/4,s13,x3/10,po/c,x5/0,s14,x1/14,s13,x15/0,s8,pn/m,x9/5,s4,x0/7,pa/p,x8/2,s8,x13/4,pd/h,x2/8,s4,x13/12,pk/j,x11/15,s15,pd/n,x13/0,pb/g,x11/2,pj/e,x14/3,s2,x2/10,s9,x7/13,pc/l,x14/1,s9,x0/3,s3,x7/14,pg/h,x12/0,s10,x7/3,pc/e,x4/15,pm/d,x7/11,s6,x13/8,s1,x1/11,pc/k,x13/12,pi/o,x8/4,s1,x1/0,s8,x5/8,pf/h,x15/0,pm/n,x6/7,s14,x2/13,s6,x15/7,pk/h,x2/3,s3,x15/14,s7,x2/0,s13,x11/3,s15,x8/0,pf/l,x6/13,pd/i,x14/11,s2,x2/8,pc/n,x10/0,s5,x7/9,po/m,x6/10,pb/f,x11/14,s10,x3/4,s8,x10/13,pg/m,s13,x9/2,s8,x7/0,s2,ph/p,x11/14,pi/d,x13/6,pe/l,s10,x11/10,s4,x1/8,pc/o,x9/5,s8,x3/8,s14,x10/9,s2,x15/5,pm/i,s1,x0/13,s7,x14/4,pj/n,x11/9,s9,x12/13,s13,x5/10,s2,x1/11,pb/o,x5/13,pm/h,x0/11,s6,x3/4,s9,x11/10,pl/c,x14/12,po/h,x4/11,s14,x7/13,pl/k,x4/15,pd/o,x0/10,s13,x3/6,s7,x9/12,s15,pm/c,x11/13,pj/a,x5/8,pn/g,x13/4,s15,x14/9,s1,x12/11,pi/b,x15/1,s1,x11/3,s2,x8/1,s11,x11/9,pl/m,x14/10,s10,x1/11,pf/n,x6/5,s3,x4/14,s13,x1/8,s5,x4/6,s6,x15/11,po/c,x10/5,s7,x13/15,s15,x7/5,pj/g,x6/0,s8,x14/1,s10,pc/m,x12/13,pp/b,x11/1,pd/n,x5/2,pl/e,x12/8,s14,x10/15,s10,x6/8,pb/i,x13/1,s6,x3/11,s9,x14/12,s6,x7/5,pk/g,s9,x6/14,pi/o,x13/12,s13,x6/3,s7,x0/9,s15,x7/3,s10,x2/1,s4,x8/7,s5,x9/2,pd/j,x6/15,pi/c,x9/10,s9,x4/1,s1,x14/3,s10,x0/13,s5,x3/2,s13,pg/d,s1,x12/10,s13,x8/0,s13,x11/12,s10,x14/3,s10,x2/12,s9,x13/1,s10,x10/0,pf/p,x3/12,s8,x10/6,s7,x1/13,pi/j,x6/3,s7,pb/l,x5/2,s5,x13/1,pi/n,x6/0,pj/l,x2/9,s1,x15/10,pp/i,x12/3,s11,pb/n,x8/10,pd/a,x5/12,s11,x1/10,pg/l,x0/15,pb/d,x7/9,pm/f,x8/3,pb/p,x6/15,s3,x12/14,s14,x5/4,pf/o,x12/14,s15,x15/8,s6,x0/2,pg/b,x13/6,pl/h,x12/15,s2,x6/10,pe/c,x0/2,s8,x9/6,pf/n,x3/15,pb/c,x4/8,pe/k,x11/5,s13,x9/10,s8,x11/14,pb/o,x8/15,s5,x5/9,pm/d,x1/0,s3,x15/9,pc/b,x7/14,pp/o,x12/1,pg/d,x5/4,pl/a,x7/12,pb/m,x13/6,s3,x14/11,ph/e,x13/10,s15,x8/6,s14,x11/0,s9,x1/12,pn/i,x8/9,s12,x7/2,pk/p,x9/3,s4,x13/2,pg/j,s15,x0/14,s7,x6/5,s3,x0/10,s14,x13/9,s1,x6/5,pp/l,s14,x3/4,s11,x15/6,pd/o,x3/4,pm/p,x5/14,pc/d,x10/0,s8,x7/13,s1,x8/0,pn/m,x2/5,pd/j,s9,x12/9,pf/g,x8/0,pm/b,x10/15,pe/d,s11,x14/12,s11,x1/10,pi/k,x9/0,pj/d,s11,x10/12,s9,x2/11,pk/m,x8/10,s13,x13/1,pg/p,x3/15,pe/m,x13/5,s6,x0/7,s1,x8/1,pn/p,x10/5,s10,x0/8,pj/c,x3/9,s7,x10/1,s6,x9/14,s12,x2/7,po/k,x1/15,s13,x3/7,s1,x10/12,s2,x9/7,s13,pc/n,s13,pa/p,x1/5,ph/g,x15/10,s7,x9/0,s4,x10/2,po/n,x14/8,pi/b,x0/4,s13,x15/6,pl/m,s3,x1/9,pn/d,x12/8,pg/k,x15/1,s8,x4/12,s3,x10/14,s10,ph/b,s5,x5/3,s13,x6/4,s5,x12/5,pl/k,x13/15,s13,x10/9,s5,x14/5,s5,x12/13,pc/f,x6/2,s3,pn/a,s3,x12/14,s1,x3/10,s10,pm/p,x12/2,pe/f,x4/0,s11,x9/15,s11,x8/0,s13,x10/4,s13,po/m,x9/7,s9,x14/11,s3,pe/p,s11,x7/10,pn/m,x13/14,s4,x6/15,po/h,x2/5,s6,x3/12,s14,x11/1,s8,x10/4,pk/n,x6/5,pm/f,x8/11,pc/n,x7/10,s10,x1/3,pj/k,x7/14,s14,x6/3,s2,x10/0,s6,x15/8,s15,x5/13,s6,x15/11,pf/p,x0/6,s1,pd/n,x4/8,ph/k,x12/14,s9,x7/3,pm/c,x9/8,pb/j,x2/1,pg/m,x4/13,pe/a,s10,x8/10,s8,x13/15,pc/g,x2/14,s5,x9/13,pn/e,x7/5,pb/h,x10/11,s1,x0/7,s1,x3/12,s6,x7/13,s9,x12/8,s15,pe/i,s8,x7/2,pg/h,x0/4,pn/j,s9,pf/d,x6/7,s4,x1/11,s14,x15/10,s2,x1/7,s5,pe/b,x11/6,pl/p,x1/12,s2,pk/o,x7/2,s5,pe/p,x4/12,pi/j,x15/1,pl/d,x8/3,s3,x2/10,s4,x7/3,s8,x6/14,pf/n,x3/13,s5,x6/8,s1,x15/12,pm/a,x1/13,s10,x11/4,pn/e,x8/14,pm/c,x0/6,pn/i,x15/14,s15,x11/5,s8,x13/3,s7,x0/12,pe/o,s6,pi/a,x15/8,pj/m,x0/2,s2,x9/13,pe/i,x12/14,ph/g,x4/10,s3,x2/7,pe/p,x9/13,s12,x12/4,pj/i,x5/6,s9,x7/9,s8,x8/11,pp/e,x14/1,s12,x5/10,pb/o,x2/0,pg/j,s14,x8/9,s3,x4/3,pc/n,x10/7,pa/b,s11,x13/4,s9");
            #endregion
            #region 17
            Inputs.Add(17, "344");
            #endregion
            #region 18
            Inputs.Add(18, @"set i 31
set a 1
mul p 17
jgz p p
mul a 2
add i -1
jgz i -2
add a -1
set i 127
set p 952
mul p 8505
mod p a
mul p 129749
add p 12345
mod p a
set b p
mod b 10000
snd b
add i -1
jgz i -9
jgz a 3
rcv b
jgz b -1
set f 0
set i 126
rcv a
rcv b
set p a
mul p -1
add p b
jgz p 4
snd a
set a b
jgz 1 3
snd b
set f 1
add i -1
jgz i -11
snd a
jgz f -16
jgz a -19");
            #endregion
            #region 19
            Inputs.Add(19, @"                                                                                                                                       |                                                                 
     +---------------+       +-------+ +-----------------------------------------------------------------------------------------+     |                                               +-----+ +-+       
     |               |       |       | |                                                                                         |     |                                               |     | | |       
     | +-+ +-----------------|-------+ |           +-+         +-----------+ +---------------------------------------------------------|-----------------------------------------------------+ | |       
     | | | |         |       |         |           | |         |           | |                                                   |     |                                               |       | |       
   +-+ +---------------------|---------------------------------------------|-+         +---------------------------+             |     |       +-------+                   +-+     +-----------|-+       
   |     | |         |       |         |           | |         |           |           |                           |             |     |       |       |                   | |     |   |       |         
   |   +---|---+   +-|-------|---------|-----------|-----------+           |           |                           |     +-------|-------------|-------|-------------------|-|-------+ |       |         
   |   | | |   |   | |       |         |           | |                     |           |                           |     |       |     |       |       |                   | |     | | |       |         
 +-----|---|---|---|-|-------|---------+           +-----+                 |       +-------+ +---------------------------|-------|-------------|-----------------------------------+ | |       |         
 | |   | | |   |   | |       |                       |   |                 |       |   |   | |                     |     |       |     |       |       |                   | |       | |       |         
 | |   | | |   | +-|-------+ |         +-----------------|-------------+   |       +---|-----|---------------------|-------------|---------------------|---------------+   | |       | |       |         
 | |   | | |   | | | |     | |         |             |   |             |   |           |   | |                     |     |       |     |       |       |               |   | |       | |       |         
 +---+ | | |   +-----|-------|---------------------------------------------------------|---|-----------+     +-------------------|---+ |       |       |               |   | |       | |       |         
   | | | | |     | | |     | |         |             |   |             |   |           |   | |         |     |     |     |       |   | |       |       |               |   | |       | |       |         
   | | | +-|-+   +-------+ +-+         |             |   |             |   |           |   | |         |     |     |     |   +---|---+ |       |       |               |   | |       | |       |         
   | | |   | |     | |   |             |             |   |             |   |           |   | |         |     |     |     |   |   |     |       |       |               |   | |       | |       |         
   +---|-+ | |   +---|---|---------------------------|---|-----------------|---------------------------|-----|-----|---------|---|-----|---------------|-------------+ |   +-|-----+ | | +-----|---+     
     | | | | |   | | |   |             |             |   |             |   |           |   | |         |     |     |     |   |   |     |       |       |             | |     |     | | | |     |   |     
     | | | | |   | | |   |             |             |   |             |   |           |   | |         |     +-----|----I|---|---|-----------------+   +-------------|-----+ | +-+ | | | |     |   |     
     | | | | |   | | |   |             |             |   |             |   |           |   | |         |           |     |   |   |     |       |   |                 | |   | | | | | | | |     |   |     
     | | | | |   | | +---|------------------------B--|---|-------------|---------------|-----|---------|-----------|-------------------|-------|---|-----------------|-----|-----|-----|---------+ |     
     | | | | |   | |     |             |             |   |             |   |           |   | |         |           |     |   |   |     |       |   |                 | |   | | | | | | | |     | | |     
 +-+ | | | | |   | |     |             |       +-----|---|-------------|---------------|---|-|---------------------|---------+   |   +---------|---|-----+           | |   | | | | | | | |     | | |     
 | | | | | | |   | |     |             |       |     |   |             |   |           |   | |         |           |     |       |   | |       |   |     |           | |   | | | | | | | |     | | |     
 | | | | | | |   | |     |   +-+       |       | +-------|-----------------|-------------+ | |         |           |     |       |   | |       |   |     |           | |   | | | | | | | |     | | +-+   
 | | | | | | |   | |     |   | |       |       | |   |   |             |   |           | | | |         |           |     |       |   | |       |   |     |           | |   | | | | | | | |     | |   |   
 | | | | | | +---|-------|---|-|-------|---------|---|---|---------------------------------|-|---------------------|---+ |       |   | |       |   |     |           | |   | | | | | | | |     | |   |   
 | | | | | |     | |     |   | |       |       | |   |   |             |   |           | | | |         |           |   | |       |   | |       |   |     |           | |   | | | | | | | |     | |   |   
 | | | | | |     | |     |   | |       |   +---+ |   |   |             |   |       +---|-|-|-|---------|-----------|---|-------------|-|-------|---|-----------------|-------------------------|---+ |   
 | | | | | |     | |     |   | |       |   |     |   |   |             |   |       |   | | | |         |           |   | |       |   | |       |   |     |           | |   | | | | | | | |     | | | |   
 | | | | +-|-----------+ |   | |       |   +-----|---|---|-----------------|-----------|---|-----------------------|---|---------|-+ | |       |   |     |           | |   | +---|-|-|---|-+   | | | |   
 | | | |   |     | |   | |   | |       |         |   |   |             |   |       |   | | | |         |           |   | |       | | | |       |   |     |           | |   |   | | | | | | |   | | | |   
 | | | |   |     | |   | |   | |       |         |   |   +-------------------------|---|---------------|-----------+   | |       | | | |       |   |     |         +-|-|-------|-+ | | | | |   | | | |   
 | | | |   |     | |   | |   | |       |         |   |                 |   |       |   | | | |         |               | |       | | | |       |   |     |         | | |   |   |   | | | | |   | | | |   
 | | | |   |     | +-----|---|-------------------|---------+           |   |       |   | | | |         |               | |       | | | |       |   |     |         | | |   |   |   | | | | |   | | | |   
 | | | |   |     |     | |   | |       |         |   |     |           |   |       |   | | | |         |               | |       | | | |       |   |     |         | | |   |   |   | | | | |   | | | |   
 | | | |   |     |     | |   | |       |         |   |     |           |   |       |   | | | |         |               | |       | | | |       |   |     |         | | |   | +-------|-----|---|-|-----+ 
 | | | |   |     |     | |   | |       |         |   |     |           |   |       |   | | | |         |               | |       | | | |       |   |     |         | | |   | | |   | | | | |   | | | | | 
 | | | |   |     |     | +-------------|-------------|-----------------|---|-------|-------------------|---------------|---------------------------|-----------+   | | |   | +-+ +-|---|---|-----|---|-+ 
 | | | |   |     |     |     | |       |         |   |     |           |   |       |   | | | |         |               | |       | | | |       |   |     |     |   | | |   |     | | | | | |   | | | |   
 | | | |   |   +-----------------------------+   |   |     |   +---------------+   |   | | | |         |               | |       | | | |       |   |     |     |   | | |   |     | | | | | |   | | | |   
 | | | |   |   | |     |     | |       |     |   |   |     |   |       |   |   |   |   | | | |         |               | |       | | | |       |   |     |     |   | | |   |     | | | | | |   | | | |   
 +-|---|-------|-|-+   +-+   | +-------------|---|---|-----|---|-----------|-------|-------|-|-----------------------------------|---|-|-------|---|-----|---------|-|-|---|-----|---+ | | | +-|---|---+ 
   | | |   |   | | |     |   |         |     |   |   |     |   |       |   |   |   |   | | | |         |               | |       | | | |       |   |     |     |   | | |   |     | |   | | | | | | | | | 
 +-|---|-------------+   | +-|---------+   +-+   |   |     |   |       |   |   |   |   | | | |         |               | |       | | | |       |   |     |     |   | | | +---+ +-------|-|-|---|-|---|-+ 
 | | | |   |   | | | |   | | |             |     |   |     |   |       |   |   |   |   | | | |         |               | |       | | | |       |   |     |     |   | | | | | | | | |   | | | | | | | |   
 +---------|---|---|-|-----+ |             |     |   |     |   |       |   |   |   |   | | | |         | +---------------------+ | | | |       |   |     |     |   | | | | | | | | |   | | | | | | | |   
   | | |   |   | | | |   |   |             |     |   |     |   |       |   |   |   |   | | | |         | |             | |     | | | | |       |   |     |     |   | | | | | | | | |   | | | | | | | |   
   +-|-|-----------------|-----------------+ +---|---------|---+       |   |   |   |   +---|-----------|-|-------------|-------+ | | | |       |   |     |     |   +---|-|-|-|-+ | |   | | | | | | | |   
     | |   |   | | | |   |   |               |   |   |     |           |   |   |   |     | | |         | |             | |       | | | |       |   |     |     |     | | | | |   | |   | | | | | | | |   
     | |   |   | | | |   |   |               | +-|-------------------------|-------------|-|-+         | +---------------------------|-------------|-----------|-----|-|-|-|---+ | |   | | | | | | | |   
     | |   |   | | | |   |   |               | | |   |     |           |   |   |   |     | |           |               | |       | | | |       |   |     |     |     | | | | | | | |   | | | | | | | |   
     | |   | +-|-|-------|-----------------------+   |     |   +-+     |   |   |   |     | |           |       +---------|-------|-|-|-|-----------------------|---+ | | | | | | | |   | | | | | | | |   
     | |   | | | | | |   |   |               | |     |     |   | |     |   |   |   |     | |           |       |       | |       | | | |       |   |     |     |   | | | | | | | | |   | | | | | | | |   
 +-+ | |   | | | | | | +-+   |             +-|-------------|---|-|-----|---|---|-----------|---------------------------|---------|-|-|---------|---------|-----+   | | | | | | | | |   | | | | | | | |   
 | | | |   | | | | | | |     |             | | |     |     |   | |     |   |   |   |     | |           |       |       | |       | | | |       |   |     |         | | | | | | | | |   | | | | | | | |   
 | | | | +-----|-------|-------------------|-|-------|---------|-------|-----------|-----|-------------|---------------|-|---+ +---|---|-------|---|-----|---------|-|-----------------|-|---+ | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   |     | |           |       |       | |   | | | | | |       |   |     |         | | | | | | | | |   | | |   | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | +-----|-----------|-------|-------------|-|-----|-------------|-----|-----------|-|---|-|-+ | |   | | |   | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   | | | | | |       |   |     |         | | | | | |   | |   | | |   | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   | +-------|-------|---------|---------|-|-------------|---|---+   | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |     |         | | | | | |   | |   | |     | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |     |         | | | | | |   +-|-------+   | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |     |         | | | | | |     |   | | |   | | | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |     +---------+ | | | | |     +---|-|-|---|-+ | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |                 | | | | |         | | |   |   | |   
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |   +---------------|---|-----------|-|-|-------|-|-+ 
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |   |             | | | | |         | | |   |   | | | 
 | | | | | | | | | | | |     |       +-----|-|-------------|---|-|-----|-------------------|---------------------------|-|---|---|-|-------------------|-------------|-----|-|---------+ | +-----+ | | | 
 | | | | | | | | | | | |     |       |     | | |     |     |   | |     |   |   |   | |   | |           |       |       | |   |   | | | |       |   |   |             | | | | |           |     | | | | | 
 | | | | | | | | | | | |     |       |     | | |     |     |   | |     |   |   |   +-|-----|-----------|-------|-------+ |   |   | | | |       |   |   |             | | | | |     +-----|-+   | | | | | 
 | | | | | | | | | | | |     |       |     | | |     |     |   | |     |   |   |     |   | |           |       |         |   |   | | | |       |   |   |             | | | | |     |     | |   | | | | | 
 | | | | | | | | | | | |     |       |     | | |     |     |   | |     |   |   |     |   | |           +-------|-----------------|-|---|---------------|-----------+ | | | | |     | +---|-|-----+ | | | 
 | | | | | | | | | | | |     |       |     | | |     |     |   | |     |   |   |     |   | |                   |         |   |   | | | |       |   |   |           | | | | | |     | |   | |   |   | | | 
 | | | | | | | | | | | |     |       +-----|-|-------|-----|-----|-----|---|---|-----|--K--|-------------------|---------|---------|-|-----------------|-----------|-------+ | +-----+   | |   |   | | | 
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |     |   | |                   |         |   |   | | | |       |   |   |           | | | |   | |   |     | |   |   | | | 
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |     |   | |                   |         |   |   | | | |       |   |   |           | | | |   | |   |     | |   |   | | | 
 | | | | | | | | | | | |     |             | | |     |     |   | |     |   |   |     |   | |                   |         |   |   | | | |       |   |   |           | | | |   | |   |     | |   |   | | | 
 | | | | | | | | | | | +-----|---------------|-------|-----|---|-------|---------------------------------------|---------|---+   | | | |       |   |   |       +---+ | | |   | | +-|-----|---+ |   | | | 
 | | | | | | | | | | |       |             | | |     |     |   | |     |   |   |     |   | |                   |         |       | | | |       |   |   |       |     | | |   | | | |     | | | |   | | | 
 | | | | | | | +---|-----------------------|-|-------|-----|---+ |     |   |   |     |   | |                   |         |       | | | |       |   |   | +-------------------|-|---|---+ +-|-|-+   | | | 
 | | | | | | |   | | |       |             | | |     |     |     |     |   |   |     |   | |                   |         |       | | | |       |   |   | |     |     | | |   | | | |   |   | |     | | | 
 | | | | | | | +-|-|-+       |             +---+     |     |   +---------------|---------|---------------------|-----------------|-|-|-----------+ |   | |     |   +-|-|-|-------|---+ |   | |     | | | 
 | | | | | | | | | |         |               |       |     |   | |     |   |   |     |   | |                   |         |       | | | |       | | |   | |     |   | | | |   | | | | | |   | |     | | | 
 | | | | | | | | | |         |               |       |     |   | |     |   |   |     |   | |                   |       +-|---------|-|---------|---------------|---|-|-|-|-------|-|-|-----|-|-----|-+ | 
 | | | | | | | | | |         |               |       |     |   | |     |   |   |     |   | |                   |       | |       | | | |       | | |   | |     |   | | | |   | | | | | |   | |     |   | 
 | | | | | | | | | |         |               |       |     |   | |   +---------|-----|---|-+                   |       | |       | | | |       | | |   | |     |   | | | | +---|-----------|-------|-+ | 
 | | | | | | | | | |         |               |       |     |   | |   | |   |   |     |   |                     |       | |       | | | |       | | |   | |     |   | | | | | | | | | | |   | |     | | | 
 | | | | | | | | | |         |               | +-----|-----------------|---|-------------|---------------------|-----------------|-|-|-|---------|-|-----|-----|-+ +-----|---+ | | | | |   | |     | | | 
 | | | | | | | | | |         |               | |     |     |   | |   | |   |   |     |   |                     |       | |       | | | |       | | |   | |     | |   | | | |   | | | | |   | |     | | | 
 | | | | | | | +---+         |               +-|-----+     +---|-|-----|---|---|-----|-------------------------------------------|---------------|-|-----|-----|-----|-|-|---+ | | | | |   | |     | | | 
 | | | | | | |   |           |                 |               | |   | |   |   |     |   |                     |       | |       | | | |       | | |   | |     | |   | | | | | | | | | |   | |     | | | 
 | | | | | | |   | +---------|-----------------+               | |   | |   |   |     |   |     +---------------|-----------------|---|-|-------|-|-|---|-|---------+ | | | | | | | | | |   | |     | | | 
 | | | | | | |   | |         |                                 | |   | |   |   |     |   |     |               |       | |       | | | |       | | |   | |     | | | | | | | | | | | | |   | |     | | | 
 | | | | | | |   | | +-------|---------------------------------------------|---------|---|-----|-----------------------|---------+ | | |       | | |   | |     | | | | +-----|-|-+ | | |   | |     | | | 
 | | | | | | |   | | |       |                                 | |   | |   |   |     |   |     |               |       | |         | | |       | | |   | |     | | | |   | | | |   | | |   | |     | | | 
 | | | | | | | +-+ | |       |                                 | |   | |   |   |     |   |     |               |       | |         | | |       | | |   | |     | +---|-----|---|---|-------------+ | | | 
 | | | | | | | |   | |       |                                 | |   | |   |   |     |   |     |               |       | |         | | |       | | |   | |     |   | |   | | | |   | | |   | |   | | | | 
 | | | | | | | | +-----------|-------------------------------+ | |   | |   |   |     |   |     |               |       | |         | | |       | | |   | |     |   | | +-|-+ | | +-----|---------|-+ | | 
 | | | | | | | | | | |       |                               | | |   | |   |   |     |   |     |               |       | |         | | |       | | |   | |     |   | | | |   | | | | | |   | |   |   | | 
 | | | | | | | | | +---------|-------------------------------------------------------|---|-----|-----------------------------------|-|-----------------|-----+ |   | | +-----|-+ | | | |   | |   |   | | 
 | | | | | | | | |   |       |                               | | |   | |   |   |     |   |     |               |       | |         | | |       | | |   | |   | |   | |   |   |   | | | |   | |   |   | | 
 | | | | | +---|-|-------------------+               +-----------------|-------------|---|-+   |               |       +-|---------|---|---------------|-|-----|---|-|-+ | L | +-|---|-|---|-|---|---+ | 
 | | | | |   | | |   |       |       |               |       | | |   | |   |   |     |   | |   |               |         |         | | |       | | |   | |   | |   | | | | | | | | | | |   | |   |     | 
 | | | | |   | | |   |       |       |               |       | | |   | | +-+   |     |   | |   |               |         |         | | |       | | |   | |   | |   | | | | | | | | | | |   | |   |     | 
 | | | | |   | | |   |       |       |               |       | | |   | | |     |     |   | |   |               |         |         | | |       | | |   | |   | |   | | | | | | | | | | |   | |   |     O 
 | | | | |   | | |   |       |       |               |       +---+   | | +-----------|---------+               |         |         | | |       | | |   +-|-+ | |   | | | | | | | +---|-+   | |   |     | 
 | | | | |   | | |   |       |       |               |         |     | |       |     |   | |                   |         |         | | |       | | |     | | | |   | | | | | | |   | |     | |   |     | 
 | | | | | +-----+ +-|-------|-------|-------------------------------|---------|-----|-----|-------+           |         |         | | |       | | |     +-----|-------------|-|---|-----+ | |   | +---+ 
 | | | | | | | |   | |       |       |               |         |     | |       |     |   | |       |           |         |         | | |       | | |       | | |   | | | | | | |   | |   | | |   | |     
 | | | | | | | |   | |       |       |               |         |     | |       |     |   | |       |           |         |         | | |       | | |       | | |   | | | | | | |   | |   | | |   | |     
 | | | | | | | |   | |       |       |               |         |     | |       |     |   | |       |           |         |         | | |       | | |       | | |   | | | | | | |   | |   | | |   | |     
 | | | | | +---|----N------+ |       |               |         |     | |       |     |   | |       |           |         +-----------------------------+   | | |   | +-|-----|-|---|-+   | | |   | |     
 | | | | |   | |   | |     | |       |               |         |     | |       |     |   | |       |           |                   | | |       | | |   |   | | M   |   | | | | |   |     | | |   | |     
 | | | | |   | |   | |     | |       |               | +---------------|-------------------|-------|---------------------------------------------|-+   |   | | |   |   | | | | |   |     | | |   | |     
 | | | | |   | |   | |     | |       |               | |       |     | |       |     |   | |       |           |                   | | |       | |     |   | | |   |   | | | | |   |     | | |   | |     
 | | | | |   | +---|-|-------|-----------------------|-|-------|-------------------------|---------------------|-------------------|-|-|-+     | |     |   | | |   |   | | +-|-+   |     | | |   | |     
 | | | | |   |     | |     | |       |               | |       |     | |       |     |   | |       |           |                   | | | |     | |     |   | | |   |   | |   |     |     | | |   | |     
 | | | | |   |     | |     | |       |               | +-------|-------|-+     |     |   | |       |           |                   | | | |     | |     |   | | |   |   | |   |     |     | | |   | |     
 | | | | |   |     | |     | |       |               |         |     | | |     |     |   | |       |           |                   | | | |     | |     |   | | |   |   | |   |     |     | | |   | |     
 | | | | |   | +---|-|-----|-|-------|---------+     |       +---+   +---------|-----------|-------|-----------|-------------------------|-------+     |   | | |   |   | |   |     |     | | |   | |     
 | | | | |   | |   | |     | |       |         |     |       | | |     | |     |     |   | |       |           |                   | | | |     |       |   | | |   |   | |   |     |     | | |   | |     
 | | +-------------|---------|-----------------------|---------|-|-------------|-----|---|---------|-----------|-------------------|-|-+ |     |       |   | | |   |   | |   |     |     | | |   | | +-+ 
 | |   | |   | |   | |     | |       |         |     |       | | |     | |     |     |   | |       |           |                   | |   |     |       |   | | |   |   | |   |     |     | | |   | | | | 
 | |   | |   | |   | |     | |       |         |     |       | | |     | |     |     |   | |       |           |                   | |   |     |       |   | | |   |   | |   |     |     | | |   | | | | 
 | |   | |   | |   | |     | |       |         |     |       | | |     | |     |     |   | |       |           |                   | |   |     |       |   | | |   |   | |   |     |     | | |   | | | | 
 | |   | |   | |   | |     +-------------------|-----|-----------|-----|-|-----|-----------|---------------------------------------|-+   |     |       |   | +-|---|-----|-+ |     +-------|---+ | | | | 
 | |   | |   | |   | |       |       |         |     |       | | |     | |     |     |   | |       |           |                   |     |     |       |   |   |   |   | | | |           | | | | | | | | 
 | |   | |   | |   | |     +-|-------|---------------------------|-----|---------------+ | |       |           |                   |     |     |       |   |   |   |   | | | |           | | | | | | | | 
 | |   | |   | |   | |     | |       |         |     |       | | |     | |     |     | | | |       |           |                   |     |     |       |   |   |   |   | | | |           | | | | | | | | 
 | |   | |   | |   | |     | |       +-----------------------------------|-----------|---------------------------------------------|-----|-------------|-----------------|-|---+         | | | | | | | | 
 | |   | |   | |   | |     | |                 |     |       | | |     | |     |     | | | |       |           |                   |     |     |       |   |   |   |   | | | | |         | | | | | | | | 
 | |   | |   | |   | |     | |                 |     |     +-|-|---------|---------------|-|---------------------------------------|-----------|-------|---|-+ |   |   | | | | |         | | | | | | | | 
 | |   | |   | |   | |     | |                 |     |     | | | |     | |     |     | | | |       |           |                   |     |     |       |   | | |   |   | | | | |         | | | | | | | | 
 | |   | |   | |   | |     | |                 |   +-|-----|-+ | |     | |     |     | | | |       |           |                   |     |     |       |   | | |   |   | | | | |         | | | | | | | | 
 | |   | |   | |   | |     | |                 |   | |     |   | |     | |     |     | | | |       |           |                   |     |     |       |   | | |   |   | | | | |         | | | | | | | | 
 | |   | |   | +---|-|-----------------------------|-|---------|-------|-|-------------|-|-|-------------------|-------------------------|-----|-------|---|-|---------|-|-|-|-|---------|-+ | | | | | | 
 | |   | |   |     | |     | |                 |   | |     |   | |     | |     |     | | | |       |           |                   |     |     |       |   | | |   |   | | | | |         |   | | | | | | 
 | |   +-----|-------|-----|-------------------|-----|-----|-----------|-|-----|-------|-|-----------------------------------------|---------+ |       |   | | |   | +---|-|-----------+ |   | | | | | | 
 | |     |   |     | |     | |                 |   | |     |   | |     | |     |     | | | |       |           |                   |     |   | |       |   | | |   | | | | | | |       | |   | | | | | | 
 | |     |   |     | |     | |                 |   | |     | +-------+ | |     |     | | | |       |           |                   |     |   | |       |   | | |   | | | | | | |       | |   | | | | | | 
 | |     |   |     | |     | |                 |   | |     | | | |   | | |     |     | | | |       |           |                   |     |   | |       |   | | |   | | | | | | |       | |   | | | | | | 
 | | +-------|-+   | |     | |                 |   | |     +-|---|---|-+ |     |     | | | |       |           |                   |     |   | |       |   | | |   | | | | | | |       | | +---+ | | | | 
 | | |   |   | |   | |     | |                 |   | |       | | |   |   |     |     | | | |       |           |                   |     |   | |       |   | | |   | | | | | | |       | | | |   | | | | 
 | | |   |   | |   | |     | |                 |   | | +-------|---------------------|-|-------------------------------------------|-----|---|-|-----------|-|-|-----|-|-|-|---+       | | | |   | | | | 
 | | |   |   | |   | |     | |                 |   | | |     | | |   |   |     |     | | | |       |           |                   |     |   | |       |   | | |   | | | | | |         | | | |   | | | | 
 | | | +-----|-|-----|------------------------------X--|-----|-|-|-------------|-----|---|---------------------|-------+           |     |   | +-------|-----------|-|-----|---------+ | | | |   | | | | 
 | | | | |   | |   | |     | |                 |   | | |     | | |   |   |     |     | | | |       |           |       |           |     |   |         |   | | |   | | | | | |       | | | | |   | | | | 
 | | | | +-+ | |   | |     | |                 |   | | |     | | |   |   |     |     | | | |       |           |       |       +---------|---|---------|---|-------|-|-----------------|-|--H|-------+ | 
 | | | |   | | |   | |     | |                 |   | | |     | | |   |   |     |     | | | |       |           |       |       |   |     |   |         |   | | |   | | | | | |       | | | | |   | |   | 
 | | | |   | | |   | |   +---|---------------------|-|-------|---|-------|---------------|---------|-+         |       |       |   |     |   |         |   | | |   | | | | | |       | | | | |   | |   | 
 | | | |   | | |   | |   | | |                 |   | | |     | | |   |   |     |     | | | |       | |         |       |       |   |     |   |         |   | | |   | | | | | |       | | | | |   | |   | 
 | | | |   +---|---------|-+ |                 | +-----|-----|-------|---------|-----|-|-|---------------------+       |       |   |     |   |         |   | +-------------|-----------+ | | |   | |   | 
 | | | |     | |   | |   |   |                 | | | | |     | | |   |   |     |     | | | |       | |                 |       |   |     |   |         |   |   |   | | | | | |       |   | | |   | |   | 
 | | | |     | |   | |   |   |                 | | | | +-----+ | |   |   |     |     | | | |     +-|-+                 |       |   |     |   |         |   |   |   | +-|-|---------+ |   | | |   | |   | 
 | | | |     | |   | |   |   |                 | | | |         | |   |   |     |     | | | |     | |                   |       |   |     |   |         |   |   |   |   | | | |     | |   | | |   | |   | 
 | | | | +---|---+ | | +-|---|-------------------|-|-|---------|-----|---|---------+ | | | |     | |                   |       |   |     |   |         |   |   |   |   | | | |     | |   | | |   | |   | 
 | | | | |   | | | | | | |   |                 | | | |         | |   |   |     |   | | | | |     | |                   |       |   |     |   |         |   |   |   |   | | | |     | |   | | |   | |   | 
 | | | | +-----+ | | | +-----------------------------------------|-------|-----|-----|-|-|-|-----+ |                   +-----------|---------|-----------------|---|---|---|---+   +-|---------+ | |   | 
 | | | |     |   | | |   |   |                 | | | |         | |   |   |     |   | | | | |       |                           |   |     |   |         |   |   |   |   | | | | |     |   | | | | | |   | 
 | +---|---------|-|-------------------------------|-|---------|-----|---|-------------|---|-------|-------------------------------------|-------------|---|-+ |   |   | | | | |     |   | | | | | |   | 
 |   | |     |   | | |   |   |                 | | | |         | |   |   |     |   | | | | |       |                           |   |     |   |         |   | | |   |   | | | | |     |   | | | | | |   | 
 | +-|---+ +-|---|-+ |   +---|-------------------|-|-----------|-|-----+ |     |   | | | | |       |                           |   |     |   |         |   | | |   |   | | | | |     |   | | | | | |   | 
 | | | | | | |   |   |       |                 | | | |         | |   | | |     |   | | | | |       |                           |   |     |   |         |   | | |   |   | | | | |     |   | | | | | |   | 
 | | | | | | |   +---|-------------------------|-|-------------|-----|---------+   | | | | +-------|---------------------------|---|-----|---|---------|---|-|-----|---|-----|-------|---|-----+ | |   | 
 | | | | | | |       |       |                 | | | |         | |   | | |         | | | |         |                           |   |     |   |         |   | | |   |   | | | | |     |   | | |   | |   | 
 | | | +-------------|-------+                 | | +-|---------|-|---|-|-----------|-|-----------------+                       |   |     |   |         |   | | |   |   +---|-|-------|---|-|-|-+ | |   | 
 | | |   | | |       |                         | |   |         | |   | | |         | | | |         |   |                       |   |     |   |         |   | | |   |     | | | |     |   | | | | | |   | 
 | | |   | | |       |                         | |   +---------|-|-----|-|---------|---|-|-+       |   |                       |   |     |   |         |   | | | +-------|---|-------|-------|-|-|-|-+ | 
 | | |   | | |       |                         | |             | |   | | |         | | | | |       |   |                       |   |     |   |         |   | | | | |     | | | |     |   | | | | | | | | 
 | | |   +-|-----------------------------------|---------------------|-|-|---------|---|-|---------|---+                       |   |     |   |         |   | | | | |     | | | |     |   | | | | | | | | 
 | | |     | |       |                         | |             | |   | | |         | | | | |       |                           |   |     |   |         |   | | | | |     | | | |     |   | | | | | | | | 
 | | |     | |       |                         | |             | |   | +-------------|---|-------------------------------------|---------|---|---------|-+ | | | | |     | | | |     |   | | | +-|-|-|-+ 
 | | |     | |       |                         | |             | |   |   |         | | | | |       |                           |   |     |   |         | | | | | | |     | | | |     |   | | |   | | |   
 | | |     | |       +-----------------------------------------|-|-------------------|-------------|---------------------------|-----+   |   |         | +-|---|-|-----+ | | | +-----|---|-|---+ | | |   
 | | |     | |                                 | |             | |   |   |         | | | | |       |                           |   | |   |   |         |   | | | | |   | | | |       |   | | | | | | |   
 +-|-------|-----------------------------------|---------------------|-------------|-|-|---|-------+         +-----------------+   | |   |   |         |   | | | | |   | | | |       |   | | | | | | |   
   | |     | |                                 | |             | |   |   |         | | | | |                 |                     | |   |   |         |   | | | | |   | | | |       |   | | | | | | |   
   | |     +-|-----------------------------------|---------------|-----------------|---|---|-----------------|---------------------|-------------------+   | | | | |   | | | |       |   | | | | | | |   
   | |       |                                 | |             | |   |   |         | Z | | |                 |                     | |   |   |             | | | | |   | | | |       |   | | | | | | |   
 +-|-|-------+       +-------------------------|-----------------+   +---+         | | | | |                 |                     | +-----------------------|-+ | |   | | | |       |   | | | | | | |   
 | | |               |                         | |             |                   | | | | |                 |                     |     |   |             | |   | |   | | | |       |   | | | | | | |   
 +-----------+       +-+                       +-|-------+     +-------------------+ | +---+   +-----------------------------------------------------------|-|---|-|---|-|-|-|-+     |   | | | | | | |   
   | |       |         |                         |       |                           |   |     |             |                     |     |   |             | |   | |   | | | | |     |   | | | | | | |   
   +---------|---------|-------------------------+       +-------------+             |   |     +-------------|---------------------+     +---------------+ | |   | +---|-----|-----+ |   | +-|-|-+ | |   
     |       |         |                                               |             |   |                   |                               |           | | |   |     | | | | |   | |   |   | |   | |   
     |       +---------|-----------------------------------------------|---------------------------------------------------------------------------------|-|-----|-----|-|-+ | |   | |   |   | |   | |   
     |                 |                                               |             |   |                   |                               |           | | |   |     | |   | |   | |   |   | |   | |   
     +-----------------+ +-------------------------------------------------------------------------------------------------------------------+           | | +---|-----|-----|-----|-+   |   | |   | |   
                         |                                             |             |   |                   |                                           | |     |     | |   | |   |     |   | |   | |   
                         |                                             |             |   |                   |                                           | +-----|-----|-|-----|---|---------+ |   | |   
                         |                                             |             |   |                   |                                           |       |     | |   | |   |     |     |   | |   
                         +---------------------------------------------------------------|-------------------|-------------------------------------------|-------|-------|---------------+     |   | |   
                                                                       |             |   |                   |                                           |       |     | |   | |   |           |   | |   
 +---------------------------------------------------------------------|-------------|-----------------------+                                           |       +-------+   | |   |           +---|-+   
 |                                                                     |             |   |                                                               |             |     | |   |               |     
 |                                                                     +-------------+   |                                                               +-------------|-----+ |   +-----------+   |     
 |                                                                                       |                                                                             |       |               |   |     
 +---------------------------------------------------------------------------------------+                                                                             +-------+               +---+     
                                                                                                                                                                                                      ");
            #endregion
            #region 20
            Inputs.Add(20, @"p=<-3770,-455,1749>, v=<-4,-77,53>, a=<11,7,-9>
p=<1430,195,-903>, v=<-123,60,20>, a=<5,-5,1>
p=<-2964,-3029,2594>, v=<-8,157,7>, a=<9,-3,-8>
p=<-6383,-4277,-3529>, v=<29,70,67>, a=<16,7,5>
p=<3458,4134,-3451>, v=<-12,-132,64>, a=<-9,-2,5>
p=<-702,5382,6208>, v=<-68,-45,-132>, a=<7,-12,-8>
p=<2353,-1261,-747>, v=<-37,8,-40>, a=<-4,3,5>
p=<481,6074,-5911>, v=<-64,-51,159>, a=<3,-9,2>
p=<-3084,-2792,1033>, v=<-29,43,15>, a=<8,3,-3>
p=<-325,1951,-7399>, v=<-86,50,47>, a=<6,-7,12>
p=<4170,-2482,2893>, v=<-135,-63,-125>, a=<0,9,2>
p=<8851,1021,-4299>, v=<-30,-80,-69>, a=<-16,3,13>
p=<543,6446,4505>, v=<62,-175,-1>, a=<-5,-2,-9>
p=<-263,-715,-7368>, v=<56,-8,142>, a=<-3,2,6>
p=<4127,-3461,1895>, v=<-62,-20,-9>, a=<-6,10,-4>
p=<5681,1033,-3439>, v=<13,-79,22>, a=<-15,3,7>
p=<767,543,-5161>, v=<0,40,-47>, a=<-2,-4,16>
p=<585,-2411,1951>, v=<-95,-14,-69>, a=<5,7,0>
p=<4505,-2033,6515>, v=<-148,-42,-116>, a=<-1,8,-8>
p=<991,-3405,1951>, v=<-37,94,-69>, a=<0,2,0>
p=<1215,-3055,-3957>, v=<129,-20,55>, a=<-12,9,6>
p=<-2495,6955,215>, v=<44,-131,22>, a=<3,-8,-2>
p=<1285,3567,-2123>, v=<141,-68,-25>, a=<-13,-4,7>
p=<2188,2627,722>, v=<-47,11,-5>, a=<-1,-5,-1>
p=<-5326,5738,-4021>, v=<104,7,82>, a=<3,-10,2>
p=<-2181,6826,-621>, v=<64,-60,17>, a=<0,-8,0>
p=<5758,-7199,8049>, v=<58,-50,-168>, a=<-13,15,-4>
p=<1117,4157,1283>, v=<37,-139,66>, a=<-4,1,-6>
p=<-14268,1301,-3341>, v=<122,-125,62>, a=<17,5,2>
p=<-1110,-2830,-1607>, v=<120,14,-59>, a=<-5,4,6>
p=<-736,-4513,5958>, v=<39,11,-159>, a=<-1,7,-1>
p=<3174,2117,-13218>, v=<-6,26,160>, a=<-5,-5,13>
p=<13952,-4292,450>, v=<-148,22,3>, a=<-15,6,-1>
p=<-6015,3481,5912>, v=<77,-68,-198>, a=<8,-3,0>
p=<6270,1846,152>, v=<-38,2,25>, a=<-11,-4,-2>
p=<3600,-1784,-3433>, v=<-42,61,67>, a=<-5,0,3>
p=<5985,-4319,5207>, v=<-75,6,27>, a=<-8,9,-13>
p=<-5775,2866,-733>, v=<-55,-125,8>, a=<16,2,1>
p=<1020,2536,-598>, v=<13,-114,19>, a=<-3,2,0>
p=<3555,5322,-2095>, v=<-41,-30,75>, a=<-6,-11,0>
p=<-1177,4790,1699>, v=<41,-11,70>, a=<0,-11,-9>
p=<-3193,-3078,-3243>, v=<113,-49,0>, a=<0,11,8>
p=<3639,-768,1307>, v=<-44,-59,26>, a=<-6,6,-5>
p=<3107,1458,-3733>, v=<-112,50,-26>, a=<0,-7,11>
p=<3415,-1552,-1983>, v=<-123,-31,-16>, a=<0,6,6>
p=<1651,-1118,-5777>, v=<-60,-3,47>, a=<0,3,11>
p=<-3529,1500,1867>, v=<-20,-111,35>, a=<10,4,-7>
p=<-3865,-4044,-4405>, v=<137,145,56>, a=<0,0,7>
p=<5263,-2294,-6225>, v=<-44,39,121>, a=<-10,3,7>
p=<-721,-1274,2648>, v=<40,56,-29>, a=<-1,-1,-3>
p=<4130,904,2813>, v=<-56,-61,34>, a=<-4,2,-7>
p=<1160,3643,-3391>, v=<-34,-42,69>, a=<0,-4,2>
p=<-2272,-4178,3374>, v=<19,25,-102>, a=<3,6,0>
p=<5516,-4904,-520>, v=<-98,13,-120>, a=<-4,8,8>
p=<1127,1663,4034>, v=<1,-101,-37>, a=<-2,3,-5>
p=<-358,-2396,-1246>, v=<-22,90,-30>, a=<2,-1,4>
p=<3965,-6356,-4645>, v=<0,6,-148>, a=<-7,11,17>
p=<-2731,11,9>, v=<225,-62,-43>, a=<9,11,8>
p=<454,1126,-286>, v=<-99,-69,47>, a=<10,-8,-3>
p=<509,-819,109>, v=<0,98,2>, a=<-9,-3,-2>
p=<1194,771,14>, v=<-74,-61,-16>, a=<-8,-3,3>
p=<2545,1808,1212>, v=<-183,-93,17>, a=<5,0,-8>
p=<493,-1764,-1809>, v=<-15,-75,86>, a=<-1,17,1>
p=<-4751,1143,965>, v=<91,52,-30>, a=<16,-11,-2>
p=<1272,1295,1098>, v=<-56,-66,-37>, a=<-1,0,-2>
p=<2786,-538,-770>, v=<-7,-3,-14>, a=<-4,1,2>
p=<-329,-1623,-2065>, v=<10,-98,-31>, a=<0,8,5>
p=<-1554,3522,-9275>, v=<171,-11,13>, a=<-7,-5,14>
p=<-259,2717,-385>, v=<-28,12,29>, a=<2,-5,-1>
p=<6601,-3303,1645>, v=<-62,-32,79>, a=<-7,7,-7>
p=<8316,2927,6405>, v=<-3,-12,-147>, a=<-13,-4,-2>
p=<4781,2647,14805>, v=<-28,-94,-81>, a=<-6,1,-19>
p=<-5614,-3618,-560>, v=<107,13,-56>, a=<3,5,4>
p=<3346,1597,5880>, v=<-59,170,48>, a=<-2,-12,-12>
p=<-749,-654,1454>, v=<33,63,-141>, a=<7,0,-1>
p=<-49,-659,-241>, v=<-15,3,-21>, a=<3,11,8>
p=<-234,-674,1524>, v=<9,65,-137>, a=<2,0,-3>
p=<-179,306,749>, v=<42,-44,-65>, a=<-5,2,-2>
p=<-2410,-1167,-3859>, v=<130,55,7>, a=<-3,-1,9>
p=<-6946,-2833,-289>, v=<2,100,-77>, a=<17,0,6>
p=<1860,1927,103>, v=<-66,17,112>, a=<0,-6,-8>
p=<656,5651,-5063>, v=<-23,-145,50>, a=<0,-4,9>
p=<1314,-187,-2865>, v=<113,-38,-14>, a=<-11,3,8>
p=<1986,-1027,-2207>, v=<-56,-8,6>, a=<-1,3,5>
p=<-2914,1059,-779>, v=<61,-39,13>, a=<3,0,1>
p=<-1458,-705,173>, v=<9,53,66>, a=<3,-2,-5>
p=<-8834,7793,-285>, v=<116,-10,8>, a=<6,-10,0>
p=<-75,-5336,5073>, v=<22,4,-16>, a=<-1,7,-6>
p=<-1842,478,3819>, v=<88,85,95>, a=<-2,-5,-10>
p=<3269,4126,608>, v=<12,-50,4>, a=<-5,-3,-1>
p=<-1500,-1042,-1729>, v=<40,8,46>, a=<0,1,0>
p=<-4996,4563,3629>, v=<54,-81,22>, a=<4,-2,-6>
p=<-2051,6938,-2299>, v=<-4,-46,61>, a=<3,-7,0>
p=<-1329,3670,4066>, v=<55,1,-87>, a=<-1,-5,-1>
p=<-992,-1369,120>, v=<-12,62,112>, a=<5,0,-10>
p=<-3038,1557,780>, v=<58,-25,13>, a=<7,-4,-4>
p=<878,1106,-4698>, v=<64,-39,147>, a=<-9,-1,6>
p=<-915,-2502,-2355>, v=<-27,125,75>, a=<6,-1,3>
p=<-750,292,1616>, v=<0,-94,-25>, a=<3,7,-4>
p=<1791,853,-727>, v=<-127,-39,-68>, a=<4,0,9>
p=<-860,3548,3222>, v=<51,-12,-29>, a=<-1,-13,-10>
p=<-3016,1557,5037>, v=<126,67,-123>, a=<1,-12,-9>
p=<-992,633,208>, v=<103,40,108>, a=<-5,-6,-10>
p=<-2863,-3533,-1419>, v=<114,-118,78>, a=<-1,16,-2>
p=<-7126,-923,-752>, v=<36,2,-5>, a=<14,2,2>
p=<-456,2383,-4667>, v=<-14,-82,25>, a=<2,0,9>
p=<-4835,6095,2873>, v=<2,-75,-100>, a=<11,-9,0>
p=<4619,-4432,-85>, v=<-9,18,47>, a=<-10,9,-3>
p=<3053,904,-2666>, v=<-105,-136,46>, a=<0,7,3>
p=<-2544,962,-3971>, v=<-2,-3,76>, a=<6,-2,4>
p=<-166,1832,1887>, v=<51,-18,-126>, a=<-3,-3,4>
p=<-2747,-1503,872>, v=<65,-23,44>, a=<2,5,-5>
p=<501,208,-2637>, v=<-17,-7,60>, a=<0,0,2>
p=<-140,-1564,228>, v=<-74,92,-2>, a=<12,4,-2>
p=<-413,2232,-708>, v=<122,-130,14>, a=<-13,-6,6>
p=<1381,724,1905>, v=<-16,-35,-54>, a=<-13,-3,-13>
p=<-1160,-3258,578>, v=<-35,67,-73>, a=<8,8,4>
p=<3838,1131,2216>, v=<-97,1,-96>, a=<-8,-5,-1>
p=<-1496,-486,-1942>, v=<-8,-10,47>, a=<7,3,4>
p=<60,301,-439>, v=<-6,-36,13>, a=<0,2,1>
p=<-1310,1011,2191>, v=<31,-61,-171>, a=<3,1,6>
p=<1380,1891,-939>, v=<-30,-21,101>, a=<-4,-7,-5>
p=<-380,2051,1>, v=<-5,-92,-9>, a=<2,-1,1>
p=<760,-3939,-1019>, v=<-104,92,105>, a=<6,10,-5>
p=<-2230,-4779,811>, v=<35,218,24>, a=<7,2,-6>
p=<740,-2819,1341>, v=<2,-6,-13>, a=<-4,14,-5>
p=<8674,1471,562>, v=<-215,-112,-51>, a=<-4,4,2>
p=<10069,9376,4871>, v=<-116,-175,2>, a=<-13,-8,-10>
p=<2288,1130,-2724>, v=<-41,59,23>, a=<-2,-6,4>
p=<-2160,-2895,-1731>, v=<70,125,-8>, a=<0,-2,4>
p=<2800,-601,3074>, v=<102,-13,-115>, a=<-12,2,1>
p=<2893,-2554,5089>, v=<-109,18,-100>, a=<1,4,-4>
p=<-7802,5103,-1359>, v=<44,-117,-100>, a=<13,-3,9>
p=<2366,-2430,625>, v=<84,62,-100>, a=<-10,1,5>
p=<1715,112,7600>, v=<-87,-20,-149>, a=<2,1,-6>
p=<-2439,2871,-987>, v=<-49,3,176>, a=<8,-6,-9>
p=<-2594,6436,-5079>, v=<4,-160,-60>, a=<5,-3,14>
p=<-1181,742,-1682>, v=<-49,5,-3>, a=<6,-2,4>
p=<-2718,-476,638>, v=<79,62,22>, a=<1,-3,-3>
p=<5199,-4681,0>, v=<1,87,29>, a=<-12,5,-2>
p=<2937,-2448,-1740>, v=<-116,115,-46>, a=<1,-2,7>
p=<588,-911,3712>, v=<-65,-28,-84>, a=<3,4,-3>
p=<762,-911,-725>, v=<64,32,-66>, a=<-6,0,6>
p=<743,-2261,753>, v=<-140,54,36>, a=<9,4,-6>
p=<963,2480,-4505>, v=<80,-12,114>, a=<-11,-9,8>
p=<-1325,-5495,-1997>, v=<23,40,-23>, a=<3,18,10>
p=<2074,742,-4241>, v=<41,-94,148>, a=<-12,5,4>
p=<-2722,1655,-1711>, v=<6,-9,56>, a=<10,-6,2>
p=<166,-634,-1439>, v=<46,28,87>, a=<-9,3,5>
p=<1102,-2008,211>, v=<-97,162,-57>, a=<1,0,6>
p=<358,86,739>, v=<-35,7,-49>, a=<1,-3,-2>
p=<958,14,-1175>, v=<19,0,65>, a=<-15,-1,5>
p=<1036,-1708,1081>, v=<-85,98,-45>, a=<0,6,-7>
p=<190,-208,205>, v=<-8,12,28>, a=<-1,0,-7>
p=<1018,-412,91>, v=<-77,29,-21>, a=<-1,0,2>
p=<1168,566,-1685>, v=<8,-85,88>, a=<-16,5,8>
p=<-254,-1354,1465>, v=<146,36,-103>, a=<-19,11,-3>
p=<-5599,-2221,740>, v=<70,-8,-20>, a=<5,4,0>
p=<3536,-6631,-1115>, v=<-11,64,-39>, a=<-5,7,4>
p=<-804,-5406,6830>, v=<-13,-43,-14>, a=<2,11,-10>
p=<-5004,1069,-3880>, v=<35,6,76>, a=<6,-2,2>
p=<-6439,3344,-2130>, v=<22,-23,-118>, a=<9,-4,10>
p=<-11864,-8801,-4055>, v=<141,18,27>, a=<11,13,5>
p=<6301,4429,2805>, v=<0,108,-7>, a=<-10,-13,-4>
p=<-3359,-4811,-11895>, v=<6,120,53>, a=<5,1,16>
p=<-6474,1279,-4265>, v=<-49,-54,-3>, a=<13,1,7>
p=<7421,-4076,4380>, v=<-122,27,20>, a=<-5,5,-8>
p=<229,10,429>, v=<62,-8,43>, a=<-11,1,-11>
p=<60,-120,338>, v=<5,51,64>, a=<-1,-6,-13>
p=<463,-1017,-1001>, v=<-26,-41,76>, a=<-1,17,0>
p=<-954,2298,-975>, v=<76,-79,109>, a=<0,-14,-5>
p=<-2475,1180,-819>, v=<144,-98,-1>, a=<7,1,9>
p=<-889,1648,-546>, v=<85,-78,55>, a=<-2,-7,-2>
p=<151,2064,1495>, v=<-86,-117,-109>, a=<11,-6,-1>
p=<-2241,10,936>, v=<140,-29,-80>, a=<5,4,1>
p=<21,-133,611>, v=<22,-39,-62>, a=<-3,7,2>
p=<-3131,229,765>, v=<47,-52,-62>, a=<15,4,2>
p=<1629,-893,3145>, v=<-80,50,-94>, a=<-2,0,-10>
p=<1340,1912,-1377>, v=<-27,-88,64>, a=<-6,-3,2>
p=<3040,1963,2261>, v=<-118,-19,-96>, a=<-7,-11,-4>
p=<-1193,195,-1649>, v=<59,-50,-64>, a=<1,4,18>
p=<-487,-1545,572>, v=<65,64,-27>, a=<-4,3,-1>
p=<975,138,-40>, v=<-12,19,27>, a=<-5,-3,-3>
p=<1204,154,-678>, v=<-119,-22,66>, a=<-1,1,0>
p=<64,1744,462>, v=<-27,-82,29>, a=<3,-17,-14>
p=<-536,1289,897>, v=<22,-119,-20>, a=<5,-2,-13>
p=<-349,-2111,-1389>, v=<39,101,51>, a=<-2,1,2>
p=<-349,3988,112>, v=<59,-130,-48>, a=<-4,-8,4>
p=<392,-933,-439>, v=<-20,19,31>, a=<0,3,-1>
p=<-919,2297,-1522>, v=<-11,-71,58>, a=<6,-5,2>
p=<1551,-3821,758>, v=<-91,21,48>, a=<1,18,-9>
p=<1171,3475,1860>, v=<-11,-113,-90>, a=<-5,-7,-1>
p=<2748,-819,1955>, v=<-44,63,45>, a=<-10,-2,-15>
p=<-15077,2445,7629>, v=<66,-67,22>, a=<18,0,-12>
p=<2017,6737,155>, v=<-35,-145,-61>, a=<-1,-2,3>
p=<-4902,4850,-2879>, v=<19,-37,192>, a=<6,-5,-6>
p=<-12265,4554,5927>, v=<85,-67,-46>, a=<13,-3,-6>
p=<-7492,-774,-1473>, v=<-63,1,-131>, a=<14,1,9>
p=<-5309,1890,-3064>, v=<-27,-33,83>, a=<9,-1,0>
p=<5458,-2069,-8947>, v=<43,74,-24>, a=<-10,-1,14>
p=<-584,4972,5510>, v=<86,-83,-81>, a=<-4,-4,-5>
p=<2287,5302,9107>, v=<-69,-76,-54>, a=<0,-5,-13>
p=<-122,6556,3101>, v=<-13,5,-25>, a=<1,-12,-4>
p=<967,-2057,2540>, v=<39,79,60>, a=<-4,-1,-8>
p=<4993,2365,494>, v=<-117,132,3>, a=<-2,-12,-1>
p=<43,-2354,-2773>, v=<-18,20,34>, a=<1,3,3>
p=<-2234,847,4487>, v=<-119,-9,-16>, a=<11,-1,-7>
p=<4440,409,-5661>, v=<24,-48,10>, a=<-8,2,8>
p=<-8268,-167,-423>, v=<7,5,-6>, a=<12,0,1>
p=<-4596,-2381,5949>, v=<-132,-26,-146>, a=<14,5,-1>
p=<561,-1562,-1060>, v=<93,64,46>, a=<-16,5,3>
p=<1236,658,1385>, v=<-56,36,-45>, a=<-3,-10,-6>
p=<-1674,-962,-145>, v=<18,128,-23>, a=<12,-8,4>
p=<381,-1532,200>, v=<-7,46,-46>, a=<-2,7,4>
p=<66,-1307,-1060>, v=<-34,55,14>, a=<4,4,7>
p=<-609,718,1715>, v=<147,-40,13>, a=<-13,-1,-16>
p=<-339,-347,-1135>, v=<25,23,19>, a=<0,0,7>
p=<1401,523,1850>, v=<-11,-19,-68>, a=<-10,-2,-7>
p=<-3880,-4930,-4999>, v=<3,159,126>, a=<6,-1,1>
p=<-6995,-2690,181>, v=<110,77,-4>, a=<5,0,0>
p=<5395,-4055,13376>, v=<26,-46,-183>, a=<-10,9,-11>
p=<-5280,2770,6446>, v=<169,65,-39>, a=<-1,-8,-8>
p=<110,-2305,321>, v=<-75,-6,64>, a=<4,4,-4>
p=<-3229,-920,1526>, v=<-23,33,-53>, a=<9,0,0>
p=<918,1603,1410>, v=<44,36,-64>, a=<-5,-6,1>
p=<-6187,2560,1352>, v=<124,-12,-2>, a=<6,-5,-3>
p=<-1083,-2834,-620>, v=<8,129,21>, a=<2,-2,0>
p=<-2685,3997,-1222>, v=<-66,7,119>, a=<10,-9,-5>
p=<-2820,1792,-3967>, v=<16,-59,9>, a=<5,0,8>
p=<2827,286,-1978>, v=<-60,-81,56>, a=<-6,6,3>
p=<-143,-3685,-2737>, v=<-17,19,56>, a=<2,13,6>
p=<4686,-418,4600>, v=<-18,43,-36>, a=<-17,-2,-15>
p=<-2277,-4961,-405>, v=<149,31,-119>, a=<-4,17,12>
p=<-2761,-3058,-1505>, v=<56,2,-69>, a=<6,12,12>
p=<-748,1969,-295>, v=<22,-123,14>, a=<1,3,0>
p=<2024,-891,-3122>, v=<80,7,85>, a=<-15,3,5>
p=<979,-1650,519>, v=<-68,-16,46>, a=<2,8,-6>
p=<1441,-968,3390>, v=<-43,45,-50>, a=<-2,0,-9>
p=<1920,-2294,-651>, v=<-174,-26,100>, a=<7,16,-7>
p=<-1500,154,-5313>, v=<149,-10,188>, a=<-7,0,11>
p=<-2751,-2456,-3783>, v=<0,135,84>, a=<16,0,13>
p=<219,1243,-30>, v=<-13,-80,-1>, a=<0,1,0>
p=<-789,388,861>, v=<43,-23,-98>, a=<0,0,5>
p=<-1820,-2022,-5756>, v=<67,52,8>, a=<-1,0,7>
p=<8749,-2412,-2480>, v=<-124,62,-36>, a=<-5,0,5>
p=<-6500,-6273,-6926>, v=<-33,-59,-22>, a=<10,11,10>
p=<-5447,84,-4391>, v=<0,78,33>, a=<7,-4,4>
p=<5239,-7989,-491>, v=<-94,45,153>, a=<-2,8,-7>
p=<598,-5181,4033>, v=<5,53,-43>, a=<-1,4,-3>
p=<-2405,-5064,-12503>, v=<102,-90,1>, a=<-2,11,16>
p=<442,8196,133>, v=<-11,10,-63>, a=<0,-11,3>
p=<-455,4413,-6653>, v=<12,-93,31>, a=<0,-1,7>
p=<-5876,-1398,-11255>, v=<91,-24,149>, a=<3,3,7>
p=<467,1357,1470>, v=<-54,-38,-59>, a=<2,-12,-10>
p=<-7,-1571,-1734>, v=<-8,141,169>, a=<1,-2,-4>
p=<2045,379,-462>, v=<-114,-67,63>, a=<-9,5,-4>
p=<-349,-1595,-1284>, v=<1,26,34>, a=<4,16,11>
p=<1199,-1259,-1212>, v=<-89,76,80>, a=<-2,4,3>
p=<-3704,-1371,-1025>, v=<115,11,-64>, a=<8,6,12>
p=<-2792,624,96>, v=<137,-124,-13>, a=<1,9,1>
p=<589,390,-229>, v=<-28,-74,35>, a=<-6,7,-2>
p=<-1261,-675,-694>, v=<113,82,87>, a=<2,-2,-3>
p=<9,545,-1744>, v=<-36,-51,104>, a=<6,0,13>
p=<-686,30,451>, v=<28,-27,-44>, a=<7,5,0>
p=<-516,-305,-219>, v=<33,12,1>, a=<3,4,4>
p=<-996,105,-1449>, v=<37,-7,124>, a=<11,0,4>
p=<1638,-3532,-519>, v=<136,-39,-65>, a=<-14,12,6>
p=<3744,5459,-2517>, v=<-138,6,107>, a=<0,-15,-1>
p=<-358,1728,130>, v=<56,-54,-13>, a=<-4,-12,0>
p=<-761,-482,-923>, v=<59,4,26>, a=<0,4,6>
p=<-1177,155,-754>, v=<77,53,27>, a=<2,-10,4>
p=<435,1091,-1027>, v=<23,-89,-1>, a=<-8,0,11>
p=<84,-846,-1716>, v=<36,32,129>, a=<-6,4,0>
p=<1722,-1704,-299>, v=<-13,98,76>, a=<-17,4,-8>
p=<1358,-1548,-572>, v=<-104,51,-22>, a=<0,9,9>
p=<-1697,727,-598>, v=<47,-68,8>, a=<12,1,5>
p=<-150,571,416>, v=<-16,-14,35>, a=<4,-5,-10>
p=<435,-8451,531>, v=<-12,19,0>, a=<0,14,-1>
p=<798,13692,-8478>, v=<-23,-176,154>, a=<0,-14,6>
p=<171,1779,5052>, v=<13,-53,-86>, a=<-1,0,-4>
p=<-3558,-3072,-3528>, v=<92,-42,-13>, a=<1,8,7>
p=<-4218,-2313,-4122>, v=<129,-31,107>, a=<0,6,1>
p=<-2766,7356,-3066>, v=<0,-35,58>, a=<5,-11,2>
p=<-4331,7140,-11515>, v=<-24,10,90>, a=<11,-16,19>
p=<3484,2565,-880>, v=<10,-101,-125>, a=<-8,1,10>
p=<7564,-1275,-1420>, v=<-126,-35,48>, a=<-8,5,0>
p=<-3251,-9690,3485>, v=<-29,168,-38>, a=<9,10,-5>
p=<2367,-3580,4558>, v=<72,36,-12>, a=<-8,4,-7>
p=<7892,-1625,-2344>, v=<-108,101,86>, a=<-7,-3,-1>
p=<-7969,-469,6819>, v=<96,-3,-96>, a=<8,1,-6>
p=<-2240,823,7618>, v=<-125,-41,-67>, a=<11,1,-9>
p=<6702,11312,-4163>, v=<32,-87,-18>, a=<-13,-14,8>
p=<-8853,-1659,2739>, v=<157,-73,-81>, a=<6,7,0>
p=<3647,-2764,-635>, v=<-8,19,66>, a=<-9,6,-3>
p=<623,2501,-2525>, v=<-36,-120,38>, a=<1,2,4>
p=<-7045,-955,229>, v=<94,-34,62>, a=<12,5,-5>
p=<5402,6470,-1796>, v=<-87,-57,67>, a=<-8,-13,0>
p=<-1045,-2592,2778>, v=<68,60,-126>, a=<-2,4,1>
p=<-7249,3372,-5394>, v=<164,-76,127>, a=<11,-5,8>
p=<1103,-2460,-6378>, v=<66,-8,68>, a=<-9,9,16>
p=<-1633,3072,-2442>, v=<-20,-51,104>, a=<7,-6,0>
p=<659,924,642>, v=<-28,-24,63>, a=<0,-1,-7>
p=<599,-4248,3630>, v=<37,204,-124>, a=<-5,-2,-2>
p=<-4669,888,-3654>, v=<119,-110,67>, a=<6,6,7>
p=<1175,-3060,2454>, v=<38,17,-125>, a=<-7,9,2>
p=<-4808,-3374,1978>, v=<72,12,-39>, a=<4,5,-1>
p=<-1425,1726,8115>, v=<25,-68,-132>, a=<1,1,-6>
p=<-915,-1691,533>, v=<-60,-20,56>, a=<5,4,-4>
p=<-9262,-2082,465>, v=<98,114,23>, a=<10,-3,-2>
p=<-235,1692,-6199>, v=<-80,-137,44>, a=<5,5,8>
p=<1006,-2745,3967>, v=<-29,11,60>, a=<0,4,-10>
p=<734,910,4545>, v=<49,-9,113>, a=<-4,-1,-14>
p=<-4400,5245,1145>, v=<95,-84,108>, a=<2,-4,-8>
p=<-5137,-4813,-3931>, v=<170,99,130>, a=<0,4,0>
p=<-1237,362,4664>, v=<71,-27,-48>, a=<-2,1,-7>
p=<4118,3047,-4426>, v=<-30,23,7>, a=<-7,-8,9>
p=<3953,-5713,2879>, v=<-40,129,-35>, a=<-6,4,-4>
p=<6098,467,284>, v=<28,-108,-119>, a=<-15,6,7>
p=<-5257,-463,-1006>, v=<81,78,-14>, a=<6,-4,3>
p=<-2392,-4483,-781>, v=<1,88,-6>, a=<5,4,2>
p=<2392,-3365,691>, v=<-86,94,96>, a=<-2,5,-11>
p=<38,100,4266>, v=<44,17,-170>, a=<-4,-2,-2>
p=<-1986,-3255,-651>, v=<44,66,-27>, a=<4,7,5>
p=<-4813,-582,2253>, v=<92,2,2>, a=<11,2,-9>
p=<-4351,-4146,460>, v=<94,95,-20>, a=<9,8,0>
p=<654,-351,-2928>, v=<-53,3,134>, a=<2,1,0>
p=<-1711,870,2814>, v=<20,5,-58>, a=<5,-4,-6>
p=<269,-4707,1637>, v=<-47,132,-62>, a=<3,7,-1>
p=<-3141,2135,4365>, v=<108,-18,-94>, a=<3,-7,-9>
p=<-326,254,-1121>, v=<46,-14,57>, a=<-3,0,1>
p=<830,-290,1599>, v=<5,27,-49>, a=<-6,-1,-5>
p=<-1591,14168,-6462>, v=<136,-117,76>, a=<-5,-16,6>
p=<-5651,3843,-5132>, v=<126,-38,110>, a=<2,-4,2>
p=<-10131,1288,9673>, v=<56,-37,-7>, a=<13,0,-15>
p=<6424,-4347,-1982>, v=<-39,52,-16>, a=<-8,4,4>
p=<-1158,-4508,3667>, v=<70,88,-149>, a=<-1,13,-3>
p=<2522,3462,-253>, v=<-135,-111,47>, a=<1,-6,-3>
p=<1452,-3418,-1613>, v=<-50,44,-11>, a=<-2,12,9>
p=<-4388,2692,1047>, v=<11,-104,-39>, a=<20,-3,-1>
p=<1672,592,-913>, v=<-61,-104,143>, a=<-2,7,-9>
p=<1792,-968,317>, v=<-88,37,-13>, a=<0,1,0>
p=<3902,-2518,-2033>, v=<-141,62,94>, a=<-5,6,1>
p=<-1618,-4358,-1043>, v=<51,175,-29>, a=<3,4,8>
p=<-58,-1808,2057>, v=<78,37,26>, a=<-7,5,-12>
p=<2272,1312,-633>, v=<-70,-98,129>, a=<-4,3,-9>
p=<-1750,755,1487>, v=<26,-47,18>, a=<10,0,-13>
p=<-46,-2101,1943>, v=<98,72,-70>, a=<-11,7,-6>
p=<-870,1043,791>, v=<22,-65,-49>, a=<4,0,0>
p=<1618,243,-257>, v=<-74,-168,59>, a=<-3,18,-5>
p=<2066,155,-2385>, v=<-102,-1,107>, a=<-3,-1,5>
p=<10,115,-633>, v=<-16,-7,23>, a=<2,0,2>
p=<418,1539,471>, v=<18,-96,39>, a=<-5,0,-8>
p=<-1462,235,-233>, v=<127,-74,32>, a=<-4,7,-2>
p=<125,463,-834>, v=<19,20,-50>, a=<-3,-5,11>
p=<-2034,-999,-1565>, v=<38,7,56>, a=<9,6,4>
p=<-215,140,-1293>, v=<-24,-51,76>, a=<4,5,0>
p=<-895,1398,645>, v=<-56,-17,-38>, a=<12,-7,0>
p=<-1048,225,951>, v=<34,25,-65>, a=<3,-4,1>
p=<1077,2350,271>, v=<-64,-55,-61>, a=<0,-9,5>
p=<3813,2408,4701>, v=<-35,30,-184>, a=<-7,-8,1>
p=<-1297,-3052,-59>, v=<46,-123,-72>, a=<0,16,5>
p=<-7569,-98,1677>, v=<9,-11,11>, a=<18,1,-5>
p=<-3733,7084,823>, v=<46,-50,-89>, a=<6,-14,4>
p=<145,-490,-1221>, v=<-20,61,42>, a=<1,-3,0>
p=<-639,224,-6499>, v=<8,-8,-16>, a=<1,0,17>
p=<-3397,98,4183>, v=<121,40,-93>, a=<0,-3,-4>
p=<1714,-5869,-7053>, v=<-6,174,-30>, a=<-2,-1,11>
p=<-4119,2852,1022>, v=<11,-114,-28>, a=<5,2,0>
p=<-4100,-8852,1687>, v=<30,77,13>, a=<4,8,-3>
p=<-5544,-1176,6418>, v=<146,-86,25>, a=<0,6,-10>
p=<-102,595,-2723>, v=<16,-3,20>, a=<-1,-3,14>
p=<-2694,-1646,-878>, v=<8,131,79>, a=<15,-4,-3>
p=<-606,523,256>, v=<120,1,-41>, a=<-9,-3,3>
p=<-2636,5944,-1281>, v=<-39,-63,124>, a=<7,-7,-5>
p=<3535,-4088,6705>, v=<80,-65,-33>, a=<-11,11,-10>
p=<-3461,-5936,864>, v=<71,178,-26>, a=<2,0,0>
p=<73,-410,-1012>, v=<-5,27,70>, a=<0,0,0>
p=<878,654,1417>, v=<-145,-4,-141>, a=<11,-6,5>
p=<-417,-606,-1369>, v=<0,-4,58>, a=<4,6,5>
p=<-46,-1495,-634>, v=<-4,52,28>, a=<1,7,2>
p=<213,1249,-1936>, v=<0,-24,46>, a=<-2,-9,12>
p=<-1280,328,161>, v=<-57,-17,15>, a=<10,0,-2>
p=<-334,-805,1151>, v=<84,-23,-53>, a=<-6,5,0>
p=<876,-1861,-1665>, v=<-63,25,-17>, a=<2,5,8>
p=<-301,4959,1173>, v=<71,-147,61>, a=<-5,-7,-10>
p=<1822,-1223,1404>, v=<-83,-27,-99>, a=<0,7,3>
p=<-2776,856,-1071>, v=<80,-64,25>, a=<4,2,2>
p=<1264,-2025,375>, v=<4,-98,47>, a=<-2,8,-3>
p=<-7024,4746,-2363>, v=<152,-91,26>, a=<2,-2,2>
p=<2337,3599,5037>, v=<51,35,-136>, a=<-6,-7,0>
p=<-3176,6115,2225>, v=<-28,-128,-117>, a=<6,-2,3>
p=<-7542,3599,-5841>, v=<14,-60,-70>, a=<10,-2,12>
p=<-2510,-10868,2484>, v=<30,84,47>, a=<2,11,-6>
p=<1375,5042,560>, v=<-94,-118,-15>, a=<3,-1,0>
p=<572,-184,9935>, v=<121,83,-129>, a=<-9,-5,-13>
p=<3317,1631,-3265>, v=<-110,-55,32>, a=<0,0,5>
p=<-1213,-4699,2240>, v=<41,32,-43>, a=<0,8,-2>
p=<-778,7046,4100>, v=<135,-96,19>, a=<-7,-9,-10>
p=<-4558,-7279,-910>, v=<106,-37,-31>, a=<3,18,4>
p=<4472,4916,770>, v=<-164,6,6>, a=<1,-11,-2>
p=<-2371,9,-1448>, v=<161,37,64>, a=<0,-5,4>
p=<1934,-141,-2153>, v=<-94,103,23>, a=<-4,-12,15>
p=<1004,2454,532>, v=<-32,-166,-84>, a=<-4,0,6>
p=<449,1374,-23>, v=<-27,-70,-7>, a=<0,-3,1>
p=<-46,189,742>, v=<-2,-7,38>, a=<1,-1,-11>
p=<-1921,-486,-1268>, v=<51,-26,-4>, a=<10,7,11>
p=<-8594,-6964,453>, v=<37,85,-79>, a=<14,8,4>
p=<-3426,4252,1909>, v=<24,-117,-9>, a=<5,-1,-3>
p=<4734,-8724,949>, v=<-33,74,153>, a=<-7,12,-11>
p=<1470,-7028,-2683>, v=<-63,87,85>, a=<1,8,0>
p=<-2834,-7572,5093>, v=<-11,137,73>, a=<6,6,-14>
p=<-2082,-2212,-10699>, v=<-84,-47,121>, a=<9,7,13>
p=<-8770,7388,-1531>, v=<59,-83,49>, a=<13,-9,0>
p=<1550,-4996,-2219>, v=<-16,-59,21>, a=<-2,13,3>
p=<-3570,-5748,-6619>, v=<-87,80,43>, a=<12,6,10>
p=<3694,-11780,-3643>, v=<-17,186,16>, a=<-6,11,6>
p=<216,-1664,-1581>, v=<32,40,67>, a=<-4,4,1>
p=<-3484,-344,959>, v=<175,58,-60>, a=<0,-4,1>
p=<-524,-854,-1941>, v=<-36,31,64>, a=<6,1,3>
p=<1556,-1314,829>, v=<-77,75,-64>, a=<0,-1,2>
p=<-1804,1036,-1481>, v=<-35,10,62>, a=<12,-6,1>
p=<-6204,1486,1019>, v=<122,-23,42>, a=<18,-5,-9>
p=<106,-1634,769>, v=<-99,7,2>, a=<9,7,-4>
p=<-744,-1114,1239>, v=<-25,-61,-32>, a=<6,11,-3>
p=<1326,-1514,-2681>, v=<-13,-20,164>, a=<-5,9,-3>
p=<-6024,1756,-2991>, v=<176,-47,148>, a=<12,-4,0>
p=<-1185,1891,-1377>, v=<-169,271,-196>, a=<2,-18,15>
p=<2450,-113,1689>, v=<347,-19,245>, a=<-24,4,-14>
p=<-2696,798,-390>, v=<-385,115,-51>, a=<23,-7,3>
p=<-253,-2657,-1113>, v=<-39,-378,-160>, a=<2,28,15>
p=<941,-2221,-1739>, v=<134,-319,-247>, a=<-10,22,17>
p=<-2571,622,692>, v=<-367,83,94>, a=<26,-10,-6>
p=<887,-469,2889>, v=<123,-69,414>, a=<-14,8,-28>
p=<2493,-978,-1309>, v=<353,-130,-187>, a=<-24,10,10>
p=<2150,1501,-1594>, v=<311,209,-227>, a=<-18,-15,13>
p=<1856,2988,-329>, v=<269,430,-53>, a=<-19,-31,3>
p=<1148,1977,-2139>, v=<164,283,-301>, a=<-16,-24,28>
p=<-2743,629,-1085>, v=<-390,89,-162>, a=<29,-3,14>
p=<1933,946,-1573>, v=<275,130,-224>, a=<-19,-9,15>
p=<-2305,-1290,388>, v=<-331,-184,57>, a=<22,13,-4>
p=<464,-149,-3139>, v=<67,-21,-447>, a=<-5,4,30>
p=<479,-1038,-2341>, v=<72,-149,-337>, a=<-1,8,23>
p=<1839,-337,1939>, v=<261,-46,278>, a=<-21,-3,-21>
p=<257,2019,-2008>, v=<41,295,-285>, a=<-3,-19,16>
p=<-1160,-1445,2476>, v=<-164,-204,355>, a=<15,11,-23>
p=<-889,2702,851>, v=<-125,388,122>, a=<11,-31,-3>
p=<-1514,1718,1230>, v=<-217,249,178>, a=<20,-13,-12>
p=<-2265,-358,624>, v=<-323,-49,84>, a=<21,8,-5>
p=<825,-2007,-2588>, v=<117,-286,-369>, a=<-10,18,22>
p=<2389,1568,1685>, v=<343,221,242>, a=<-21,-16,-20>
p=<-1230,2091,-604>, v=<-173,298,-84>, a=<15,-18,3>
p=<-2333,857,1449>, v=<-336,118,209>, a=<24,-12,-11>
p=<558,-2136,1370>, v=<79,-305,192>, a=<-5,21,-12>
p=<-2414,1497,576>, v=<-344,215,80>, a=<24,-17,-5>
p=<-1901,2046,695>, v=<-270,288,101>, a=<19,-21,-4>
p=<373,1186,-2417>, v=<55,170,-343>, a=<0,-16,25>
p=<-1470,-340,-2620>, v=<-217,-48,-373>, a=<10,5,28>
p=<-501,847,2590>, v=<-74,121,370>, a=<7,-8,-29>
p=<863,-1755,-1964>, v=<119,-250,-279>, a=<-5,19,17>
p=<-2564,816,-1585>, v=<-366,112,-226>, a=<23,-8,16>
p=<2452,-1521,-1441>, v=<356,-217,-203>, a=<-19,11,10>
p=<-426,2546,-2083>, v=<-62,366,-300>, a=<1,-19,17>
p=<51,788,2731>, v=<10,112,390>, a=<2,-11,-29>
p=<191,617,-2860>, v=<27,89,-407>, a=<-4,-3,30>
p=<2197,-762,-1985>, v=<314,-110,-283>, a=<-22,12,20>
p=<-1336,1043,2127>, v=<-190,147,303>, a=<13,-10,-21>
p=<-2534,-988,2164>, v=<-358,-146,311>, a=<26,9,-17>
p=<1028,-2556,-47>, v=<147,-360,-6>, a=<-12,25,2>
p=<1301,-1925,-1704>, v=<182,-278,-243>, a=<-19,14,14>
p=<-1982,194,1860>, v=<-285,27,261>, a=<16,-5,-18>
p=<1264,1574,-2430>, v=<177,224,-351>, a=<-16,-15,25>
p=<1841,411,-2245>, v=<262,61,-316>, a=<-18,-2,27>
p=<-2439,1764,774>, v=<-345,252,110>, a=<24,-25,-5>
p=<561,772,-2215>, v=<77,114,-313>, a=<-3,-9,25>
p=<-326,-877,-3157>, v=<-42,-124,-451>, a=<3,9,31>
p=<53,2546,-1341>, v=<12,362,-189>, a=<-5,-25,10>
p=<1588,1660,2255>, v=<226,242,326>, a=<-15,-15,-25>
p=<-65,780,-2718>, v=<-11,112,-387>, a=<-4,-7,27>
p=<-2660,-340,538>, v=<-381,-48,70>, a=<26,3,-5>
p=<-1538,303,2055>, v=<-219,40,294>, a=<11,0,-19>
p=<-227,-2448,-2132>, v=<-32,-344,-304>, a=<3,25,22>
p=<2226,-1561,-1043>, v=<316,-223,-152>, a=<-22,14,8>
p=<1033,1427,2456>, v=<151,204,354>, a=<-12,-16,-24>
p=<2625,-1026,-1869>, v=<374,-143,-268>, a=<-26,11,22>
p=<-2217,-2660,57>, v=<-319,-380,8>, a=<22,29,3>
p=<770,606,-2745>, v=<113,85,-392>, a=<-2,-4,26>
p=<2143,1913,402>, v=<309,273,58>, a=<-22,-16,1>
p=<-2528,1344,-281>, v=<-361,192,-37>, a=<23,-13,3>
p=<2732,456,414>, v=<386,65,56>, a=<-27,-7,-4>
p=<2490,-1902,315>, v=<355,-277,44>, a=<-24,19,-1>
p=<-10,-462,3021>, v=<-4,-62,431>, a=<-2,-1,-29>
p=<-3044,1288,861>, v=<-433,189,124>, a=<30,-9,-7>
p=<-552,301,2652>, v=<-86,49,379>, a=<1,-1,-29>
p=<1577,1507,1914>, v=<224,220,270>, a=<-16,-15,-19>
p=<2804,542,-194>, v=<398,77,-28>, a=<-22,-9,4>
p=<1989,1071,1788>, v=<284,152,253>, a=<-19,-11,-22>
p=<2939,-331,-1719>, v=<416,-50,-246>, a=<-28,5,9>
p=<-596,-2447,1601>, v=<-85,-351,228>, a=<0,24,-13>
p=<1887,932,-538>, v=<272,130,-76>, a=<-19,-7,5>
p=<857,-260,-2540>, v=<124,-38,-361>, a=<-13,0,18>
p=<-1359,-2481,-778>, v=<-194,-356,-111>, a=<11,25,7>
p=<2695,-449,1496>, v=<384,-64,215>, a=<-28,1,-14>
p=<-1518,2278,953>, v=<-214,325,134>, a=<12,-25,-8>
p=<1233,2135,1600>, v=<175,312,230>, a=<-11,-15,-15>
p=<552,286,2951>, v=<81,40,425>, a=<-4,-5,-30>
p=<-1833,-433,2423>, v=<-257,-69,346>, a=<21,2,-24>
p=<868,-2791,-1661>, v=<126,-403,-234>, a=<-10,24,15>
p=<1124,2180,-1315>, v=<158,312,-184>, a=<-6,-24,10>
p=<2362,1733,-443>, v=<336,249,-63>, a=<-23,-16,9>
p=<-2797,-695,-1637>, v=<-399,-97,-226>, a=<31,2,16>
p=<2080,1064,1457>, v=<295,152,206>, a=<-20,-12,-14>
p=<-2097,-1197,-1723>, v=<-303,-172,-246>, a=<23,13,19>
p=<12,-2706,1595>, v=<2,-386,231>, a=<-2,32,-15>
p=<-2664,-836,354>, v=<-380,-118,48>, a=<24,6,-3>
p=<-626,2290,-1721>, v=<-86,330,-242>, a=<10,-22,17>
p=<1172,-2726,-678>, v=<169,-386,-100>, a=<-9,26,5>
p=<1946,2224,-812>, v=<276,315,-118>, a=<-19,-26,5>
p=<-1546,-1945,-456>, v=<-217,-276,-61>, a=<15,18,2>
p=<-2731,-230,-4>, v=<-390,-32,4>, a=<27,4,0>
p=<488,-1761,-2141>, v=<70,-255,-302>, a=<-9,17,16>
p=<-631,2781,2584>, v=<-88,400,370>, a=<5,-26,-30>
p=<1889,-1146,-1587>, v=<269,-170,-225>, a=<-21,8,12>
p=<-300,-2429,1873>, v=<-50,-347,270>, a=<3,23,-13>
p=<-2819,-517,-187>, v=<-405,-78,-28>, a=<28,2,5>
p=<-1364,-2076,2041>, v=<-194,-295,293>, a=<16,20,-18>
p=<-2689,-145,-379>, v=<-384,-19,-53>, a=<24,3,2>
p=<1165,2759,-18>, v=<165,396,1>, a=<-11,-23,0>
p=<-411,-1272,2205>, v=<-55,-184,315>, a=<8,16,-24>
p=<703,1225,2986>, v=<100,175,424>, a=<-10,-10,-29>
p=<1557,2047,1330>, v=<222,292,196>, a=<-15,-20,-13>
p=<2432,1064,-604>, v=<347,153,-86>, a=<-22,-12,5>
p=<2707,-575,-976>, v=<387,-77,-139>, a=<-29,8,13>
p=<-415,2782,-2030>, v=<-59,397,-293>, a=<4,-27,21>
p=<437,-2795,291>, v=<58,-400,36>, a=<-9,28,-6>
p=<3282,163,-811>, v=<468,23,-113>, a=<-34,-4,9>
p=<1812,-1269,1678>, v=<252,-181,238>, a=<-21,10,-16>
p=<1190,405,-2752>, v=<169,63,-398>, a=<-10,-4,26>
p=<1070,-2048,-997>, v=<154,-287,-145>, a=<-12,21,12>
p=<-2340,-577,-2119>, v=<-339,-80,-302>, a=<28,10,21>
p=<2672,595,1296>, v=<383,84,186>, a=<-28,-5,-14>
p=<-21,52,-2410>, v=<-1,6,-337>, a=<6,-6,22>
p=<501,2436,-1297>, v=<73,350,-186>, a=<-5,-26,12>
p=<-1073,1132,2603>, v=<-156,165,372>, a=<11,-7,-26>
p=<-227,-52,3320>, v=<-31,-7,478>, a=<5,5,-32>
p=<-1156,-1949,2115>, v=<-164,-277,302>, a=<11,19,-18>
p=<2230,-1374,-2410>, v=<319,-194,-346>, a=<-25,13,28>
p=<-891,-772,2519>, v=<-128,-104,357>, a=<8,7,-27>
p=<-1407,-2788,-953>, v=<-205,-398,-135>, a=<10,30,10>
p=<2782,253,-538>, v=<393,39,-77>, a=<-30,-3,8>
p=<-2762,-694,-371>, v=<-393,-98,-52>, a=<26,2,2>
p=<549,2620,-1246>, v=<74,374,-178>, a=<-5,-28,12>
p=<1894,1939,-62>, v=<273,279,-9>, a=<-20,-19,2>
p=<616,2630,-248>, v=<87,375,-36>, a=<-6,-31,4>
p=<1667,2513,-359>, v=<240,358,-51>, a=<-16,-22,2>
p=<-2291,-36,-2460>, v=<-325,2,-350>, a=<22,6,24>
p=<-225,-1066,-3008>, v=<-34,-149,-429>, a=<-1,9,27>
p=<-2072,-2536,70>, v=<-294,-363,8>, a=<23,21,1>
p=<826,-1220,2142>, v=<118,-172,310>, a=<-9,14,-21>
p=<-1769,2052,-229>, v=<-246,296,-28>, a=<17,-21,3>
p=<1964,2481,-738>, v=<288,354,-105>, a=<-24,-26,10>
p=<1322,2501,492>, v=<189,360,68>, a=<-15,-25,-5>
p=<-2049,2194,-775>, v=<-290,311,-114>, a=<22,-24,3>
p=<-1142,-2134,1804>, v=<-161,-305,258>, a=<10,18,-21>
p=<-2405,-1901,523>, v=<-338,-274,71>, a=<28,22,-1>
p=<-390,128,2783>, v=<-60,21,404>, a=<1,-1,-27>
p=<-1011,-2266,1237>, v=<-143,-327,175>, a=<8,19,-12>
p=<-2554,-1987,167>, v=<-364,-280,23>, a=<24,19,1>
p=<604,1223,2588>, v=<85,182,366>, a=<-8,-14,-25>
p=<-1616,-163,-2086>, v=<-232,-24,-305>, a=<12,3,17>
p=<-2698,-239,-252>, v=<-389,-34,-34>, a=<29,1,3>
p=<1232,-72,-3004>, v=<180,-7,-425>, a=<-16,-6,32>
p=<2545,1542,-788>, v=<367,221,-112>, a=<-27,-15,3>
p=<243,-2267,2095>, v=<36,-327,298>, a=<-4,14,-18>
p=<192,-1627,2420>, v=<23,-232,345>, a=<-2,23,-24>
p=<-1838,1657,-477>, v=<-265,235,-68>, a=<15,-22,6>
p=<1739,-728,-2486>, v=<249,-103,-355>, a=<-21,6,25>
p=<-82,-1585,-2878>, v=<-11,-227,-415>, a=<4,11,25>
p=<2105,-1629,-857>, v=<302,-230,-123>, a=<-21,17,10>
p=<-2179,1212,2229>, v=<-312,172,316>, a=<27,-9,-24>
p=<1905,1756,1533>, v=<272,250,220>, a=<-19,-18,-15>
p=<-1918,-1724,1169>, v=<-273,-250,162>, a=<21,21,-10>
p=<104,-2945,352>, v=<14,-420,51>, a=<2,29,-3>
p=<938,192,-2775>, v=<139,27,-391>, a=<-11,-2,27>
p=<-1622,66,2201>, v=<-230,14,319>, a=<12,6,-21>
p=<-456,2516,-452>, v=<-65,363,-65>, a=<4,-25,4>
p=<2495,-1215,1016>, v=<359,-174,148>, a=<-24,16,-8>
p=<-1576,1299,-2319>, v=<-226,185,-330>, a=<15,-15,22>
p=<-2117,-1834,151>, v=<-299,-265,27>, a=<20,17,3>
p=<-1294,-1127,2522>, v=<-185,-161,360>, a=<16,16,-30>
p=<-1101,-2674,738>, v=<-160,-379,105>, a=<16,22,-8>
p=<2009,-1556,-1579>, v=<280,-222,-225>, a=<-22,15,13>
p=<-2802,872,-2008>, v=<-399,126,-283>, a=<23,-8,24>
p=<465,415,-2268>, v=<66,59,-322>, a=<0,-4,25>
p=<133,1403,2447>, v=<19,195,352>, a=<0,-20,-24>
p=<-335,1409,1970>, v=<-52,194,279>, a=<3,-14,-18>
p=<582,-2694,-473>, v=<82,-380,-73>, a=<-3,27,7>
p=<1793,1331,-2287>, v=<256,188,-325>, a=<-17,-7,24>
p=<3093,-123,770>, v=<441,-21,106>, a=<-30,2,-5>
p=<989,-1851,2200>, v=<141,-260,318>, a=<-6,21,-22>
p=<3244,-172,701>, v=<465,-24,100>, a=<-30,-2,-8>
p=<-129,-2951,1212>, v=<-14,-425,171>, a=<-5,30,-7>
p=<1884,877,-1533>, v=<274,125,-219>, a=<-19,-12,15>
p=<-1466,-2618,-346>, v=<-211,-382,-49>, a=<13,28,4>
p=<562,963,-2956>, v=<77,139,-425>, a=<-5,-12,31>
p=<-310,-2462,-856>, v=<-43,-354,-122>, a=<4,25,5>
p=<1678,2238,-1419>, v=<236,321,-198>, a=<-17,-21,20>
p=<1859,-1917,1187>, v=<263,-271,167>, a=<-19,21,-14>
p=<2902,-893,-1497>, v=<411,-124,-217>, a=<-28,8,14>
p=<-133,-2626,-864>, v=<-24,-373,-123>, a=<0,32,7>
p=<-1054,2781,-794>, v=<-148,401,-113>, a=<9,-29,4>
p=<526,689,-2372>, v=<73,103,-337>, a=<-9,-5,31>
p=<-1056,-1107,2500>, v=<-148,-158,356>, a=<12,13,-18>
p=<2996,-826,-419>, v=<424,-117,-58>, a=<-29,8,9>
p=<-1771,1907,656>, v=<-252,270,94>, a=<14,-20,0>
p=<2121,2061,-611>, v=<304,290,-79>, a=<-20,-17,8>
p=<-2368,1603,-253>, v=<-339,224,-36>, a=<23,-16,2>
p=<-2218,-2071,244>, v=<-312,-296,27>, a=<18,19,0>
p=<-1023,-64,-2588>, v=<-147,-6,-366>, a=<10,-6,22>
p=<1831,748,1395>, v=<261,112,196>, a=<-17,-3,-12>
p=<2877,-1441,747>, v=<411,-207,102>, a=<-23,13,-6>
p=<850,1692,1823>, v=<122,241,266>, a=<-11,-16,-20>
p=<2912,-356,-1452>, v=<416,-51,-204>, a=<-25,3,19>
p=<2441,1090,-441>, v=<349,155,-60>, a=<-25,-12,4>
p=<-2420,2114,682>, v=<-341,305,100>, a=<22,-19,-3>
p=<-174,-1003,2392>, v=<-21,-146,342>, a=<2,10,-23>
p=<751,-2676,-811>, v=<105,-380,-113>, a=<-1,26,11>
p=<-2436,2515,-340>, v=<-346,359,-46>, a=<20,-23,5>
p=<-2119,-1482,1270>, v=<-299,-208,186>, a=<28,14,-15>
p=<-1440,605,1931>, v=<-205,86,274>, a=<18,-5,-22>
p=<-824,2827,1983>, v=<-122,400,284>, a=<10,-30,-19>
p=<2686,-1319,979>, v=<383,-185,143>, a=<-25,11,-10>
p=<-437,-3237,-1121>, v=<-62,-463,-160>, a=<3,32,10>
p=<-1379,2833,733>, v=<-198,404,104>, a=<7,-30,-7>
p=<-2851,-268,-153>, v=<-402,-38,-17>, a=<30,1,2>
p=<-1730,1393,-1593>, v=<-248,198,-227>, a=<17,-14,20>
p=<-441,2382,721>, v=<-63,338,103>, a=<-2,-23,-4>
p=<2758,-338,124>, v=<394,-43,24>, a=<-25,3,-4>
p=<1371,2018,-1514>, v=<194,287,-218>, a=<-13,-21,11>
p=<510,-2755,-886>, v=<71,-395,-131>, a=<-7,23,7>
p=<272,629,2616>, v=<39,92,371>, a=<2,-4,-27>
p=<546,2123,1770>, v=<78,312,257>, a=<-1,-19,-17>
p=<2648,127,-1710>, v=<378,18,-244>, a=<-26,2,16>
p=<-309,1136,2477>, v=<-39,160,352>, a=<1,-13,-27>
p=<-260,-3290,-1174>, v=<-34,-469,-168>, a=<2,34,11>
p=<2244,661,-2524>, v=<323,97,-364>, a=<-28,-6,21>
p=<-2431,112,1253>, v=<-347,16,181>, a=<23,-1,-12>
p=<-2815,497,-1110>, v=<-404,71,-161>, a=<28,-7,9>
p=<-56,1941,-3189>, v=<-9,275,-454>, a=<2,-21,30>
p=<-2056,1594,-1735>, v=<-293,228,-247>, a=<22,-20,12>
p=<2014,-2106,-544>, v=<286,-298,-77>, a=<-20,21,9>
p=<-2708,-281,278>, v=<-389,-43,33>, a=<29,2,-1>
p=<1078,2027,-2683>, v=<156,287,-384>, a=<-12,-20,22>
p=<-1261,-2081,-1577>, v=<-179,-294,-220>, a=<12,23,11>
p=<-2183,-474,-2274>, v=<-311,-69,-329>, a=<21,4,22>
p=<-1821,-2105,1524>, v=<-260,-301,219>, a=<17,21,-10>
p=<-2381,1310,-1381>, v=<-341,188,-196>, a=<25,-14,17>
p=<-155,-2635,-32>, v=<-26,-371,-4>, a=<2,25,-7>
p=<-2869,-1101,1206>, v=<-406,-158,172>, a=<32,8,-12>
p=<-421,-18,-3512>, v=<-60,2,-497>, a=<5,0,35>
p=<-1725,-1455,988>, v=<-245,-207,144>, a=<13,12,-6>
p=<-2072,1335,-1575>, v=<-292,191,-229>, a=<21,-17,17>
p=<-3118,-340,-600>, v=<-444,-52,-85>, a=<31,2,3>
p=<-408,1362,2709>, v=<-60,193,387>, a=<5,-11,-31>
p=<-803,-3302,162>, v=<-112,-473,25>, a=<8,33,-5>
p=<-1913,-2082,-1050>, v=<-273,-295,-150>, a=<20,20,13>
p=<-35,1990,3010>, v=<-3,288,429>, a=<-2,-23,-33>
p=<-2235,1599,350>, v=<-319,228,49>, a=<22,-12,-4>
p=<-2875,982,1077>, v=<-407,138,153>, a=<30,-11,-10>
p=<-1099,2301,1861>, v=<-159,326,263>, a=<10,-21,-18>
p=<2751,807,-1186>, v=<396,115,-167>, a=<-27,-11,11>
p=<789,-822,2735>, v=<112,-117,390>, a=<-7,7,-30>
p=<714,-2468,-633>, v=<99,-351,-90>, a=<-8,23,6>
p=<1160,92,2472>, v=<161,10,354>, a=<-11,-2,-25>
p=<-806,3039,851>, v=<-117,434,124>, a=<10,-30,-8>
p=<-1909,-1290,-1662>, v=<-272,-182,-240>, a=<21,8,17>
p=<-2029,1009,-1406>, v=<-286,144,-202>, a=<19,-9,9>
p=<-2633,773,-1212>, v=<-371,110,-171>, a=<28,-9,13>
p=<-2428,848,-649>, v=<-345,115,-90>, a=<22,-11,3>
p=<-1943,-1284,1950>, v=<-276,-183,277>, a=<16,16,-18>
p=<2135,-4,1969>, v=<308,-2,278>, a=<-23,1,-20>
p=<-2252,1999,-809>, v=<-321,281,-115>, a=<26,-20,8>
p=<-2200,-1994,1268>, v=<-314,-283,183>, a=<19,18,-12>
p=<-573,1089,-2660>, v=<-80,150,-383>, a=<2,-5,30>
p=<-634,-858,-2314>, v=<-90,-126,-325>, a=<4,7,21>
p=<602,-2854,-355>, v=<89,-401,-47>, a=<-3,30,4>
p=<208,-3102,-114>, v=<32,-445,-15>, a=<-2,30,1>
p=<-1962,-1576,1725>, v=<-287,-225,248>, a=<22,16,-17>
p=<2093,-78,-2123>, v=<297,-10,-300>, a=<-20,-1,21>
p=<-1858,-1403,2246>, v=<-264,-200,315>, a=<18,10,-20>
p=<3140,363,636>, v=<443,50,90>, a=<-31,-3,-7>
p=<-970,-2562,160>, v=<-140,-364,22>, a=<11,27,-4>
p=<-1838,1530,-2171>, v=<-260,220,-310>, a=<13,-13,21>
p=<-1531,917,-2288>, v=<-222,129,-326>, a=<18,-9,20>
p=<311,2074,-2252>, v=<44,296,-316>, a=<-3,-14,17>
p=<-362,974,-2529>, v=<-44,142,-361>, a=<3,-9,25>
p=<2303,269,-756>, v=<329,41,-108>, a=<-21,-5,7>
p=<-2647,-1151,2>, v=<-384,-164,0>, a=<34,11,2>
p=<1445,1783,1976>, v=<207,258,282>, a=<-10,-25,-15>
p=<-530,-3161,358>, v=<-79,-448,45>, a=<3,29,-4>
p=<778,-2487,1111>, v=<111,-352,156>, a=<-4,27,-16>
p=<-731,1278,2348>, v=<-106,182,334>, a=<7,-9,-26>
p=<-2074,1825,1081>, v=<-297,263,160>, a=<19,-17,-12>
p=<-1704,-2190,404>, v=<-244,-317,55>, a=<14,20,-2>
p=<2216,-2208,727>, v=<319,-312,107>, a=<-24,22,-6>
p=<332,341,2589>, v=<50,52,371>, a=<1,-6,-24>
p=<-2770,-562,-1888>, v=<-395,-80,-269>, a=<29,8,23>
p=<-2106,576,2047>, v=<-295,83,293>, a=<15,-11,-17>
p=<611,-2791,761>, v=<87,-398,106>, a=<-7,26,-5>
p=<1504,1800,-2072>, v=<215,256,-294>, a=<-15,-21,22>
p=<875,1832,1854>, v=<124,266,261>, a=<-9,-19,-17>
p=<-2038,171,-1609>, v=<-293,29,-229>, a=<17,-1,19>
p=<2565,1896,527>, v=<367,270,73>, a=<-22,-15,-9>
p=<1369,-2192,691>, v=<196,-307,100>, a=<-14,17,-8>
p=<965,2492,-734>, v=<134,357,-106>, a=<-7,-22,7>
p=<1574,1686,-2192>, v=<227,241,-314>, a=<-14,-13,19>
p=<-1522,-2068,1835>, v=<-220,-296,260>, a=<11,16,-12>
p=<-1257,50,2566>, v=<-183,7,364>, a=<11,3,-26>
p=<-1152,-1761,-1271>, v=<-164,-245,-185>, a=<9,16,14>
p=<-28,1789,2823>, v=<-11,249,403>, a=<-1,-17,-28>
p=<2415,164,-1672>, v=<350,23,-237>, a=<-24,4,10>
p=<-1564,2450,-465>, v=<-223,349,-63>, a=<16,-24,1>
p=<-2364,1632,-1100>, v=<-335,231,-157>, a=<27,-17,14>
p=<2545,-1701,-1620>, v=<363,-242,-227>, a=<-23,17,18>
p=<-274,2024,-3258>, v=<-37,291,-465>, a=<2,-23,33>
p=<234,2394,2051>, v=<29,342,294>, a=<-6,-23,-20>
p=<375,687,-2380>, v=<53,98,-338>, a=<1,-1,20>
p=<-2444,1961,-1416>, v=<-351,277,-199>, a=<23,-17,14>
p=<-904,-230,3463>, v=<-124,-31,494>, a=<6,6,-38>
p=<-1823,-74,2035>, v=<-257,-13,287>, a=<18,-1,-23>
p=<1199,-2404,-1239>, v=<176,-348,-179>, a=<-13,27,16>
p=<658,-2538,1304>, v=<91,-364,187>, a=<-8,25,-10>
p=<2516,-1649,-1225>, v=<360,-237,-175>, a=<-23,16,13>
p=<-1818,1623,-1110>, v=<-264,231,-158>, a=<18,-21,6>
p=<1775,2837,317>, v=<250,409,48>, a=<-15,-28,-4>
p=<-2263,496,-1728>, v=<-323,73,-246>, a=<25,-1,20>
p=<2316,1197,-978>, v=<331,171,-141>, a=<-25,-9,12>
p=<-1391,-2923,457>, v=<-195,-413,68>, a=<12,25,-2>
p=<1334,629,-2793>, v=<192,85,-407>, a=<-13,-6,27>
p=<-1362,-1499,1617>, v=<-190,-212,228>, a=<13,16,-16>
p=<2597,-1634,-622>, v=<374,-236,-90>, a=<-29,9,9>
p=<-2576,-114,1901>, v=<-370,-16,275>, a=<20,3,-18>
p=<2411,-993,1717>, v=<345,-138,242>, a=<-25,11,-17>
p=<1860,-2435,-943>, v=<257,-346,-138>, a=<-18,26,4>
p=<-734,-2821,1280>, v=<-108,-400,187>, a=<6,23,-8>
p=<-2222,-1244,2441>, v=<-314,-178,352>, a=<22,12,-23>
p=<-1371,2548,-1801>, v=<-195,366,-252>, a=<16,-25,16>
p=<-2007,2173,-1284>, v=<-292,312,-183>, a=<20,-23,12>
p=<2523,-1170,840>, v=<358,-166,120>, a=<-22,8,-2>
p=<1600,1855,-2041>, v=<229,265,-291>, a=<-16,-17,21>
p=<312,82,2996>, v=<45,7,433>, a=<-5,2,-29>
p=<-2102,1894,159>, v=<-296,266,20>, a=<23,-18,-3>
p=<-2480,-1473,1376>, v=<-355,-205,196>, a=<28,13,-11>
p=<-37,-1315,-2317>, v=<-4,-190,-332>, a=<0,14,21>
p=<-871,-2721,1074>, v=<-122,-388,152>, a=<6,28,-11>
p=<2068,-1389,2102>, v=<293,-198,298>, a=<-19,16,-26>
p=<-2252,1520,-787>, v=<-321,212,-113>, a=<20,-16,7>
p=<243,2207,1305>, v=<34,316,181>, a=<-5,-23,-6>
p=<1936,1013,1838>, v=<281,144,261>, a=<-18,-9,-19>
p=<-1485,1301,-2362>, v=<-210,188,-343>, a=<14,-17,24>
p=<-455,1640,-2702>, v=<-65,236,-391>, a=<5,-17,27>
p=<-2578,-931,-1005>, v=<-366,-133,-147>, a=<25,4,9>
p=<-865,2537,585>, v=<-118,362,83>, a=<13,-25,-2>
p=<-159,462,-2925>, v=<-21,65,-417>, a=<5,-4,30>
p=<-1832,1434,-1780>, v=<-261,205,-249>, a=<16,-14,20>
p=<2284,-1994,-649>, v=<328,-289,-92>, a=<-22,22,10>
p=<1865,2211,972>, v=<263,310,138>, a=<-19,-19,-10>
p=<2750,-481,1067>, v=<394,-66,153>, a=<-22,10,-13>
p=<-3006,437,-473>, v=<-427,68,-67>, a=<30,-4,5>
p=<325,2718,741>, v=<44,383,100>, a=<-3,-29,-10>
p=<-1684,2213,-1061>, v=<-240,317,-150>, a=<19,-25,11>
p=<1994,2624,1581>, v=<286,372,225>, a=<-20,-26,-20>
p=<2139,1038,1518>, v=<305,147,218>, a=<-17,-6,-10>
p=<-207,-2511,-807>, v=<-24,-353,-119>, a=<7,29,6>
p=<657,1665,-1908>, v=<93,236,-270>, a=<-11,-10,18>
p=<-2525,-892,33>, v=<-360,-129,4>, a=<19,3,2>
p=<2205,1598,-1551>, v=<314,233,-218>, a=<-22,-15,12>
p=<-1368,1714,1493>, v=<-195,244,205>, a=<13,-17,-14>
p=<157,-3247,-30>, v=<25,-463,-3>, a=<0,31,-4>
p=<-137,709,3045>, v=<-20,97,435>, a=<1,-9,-31>
p=<-2835,1244,157>, v=<-408,177,25>, a=<29,-7,-5>
p=<1118,-2403,723>, v=<158,-338,106>, a=<-10,21,-11>
p=<1905,340,-2016>, v=<274,47,-288>, a=<-21,0,20>
p=<2145,-2133,-551>, v=<305,-305,-78>, a=<-22,21,6>
p=<3017,855,-70>, v=<429,124,-14>, a=<-22,-8,-3>
p=<676,-3059,675>, v=<96,-435,94>, a=<1,24,-8>
p=<2707,-1594,-327>, v=<385,-227,-40>, a=<-21,20,4>
p=<-614,3013,200>, v=<-86,434,28>, a=<5,-30,-2>
p=<1081,191,2191>, v=<157,27,313>, a=<-14,2,-24>
p=<699,-2381,-1446>, v=<98,-340,-203>, a=<-9,24,7>
p=<-1101,-3103,-317>, v=<-158,-442,-50>, a=<9,25,-1>
p=<1700,1246,-1427>, v=<246,176,-202>, a=<-14,-9,8>
p=<2963,-300,-418>, v=<418,-40,-59>, a=<-28,7,4>
p=<2751,50,-1648>, v=<393,10,-234>, a=<-31,-2,16>
p=<153,-1278,2341>, v=<21,-184,334>, a=<2,15,-22>
p=<-985,1406,2708>, v=<-142,200,383>, a=<10,-19,-26>
p=<227,-3147,-6>, v=<31,-449,2>, a=<-4,31,1>
p=<1057,-3331,559>, v=<151,-479,80>, a=<-6,33,-4>
p=<-1968,371,-1914>, v=<-285,54,-273>, a=<26,-6,14>
p=<-471,-2576,1278>, v=<-70,-369,176>, a=<2,25,-12>
p=<-496,-2119,-2830>, v=<-70,-299,-404>, a=<3,21,29>
p=<-1363,2930,492>, v=<-195,417,70>, a=<15,-28,-1>
p=<-1235,2391,-1179>, v=<-176,342,-168>, a=<15,-25,9>
p=<-2674,335,1779>, v=<-386,50,252>, a=<30,-5,-13>
p=<891,708,2397>, v=<123,103,349>, a=<-11,-5,-22>
p=<-1598,2259,942>, v=<-228,322,132>, a=<19,-17,-3>
p=<803,-2810,-1540>, v=<119,-404,-220>, a=<-8,25,14>
p=<-224,510,-2749>, v=<-29,67,-390>, a=<-2,-7,32>
p=<-1835,2215,-1440>, v=<-266,320,-203>, a=<17,-21,16>
p=<-1184,507,-2096>, v=<-168,72,-293>, a=<13,-5,19>
p=<288,409,-3326>, v=<36,53,-474>, a=<2,-2,36>
p=<1894,2356,559>, v=<269,340,75>, a=<-21,-24,-4>
p=<7,1036,2617>, v=<2,148,375>, a=<0,-8,-26>
p=<2491,732,-1505>, v=<353,103,-213>, a=<-22,-7,17>
p=<361,-2673,-1070>, v=<54,-379,-151>, a=<3,30,11>
p=<-2627,1037,105>, v=<-375,151,15>, a=<26,-12,1>
p=<1308,2510,864>, v=<188,362,123>, a=<-13,-25,-8>
p=<-277,3713,910>, v=<-39,530,131>, a=<2,-38,-8>
p=<-669,-418,2646>, v=<-95,-60,381>, a=<9,1,-23>
p=<91,-1150,-2124>, v=<13,-164,-306>, a=<-3,14,19>
p=<1340,-56,-2233>, v=<191,-6,-318>, a=<-11,3,19>
p=<2468,467,2268>, v=<353,67,324>, a=<-26,-6,-27>
p=<2076,1476,1721>, v=<299,210,247>, a=<-19,-18,-21>
p=<1017,1860,-2186>, v=<145,265,-311>, a=<-10,-18,20>
p=<479,-1075,3025>, v=<75,-158,430>, a=<-5,10,-30>
p=<1312,504,-2305>, v=<187,76,-333>, a=<-17,1,26>
p=<-1016,-2173,-1594>, v=<-145,-315,-225>, a=<11,22,16>
p=<88,-1087,3153>, v=<12,-157,451>, a=<-2,10,-34>
p=<-2775,172,-308>, v=<-398,24,-42>, a=<28,-5,2>
p=<-1050,854,-3117>, v=<-149,128,-442>, a=<14,-12,30>
p=<-2588,-928,648>, v=<-370,-127,95>, a=<25,13,-6>
p=<2788,1614,-1908>, v=<398,231,-274>, a=<-28,-18,19>
p=<-915,1287,-1911>, v=<-129,181,-272>, a=<9,-12,18>
p=<118,2882,1001>, v=<16,414,143>, a=<-5,-28,-14>
p=<2751,1232,612>, v=<393,180,86>, a=<-29,-7,-6>
p=<1575,-30,-2882>, v=<223,-9,-418>, a=<-7,4,30>
p=<1451,813,-2363>, v=<204,116,-332>, a=<-11,-7,20>
p=<1189,149,-2249>, v=<169,21,-318>, a=<-11,-4,23>
p=<-2388,1306,-1182>, v=<-340,186,-168>, a=<24,-7,12>
p=<-955,-2759,111>, v=<-136,-390,21>, a=<9,27,-1>
p=<-1408,2687,-760>, v=<-197,383,-108>, a=<18,-22,10>
p=<-2379,629,-222>, v=<-340,89,-34>, a=<26,-9,2>
p=<-1312,2261,2231>, v=<-193,324,324>, a=<13,-21,-26>
p=<184,-3068,-566>, v=<28,-440,-83>, a=<1,37,5>
p=<1603,-2812,-1038>, v=<230,-404,-146>, a=<-20,28,16>
p=<-980,-697,-2686>, v=<-139,-92,-383>, a=<4,6,21>
p=<-1750,667,-2178>, v=<-254,95,-313>, a=<25,-11,18>
p=<-1149,-1507,2370>, v=<-167,-220,338>, a=<11,14,-27>
p=<-441,-2319,-218>, v=<-71,-329,-34>, a=<0,21,-3>
p=<-267,-2311,-182>, v=<-38,-333,-26>, a=<2,23,0>
p=<-546,-226,-2561>, v=<-78,-33,-364>, a=<7,1,29>
p=<267,-2557,-1438>, v=<33,-368,-208>, a=<0,24,17>
p=<-2277,-824,2094>, v=<-322,-117,297>, a=<24,10,-19>
p=<-741,-2572,807>, v=<-99,-368,117>, a=<7,21,-3>
p=<542,3001,690>, v=<75,426,100>, a=<-5,-28,-1>
p=<57,60,2942>, v=<6,8,420>, a=<0,-2,-28>
p=<-1498,-556,2735>, v=<-210,-79,390>, a=<17,5,-32>
p=<1137,-2293,-2016>, v=<167,-325,-292>, a=<-11,22,20>
p=<2255,1342,-912>, v=<323,190,-132>, a=<-24,-18,13>
p=<120,-2668,-1049>, v=<21,-385,-149>, a=<-1,30,7>
p=<-1797,1658,-1847>, v=<-259,234,-263>, a=<17,-22,19>
p=<60,1626,-2635>, v=<9,232,-377>, a=<-6,-18,31>
p=<1915,2444,-748>, v=<271,349,-106>, a=<-19,-28,8>
p=<-794,625,2323>, v=<-112,96,328>, a=<9,-5,-25>
p=<-2847,30,-1420>, v=<-409,4,-199>, a=<28,-2,19>
p=<2278,1741,1013>, v=<327,252,139>, a=<-20,-17,-6>
p=<-1252,-2783,790>, v=<-182,-396,110>, a=<10,26,-10>
p=<-683,-656,2967>, v=<-93,-92,424>, a=<10,8,-31>
p=<1045,2844,-423>, v=<148,408,-63>, a=<-14,-36,1>
p=<-1583,-2548,-609>, v=<-227,-364,-84>, a=<10,27,2>
p=<464,2509,1714>, v=<63,358,248>, a=<-2,-27,-17>
p=<-781,2794,-778>, v=<-107,400,-106>, a=<9,-27,7>
p=<464,-3398,439>, v=<63,-486,65>, a=<-2,34,-2>
p=<-2356,-669,-1735>, v=<-333,-97,-242>, a=<23,10,17>
p=<-94,-547,3403>, v=<-10,-79,487>, a=<-3,5,-35>
p=<356,1321,2678>, v=<50,189,382>, a=<-5,-14,-22>
p=<-2901,402,-624>, v=<-412,57,-83>, a=<24,-4,4>
p=<-533,-996,2729>, v=<-78,-139,391>, a=<1,8,-26>
p=<-1126,265,-2804>, v=<-157,38,-405>, a=<10,-2,27>
p=<821,2209,2295>, v=<117,314,321>, a=<-8,-22,-22>
p=<1797,2125,-114>, v=<256,304,-19>, a=<-13,-17,-4>
p=<-1603,-2603,258>, v=<-229,-372,36>, a=<17,26,-2>
p=<2400,-131,1736>, v=<338,-17,248>, a=<-21,0,-17>
p=<738,2677,-1548>, v=<103,381,-223>, a=<-7,-26,17>
p=<-761,581,2364>, v=<-114,88,336>, a=<8,-5,-23>
p=<-1590,519,-2348>, v=<-222,73,-333>, a=<21,-4,20>
p=<-708,-1178,2583>, v=<-103,-167,366>, a=<6,13,-30>
p=<14,-2595,45>, v=<2,-364,6>, a=<2,20,-3>
p=<1631,-2540,-896>, v=<233,-357,-133>, a=<-17,25,8>
p=<-921,-101,2800>, v=<-125,-20,396>, a=<4,-1,-28>
p=<1010,3304,-47>, v=<144,469,-10>, a=<-6,-33,-3>
p=<402,-2919,1203>, v=<60,-417,175>, a=<-5,25,-17>
p=<498,683,2643>, v=<72,103,380>, a=<-4,-10,-25>
p=<-3169,-182,387>, v=<-455,-26,55>, a=<31,2,-7>
p=<-513,-1694,-1964>, v=<-73,-244,-276>, a=<8,20,17>
p=<-1289,1837,-2023>, v=<-182,265,-293>, a=<11,-16,21>
p=<-637,-2233,-1326>, v=<-93,-319,-189>, a=<6,23,13>
p=<1965,1240,1453>, v=<279,178,206>, a=<-22,-12,-16>
p=<-2103,773,-994>, v=<-302,112,-140>, a=<25,-6,9>
p=<88,-702,2651>, v=<13,-100,377>, a=<0,11,-26>
p=<2869,-1326,1716>, v=<409,-192,247>, a=<-31,14,-21>
p=<-425,-3427,-757>, v=<-60,-488,-107>, a=<4,35,7>
p=<34,-2755,170>, v=<4,-396,24>, a=<0,25,0>
p=<821,2555,-1836>, v=<119,366,-262>, a=<-3,-26,18>
p=<1466,-2376,-1120>, v=<216,-344,-157>, a=<-16,27,10>
p=<-1356,-1502,2665>, v=<-192,-209,379>, a=<4,15,-22>
p=<3183,876,470>, v=<455,129,61>, a=<-28,-4,-8>
p=<1076,-2112,-227>, v=<152,-301,-31>, a=<-8,21,2>
p=<1703,346,2486>, v=<246,50,354>, a=<-13,3,-23>
p=<-7,550,-3126>, v=<0,78,-452>, a=<4,-10,31>
p=<3247,-142,853>, v=<466,-17,121>, a=<-26,1,-8>
p=<-3445,1526,-371>, v=<-494,212,-59>, a=<35,-14,7>
p=<-643,-408,2923>, v=<-86,-58,419>, a=<7,2,-35>
p=<1032,-1460,1789>, v=<147,-206,256>, a=<-6,13,-11>
p=<-2245,-1848,-542>, v=<-323,-267,-74>, a=<22,22,6>
p=<-2170,-645,2153>, v=<-310,-93,308>, a=<20,8,-14>
p=<1127,-735,2393>, v=<161,-112,338>, a=<-14,7,-28>
p=<887,2364,2059>, v=<128,334,293>, a=<-8,-27,-22>
p=<-359,-3118,-208>, v=<-46,-443,-30>, a=<1,32,1>
p=<-1856,-1969,-1694>, v=<-264,-283,-242>, a=<20,19,16>
p=<-162,-2764,1700>, v=<-30,-392,243>, a=<2,31,-15>
p=<2374,-690,-2425>, v=<342,-102,-346>, a=<-31,14,23>
p=<26,1729,2582>, v=<4,249,367>, a=<6,-13,-25>
p=<-2448,-1767,369>, v=<-348,-252,52>, a=<22,17,-1>
p=<-336,3532,-666>, v=<-49,502,-92>, a=<4,-35,0>
p=<-1957,1148,1090>, v=<-279,166,158>, a=<19,-11,-8>
p=<3117,338,1088>, v=<445,47,159>, a=<-31,-4,-11>
p=<-1236,-1629,1989>, v=<-177,-229,284>, a=<10,15,-18>
p=<2754,1178,374>, v=<393,168,50>, a=<-32,-11,-6>
p=<2394,252,1078>, v=<338,38,154>, a=<-26,-5,-7>
p=<344,694,-2455>, v=<52,103,-356>, a=<-3,-10,17>
p=<-3232,-521,557>, v=<-461,-72,72>, a=<33,4,-2>
p=<-770,135,2872>, v=<-107,20,409>, a=<7,-2,-28>
p=<695,-2050,-2164>, v=<99,-288,-312>, a=<-11,20,21>
p=<1617,2067,2001>, v=<227,293,289>, a=<-16,-22,-15>
p=<-302,-1717,2660>, v=<-41,-243,380>, a=<1,18,-27>
p=<-236,-1665,2628>, v=<-31,-236,374>, a=<6,16,-24>
p=<1884,1254,-949>, v=<269,179,-137>, a=<-15,-7,9>
p=<-256,2011,3034>, v=<-37,286,433>, a=<2,-16,-27>
p=<-2646,860,1413>, v=<-378,127,200>, a=<21,-8,-12>
p=<1812,-2148,1649>, v=<258,-309,237>, a=<-15,27,-17>
p=<5,-2811,634>, v=<3,-403,84>, a=<0,23,-1>
p=<-637,-986,3106>, v=<-89,-136,446>, a=<9,5,-31>
p=<1096,1410,-1436>, v=<157,201,-205>, a=<-6,-11,14>
p=<1024,2785,394>, v=<146,396,56>, a=<-17,-29,-5>
p=<2650,1322,1655>, v=<371,188,233>, a=<-27,-13,-17>
p=<68,2262,-502>, v=<8,322,-70>, a=<-4,-22,7>
p=<1045,727,-2635>, v=<143,105,-376>, a=<-13,-3,33>
p=<-436,-2423,-1791>, v=<-60,-347,-256>, a=<7,25,18>
p=<1423,-1701,2193>, v=<205,-241,313>, a=<-20,15,-21>
p=<-297,-3193,-1159>, v=<-46,-456,-168>, a=<0,31,9>
p=<1915,226,-2420>, v=<273,31,-350>, a=<-18,-4,24>
p=<-1813,-887,-2599>, v=<-259,-127,-374>, a=<18,9,29>
p=<-300,2457,-639>, v=<-38,350,-90>, a=<-3,-25,9>
p=<-2591,-143,1386>, v=<-370,-20,199>, a=<25,-4,-13>
p=<-2,-3096,389>, v=<3,-441,53>, a=<4,27,-3>
p=<1960,592,-2014>, v=<280,88,-287>, a=<-17,-2,19>
p=<1551,260,-2258>, v=<219,41,-326>, a=<-15,-2,25>
p=<399,132,-2311>, v=<53,22,-330>, a=<2,-3,24>
p=<477,-346,3227>, v=<68,-53,459>, a=<-1,3,-32>
p=<-1639,-1071,1985>, v=<-238,-151,280>, a=<17,11,-19>
p=<1759,1580,-1837>, v=<249,222,-262>, a=<-22,-15,15>
p=<1198,-847,2295>, v=<171,-123,329>, a=<-13,2,-26>
p=<2719,1279,303>, v=<383,182,40>, a=<-30,-10,0>
p=<-1399,2041,-1393>, v=<-195,295,-199>, a=<13,-24,14>
p=<-536,446,2660>, v=<-75,58,381>, a=<5,-9,-26>
p=<-2469,-372,706>, v=<-356,-53,105>, a=<24,9,-4>
p=<-1248,2222,907>, v=<-177,318,130>, a=<7,-22,-10>
p=<-984,-1142,-2583>, v=<-140,-163,-369>, a=<9,15,22>
p=<-2655,-1223,1083>, v=<-379,-168,153>, a=<23,12,-11>
p=<1201,-1941,-1509>, v=<168,-284,-214>, a=<-15,19,7>
p=<1897,-1095,-2167>, v=<271,-158,-304>, a=<-14,13,24>
p=<1401,690,-2236>, v=<197,101,-317>, a=<-9,-11,21>
p=<2140,-1925,-1702>, v=<307,-273,-243>, a=<-21,21,18>
p=<-2527,-640,-830>, v=<-354,-89,-117>, a=<21,7,3>
p=<-1535,-525,2648>, v=<-219,-75,379>, a=<17,5,-30>
p=<-1325,-199,-2594>, v=<-192,-22,-367>, a=<17,1,26>
p=<1382,232,2746>, v=<196,36,393>, a=<-14,-3,-27>
p=<-1985,-1158,300>, v=<-284,-164,41>, a=<23,7,-4>
p=<-380,-205,-2983>, v=<-56,-27,-427>, a=<2,1,31>
p=<-2245,165,1606>, v=<-318,24,232>, a=<22,-2,-11>
p=<-660,1383,-2562>, v=<-93,197,-370>, a=<7,-13,28>
p=<-1953,-421,-2259>, v=<-275,-63,-319>, a=<21,4,22>
p=<2118,-1286,-1974>, v=<302,-182,-282>, a=<-21,14,23>
p=<138,-36,2926>, v=<16,-7,422>, a=<-2,4,-29>
p=<1464,-1220,-2905>, v=<209,-169,-409>, a=<-14,12,28>
p=<-1005,-2026,-2125>, v=<-143,-285,-301>, a=<11,26,15>
p=<1970,863,-2135>, v=<280,121,-300>, a=<-16,-8,22>
p=<2395,72,1354>, v=<339,12,195>, a=<-22,6,-16>
p=<52,2063,1568>, v=<9,295,225>, a=<-5,-20,-19>
p=<2967,1093,1408>, v=<424,155,203>, a=<-29,-7,-11>
p=<197,-1704,-1665>, v=<27,-245,-243>, a=<1,16,15>
p=<1845,-2345,-419>, v=<264,-335,-60>, a=<-17,24,6>
p=<2368,1170,299>, v=<335,167,40>, a=<-28,-13,-2>
p=<-433,-2693,-1255>, v=<-64,-392,-181>, a=<3,26,10>
p=<-1864,2213,-577>, v=<-264,319,-82>, a=<13,-22,10>
p=<-698,1219,2813>, v=<-98,178,401>, a=<7,-12,-25>
p=<3207,253,-25>, v=<459,36,-2>, a=<-37,-1,-4>
p=<-1494,-3321,-55>, v=<-207,-471,-7>, a=<11,32,1>
p=<2641,-2494,-842>, v=<381,-356,-120>, a=<-26,23,7>
p=<2218,-821,794>, v=<312,-113,114>, a=<-23,9,-7>");
            #endregion
            #region 21
            Inputs.Add(21, @"../.. => ###/#../.#.
#./.. => ##./.#./...
##/.. => ..#/.#./#.#
.#/#. => ..#/.#./..#
##/#. => .../.##/##.
##/## => ###/#../#..
.../.../... => .#../.#../#..#/##..
#../.../... => ####/####/.###/####
.#./.../... => ####/..../#.#./.#.#
##./.../... => ..##/###./...#/##.#
#.#/.../... => .#../#..#/.#../#.#.
###/.../... => #.##/..##/##.#/..##
.#./#../... => .##./#..#/..../....
##./#../... => ##../.#../...#/####
..#/#../... => ##../###./...#/.#.#
#.#/#../... => ####/#.../..../##..
.##/#../... => #..#/..##/#..#/....
###/#../... => #.##/####/..#./#.#.
.../.#./... => #.##/.#.#/#.../...#
#../.#./... => .###/##.#/..../###.
.#./.#./... => ..#./.#../..../##..
##./.#./... => ##../...#/..../....
#.#/.#./... => ####/.#../..#./.###
###/.#./... => ..#./.###/##../.##.
.#./##./... => ###./#.#./.###/.##.
##./##./... => ...#/.#../.#../####
..#/##./... => ..#./#.../##../###.
#.#/##./... => #.../..../.#.#/.###
.##/##./... => #.#./.#../####/.###
###/##./... => .#.#/#.#./##../#...
.../#.#/... => #.##/##.#/..../#.#.
#../#.#/... => ##../#.##/###./###.
.#./#.#/... => ##../.#../#.##/###.
##./#.#/... => ##../##../..#./..#.
#.#/#.#/... => #.../.##./.###/###.
###/#.#/... => ##.#/##../.##./#...
.../###/... => ...#/####/..../#..#
#../###/... => ##.#/##.#/.##./#.#.
.#./###/... => .#../#.../.#.#/##.#
##./###/... => ##.#/#.#./#.../.#..
#.#/###/... => ..../#.../####/.#..
###/###/... => .#../#..#/.#../.#..
..#/.../#.. => .#.#/#.../..##/...#
#.#/.../#.. => ####/####/###./...#
.##/.../#.. => ####/.###/##.#/##..
###/.../#.. => ..##/..../...#/#.#.
.##/#../#.. => ###./..#./##.#/##.#
###/#../#.. => ##.#/...#/.##./.###
..#/.#./#.. => #.#./#.#./...#/#.#.
#.#/.#./#.. => ###./.#.#/#.#./.#..
.##/.#./#.. => #.#./.##./.###/#.#.
###/.#./#.. => #.../#.../#.#./.###
.##/##./#.. => .#.#/.##./..#./##..
###/##./#.. => .###/.##./#.##/..##
#../..#/#.. => #.#./#..#/###./.##.
.#./..#/#.. => ###./.###/...#/..##
##./..#/#.. => ###./##../####/.#.#
#.#/..#/#.. => ..#./.#../.##./.#..
.##/..#/#.. => ##.#/###./.##./#...
###/..#/#.. => ...#/..##/##.#/##.#
#../#.#/#.. => #.../.##./.#.#/.###
.#./#.#/#.. => #.##/...#/####/###.
##./#.#/#.. => .#../#.../.###/....
..#/#.#/#.. => ####/###./.#.#/#...
#.#/#.#/#.. => ###./..##/...#/#.##
.##/#.#/#.. => ##.#/..#./..##/.#.#
###/#.#/#.. => #.#./..../##../.###
#../.##/#.. => #..#/###./.#.#/##.#
.#./.##/#.. => #.../.###/.##./.###
##./.##/#.. => .#../###./.#../##.#
#.#/.##/#.. => .#../#.#./.#../#.##
.##/.##/#.. => ##../###./.#.#/.###
###/.##/#.. => ..##/...#/#.../.#..
#../###/#.. => #.##/#..#/####/###.
.#./###/#.. => .###/.#.#/#.#./..#.
##./###/#.. => ####/#.#./..##/#.##
..#/###/#.. => .###/##.#/.##./#.#.
#.#/###/#.. => #.##/###./.###/....
.##/###/#.. => #.##/..../.#../####
###/###/#.. => ##.#/###./.#../...#
.#./#.#/.#. => ..#./##.#/.#../###.
##./#.#/.#. => ..##/###./..#./.#.#
#.#/#.#/.#. => .#../..##/.#.#/.#.#
###/#.#/.#. => ##../#..#/.#../..#.
.#./###/.#. => #.../#..#/.#.#/....
##./###/.#. => ..../..##/..#./####
#.#/###/.#. => ..##/##.#/.###/...#
###/###/.#. => ##.#/#.##/..#./#.#.
#.#/..#/##. => #.../####/#.##/.###
###/..#/##. => ###./...#/.#.#/#..#
.##/#.#/##. => ..../.#.#/##.#/..##
###/#.#/##. => ###./.#../.#.#/###.
#.#/.##/##. => ###./.#../.#../.#.#
###/.##/##. => .##./..../..../#.##
.##/###/##. => ####/##../.###/##.#
###/###/##. => #..#/#.##/#.##/.#..
#.#/.../#.# => ####/#.#./#..#/.##.
###/.../#.# => .#../.#.#/.#../.#.#
###/#../#.# => ..#./..#./.###/#...
#.#/.#./#.# => #.#./..../.##./####
###/.#./#.# => #.../..##/.##./..#.
###/##./#.# => .#.#/##../#.#./..#.
#.#/#.#/#.# => #.##/#.##/#.##/..##
###/#.#/#.# => .###/#.#./.##./..##
#.#/###/#.# => ...#/#.#./..#./#..#
###/###/#.# => #.../#..#/#..#/.##.
###/#.#/### => .#.#/..##/##.#/#...
###/###/### => .###/#.#./#.../#...");
            #endregion
            #region 22
            Inputs.Add(22, @"..##.##.######...#.######
##...#...###....##.#.#.##
###.#.#.#..#.##.####.#.#.
..##.##...#..#.##.....##.
##.##...#.....#.#..#.####
.###...#.........###.####
#..##....###...#######..#
###..#.####.###.#.#......
.#....##..##...###..###.#
###.#..#.##.###.#..###...
####.#..##.#.#.#.#.#...##
##.#####.#......#.#.#.#.#
..##..####...#..#.#.####.
.####.####.####...##.#.##
#####....#...#.####.#..#.
.#..###..........#..#.#..
.#.##.#.#.##.##.#..#.#...
..##...#..#.....##.####..
..#.#...######..##..##.#.
.####.###....##...####.#.
.#####..#####....####.#..
###..#..##.#......##.###.
.########...#.#...###....
...##.#.##.#####.###.####
.....##.#.#....#..#....#.");
            #endregion
            #region 23
            Inputs.Add(23, @"set b 65
set c b
jnz a 2
jnz 1 5
mul b 100
sub b -100000
set c b
sub c -17000
set f 1
set d 2
set e 2
set g d
mul g e
sub g b
jnz g 2
set f 0
sub e -1
set g e
sub g b
jnz g -8
sub d -1
set g d
sub g b
jnz g -13
jnz f 2
sub h -1
set g b
sub g c
jnz g 2
jnz 1 3
sub b -17
jnz 1 -23");
            #endregion
            #region 24
            Inputs.Add(24, @"48/5
25/10
35/49
34/41
35/35
47/35
34/46
47/23
28/8
27/21
40/11
22/50
48/42
38/17
50/33
13/13
22/33
17/29
50/0
20/47
28/0
42/4
46/22
19/35
17/22
33/37
47/7
35/20
8/36
24/34
6/7
7/43
45/37
21/31
37/26
16/5
11/14
7/23
2/23
3/25
20/20
18/20
19/34
25/46
41/24
0/33
3/7
49/38
47/22
44/15
24/21
10/35
6/21
14/50");
            #endregion
            #region 25
            Inputs.Add(25, @"A,0,1,Right,B
A,1,0,Right,C
B,0,0,Left,A
B,1,0,Right,D
C,0,1,Right,D
C,1,1,Right,A
D,0,1,Left,E
D,1,0,Left,D
E,0,1,Right,F
E,1,1,Left,B
F,0,1,Right,A
F,1,1,Right,E");
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
                yield return new TestCaseData("0\t2\t7\t0").Returns(4);
                yield return new TestCaseData(Inputs[6]).Returns(1086);
            }
        }
        public static IEnumerable TcD07P1
        {
            get
            {
                yield return new TestCaseData("").Returns(string.Empty);
                yield return new TestCaseData(@"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)").Returns("tknk");
                yield return new TestCaseData(@"Qpbga (66)
Qxhth (57)
Qebii (61)
Qhavc (66)
Qktlj (57)
Qfwft (72) -> Qktlj, Qcntj, Qxhth
Qqoyq (66)
Qpadx (45) -> Qpbga, Qhavc, Qqoyq
Qtknk (41) -> Qugml, Qpadx, Qfwft
Qjptl (61)
Qugml (60) -> Qgyxo, Qebii, Qjptl
Qgyxo (61)
Qcntj (57)").Returns("Qtknk");
                yield return new TestCaseData(Inputs[7]).Returns("vmpywg");
            }
        }
        public static IEnumerable TcD07P2
        {
            get
            {
                yield return new TestCaseData("").Returns(string.Empty);
                yield return new TestCaseData(@"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)").Returns("60");
                yield return new TestCaseData(Inputs[7]).Returns("1674");
            }
        }
        public static IEnumerable TcD08P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(@"b inc 5 if a > 1
a inc 1 if b < 5
c dec -10 if a >= 1
c inc -20 if c == 10").Returns(1);
                yield return new TestCaseData(Inputs[8]).Returns(5215);
            }
        }
        public static IEnumerable TcD08P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(@"b inc 5 if a > 1
a inc 1 if b < 5
c dec -10 if a >= 1
c inc -20 if c == 10").Returns(10);
                yield return new TestCaseData(Inputs[8]).Returns(6419);
            }
        }
        public static IEnumerable TcD09P1
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData("{}").Returns(1);
                yield return new TestCaseData("{{{}}}").Returns(6);
                yield return new TestCaseData("{{},{}}").Returns(5);
                yield return new TestCaseData("{{{},{},{{}}}}").Returns(16);
                yield return new TestCaseData("{}").Returns(1);
                yield return new TestCaseData("{{},{},{},{}}").Returns(9);
                yield return new TestCaseData("{{}}").Returns(3);
                yield return new TestCaseData("{<a>,<a>,<a>,<a>}").Returns(1);
                yield return new TestCaseData("{{<ab>},{<ab>},{<ab>},{<ab>}}").Returns(9);
                yield return new TestCaseData("{{<<ab>},{<ab>},{<ab>},{<ab>}}").Returns(9);
                yield return new TestCaseData("{{<ab>},{<<ab>},{<<<<ab>},{<<<<<<<<<ab>}}").Returns(9);
                yield return new TestCaseData("{{<!!>},{<!!>},{<!!>},{<!!>}}").Returns(9);
                yield return new TestCaseData("{{<a!>},{<a!>},{<a!>},{<ab>}}").Returns(3);
                yield return new TestCaseData(Inputs[9]).Returns(-1);
            }
        }
        public static IEnumerable TcD09P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData("<>").Returns(0);
                yield return new TestCaseData("<random characters>").Returns(17);
                yield return new TestCaseData("<<<<>").Returns(3);
                yield return new TestCaseData("<{!>}>").Returns(2);
                yield return new TestCaseData("<!!>").Returns(0);
                yield return new TestCaseData("<!!!>>").Returns(0);
                yield return new TestCaseData("<{o\"i!a,<{i<a>").Returns(10);
                yield return new TestCaseData(Inputs[9]).Returns(-1);
            }
        }
        public static IEnumerable TcD10P1
        {
            get
            {
                yield return new TestCaseData("", int.MaxValue).Returns(int.MinValue);
                yield return new TestCaseData("3,4,1,5", 5).Returns(12);
                yield return new TestCaseData(Inputs[10], 256).Returns(-1);
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
                yield return new TestCaseData("ne,ne,ne").Returns(3);
                yield return new TestCaseData("ne,ne,sw,sw").Returns(0);
                yield return new TestCaseData("ne,ne,s,s").Returns(2);
                yield return new TestCaseData("se,sw,se,sw,sw").Returns(3);
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
                yield return new TestCaseData(@"0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5").Returns(6);
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
                yield return new TestCaseData(@"0: 3
1: 2
4: 4
6: 4").Returns(24);
                yield return new TestCaseData(Inputs[13]).Returns(-1);
            }
        }
        public static IEnumerable TcD13P2
        {
            get
            {
                yield return new TestCaseData("").Returns(int.MinValue);
                yield return new TestCaseData(@"0: 3
1: 2
4: 4
6: 4").Returns(10);
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
                yield return new TestCaseData("", 5).Returns(int.MinValue);
                yield return new TestCaseData("", 40000000).Returns(int.MinValue);
                yield return new TestCaseData("65,8921", 5).Returns(1);
                yield return new TestCaseData("65,8921", 40000000).Returns(588);
                yield return new TestCaseData(Inputs[15], 40000000).Returns(-1);
            }
        }
        public static IEnumerable TcD15P2
        {
            get
            {
                yield return new TestCaseData("", 5).Returns(int.MinValue);
                yield return new TestCaseData("", 5000000).Returns(int.MinValue);
                yield return new TestCaseData("65,8921", 1056).Returns(1);
                yield return new TestCaseData("65,8921", 5000000).Returns(309);
                yield return new TestCaseData(Inputs[15], 5000000).Returns(-1);
            }

        }
        public static IEnumerable TcD16P1
        {
            get
            {
                yield return new TestCaseData("s1,x3/4,pe/b", "abcde").Returns("baedc");
                yield return new TestCaseData(Inputs[16], "abcdefghijklmnop").Returns("olgejankfhbmpidc");
            }
        }
        public static IEnumerable TcD16P2
        {
            get
            {
                yield return new TestCaseData("s1,x3/4,pe/b", "abcde", 1).Returns("baedc");
                yield return new TestCaseData("s1,x3/4,pe/b", "abcde", 2).Returns("ceadb");
                //yield return new TestCaseData(Inputs[16], "abcdefghijklmnop", 1000).Returns("");
                yield return new TestCaseData(Inputs[16], "abcdefghijklmnop", 1000000000).Returns("");
            }
        }
        public static IEnumerable TcD17P1
        {
            get
            {
                yield return new TestCaseData(3, 1).Returns(0);
                yield return new TestCaseData(3, 2).Returns(1);
                yield return new TestCaseData(3, 3).Returns(1);
                yield return new TestCaseData(3, 4).Returns(3);
                yield return new TestCaseData(3, 5).Returns(2);
                yield return new TestCaseData(3, 6).Returns(1);
                yield return new TestCaseData(3, 7).Returns(2);
                yield return new TestCaseData(3, 8).Returns(6);
                yield return new TestCaseData(3, 9).Returns(5);
                yield return new TestCaseData(3, 2017).Returns(638);
                yield return new TestCaseData(int.Parse(Inputs[17]), 2017).Returns(996);
            }
        }
        public static IEnumerable TcD17P2
        {
            get
            {
                //yield return new TestCaseData(3, 1).Returns(0);
                yield return new TestCaseData(3, 2).Returns(1);
                yield return new TestCaseData(3, 3).Returns(2);
                yield return new TestCaseData(3, 4).Returns(2);
                yield return new TestCaseData(3, 5).Returns(2);
                yield return new TestCaseData(3, 6).Returns(5);
                yield return new TestCaseData(3, 7).Returns(5);
                yield return new TestCaseData(3, 8).Returns(5);
                yield return new TestCaseData(3, 9).Returns(5);
                //yield return new TestCaseData(3, 2017).Returns(638);
                yield return new TestCaseData(int.Parse(Inputs[17]), 50000000).Returns(-1);
            }
        }
        public static IEnumerable TcD18P1
        {
            get
            {
                yield return new TestCaseData(@"set a 1
add a 2
mul a a
mod a 5
snd a
set a 0
rcv a
jgz a -1
set a 1
jgz a -2").Returns(4);
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
                yield return new TestCaseData(@"     |          
     |  +--+    
     A  |  C    
 F---|----E|--+ 
     |  |  |  D 
     +B-+  +--+").Returns("ABCDEF");
                yield return new TestCaseData(Inputs[19]).Returns("MKXOIHZNBL");
            }
        }
        public static IEnumerable TcD19P2
        {
            get
            {
                yield return new TestCaseData(Inputs[19]).Returns(17872);
            }
        }
        public static IEnumerable TcD20P1
        {
            get
            {
                //yield return new TestCaseData("", 0).Returns(int.MinValue);
                //                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
                //p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 0).Returns(0);
                //                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
                //p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 1).Returns(1);
                //                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
                //p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 2).Returns(1);
                //                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
                //p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 3).Returns(1);
                //                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
                //p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 5).Returns(0);
                //                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
                //p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 10).Returns(0);
//                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
//p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 10000).Returns(0);
//                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
//p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 20).Returns(0);
//                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
//p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 100).Returns(0);
//                yield return new TestCaseData(@"p=<3,0,0>, v=<2,0,0>, a=<-1,0,0>
//p=<4,0,0>, v=<0,0,0>, a=<-2,0,0>", 200).Returns(0);

                yield return new TestCaseData(Inputs[20], 1000).Returns(-1);
//                yield return new TestCaseData(@"p=<1714,-5869,-7053>, v=<-6,174,-30>, a=<-2,-1,11>
//p=<-4119,2852,1022>, v=<11,-114,-28>, a=<5,2,0>
//p=<-4100,-8852,1687>, v=<30,77,13>, a=<4,8,-3>
//p=<-5544,-1176,6418>, v=<146,-86,25>, a=<0,6,-10>", 1000).Returns(-1);
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
                yield return new TestCaseData(@"../.# => ##./#../...
.#./..#/### => #..#/..../..../#..#", 2).Returns(12);
                yield return new TestCaseData(Inputs[21], 5).Returns(139);
                yield return new TestCaseData(Inputs[21], 18).Returns(1857134);
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


                yield return new TestCaseData(@"..#
#..
...", 7).Returns(5);
                yield return new TestCaseData(@"..#
#..
...", 70).Returns(41);
                yield return new TestCaseData(@"..#
#..
...", 10000).Returns(5587);
                yield return new TestCaseData(Inputs[22], 10000).Returns(5339);
            }
        }
        public static IEnumerable TcD22P2
        {
            get
            {
                yield return new TestCaseData(@"..#
#..
...", 100).Returns(26);
                yield return new TestCaseData(@"..#
#..
...", 10000000).Returns(2511944);
                yield return new TestCaseData(Inputs[22], 10000000).Returns(2512380);
            }
        }
        public static IEnumerable TcD23P1
        {
            get
            {
                yield return new TestCaseData(Inputs[23]).Returns(-1);
            }
        }
        public static IEnumerable TcD23P2
        {
            get
            {
                yield return new TestCaseData(Inputs[23]).Returns(-1);
            }
        }
        public static IEnumerable TcD24P1
        {
            get
            {
//                yield return new TestCaseData(@"0/2
//2/2
//2/3
//3/4
//3/5
//0/1
//10/1
//9/10").Returns(int.MinValue);
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
                yield return new TestCaseData(@"A,0,1,Right,B
A,1,0,Left,B
B,0,1,Left,A
B,1,1,Right,A", 6).Returns(3);
                yield return new TestCaseData(Inputs[25], 12399302).Returns(2794);
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


        public static IEnumerable DanceSpin
        {
            get
            {
                yield return new TestCaseData("".AsSpan(), "abcde").Returns("abcde");
                yield return new TestCaseData("s0".AsSpan(), "abcde").Returns("abcde");
                yield return new TestCaseData("s1".AsSpan(), "abcde").Returns("eabcd");
                yield return new TestCaseData("s2".AsSpan(), "abcde").Returns("deabc");
                yield return new TestCaseData("s3".AsSpan(), "abcde").Returns("cdeab");
                yield return new TestCaseData("s4".AsSpan(), "abcde").Returns("bcdea");
                yield return new TestCaseData("s5".AsSpan(), "abcde").Returns("abcde");
            }
        }

        public static IEnumerable DanceExchange
        {
            get
            {
                yield return new TestCaseData("".AsSpan(), "abcde").Returns("abcde");
                yield return new TestCaseData("x0/1".AsSpan(), "abcde").Returns("bacde");
                yield return new TestCaseData("x1/2".AsSpan(), "abcde").Returns("acbde");
                yield return new TestCaseData("x2/3".AsSpan(), "abcde").Returns("abdce");
                yield return new TestCaseData("x3/4".AsSpan(), "abcde").Returns("abced");
                yield return new TestCaseData("x0/2".AsSpan(), "abcde").Returns("cbade");
                yield return new TestCaseData("x1/3".AsSpan(), "abcde").Returns("adcbe");
                yield return new TestCaseData("x2/4".AsSpan(), "abcde").Returns("abedc");
            }
        }

        public static IEnumerable DancePartner
        {
            get
            {
                yield return new TestCaseData("".AsSpan(), "abcde").Returns("abcde");
                yield return new TestCaseData("pa/b".AsSpan(), "abcde").Returns("bacde");
                yield return new TestCaseData("pa/c".AsSpan(), "abcde").Returns("cbade");
                yield return new TestCaseData("pa/d".AsSpan(), "abcde").Returns("dbcae");
                yield return new TestCaseData("pa/e".AsSpan(), "abcde").Returns("ebcda");
                yield return new TestCaseData("pb/a".AsSpan(), "abcde").Returns("bacde");
                yield return new TestCaseData("pb/c".AsSpan(), "abcde").Returns("acbde");
                yield return new TestCaseData("pb/d".AsSpan(), "abcde").Returns("adcbe");
                yield return new TestCaseData("pb/e".AsSpan(), "abcde").Returns("aecdb");
                yield return new TestCaseData("pc/a".AsSpan(), "abcde").Returns("cbade");
                yield return new TestCaseData("pc/b".AsSpan(), "abcde").Returns("acbde");
                yield return new TestCaseData("pc/d".AsSpan(), "abcde").Returns("abdce");
                yield return new TestCaseData("pc/e".AsSpan(), "abcde").Returns("abedc");
                yield return new TestCaseData("pd/a".AsSpan(), "abcde").Returns("dbcae");
                yield return new TestCaseData("pd/b".AsSpan(), "abcde").Returns("adcbe");
                yield return new TestCaseData("pd/c".AsSpan(), "abcde").Returns("abdce");
                yield return new TestCaseData("pd/e".AsSpan(), "abcde").Returns("abced");
                yield return new TestCaseData("pe/a".AsSpan(), "abcde").Returns("ebcda");
                yield return new TestCaseData("pe/b".AsSpan(), "abcde").Returns("aecdb");
                yield return new TestCaseData("pe/c".AsSpan(), "abcde").Returns("abedc");
                yield return new TestCaseData("pe/d".AsSpan(), "abcde").Returns("abced");
            }
        }

        public static IEnumerable TestRotate2
        {
            get
            {
                yield return new TestCaseData("1234").Returns("3142");
                yield return new TestCaseData("3142").Returns("4321");
                yield return new TestCaseData("4321").Returns("2413");
                yield return new TestCaseData("2413").Returns("1234");
            }
        }
        public static IEnumerable TestRotate3
        {
            get
            {
                yield return new TestCaseData("123456789").Returns("412753896");
                yield return new TestCaseData("412753896").Returns("741852963");
                yield return new TestCaseData("741852963").Returns("874951632");
                yield return new TestCaseData("874951632").Returns("987654321");
                yield return new TestCaseData("987654321").Returns("698357214");
                yield return new TestCaseData("698357214").Returns("369258147");
                yield return new TestCaseData("369258147").Returns("236159478");
                yield return new TestCaseData("236159478").Returns("123456789");
            }
        }

        public static IEnumerable StringHelperClean
        {
            get
            {
                yield return new TestCaseData("", '!').Returns("");
                yield return new TestCaseData("<>", '!').Returns("<>");
                yield return new TestCaseData("<random characters>", '!').Returns("<random characters>");
                yield return new TestCaseData("<{!>}>", '!').Returns("<{}>");
                yield return new TestCaseData("<!!>", '!').Returns("<>");
                yield return new TestCaseData("<!!!>>", '!').Returns("<>");
                yield return new TestCaseData("<{o\"i!a,<{i<a>", '!').Returns("<{o\"i,<{i<a>");
            }
        }
        public static IEnumerable StringHelperGarbage
        {
            get
            {
                yield return new TestCaseData("", '<', '>').Returns(new List<string> { "" });
                yield return new TestCaseData("<>", '<', '>').Returns(new List<string> { "<>" });
                yield return new TestCaseData("<random characters>", '<', '>').Returns(new List<string> { "<random characters>" });
                yield return new TestCaseData("<{!>}>", '<', '>').Returns(new List<string> { "<{}>" });
                yield return new TestCaseData("<!!>", '<', '>').Returns(new List<string> { "<>" });
                yield return new TestCaseData("<!!!>>", '<', '>').Returns(new List<string> { "<>" });
                yield return new TestCaseData("<{o\"i!a,<{i<a>", '<', '>').Returns(new List<string> { "<{o\"i,<{i<a>" });
                yield return new TestCaseData("<><random characters><{!>}><!!><!!!>><{o\"i!a,<{i<a>", '<', '>').Returns(new List<string> { "<>", "<random characters>", "<{}>", "<>", "<>", "<{o\"i,<{i<a>" });
            }
        }

        public static IEnumerable StringHelperScore
        {
            get
            {
                yield return new TestCaseData("{}", 1).Returns(1);
                yield return new TestCaseData("{{{}}}", 1).Returns(6);
                yield return new TestCaseData("{{},{}}", 1).Returns(5);
                yield return new TestCaseData("{{{},{},{{}}}}", 1).Returns(16);
                yield return new TestCaseData("{}", 1).Returns(1);
                yield return new TestCaseData("{{},{},{},{}}", 1).Returns(9);
                yield return new TestCaseData("{{}}", 1).Returns(3);
            }
        }

    }
}
