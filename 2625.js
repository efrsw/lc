let a = [1, 2, [3, [4], 5], 6];

var flat = function(arr, n, curDepth = 0) {
	if (curDepth >= n) return arr;

	res = []
	arr.forEach(x => {
		if (Array.isArray(x)) {
			res.push(...x);
		} else {
			res.push(x);
		}
	});

	return flat(res, n, ++curDepth);
}

console.log(flat(a, 1));
