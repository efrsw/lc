var join = function(arr1, arr2) {
	let res = new Map();

	[...arr1, ...arr2].forEach(x => {
		if (res.has(x.id)) {
			Object.keys(x).forEach(k => {
				res.get(x.id)[k] = x[k];
			});
		} else {
			res.set(x.id, x);
		}
	});

	return [...res.values()].toSorted((a, b) => a.id - b.id);
}

let a = [
	{ id: 1, x: 5 },
	{ id: 2, x: 6 }
];

let b = [
	{ id: 3, x: 7 }
]

console.log(join(a, b));
