Cliente cliente1 = new Cliente(
    "Arthur Morgan",
    "123.456.789-00"
);

Cliente cliente2 = new Cliente(
    "João Neres",
    "987.654.321-00"
);

Veiculo veiculo1 = new Veiculo(
    "Chevrolet Tracker",
    "ABC-1234"
);

Veiculo veiculo2 = new Veiculo(
    "Volkswagen Virtus",
    "DEF-5678"
);

Locacao locacao1 = new Locacao(
    cliente1,
    veiculo1,
    new DateOnly(2026, 10, 8),
    5,
    150.00m
);

Locacao locacao2 = new Locacao(
    cliente2,
    veiculo2,
    new DateOnly(2026, 10, 8),
    10,
    200.00m
);

locacao1.ExibirResumo();

Console.WriteLine();

locacao2.ExibirResumo();