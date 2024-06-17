class TimeLimitCache {
	_cache: Map<any, any>;

	constructor() {
		this._cache = new Map();
	}

	set(key: number, value: number, duration: number): boolean {
		let isPresent = this._cache.has(key);
		if (isPresent) clearTimeout(this._cache.get(key).timerId);
		this._cache.set(key, {
			value: value,
			timerId: setTimeout(_ => this._cache.delete(key), duration)
		});

		return isPresent;
	}

	get(key: number): number {
		return this._cache.has(key)
			? this._cache.get(key)!.value
			: -1;
	}

	count(): number {
		return this._cache.size;
	}
}
