var ETWindow = Class.create(ETContainer, {	/*			@name Window Widget		@author Gray		@param parent, properties			A basic window widget	*/		initialize: function($super, parent, properties) {			properties.selectable = true;			$super(parent, properties);			this.getElement().addClassName("ETWindow");		this.parent.addElement(this);		this.getElement().setOpacity(0.8);				if (properties.hastitle) {					this.content = new ETWindowTitle(this, {							id: properties.id+"_title",				state: true,				title: properties.title						});							}				if (properties.hasInnerContent) {			this.content = new ETWindowContent(this, {							id: properties.id+"_content",				state: true						});		}				if (properties.moveable != false) {					if (properties.hastitle) {				new Draggable(properties.id, {handle: properties.id+"_title"});			} else {				new Draggable(properties.id, {handle: properties.id});			}				}				this.getElement().setStyle({					position: "absolute"			});	},		closeFold: function() {		Effect.Fold(this.properties.id);	}				});var ETWindowTitle = Class.create(ETLabel, {	initialize: function($super, parent, properties) {			$super(parent, properties);				// is properties.title set?				if (properties.title) {					this.text = properties.title;				} else {					this.text = "undefined!";				}				// Set the initial text		this.setText(this.text);				// Set the CSS class		this.getElement().removeClassName("ETLabel");		this.getElement().addClassName("ETWindowTitle");				this.parent.addElement(this);	}});