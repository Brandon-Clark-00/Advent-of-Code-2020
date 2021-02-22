total = 0
required = 0
found = []

def read_file():
    with open("day7.txt") as f:
        bags = f.read().splitlines()
    return bags

def find_bags(bags, colour="shiny gold"):
    for bag in bags:
        bagtemp = bag.split(" ")
        contain = " ".join(bagtemp[0:2])
        contained = " ".join(bagtemp[5:])
        # print(f"{contain} contain {contained}")
        global found
        if colour in contained and contain not in found:
            found.append(contain)
            global total
            total += 1
            find_bags(bags, contain)

def find_bags_required(bags, colour="shiny gold"):
    for bag in bags:
        bagtemp = bag.split(" ")
        contain = " ".join(bagtemp[0:2])
        contained = " ".join(bagtemp[4:]).replace(".", "")
        if contain == colour:
            if "no other bags" not in contained:
                contained = contained.split(", ")
                for x in contained:
                    recursions = int(x.split(" ")[0])
                    new_colour = " ".join(x.split(" ")[1:3])
                    global required
                    required += recursions
                    for y in range(recursions):
                        find_bags_required(bags, new_colour)

find_bags(read_file())
print(f"Total = {total}")
find_bags_required(read_file())
print(f"Required: {required}")