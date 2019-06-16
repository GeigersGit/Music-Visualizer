using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Circle64 : MonoBehaviour {
  
    public GameObject cube01,cube02,cube03,cube04,cube05,cube06,cube07,cube08,cube09,cube10,
                   cube11,cube12,cube13,cube14,cube15,cube16,cube17,cube18,cube19,cube20,
                   cube21,cube22,cube23,cube24,cube25,cube26,cube27,cube28,cube29,cube30,
                   cube31,cube32,cube33,cube34,cube35,cube36,cube37,cube38,cube39,cube40,
                   cube41,cube42,cube43,cube44,cube45,cube46,cube47,cube48,cube49,cube50,
                   cube51,cube52;

    public float specMag01, specMag02, specMag03, specMag04, specMag05, specMag06, specMag07, specMag08, specMag09, specMag10,
             specMag11, specMag12, specMag13, specMag14, specMag15, specMag16, specMag17, specMag18, specMag19, specMag20,
             specMag21, specMag22, specMag23, specMag24, specMag25, specMag26, specMag27, specMag28, specMag29, specMag30,
             specMag31, specMag32, specMag33, specMag34, specMag35, specMag36, specMag37, specMag38, specMag39, specMag40,
             specMag41, specMag42, specMag43, specMag44, specMag45, specMag46, specMag47, specMag48, specMag49, specMag50,
             specMag51, specMag52;

    public int limit = 50;
    public float intensity = 50;
    public float rate = 10;
    public float mytime = 1;
    public bool waiting = false;
    public float speed = .1f;
	
    public float[] spec;
    List<float> specmags = new List<float>();
    List<GameObject> cubes = new List<GameObject>();

    void Start () {
        
        cubes.Add(cube01); cubes.Add(cube02); cubes.Add(cube03); cubes.Add(cube04); cubes.Add(cube05);
        cubes.Add(cube06); cubes.Add(cube07); cubes.Add(cube08); cubes.Add(cube09); cubes.Add(cube10);
        cubes.Add(cube11); cubes.Add(cube12); cubes.Add(cube13); cubes.Add(cube14); cubes.Add(cube15);
        cubes.Add(cube16); cubes.Add(cube17); cubes.Add(cube18); cubes.Add(cube19); cubes.Add(cube20);
        cubes.Add(cube21); cubes.Add(cube22); cubes.Add(cube23); cubes.Add(cube24); cubes.Add(cube25);
        cubes.Add(cube26); cubes.Add(cube27); cubes.Add(cube28); cubes.Add(cube29); cubes.Add(cube30);
        cubes.Add(cube31); cubes.Add(cube32); cubes.Add(cube33); cubes.Add(cube34); cubes.Add(cube35);
        cubes.Add(cube36); cubes.Add(cube37); cubes.Add(cube38); cubes.Add(cube39); cubes.Add(cube40);
        cubes.Add(cube41); cubes.Add(cube42); cubes.Add(cube43); cubes.Add(cube44); cubes.Add(cube45);
        cubes.Add(cube46); cubes.Add(cube47); cubes.Add(cube48); cubes.Add(cube49); cubes.Add(cube50);
        cubes.Add(cube51); cubes.Add(cube52);


       
        specmags.Add(specMag01); specmags.Add(specMag02); specmags.Add(specMag03); specmags.Add(specMag04); specmags.Add(specMag05);
        specmags.Add(specMag06); specmags.Add(specMag07); specmags.Add(specMag08); specmags.Add(specMag09); specmags.Add(specMag10);
        specmags.Add(specMag11); specmags.Add(specMag12); specmags.Add(specMag13); specmags.Add(specMag14); specmags.Add(specMag15);
        specmags.Add(specMag16); specmags.Add(specMag17); specmags.Add(specMag18); specmags.Add(specMag19); specmags.Add(specMag20);
        specmags.Add(specMag21); specmags.Add(specMag22); specmags.Add(specMag23); specmags.Add(specMag24); specmags.Add(specMag25);
        specmags.Add(specMag26); specmags.Add(specMag27); specmags.Add(specMag28); specmags.Add(specMag29); specmags.Add(specMag30);
        specmags.Add(specMag31); specmags.Add(specMag32); specmags.Add(specMag33); specmags.Add(specMag34); specmags.Add(specMag35);
        specmags.Add(specMag36); specmags.Add(specMag37); specmags.Add(specMag38); specmags.Add(specMag39); specmags.Add(specMag40);
        specmags.Add(specMag41); specmags.Add(specMag42); specmags.Add(specMag43); specmags.Add(specMag44); specmags.Add(specMag45);
        specmags.Add(specMag46); specmags.Add(specMag47); specmags.Add(specMag48); specmags.Add(specMag49); specmags.Add(specMag50);
        specmags.Add(specMag51); specmags.Add(specMag52);

    }

 void music(){
	GetComponent<AudioSource>().Play ();
}
 
 void Update () {
	if(Input.GetKey (KeyCode.Escape)){
			Application.Quit();
	}
	
	spec = AudioListener.GetSpectrumData(8192,0,FFTWindow.BlackmanHarris);
        specmags[13] = spec[1] + spec[2] + spec[3] + spec[4] + spec[5] + spec[6] + spec[7] + spec[8] + spec[9] + spec[10] + spec[11] + spec[12] + spec[13] + spec[14]; 
        specmags[14] = spec[15] + spec[15];
        specmags[15] = spec[16]+ spec[17];// + spec[675] + spec [700];
        specmags[16] = spec[18] + spec[18];// + spec[775] + spec [800];
        specmags[17] = spec[19]+ spec[20];// + spec[925] + spec [950];
        specmags[18] = spec[21]+ spec[21];// + spec[1050] + spec [1075];
        specmags[19] = spec[22]+ spec[23];// + spec[1175] + spec [1200];
        specmags[20] = spec[24]+ spec[25] + spec[26];// + spec[25] + spec [50];
        specmags[21] = spec[27]+ spec[28] + spec[29];// + spec[150] + spec [175];
        specmags[22] = spec[30]+ spec[31] + spec[32];// + spec[275] + spec [300];
        specmags[23] = spec[33]+ spec[34] + spec[35];// + spec[400] + spec [425];
        specmags[24] = spec[36]+ spec[37] + spec[38];// + spec[525] + spec [550];
        specmags[25] = spec[39]+ spec[40] + spec[40];
        specmags[26] = spec[41]+ spec[42] + spec[43];
        specmags[27] = spec[44]+ spec[45] + spec[46];
        specmags[28] = spec[48]+ spec[49] + spec[50] + spec[51] + spec[52] + spec[53];
        specmags[29] = spec[54]+ spec[55] + spec[56] + spec[57] + spec[58] + spec[59];
        specmags[30] = spec[60]+ spec[61] + spec[62] + spec[63] + spec[64] + spec[64];
        specmags[31] = spec[65]+ spec[66] + spec[67] + spec[68] + spec[69] + spec[70];
        specmags[32] = spec[71]+ spec[72] + spec[73] + spec[74] + spec[75] + spec[76];
        specmags[33] = spec[77]+ spec[78] + spec[79] + spec[80] + spec[81] + spec[82];
        specmags[34] = spec[83]+ spec[84] + spec[85] + spec[86] + spec[87] + spec[88];
        specmags[35] = spec[89]+ spec[90] + spec[91] + spec[92] + spec[93] + spec[94];
        specmags[36] = spec[95]+ spec[96] + spec[97] + spec[98] + spec[99] + spec[100] +spec[101] + spec[102] + spec[103] + spec[104];
        specmags[37] = spec[105]+ spec[106] + spec[107] + spec[108] + spec[109] + spec[110] + spec[111] + spec[113] + spec[114] + spec[115];
        specmags[38] = spec[116]+ spec[117] + spec[118] + spec[119] + spec[120] + spec[121] + spec[122] + spec[123] + spec[124] + spec[125];
        specmags[39] = spec[126]+ spec[127] + spec[128] + spec[129] + spec[130] + spec[131] + spec[132] + spec[133] + spec[134] + spec[135];
        specmags[40] = spec[136]+ spec[137] + spec[138] + spec[139] + spec[140] + spec[141] + spec[142] + spec[143] + spec[144] + spec[145];
        specmags[41] = spec[146]+ spec[147] + spec[148] + spec[149] + spec[150] + spec[151] + spec[152] + spec[153] + spec[154] + spec[155];
        specmags[42] = spec[156]+ spec[157] + spec[158] + spec[159] + spec[160] + spec[161] + spec[162] + spec[163] + spec[164] + spec[165];
        specmags[43] = spec[166]+ spec[167] + spec[168] + spec[169] + spec[170] + spec[171] + spec[172] + spec[173] + spec[174] + spec[175];
        specmags[44] = spec[176]+ spec[177] + spec[178] + spec[179] + spec[180] + spec[181] + spec[182] + spec[183] + spec[184] + spec[185];
        specmags[45] = spec[186]+ spec[187] + spec[188] + spec[189] + spec[190] + spec[191] + spec[192] + spec[193] + spec[194] + spec[195];
        specmags[46] = spec[196]+ spec[197] + spec[198] + spec[199] + spec[200] + spec[201] + spec[202] + spec[203] + spec[204] + spec[205];
        specmags[47] = spec[206]+ spec[207] + spec[208] + spec[209] + spec[210] + spec[211] + spec[212] + spec[213] + spec[214] + spec[215];
        specmags[48] = spec[216]+ spec[217] + spec[218] + spec[219] + spec[220] + spec[221] + spec[222] + spec[223] + spec[224] + spec[225];
        specmags[49] = spec[226]+ spec[227] + spec[228] + spec[229] + spec[230] + spec[231] + spec[232] + spec[233] + spec[234] + spec[235];
        specmags[50] = spec[236]+ spec[237] + spec[238] + spec[239] + spec[240] + spec[241] + spec[242] + spec[243] + spec[244] + spec[245];
        specmags[51] = spec[246]+ spec[247] + spec[248] + spec[249] + spec[250] + spec[251] + spec[252] + spec[253] + spec[254] + spec[255];
		
        specmags[0] = spec[256]+ spec[257] + spec[258] + spec[259] + spec[260] + spec[261] + spec[262] + spec[263] + spec[264] + spec[265] + 
                        spec[266] + spec[267] + spec[268] + spec[269] + spec[270] + spec[271] + spec[272] + spec[273] + spec[274] + spec[275];
        specmags[1] = spec[276] + spec[278] + spec[279] + spec[280] + spec[281] + spec[282] + spec[283] + spec[284] + spec[285] + spec[286] +
                        spec[287] + spec[288] + spec[289] + spec[290] + spec[291] + spec[292] + spec[293] + spec[294] + spec[295] + spec[296];
        specmags[2] = spec[297] + spec[298] + spec[299] + spec[300] + spec[301] + spec[302] + spec[303] + spec[304] + spec[305] + spec[306] +
                        spec[307] + spec[308] + spec[309] + spec[310] + spec[311] + spec[312] + spec[313] + spec[314] + spec[315] + spec[316];
        specmags[3] = spec[317] + spec[318] + spec[319] + spec[320] + spec[321] + spec[322] + spec[323] + spec[324] + spec[325] + spec[326] +
                        spec[327] + spec[328] + spec[329] + spec[330] + spec[331] + spec[332] + spec[333] + spec[334] + spec[335] + spec[336];
        specmags[4] = spec[337] + spec[338] + spec[339] + spec[340] + spec[341] + spec[342] + spec[343] + spec[344] + spec[345] + spec[346] +
                        spec[347] + spec[348] + spec[349] + spec[350] + spec[351] + spec[352] + spec[353] + spec[354] + spec[355] + spec[356];

        specmags[5] = spec[357] + spec[358] + spec[359] + spec[360] + spec[361] + spec[362] + spec[363] + spec[364] + spec[365] + spec[366] +
                        spec[367] + spec[368] + spec[369] + spec[370] + spec[371] + spec[372] + spec[373] + spec[374] + spec[375] + spec[376];
        specmags[6] = spec[377] + spec[378] + spec[379] + spec[380] + spec[381] + spec[382] + spec[262] + spec[384] + spec[385] + spec[386] +
                        spec[387] + spec[388] + spec[389] + spec[390] + spec[391] + spec[392] + spec[272] + spec[394] + spec[395] + spec[396];
        specmags[7] = spec[397] + spec[398] + spec[399] + spec[400] + spec[401] + spec[402] + spec[262] + spec[404] + spec[405] + spec[406] +
                        spec[407] + spec[408] + spec[409] + spec[410] + spec[411] + spec[412] + spec[272] + spec[414] + spec[415] + spec[416];
        specmags[8] = spec[417] + spec[418] + spec[419] + spec[420] + spec[421] + spec[422] + spec[262] + spec[424] + spec[425] + spec[426] +
                        spec[427] + spec[428] + spec[429] + spec[430] + spec[431] + spec[432] + spec[272] + spec[434] + spec[435] + spec[436];
        specmags[9] = spec[437] + spec[438] + spec[439] + spec[440] + spec[441] + spec[442] + spec[262] + spec[444] + spec[445] + spec[446] +
                        spec[447] + spec[448] + spec[449] + spec[450] + spec[451] + spec[452] + spec[272] + spec[454] + spec[455] + spec[456];
        specmags[10]= spec[457] + spec[458] + spec[459] + spec[460] + spec[461] + spec[462] + spec[262] + spec[464] + spec[465] + spec[466] +
                        spec[467] + spec[468] + spec[469] + spec[470] + spec[471] + spec[472] + spec[272] + spec[474] + spec[475] + spec[476];
        specmags[11]= spec[477] + spec[478] + spec[479] + spec[480] + spec[481] + spec[482] + spec[262] + spec[484] + spec[486] + spec[486] +
                        spec[487] + spec[488] + spec[489] + spec[490] + spec[491] + spec[492] + spec[272] + spec[494] + spec[495] + spec[496];
        specmags[12]= spec[497] + spec[498] + spec[499] + spec[500] + spec[501] + spec[502] + spec[262] + spec[504] + spec[505] + spec[506] +
                        spec[507] + spec[508] + spec[509] + spec[510] + spec[511] + spec[512] + spec[513] + spec[514] + spec[515] + spec[516];


        for (int i = 0; i <= 51; i++)
        {
            cubes[i].gameObject.transform.localScale = new Vector3(1, specmags[i] * intensity, 1);
            if (cubes[i].gameObject.transform.localScale.y >= limit) cubes[i].gameObject.transform.localScale = new Vector3(1, limit, 1);
        }
       

    }	
}