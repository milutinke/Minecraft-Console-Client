# /dig

Attempt to break a block.

## Syntax

```text
/dig [<x> <y> <z>|stop]
```

## Forms

| Form | Meaning |
| --- | --- |
| `/dig` | break the block you are looking at |
| `/dig <x> <y> <z>` | break a specific block |
| `/dig stop` | release the current block attack |

## Examples

Type these lines inside MCC. Replace names, coordinates, IDs, and paths with values from your installation.

```text
/dig
/dig 150 79 380
/dig stop
```

## Behavior and requirements

The bare command targets the looked-at block. The coordinate form targets a specific block. Terrain data, reach, game mode, selected tool, and protection rules affect success.

The command starts mining and returns control so you can enter other commands. Use `/dig stop` to release the attack. Unbreakable blocks keep the attack held until you stop it or the server removes the target. Looking away from the original block or moving it out of reach also releases the attack. Another block under the view does not replace the requested target. Caller cancellation and session shutdown also end it.

MCC attempts a real server interaction. It does not directly edit the local world snapshot to claim that the block broke.

Declared game features: Terrain. Some forms also need a current game session or a compatible menu.

[All commands](index.md) · [Troubleshooting](../troubleshooting/index.md)
