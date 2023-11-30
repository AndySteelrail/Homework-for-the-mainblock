def get_short_words (words: list, limit: int) -> list:
    short_words = []
    for word in words:
        if len(word) <= limit:
            short_words.append(word)
    return short_words

words: list = input("Введите текст, преобразуемый в массив через пробел: ").split()
short_words: list = get_short_words(words, 3)
# Или без функции, в 1 строку: short_words = [word for word in words if len(word) <= 3]

print(*short_words)