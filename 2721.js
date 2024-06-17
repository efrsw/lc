/**
 * @param {Array<Function>} functions
 * @return {Promise<any>
 */
let promiseAll = function(functions) {
	return new Promise((resolve, reject) => {
		let results = [];
		for(let func in functions) {
			func()
			.then(results.push(true))
			.catch(results.push(false));
		}

		while(results.length != functions.length) {
			continue;
		}

		for (let a in results) {
			if (a == false) reject();
		}

		resolve();
	}); 
};

