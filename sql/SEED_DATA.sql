-- Inserindo 10 autores
INSERT INTO authors (Name, Surname) VALUES
('Machado', 'de Assis'),
('Clarice', 'Lispector'),
('Jorge', 'Amado'),
('Cecília', 'Meireles'),
('Carlos', 'Drummond de Andrade'),
('José', 'Saramago'),
('Graciliano', 'Ramos'),
('Lygia', 'Fagundes Telles'),
('Rubem', 'Fonseca'),
('Monteiro', 'Lobato');

-- Inserindo 20 livros (2 para cada autor)
INSERT INTO books (Title, Description, launch, AuthorId) VALUES
('Dom Casmurro', 'Romance psicológico sobre ciúme e memória.', '1899-01-01 00:00:00.000000', 1),
('Quincas Borba', 'Crítica ao humanitismo através de ironia e filosofia.', '1891-01-01 00:00:00.000000', 1),

('A Hora da Estrela', 'História de uma jovem nordestina invisível na cidade.', '1977-10-10 00:00:00.000000', 2),
('Perto do Coração Selvagem', 'Romance de estreia com fluxo de consciência.', '1943-01-01 00:00:00.000000', 2),

('Gabriela, Cravo e Canela', 'Amor e política no sertão baiano.', '1958-06-10 00:00:00.000000', 3),
('Capitães da Areia', 'Meninos de rua em Salvador lutando por sobrevivência.', '1937-01-01 00:00:00.000000', 3),

('Romanceiro da Inconfidência', 'Poemas sobre a Inconfidência Mineira.', '1953-03-21 00:00:00.000000', 4),
('Viagem', 'Poesia introspectiva e metafísica.', '1939-01-01 00:00:00.000000', 4),

('Alguma Poesia', 'Obra inaugural do modernismo mineiro.', '1930-01-01 00:00:00.000000', 5),
('A Rosa do Povo', 'Poemas sobre guerra, angústia e esperança.', '1945-01-01 00:00:00.000000', 5),

('Ensaio sobre a Cegueira', 'Metáfora brutal sobre sociedade e ética.', '1995-10-01 00:00:00.000000', 6),
('O Evangelho Segundo Jesus Cristo', 'Versão ousada e humana da história bíblica.', '1991-01-01 00:00:00.000000', 6),

('Vidas Secas', 'Retrato seco e cruel da miséria nordestina.', '1938-01-01 00:00:00.000000', 7),
('São Bernardo', 'A ascensão e queda de um coronel.', '1934-01-01 00:00:00.000000', 7),

('As Meninas', 'Três jovens enfrentando ditadura e existência.', '1973-01-01 00:00:00.000000', 8),
('Ciranda de Pedra', 'Romance sobre família e amadurecimento.', '1954-01-01 00:00:00.000000', 8),

('Feliz Ano Novo', 'Contos violentos e urbanos sobre o Brasil moderno.', '1975-01-01 00:00:00.000000', 9),
('O Caso Morel', 'Crime e literatura se confundem.', '1973-01-01 00:00:00.000000', 9),

('Reinações de Narizinho', 'Clássico infantil cheio de imaginação.', '1931-01-01 00:00:00.000000', 10),
('Caçadas de Pedrinho', 'Aventuras infantis com crítica social.', '1933-01-01 00:00:00.000000', 10);
