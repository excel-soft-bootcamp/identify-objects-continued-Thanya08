# page lifecycle In ASP.NET

When an ASP.NET page runs, the page goes through a life cycle in which it performs a series of processing steps. These include initialization, instantiating controls, restoring and maintaining state, running event handler code, and rendering. The following are the various stages or events of ASP.Net page life cycle.



| Event Name        | Description                              |
| ----------------- | ---------------------------------------- |
| PreInit           | 1.  Check the IsPostBack property to determine whether this is the first time the page is being processed.                                                                                                                                                  2. Create or re-create dynamic controls.                                                                                                     3. Set a master page dynamically.                                                                                                           4. Set the Theme property dynamically. |
| Init              | 1. This event fires after each control has been initialized.                                                    2. Each control's UniqueID is set and any skin settings have been applied.            3.Use this event to read or initialize control properties.                                            4.The "Init" event is fired first for the bottom-most control in the hierarchy, and then fired up the hierarchy until it is fired for the page itself. |
| InitComplete      | 1.  Until now the viewstate values are not yet loaded, hence you can use this event to make changes to the view state that you want to ensure are persisted after the next postback.                                                                          2.Raised by the Page object.                                                                                       3.Use this event for processing tasks that require all initialization to be complete |
| PreLoad           | 1.Raised after the page loads view state for itself and all controls, and after it processes postback data that is included with the Request instance.  2.Before the Page instance raises this event, it loads view state for itself and all controls, and then processes any postback data included with the Request instance.                                                                                                3.Loads ViewState: ViewState data are loaded to controls.                       4.Loads Postback data: Postback data are now handed to the page controls. |
| Load              | 1. The Page object calls the OnLoad method on the Page object, and then recursively does the same for each child control until the page and all controls are loaded. The Load event of individual controls occurs after the Load event of the page.                                                                                              2.This is the first place in the page lifecycle that all values are restored.  3.Most code checks the value of IsPostBack to avoid unnecessarily resetting state.                                                                                                                        4.You may also call Validate and check the value of IsValid in this method.  5.You can also create dynamic controls in this method.                                     6.Use the OnLoad event method to set properties in controls and establish database connections. |
| Control Events    | 1. ASP.NET now calls any events on the page or its controls that caused the PostBack to occur.                                                                                                  2.Use these events to handle specific control events, such as a Button control's Click event or a TextBox control's TextChanged event.                           3.In a postback request, if the page contains validator controls, check the IsValid property of the Page and of individual validation controls before performing any processing.                                                                                          4.This is just an example of a control event. Here it is the button click event that caused the postback. |
| LoadComplete      | 1.Raised at the end of the event-handling stage.                                            2.Use this event for tasks that require that all other controls on the page be loaded. |
| PreRender         |                                          |
| PreRenderComplete |                                          |
| Unload            |                                          |
| Error             |                                          |





























