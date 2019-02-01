import requests, pickle, random

books = {}
class Book:
    def __init__(self):
        self.id = ""
        self.name = "",
        self.author = ""
        self.city = ""
        self.price = 0,
        self.price2 = 0
        self.rate1 = 0
        self.rate2 = 0
        self.publ = ""
        self.god = ""
        self.count = 0
        self.year = 0

    def todb(self):
        self.rate1 = "%.2f" % float(self.rate1)
        self.rate2 = "%.2f" % float(self.rate2)
        t = "insert into books (id, name, author, city, publishing, year, price_in, price_out, count, rating_clients, rating_critic) values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8}, {9}, {10});"
        return t.format(self.id, self.name, self.author, self.city, self.publ, self.year, self.price, self.price2, self.count, self.rate1, self.rate2)




try:
    f = open("books.txt", "rb")
    books = pickle.load(f)
    f.close()
except Exception as exp:
    print(exp)
    open("books.txt", "w").close()


#url = "https://www.chitai-gorod.ru/catalog/book/1060689/"
#url = "https://www.chitai-gorod.ru/catalog/book/1077540/?watch_fromlist=main_%D0%9B%D1%83%D1%87%D1%88%D0%B8%D0%B5%20%D0%BF%D1%80%D0%BE%D0%B4%D0%B0%D0%B6%D0%B8"
#url= "https://www.chitai-gorod.ru/catalog/book/1074692/?watch_fromlist=main_%D0%9B%D1%83%D1%87%D1%88%D0%B8%D0%B5%20%D0%BF%D1%80%D0%BE%D0%B4%D0%B0%D0%B6%D0%B8"
#url = "https://www.chitai-gorod.ru/catalog/book/1088057/?watch_fromlist=main_%D0%9D%D0%BE%D0%B2%D0%B8%D0%BD%D0%BA%D0%B8%20%D0%BB%D0%B8%D1%82%D0%B5%D1%80%D0%B0%D1%82%D1%83%D1%80%D1%8B"
#url = "https://www.chitai-gorod.ru/catalog/book/1081642/?watch_fromlist=main_%D0%9D%D0%BE%D0%B2%D0%B8%D0%BD%D0%BA%D0%B8%20%D0%BB%D0%B8%D1%82%D0%B5%D1%80%D0%B0%D1%82%D1%83%D1%80%D1%8B"
#url = "https://www.chitai-gorod.ru/catalog/book/1082344/?watch_fromlist=main_%D0%9D%D0%BE%D0%B2%D0%B8%D0%BD%D0%BA%D0%B8%20%D0%BB%D0%B8%D1%82%D0%B5%D1%80%D0%B0%D1%82%D1%83%D1%80%D1%8B"
urls = {
    "https://www.chitai-gorod.ru/catalog/book/1062241/?watch_fromlist=main_10%20%D0%B2%D0%B4%D0%BE%D1%85%D0%BD%D0%BE%D0%B2%D0%BB%D1%8F%D1%8E%D1%89%D0%B8%D1%85%20%D0%BA%D0%BD%D0%B8%D0%B3%20%D0%BE%20%D1%85%D1%83%D0%B4%D0%BE%D0%B6%D0%BD%D0%B8%D0%BA%D0%B0%D1%85",
    "https://www.chitai-gorod.ru/catalog/book/1056785/?watch_fromlist=main_10%20%D0%B2%D0%B4%D0%BE%D1%85%D0%BD%D0%BE%D0%B2%D0%BB%D1%8F%D1%8E%D1%89%D0%B8%D1%85%20%D0%BA%D0%BD%D0%B8%D0%B3%20%D0%BE%20%D1%85%D1%83%D0%B4%D0%BE%D0%B6%D0%BD%D0%B8%D0%BA%D0%B0%D1%85",
    "https://www.chitai-gorod.ru/catalog/book/1021085/?watch_fromlist=main_10%20%D0%B2%D0%B4%D0%BE%D1%85%D0%BD%D0%BE%D0%B2%D0%BB%D1%8F%D1%8E%D1%89%D0%B8%D1%85%20%D0%BA%D0%BD%D0%B8%D0%B3%20%D0%BE%20%D1%85%D1%83%D0%B4%D0%BE%D0%B6%D0%BD%D0%B8%D0%BA%D0%B0%D1%85",
    "https://www.chitai-gorod.ru/catalog/book/1081513/?watch_fromlist=main_%D0%A1%D0%BA%D0%BE%D1%80%D0%BE%20%D0%B2%20%D0%BF%D1%80%D0%BE%D0%B4%D0%B0%D0%B6%D0%B5",
    "https://www.chitai-gorod.ru/catalog/book/400536/?watch_fromlist=main_%D0%9F%D0%BE%D0%BF%D1%83%D0%BB%D1%8F%D1%80%D0%BD%D0%BE%D0%B5",
    "https://www.chitai-gorod.ru/catalog/book/862755/?watch_fromlist=main_%D0%9F%D0%BE%D0%BF%D1%83%D0%BB%D1%8F%D1%80%D0%BD%D0%BE%D0%B5",
    "https://www.chitai-gorod.ru/catalog/book/1088333/?watch_fromlist=main_%D0%9D%D0%BE%D0%B2%D0%B8%D0%BD%D0%BA%D0%B8%20%D0%BB%D0%B8%D1%82%D0%B5%D1%80%D0%B0%D1%82%D1%83%D1%80%D1%8B",
    "https://www.chitai-gorod.ru/catalog/book/1077850/?watch_fromlist=page_bestsell",
    "https://www.chitai-gorod.ru/catalog/book/1042884/?watch_fromlist=page_bestsell",
    "https://www.chitai-gorod.ru/catalog/book/1071877/?watch_fromlist=page_bestsell"
}



