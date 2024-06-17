let debounce = function(fn, t) {
	let delayCompleted: boolean = false;
	let timer;

	return function(...args) {
		timer = setTimeout(() => {
			delayCompleted = true;
			fn(...args);
			return;
		}, t);
		
		if(!delayCompleted) {
			clearTimeout(timer);
		}
	}
}
