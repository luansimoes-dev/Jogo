# Meu RPG

Boilerplate de um RPG 2D em C# com .NET 8 e Raylib-cs.

## Instalação e execução

No diretório `RPG/`:

```bash
dotnet restore
dotnet run
```

Para verificar a compilação:

```bash
dotnet build
```

## Arquitetura

- `Core/`: ciclo de vida de cenas e entrada do jogador.
- `Entities/`: entidades do jogo, como jogador, inimigos e NPCs.
- `Scenes/`: estados da aplicação, incluindo menu, mundo, batalha e inventário.
- `Systems/`: regras reutilizáveis de combate e diálogo.
- `Data/`: modelos de estatísticas, itens e inventário.
- `Assets/`: espaço reservado para sprites, áudio e fontes.

A cena ativa é controlada por `SceneManager`; `Game` mantém o loop principal e cada cena delega atualização e desenho às entidades necessárias.

## Próximos passos sugeridos

- Adicionar tilemap e colisões.
- Implementar save/load.
- Adicionar sprites reais e animações.
- Expandir batalhas, diálogos e conteúdo de mapas.