def get_txt(url):
    r = requests.get(url)
    t = r.text

    with open("1.html", "w") as f:
        f.write(t)

    return t

def get_name(txt):
    start = """<h1 class="product__title js-analytic-product-title" itemprop="name">"""
    end = """</h1>"""
    name = txt[txt.find(start)+len(start):]
    name = name[:name.find(end)]
    print(name)
    return name

def get_author(txt):
    start = """class="link product__author">"""
    end = "</a>"
    a = txt[txt.find(start) + len(start):]
    a = a[:a.find(end)].strip()
    print(a)
    return a

def get_price(txt):
    start = """<div class="price">"""
    end = "</div>"
    a = txt[txt.find(start) + len(start):]
    a = a[:a.find(end)].strip().split()[0]
    print(a)
    return a

def get_rate(txt):
    start = """<svg class="star"><use xlink:href="#star-icon" href="#star-icon"></use></svg>
                        <span>"""
    end = "</span>"
    a = txt[txt.find(start) + len(start):]
    a = a[:a.find(end)].replace(" ", "").replace("(", ".").replace(")","")
    print(a)
    return a

def get_publ(txt):
    start = """<div class="product-prop__value">"""
    start2 = "'>"
    end = "</a>"
    a = txt[txt.find(start) + len(start):]
    a = a[a.find(start2) + len(start2):]
    a = a[:a.find(end)].strip()
    print(a)
    return a

def get_god(txt):
    start = """Год издания"""
    start2 = """<div class="product-prop__value">"""
    end = "</div>"
    a = txt[txt.find(start) + len(start):]
    a = a[a.find(start2) + len(start2):]
    a = a[:a.find(end)].strip()
    print(a)
    return a

def get_isbn(txt):
    start = """<div class="product-prop__title">
										ISBN"""
    start2 = """<div class="product-prop__value">"""
    end = "</div>"
    a = txt[txt.find(start) + len(start):]
    a = a[a.find(start2) + len(start2):]
    a = a[:a.find(end)].strip()
    print(a)
    return a

def get_book(url):
    b = Book()
    txt = get_txt(url)

    b.name = get_name(txt)

    b.author = get_author(txt)

    b.price = int(get_price(txt))
    b.price2 = int(b.price - 0.13*b.price)
    print(b.price2)

    b.rate1 = float(get_rate(txt))
    b.rate2 = b.rate1 + float(float(random.randint(1, 150))/100 * (-1**random.randint(1,100)))
    print(b.rate2)

    b.publ = get_publ(txt)

    b.year = get_god(txt)

    b.count = random.randint(5, 370)
    print(b.count)

    b.id = get_isbn(txt)

    print(b.todb())

    if not b.id in books:
        print("добавили новое")
        books[b.id] = b


def show_all_commands():
    for i in books:
        print(books[i].todb())



###########################################
show_all_commands()

with open("books.txt", "wb") as f:
    pickle.dump(books,f)