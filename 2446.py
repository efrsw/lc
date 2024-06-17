def haveConfclict(event1: list[str], event2: list[str]) -> bool:
    def convertToSum(l: list[str]) -> list[int]:
        return list(
            map(lambda x: int(x.split(':')[0]) * 60 + int(x.split(':')[1]), l)
        )

    a = convertToSum(event1)
    b = convertToSum(event2)
    
    return len(set(range(a[0], a[1])).intersection(set(range(b[0], b[1])))) > 0

event1 = ["01:15","02:00"]
event2 = ["02:00","03:00"]

haveConfclict(event1, event2)

