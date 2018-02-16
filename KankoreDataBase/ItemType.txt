EQTDATA[MAINGUNS] = {
	name: 'Main Gun (S)',
	image: 1,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['DD','CL','CT','CLT','AS','AV','AO','AR','LHA'],
};
EQTDATA[MAINGUNSAA] = {
	name: 'Main Gun (S)',
	image: 16,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3,AAfleet:2,AAself:1},
	canequip: ['DD','CL','CT','CLT','AS','AV','AO','AR','LHA'],
};
EQTDATA[MAINGUNM] = {
	name: 'Main Gun (M)',
	image: 2,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['CL','CT','CLT','CA','CAV','BB','BBV'],
};
EQTDATA[MAINGUNL] = {
	name: 'Main Gun (L)',
	image: 3,
	improve: {Pshell:1.5,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['FBB','BB','BBV'],
};
EQTDATA[MAINGUNXL] = {
	name: 'Main Gun (L)',
	image: 3,
	improve: {Pshell:1.5,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: [],
	canequipS: [131,136,143,148,275,276],
};
EQTDATA[SECGUN] = {
	name: 'Secondary Gun',
	image: 4,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AS','AV','AR','LHA'],
};
EQTDATA[SECGUNAA] = {
	name: 'Secondary Gun',
	image: 16,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3,AAfleet:2,AAself:1},
	canequip: ['CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AS','AV','AR','LHA'],
};
EQTDATA[APSHELL] = {
	name: 'AP Shell',
	image: 13,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['FBB','BB','BBV'],
};
EQTDATA[TORPEDO] = {
	name: 'Torpedo',
	image: 5,
	improve: {Ptorp:1.2,Pnb:1,ACCtorp:2,ACCnb:1.3},
	canequip: ['DD','CL','CT','CLT','CA','CAV','SS','SSV'],
	canequipS: [178],
};
EQTDATA[TORPEDOSS] = {
	name: 'Torpedo',
	image: 5,
	canequip: ['SS','SSV'],
};
EQTDATA[MIDGETSUB] = {
	name: 'Midget Sub',
	image: 5,
	canequip: ['CLT','SS','SSV','AV'],
	canequipS: [200],
};
EQTDATA[AAGUN] = {
	name: 'Anti-Air Gun',
	image: 15,
	improve: {Pshell:1,Ptorp:1.2,ACCtorp:2,AAself:1},
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AS','AV','AO','AR','LHA'],
};
EQTDATA[AAFD] = {
	name: 'Fire Director',
	image: 30,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3,AAfleet:2,AAself:1},
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AS','AV','AO','AR','LHA'],
};
EQTDATA[SONARS] = {
	name: 'Sonar',
	image: 18,
	improve: {Pshell:.75,Pasw:1,ACCasw:1.3,EVtorp:1.5},
	canequip: ['DD','CL','CT','CLT','SS','SSV'],
	canequipS: [352,450],
};
EQTDATA[SONARL] = {
	name: 'Sonar',
	image: 18,
	canequip: ['CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AS','AV','LHA'],
};
EQTDATA[DEPTHCHARGE] = {
	name: 'Depth Charge',
	image: 17,
	improve: {Pshell:.75,Pasw:1,ACCasw:1.3},
	canequip: ['DD','CL','CT','CLT','AV'],
};
EQTDATA[FIGHTER] = {
	name: 'Fighter',
	image: 6,
	canequip: ['CVL','CV','CVB','LHA'],
	isPlane: true,
	isfighter: true,
};
EQTDATA[TORPBOMBER] = {
	name: 'Torpedo Bomber',
	image: 8,
	canequip: ['CVL','CV','CVB'],
	canequipS: [352],
	isPlane: true,
	canContact: true,
	isfighter: true,
	istorpbomber: true,
};
EQTDATA[DIVEBOMBER] = {
	name: 'Dive Bomber',
	image: 7,
	canequip: ['CVL','CV','CVB'],
	isPlane: true,
	isfighter: true,
	isdivebomber: true,
};
EQTDATA[SEAPLANE] = {
	name: 'Recon Seaplane',
	image: 10,
	improve: {LOS:1.2},
	canequip: ['CL','CT','CA','CAV','FBB','BB','BBV','SSV','AS','AV','AO'],
	isPlane: true,
	canContact: true,
};
EQTDATA[SEAPLANEBOMBER] = {
	name: 'Seaplane Bomber',
	image: 10,
	canequip: ['CAV','BBV','SSV','AV','AO'],
	canequipS: [358,361,446,447],
	isPlane: true,
	isfighter: true,
	isdivebomber: true,
};
EQTDATA[CARRIERSCOUT] = {
	name: 'Scout Plane',
	image: 9,
	canequip: ['CVL','CV','CVB'],
	isPlane: true,
	canContact: true,
};
EQTDATA[CARRIERSCOUT2] = {
	name: 'Scout Plane',
	image: 9,
	improve: {LOS:1.2},
	canequip: ['CVB'],
	isPlane: true,
	canContact: true,
};
EQTDATA[AUTOGYRO] = {
	name: 'Anti-Sub Plane',
	image: 21,
	canequip: ['CAV','BBV','CVL','AS','AO','AR','LHA'],
	isPlane: true,
};
EQTDATA[ASWPLANE] = {
	name: 'Anti-Sub Plane',
	image: 22,
	canequip: ['CVL','LHA'],
	isPlane: true,
};
EQTDATA[RADARS] = {
	name: 'Radar (S)',
	image: 11,
	improve: {LOS:1.25},
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AS','AV','AO','AR','LHA'],
};
EQTDATA[RADARL] = {
	name: 'Radar (L)',
	image: 11,
	improve: {LOS:1.4},
	canequip: ['CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AV'],
	canequipS: [352,470],
};
EQTDATA[RADARXL] = {
	name: 'Radar (L)',
	image: 11,
	canequip: ['FBB','BB','BBV'],
};
EQTDATA[ENGINE] = {
	name: 'Engine',
	image: 19,
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','SS','SSV','AS','AV','AO','AR','LHA'],
};
EQTDATA[TYPE3SHELL] = {
	name: 'Anti-Air Shell',
	image: 12,
	canequip: ['CA','CAV','FBB','BB','BBV'],
};
EQTDATA[BULGEM] = {
	name: 'Torpedo Bulge',
	image: 23,
	improve: {AR:.7},
	canequip: ['CT','CA','CAV','CVL','AS','AV','AR'],
	canequipS: [147],
};
EQTDATA[BULGEL] = {
	name: 'Torpedo Bulge',
	image: 23,
	improve: {AR:.7},
	canequip: ['FBB','BB','BBV','CV','CVB'],
};
EQTDATA[LANDINGCRAFT] = {
	name: 'Misc',
	image: 20,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['AV','LHA'],
	canequipS: [352,200,147,464,470,418,199,434,435,469,468,487],
};
EQTDATA[SEARCHLIGHTS] = {
	name: 'Night Equip',
	image: 24,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['DD','CL','CA','CAV','FBB','BB','BBV','AV'],
	canequipS: [343,356],
};
EQTDATA[SEARCHLIGHTL] = {
	name: 'Night Equip',
	image: 24,
	improve: {Pshell:1,Pnb:1,ACCshell:1,ACCnb:1.3},
	canequip: ['FBB','BB','BBV'],
};
EQTDATA[STARSHELL] = {
	name: 'Night Equip',
	image: 27,
	canequip: ['DD','CL','CLT','CA','CAV','FBB','BB','BBV','AS','AV','AR'],
};
EQTDATA[PICKET] = {
	name: 'Night Equip',
	image: 32,
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','AS','AV'],
};
EQTDATA[WG42] = {
	name: 'Misc',
	image: 31,
	canequip: ['DD','CL','CAV','BBV','SS','SSV','AS','AV','LHA'],
};
EQTDATA[SRF] = {
	name: 'Misc',
	image: 26,
	canequip: ['AR'],
};
EQTDATA[FCF] = {
	name: 'Misc',
	image: 28,
	canequip: ['CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','AS','AV','LHA'],
	canequipS: [464],
};
EQTDATA[DRUM] = {
	name: 'Misc',
	image: 25,
	canequip: ['DD','CL','CAV','AV','AO','LHA'],
};
EQTDATA[SCAMP] = {
	name: 'Misc',
	image: 29,
	canequip: ['CAV','BBV','CVL','CV','CVB','AO'],
	canequipS: [450],
};
EQTDATA[FLYINGBOAT] = {
	name: 'Recon Seaplane',
	image: 33,
	canequip: [],
	canequipS: [445,450],
	isPlane: true,
	canContact: true,
};
EQTDATA[REPAIR] = {
	name: 'Misc',
	image: 14,
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','SS','SSV','AS','AV','AO','AR','LHA'],
};
EQTDATA[RATION] = {
	name: 'Misc',
	image: 34,
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','SS','SSV','AS','AV','AO','AR','LHA'],
};
EQTDATA[SEAPLANEFIGHTER] = {
	name: 'Seaplane Fighter',
	image: 43,
	canequip: ['CAV','BBV','SSV','AS','AV','AO'],
	canequipS: [358,361,446,447,136,148,275,276],
	isPlane: true,
	isfighter: true,
};
EQTDATA[LANDINGTANK] = {
	name: 'Misc',
	image: 36,
	improve: {Pshell:1,Pnb:1},
	canequip: ['SS','SSV','AV','LHA'],
	canequipS: [352,200,147,464,470,418,199,468,487],
};
EQTDATA[OILDRUM] = {
	name: 'Misc',
	image: 35,
	canequip: ['AO'],
};
EQTDATA[LANDBOMBER] = {
	name: 'Misc',
	image: 37,
	canequip: [],
	isPlane: true,
	isfighter: true,
	isdivebomber: true,
	istorpbomber: true,
};
EQTDATA[INTERCEPTOR] = {
	name: 'Misc',
	image: 38,
	canequip: [],
	isPlane: true,
	isfighter: true,
};
EQTDATA[TRANSPORTITEM] = {
	name: 'Transportation Material',
	image: 41,
	canequip: ['CAV','BBV','CVL','CV','CVB','SSV','AV','AR','LHA'],
};
EQTDATA[SUBRADAR] = {
	name: 'Submarine Equipment',
	image: 42,
	canequip: ['SS','SSV'],
};
EQTDATA[JETBOMBER] = {
	name: 'Jet Fighter-Bomber',
	image: 39,
	canequip: ['CVB'],
	isPlane: true,
	isfighter: true,
	isdivebomber: true,
};
EQTDATA[OTHER] = {
	name: 'Misc',
	image: 14,
	canequip: ['DD','CL','CT','CLT','CA','CAV','FBB','BB','BBV','CVL','CV','CVB','SS','SSV','AS','AV','AO','AR','LHA'],
};
