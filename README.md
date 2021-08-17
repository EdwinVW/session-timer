# Session Timer

This repo contains the code for a timer app you can use for timing multiple sections of a session. The session could be a presentation or workshop for example. Here's a screen-shot of the application:

![Application screenshot](/img/app-screenshot.jpg)

- Each session has a name, shown at the top of the screen.
- The session consists of multiple sections.
- Each section is shown with its name, speaker, duration and a progress bar.
- The active section is indicated by a play-button icon.
- The progress bar counts back for the duration of the active section.
- When the timer of a section reaches 0:00, the next section will automatically become active.

This app is still in active development (see backlog below).

## Backlog

### Must

- [ ] Make session and sections configurable (now hard-coded).
- [ ] Add ability to save and load a session from config file.
- [ ] Add persistence to survive a browser refresh.

### Should

- [ ] Add configuration UI for configuring a session and sections.
- [ ] Add pause / resume capability.
- [ ] Add ability to manually activate another section.
- [ ] Make UI configurable (colors, font, progress-bars, light-/dark-mode).

### Could

- [ ] Add presenter notes per section.

## Technology

The app is built using Blazor and runs in the browser on Web Assembly.

## Disclaimer

The author can in no way be held liable for damage caused directly or indirectly by using the code in this repository.
